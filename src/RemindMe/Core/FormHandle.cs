using System.Drawing;
using System.Windows.Forms;

namespace RemindMe
{
	internal static class FormHandle
	{
		private static Point startPoint;
		private static bool DoMove;

		internal static void MoveBar_MouseDown(object sender, MouseEventArgs e)
		{
			startPoint.X = e.X;
			startPoint.Y = e.Y;
			DoMove = true;
		}

		internal static void MoveBar_MouseMove(object sender, MouseEventArgs e)
		{
			if (DoMove)
				((Control)sender).Parent.Location = new Point(((Control)sender).Parent.Location.X + (e.X - startPoint.X), ((Control)sender).Parent.Location.Y + (e.Y - startPoint.Y));
		}

		internal static void MoveBar_MouseUp(object sender, MouseEventArgs e)
		{
			DoMove = false;
		}
	}
}
