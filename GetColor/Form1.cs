using System;
using System.Drawing;
using System.Windows.Forms;

namespace GetColor
{
	public partial class fmMain : Form
	{
		private class GlobalHandler : IMessageFilter
		{
			private const int WM_SYSKEYDOWN = 0x104;
			private Action callback;

			public GlobalHandler(Action callback)
			{
				this.callback = callback;
			}

			public bool PreFilterMessage(ref Message m)
			{
				if (m.Msg == WM_SYSKEYDOWN)
				{
					callback();
					return true;
				}
				return false;
			}
		}





		private GlobalHandler _globalEvent;

		private int _zoom;
		private bool _addHash;
		private int _previewImgWidth, _previewImgHeight;
		private Bitmap _bmpForPixel, _bmpForScreen;
		private Graphics _graphicsForPixel, _graphicsForScreen;
		private Rectangle _previewRectangle, _copyFromSrcRectangle;
		private Color _lastColor;
		private int _lastMouseX, _lastMouseY;
		private bool _doNotUpdateColorFromText = true;





		public fmMain()
		{
			InitializeComponent();


			lbR.Text =  lbG.Text = lbB.Text = "0";
			lbHexR.Text = lbHexG.Text = lbHexB.Text = "00";
			tbColor.Text = "Paste here / Pick with ALT (clipboard autocopy)";
			cbAlwaysOnTop.Checked = true;
			cbHash.Checked = true;
			_addHash = true;
			rbtn0x.Checked = rbtn2x.Checked = rbtn4x.Checked = rbtn8x.Checked = rbtn16x.Checked = false;
			rbtn16x.Checked = true;
			pnColor.BackColor = Color.Black;
			_lastColor = Color.Black;
			_lastMouseX = _lastMouseY = 0;
			_doNotUpdateColorFromText = false;


			if (cbAlwaysOnTop.Checked)
				TopMost = true;


			_previewImgWidth = pnZoom.Width;
			_previewImgHeight = pnZoom.Height;
			UpdateZoom(16);

			_bmpForPixel = new Bitmap(1, 1);
			_graphicsForPixel = Graphics.FromImage(_bmpForPixel);

			_bmpForScreen = new Bitmap(_previewImgWidth, _previewImgHeight);
			_graphicsForScreen = Graphics.FromImage(_bmpForScreen);
			_graphicsForScreen.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
			_graphicsForScreen.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.AssumeLinear;
			_graphicsForScreen.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;


			// set "global" event hanler
			_globalEvent = new GlobalHandler(OnAltPresed);
			Application.AddMessageFilter(_globalEvent);
		}

		private void cbAlwaysOnTop_Click(object sender, EventArgs e)
		{
			fmMain.ActiveForm.TopMost = cbAlwaysOnTop.Checked;
		}

		private void OnAltPresed()
		{
			int m_x = Cursor.Position.X,
				m_y = Cursor.Position.Y;
			Color curr_color;

			_graphicsForPixel.CopyFromScreen(m_x-1, m_y-1, 0, 0, new Size(1, 1));
			curr_color = _bmpForPixel.GetPixel(0, 0);

			if (curr_color == _lastColor && m_x == _lastMouseX && m_y == _lastMouseY)
			{
				return;
			}

			_lastColor = curr_color;
			_lastMouseX = m_x;
			_lastMouseY = m_y;


			SetSelectedColor();


			_graphicsForScreen.CopyFromScreen(
				m_x - _previewImgWidth / 2,
				m_y - _previewImgHeight / 2,
				0,
				0,
				new Size(_previewImgWidth, _previewImgHeight)
				);

			pnZoom.Refresh();
		}


		private void SetSelectedColor()
		{
			int r, g, b;
			double C, M, Y, K;

			pnColor.BackColor = _lastColor;
			pnColor.Refresh();

			r = _lastColor.R;
			g = _lastColor.G;
			b = _lastColor.B;


			// convert GRB to CMYK
			C = 1.0 - r / 255.0;
			M = 1.0 - g / 255.0;
			Y = 1.0 - b / 255.0;
			K = Math.Min(C, Math.Min(M, Y));
			if (K < 1)
			{
				C = (C - K) / (1.0 - K);
				M = (M - K) / (1.0 - K);
				Y = (Y - K) / (1.0 - K);
			}
			else
			{
				C = 0.0;
				M = 0.0;
				Y = 0.0;
			}


			lbR.Text = r.ToString();
			lbG.Text = g.ToString();
			lbB.Text = b.ToString();

			lbHexR.Text = string.Format("{0:X2}", r);
			lbHexG.Text = string.Format("{0:X2}", g);
			lbHexB.Text = string.Format("{0:X2}", b);

			lbCyan.Text = Convert.ToInt32(Math.Round(100.0*C)).ToString();
			lbMagenta.Text = Convert.ToInt32(Math.Round(100.0*M)).ToString();
			lbYellow.Text = Convert.ToInt32(Math.Round(100.0*Y)).ToString();
			lbBlack.Text = Convert.ToInt32(Math.Round(100.0*K)).ToString();

			if (_doNotUpdateColorFromText == false)
			{
				_doNotUpdateColorFromText = true;

				tbColor.Text = string.Format(
					"{0}{1:X2}{2:X2}{3:X2}",
					(_addHash ? "#" : ""),
					r,
					g,
					b
					);

				CopyTextToClipboard(tbColor.Text);

				_doNotUpdateColorFromText = false;
			}
		}

