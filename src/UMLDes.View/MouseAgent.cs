using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using UMLDes.Model;

namespace UMLDes.GUI {

	public abstract class MouseAgent {

		public abstract void StartDrag (UmlObject elem);
		public abstract void StopDrag ();
		public abstract void Drop ();
		public abstract void Drag (int x,int y);

		public abstract void MouseDown (int x,int y,MouseButtons b,Keys modif,int realx,int realy);
		public abstract void MouseMove (int x,int y,MouseButtons b);
		public abstract void MouseUp (MouseButtons b);

		public abstract void DrawTemporary (Graphics g,Rectangle r,int offx,int offy,Rectangle pagepiece);
	};
}