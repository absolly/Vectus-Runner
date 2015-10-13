﻿using System;
using System.Drawing;

namespace GXPEngine
{
	public class DrawString : Canvas
	{
		private Font _font;
		private Brush _brush;
		private PointF _position;

		public DrawString (string text, int posX, int posY) : base(text.Length*13, 40)
		{
			graphics.Clear (Color.Empty);
			_position = new PointF (0,0);
			_font = new Font ("Arial", 20, FontStyle.Regular);
			_brush = new SolidBrush (Color.White);

			SetOrigin (width / 2, height / 2);
			this.x = posX;
			this.y = posY;

			graphics.Clear (Color.Empty);
			graphics.DrawString (text, _font, _brush, _position);
		}

		public DrawString (string text, int posX, int posY, Font _font, SolidBrush _brush) : base(text.Length*13, 40)
		{
			graphics.Clear (Color.Empty);
			_position = new PointF (0,0);

			SetOrigin (width / 2, height / 2);
			this.x = posX;
			this.y = posY;

			graphics.Clear (Color.Empty);
			graphics.DrawString (text, _font, _brush, _position);
		}
	}
}