		private void CopyTextToClipboard(string s)
		{
			try
			{
				Clipboard.SetText(s);
			}
			catch (System.Runtime.InteropServices.ExternalException)
			{
				MessageBox.Show(
					"Error copying text to the clipboard. Try to close all programs that can block clipboard (like PuntoSwitcher).",
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
					);
			}
		}

		private void pnZoom_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.FillRectangle(
				Brushes.Black,
				_previewRectangle
				);

			if (_zoom > 0)
			{
				e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
				e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
				e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
				e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

				e.Graphics.DrawImage(
					_bmpForScreen,
					_previewRectangle,
					_copyFromSrcRectangle,
					GraphicsUnit.Pixel
					);

				// draw cross
				if (_zoom >= 8)
				{
					e.Graphics.DrawLine(
						Pens.Violet,
						_previewImgWidth / 2,
						0,
						_previewImgWidth / 2,
						_previewImgHeight
						);
					e.Graphics.DrawLine(
						Pens.Violet,
						0,
						_previewImgHeight / 2,
						_previewImgWidth,
						_previewImgHeight / 2
						);
				}
			}
		}

		private void rbtn0x_Click(object sender, EventArgs e)
		{
			UpdateZoom(0);
		}

		private void rbtn2x_Click(object sender, EventArgs e)
		{
			UpdateZoom(2);
		}

		private void rbtn4x_Click(object sender, EventArgs e)
		{
			UpdateZoom(4);
		}

		private void rbtn8x_Click(object sender, EventArgs e)
		{
			UpdateZoom(8);
		}

		private void rbtn16x_Click(object sender, EventArgs e)
		{
			UpdateZoom(16);
		}

		private void UpdateZoom(int ratio)
		{
			_zoom = ratio;


			rbtn0x.Checked = _zoom == 0;
			rbtn2x.Checked = _zoom == 2;
			rbtn4x.Checked = _zoom == 4;
			rbtn8x.Checked = _zoom == 8;
			rbtn16x.Checked = _zoom == 16;


			if (_zoom > 0)
			{
				// add 1 source pixel more to width and height
				_copyFromSrcRectangle = new Rectangle(
					_previewImgWidth/2 - _previewImgWidth/_zoom/2 - 1,
					_previewImgHeight/2 - _previewImgHeight/_zoom/2 - 1,
					_previewImgWidth/_zoom + 1,
					_previewImgHeight/_zoom + 1
					);
				// and shift 1/2 pixel top,left (to use additional pixel above to center preview)
				_previewRectangle = new Rectangle(
					0 - _zoom/2,
					0 - _zoom/2,
					_previewImgWidth + _zoom,
					_previewImgHeight + +_zoom
					);
			}

			pnZoom.Refresh();
		}

		private void cbHash_Click(object sender, EventArgs e)
		{
			_addHash = cbHash.Checked;
		}

		private void tbColor_TextChanged(object sender, EventArgs e)
		{
			if (_doNotUpdateColorFromText)
				return;
			_doNotUpdateColorFromText = true;


			int R, G, B;
			string s = tbColor.Text;

			if (s.Length > 0 && s[0] == '#')
				s = s.Substring(1);

			try
			{
				if (s.Length == 3)
				{
					R = byte.Parse(s.Substring(0, 1), System.Globalization.NumberStyles.HexNumber);
					G = byte.Parse(s.Substring(1, 1), System.Globalization.NumberStyles.HexNumber);
					B = byte.Parse(s.Substring(2, 1), System.Globalization.NumberStyles.HexNumber);

					R += R << 4;
					G += G << 4;
					B += B << 4;

					_lastColor = Color.FromArgb(R, G, B);
					SetSelectedColor();
				}
				else if (s.Length == 6)
				{
					R = byte.Parse(s.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
					G = byte.Parse(s.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
					B = byte.Parse(s.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

					_lastColor = Color.FromArgb(R, G, B);
					SetSelectedColor();
				}
			}
			catch
			{
				// error converting - do nothing
			}


			_doNotUpdateColorFromText = false;
		}

		private void btnColor_Click(object sender, EventArgs e)
		{
			cdColor.Color = _lastColor;
			cdColor.FullOpen = true;

			if (cdColor.ShowDialog() == DialogResult.OK)
			{
				_lastColor = cdColor.Color;
				SetSelectedColor();
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			About dlg = new About();
			bool on_top = TopMost;

			TopMost = false;
			dlg.ShowDialog();
			TopMost = on_top;
		}

		private void pnZoom_MouseClick(object sender, MouseEventArgs e)
		{
			_lastColor = _bmpForScreen.GetPixel(
				_previewImgWidth/2 - _previewImgWidth/_zoom/2 + (e.X - _zoom/2)/_zoom,
				_previewImgHeight/2 - _previewImgHeight/_zoom/2 + (e.Y - _zoom/2)/_zoom
				);
			SetSelectedColor();
		}
	}
}
