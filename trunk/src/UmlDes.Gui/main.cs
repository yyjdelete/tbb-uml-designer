using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UMLDes.Model;
using UMLDes.GUI;
using UMLDes.Controls;

namespace UMLDes {
	public partial class MainWnd:UMLDes.Controls.FlatMenuForm {
		public MainWnd () {
			InitializeComponent ();
			PostInitialize ();
			list = toolbarImages;

			TurnOnProject (UmlDesignerSolution.createNew ());
		}

		#region ToolBar/Tree initialization

		private void menu_ZoomOut_Click (object sender,System.EventArgs e) {
			ViewCtrl1.ZoomOut ();
		}

		private void menu_ZoomIn_Click (object sender,System.EventArgs e) {
			ViewCtrl1.ZoomIn ();
		}

		#endregion

		#region 工具栏相关

		void EnableButton (UMLDes.Controls.FlatToolBarButton b,bool en) {
			if (!b.disabled != en) {
				b.disabled = !b.disabled;
				b.parent.InvalidateButton (b);
			}
		}

		public void UpdateToolBar () {
			EnableButton (tool_undo,ViewCtrl1.Curr.undo.can_undo);
			EnableButton (tool_redo,ViewCtrl1.Curr.undo.can_redo);
		}

		void ToolbarAction (int index) {
			switch ((ToolBarIcons) index) {
				case ToolBarIcons.New:   // 新建
					if (!SaveChanges ())
						return;
					TurnOnProject (UmlDesignerSolution.createNew ());
					break;
				case ToolBarIcons.Open:   // 打开
					LoadProject (null,null);
					break;
				case ToolBarIcons.Save:   // 保存
					SaveProject (null,null);
					break;
				case ToolBarIcons.Saveas:   // 另存为
					SaveAsProject (null,null);
					break;
				case ToolBarIcons.add_file: // Add files
					AddFiles (null,null);
					break;
				case ToolBarIcons.new_diagram: // New Static view
					menu_AddStaticView_Click (null,null);
					break;
				case ToolBarIcons.refresh:  // Refresh tree
					RefreshProject (null,null);
					break;
				case ToolBarIcons.print: // 打印
					ViewCtrl1.Print (false);
					break;
				case ToolBarIcons.print_preview: // 打印预览
					ViewCtrl1.Print (true);
					break;
				case ToolBarIcons.undo:   // 撤销
					ViewCtrl1.Curr.undo.DoUndo ();
					break;
				case ToolBarIcons.redo:   // 重做
					ViewCtrl1.Curr.undo.DoRedo ();
					break;
				case ToolBarIcons.cut:
				case ToolBarIcons.copy:
				case ToolBarIcons.paste:
					MessageBox.Show ("CopyPaste" + ((ToolBarIcons) index).ToString ());
					break;
			}
		}

		#endregion

		#region Main, SaveChanges, OnClosing

		[STAThread]
		static void Main () {
			Application.Run (new MainWnd ());
		}

		private bool SaveChanges () {
			if (p.modified) {
				DialogResult r = MessageBox.Show ("工程已被更改,是否保存?","警告!",MessageBoxButtons.YesNoCancel);
				if (r == DialogResult.Cancel)
					return false;
				if (r == DialogResult.Yes)
					p.Save (false);
			}
			return true;
		}

		protected override void OnClosing (CancelEventArgs e) {
#if !DEBUG
			if (!SaveChanges ())
				e.Cancel = true;
#endif
			base.OnClosing (e);
		}

		#endregion

		#region Menu actions

		private void menu_NewProject_Click (object sender,System.EventArgs e) {
			ToolbarAction ((int) ToolBarIcons.New);
		}

		private void Exit (object sender,System.EventArgs e) {
			this.Close ();
		}


		private void SaveProject (object sender,System.EventArgs e) {
			p.Save (false);
		}

		private void SaveAsProject (object sender,System.EventArgs e) {
			p.Save (true);
		}

		private void LoadProject (object sender,System.EventArgs e) {
			UmlDesignerSolution q = UmlDesignerSolution.Load (this);
			if (q != null)
				TurnOnProject (q);
		}

		public void RefreshTitle () {
			this.Text = "TBB UML Designer: " + p.name + " [" + ViewCtrl1.Curr.name + "]";
		}

		private void TurnOnProject (UmlDesignerSolution p) {

			if (p.diagrams.Count == 0)
				return;

			if (this.p != null)
				this.p.container = null;

			this.p = p;
			p.container = this;
			ProjectTree.NewSolution (p);
			SelectView ((GUI.View) p.diagrams[0],true);
			UpdateToolBar ();
		}

		ArrayList view_toolbar_panels = null;

		public GUI.View GetCurrentView () {
			return ViewCtrl1.Curr;
		}

		public void SelectView (GUI.View v,bool update) {
			ViewCtrl1.Curr = v;
			if (update) {
				if (view_toolbar_panels != null)
					foreach (FlatToolBarPanel panel in view_toolbar_panels)
						toolBar1.RemovePanel (panel);
				view_toolbar_panels = v.LoadToolbars ();
				RefreshTitle ();
				ViewCtrl1.Invalidate ();
			}
		}

		private void AddFiles (object sender,System.EventArgs e) {
			p.AddFile ();
		}

		private void RefreshProject (object sender,System.EventArgs e) {
			p.Refresh ();
		}

		private void menu_Print_Click (object sender,System.EventArgs e) {
			ToolbarAction ((int) ToolBarIcons.print);
		}

		private void menu_PrintPreview_Click (object sender,System.EventArgs e) {
			ToolbarAction ((int) ToolBarIcons.print_preview);
		}

		private void menu_AddStaticView_Click (object sender,System.EventArgs e) {
			UMLDes.GUI.View v = p.newStaticView ();
			SelectView (v,true);
		}


		#region 图像格式

		private struct FormatDescr {
			public System.Drawing.Imaging.ImageFormat format;
			public string ext,descr;

			public FormatDescr (System.Drawing.Imaging.ImageFormat format,string ext,string descr) {
				this.format = format;
				this.ext = ext;
				this.descr = descr;
			}
		}

		private FormatDescr[] formats = new FormatDescr[] { 
			new FormatDescr( System.Drawing.Imaging.ImageFormat.Png, "png", "PNG" ),
			new FormatDescr( System.Drawing.Imaging.ImageFormat.Bmp, "bmp", "Bitmap" ), 
			new FormatDescr( System.Drawing.Imaging.ImageFormat.Gif, "gif", "GIF" ), 
			new FormatDescr( System.Drawing.Imaging.ImageFormat.Tiff, "tif", "TIFF" ), 
			new FormatDescr( System.Drawing.Imaging.ImageFormat.Jpeg, "jpg", "JPEG" ), 
		};

		#endregion

		private void menu_SaveToImage_Click (object sender,System.EventArgs e) {
			Bitmap bmp = ViewCtrl1.PrintToImage ();
			if (bmp == null) {
				MessageBox.Show ("Diagram is empty","Nothing to save",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}

			SaveFileDialog sfd = new SaveFileDialog ();
			string filter = String.Empty;
			for (int i = 0;i < formats.Length;i++)
				filter += "|" + formats[i].descr + "(*." + formats[i].ext + ")|*." + formats[i].ext;
			sfd.Filter = filter.Substring (1);
			sfd.FilterIndex = 0;
			sfd.AddExtension = true;
			sfd.Title = "保存为图片...";
			sfd.ValidateNames = true;
			sfd.FileName = ViewCtrl1.Curr.name;


			if (sfd.ShowDialog (this) == DialogResult.OK) {
				string ext = System.IO.Path.GetExtension (sfd.FileName).ToLower ();
				System.Drawing.Imaging.ImageFormat format = null;
				for (int i = 0;i < formats.Length;i++)
					if (ext.Equals ("." + formats[i].ext))
						format = formats[i].format;
				if (format != null)
					bmp.Save (sfd.FileName,format);
				else
					MessageBox.Show ("未知扩展名: " + ext,"无法保存",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}

		private void menu_copyAsImage_Click (object sender,System.EventArgs e) {
			Bitmap bmp = ViewCtrl1.PrintToImage ();
			if (bmp == null) {
				MessageBox.Show ("Diagram is empty","Nothing to copy",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}

			System.Windows.Forms.Clipboard.SetDataObject (bmp,false);
		}

		#endregion

		#region “编辑”菜单

		private void EditMenuPopup (object sender,System.EventArgs e) {
			menu_Undo.Enabled = ViewCtrl1.Curr.undo.can_undo;
			menu_Redo.Enabled = ViewCtrl1.Curr.undo.can_redo;
			menu_Delete.Enabled = ViewCtrl1.Curr.IfEnabled (UMLDes.GUI.View.EditOperation.Delete);
			menu_Cut.Enabled = ViewCtrl1.Curr.IfEnabled (UMLDes.GUI.View.EditOperation.Cut);
			menu_Copy.Enabled = ViewCtrl1.Curr.IfEnabled (UMLDes.GUI.View.EditOperation.Copy);
			menu_Paste.Enabled = ViewCtrl1.Curr.IfEnabled (UMLDes.GUI.View.EditOperation.Paste);
			menu_SelectAll.Enabled = ViewCtrl1.Curr.IfEnabled (UMLDes.GUI.View.EditOperation.SelectAll);
		}

		private void menu_Undo_Click (object sender,System.EventArgs e) {
			ViewCtrl1.Curr.undo.DoUndo ();
		}

		private void menu_Redo_Click (object sender,System.EventArgs e) {
			ViewCtrl1.Curr.undo.DoRedo ();
		}

		private void menu_Copy_Click (object sender,System.EventArgs e) {
			ViewCtrl1.Curr.DoOperation (UMLDes.GUI.View.EditOperation.Copy);
		}

		private void menu_Paste_Click (object sender,System.EventArgs e) {
			ViewCtrl1.Curr.DoOperation (UMLDes.GUI.View.EditOperation.Paste);
		}

		private void menu_Cut_Click (object sender,System.EventArgs e) {
			ViewCtrl1.Curr.DoOperation (UMLDes.GUI.View.EditOperation.Cut);
		}

		private void menuDeleteClick (object sender,System.EventArgs e) {
			ViewCtrl1.Curr.DoOperation (UMLDes.GUI.View.EditOperation.Delete);
		}

		private void menu_SelectAll_Click (object sender,System.EventArgs e) {
			ViewCtrl1.Curr.DoOperation (UMLDes.GUI.View.EditOperation.SelectAll);
		}

		#endregion

		#region Menu on tree items

		void RenameNode (object v,EventArgs ev) {
			TreeNode tn = (TreeNode) ((FlatMenuItem) v).Tag;
			tn.BeginEdit ();
		}

		void TryDropDownMenu (int x,int y,object obj,TreeNode n) {
			MenuItem[] mi = null;

			if (obj is UMLDes.GUI.View) {
				mi = new FlatMenuItem[] { FlatMenuItem.Create ("重命名",null,0,false,new EventHandler (RenameNode),n) };
			}

			if (mi == null)
				return;
			ContextMenu m = new ContextMenu (mi);
			m.Show (ProjectTree,new Point (x,y));
		}

		#endregion

		#region Drag & Drop and other tree ops

		Rectangle dragbox = Rectangle.Empty;
		UmlObject dragobject;

		void TreeMouseDown (object sender,System.Windows.Forms.MouseEventArgs e) {
			TreeNode node = (sender as TreeView).GetNodeAt (e.X,e.Y);
			if (node == null)
				return;
			object obj = ProjectTree.GetNodeObject (node);

			dragbox = Rectangle.Empty;
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left) {

				if (obj is UMLDes.GUI.View) {
					if (e.Clicks == 2) {
						UMLDes.GUI.View v = obj as UMLDes.GUI.View;
						SelectView (v,true);
					}

				}
				else if (!(obj is UmlDesignerSolution)) {
					Size dragSize = SystemInformation.DragSize;
					dragbox = new Rectangle (new Point (e.X - (dragSize.Width / 2),e.Y - (dragSize.Height / 2)),dragSize);
					dragobject = obj as UmlObject;
				}
			}
			else if ((e.Button & MouseButtons.Right) == MouseButtons.Right) {
				ProjectTree.SelectedNode = node;
				if (obj != null)
					TryDropDownMenu (e.X,e.Y,obj,node);
			}
		}

		void TreeMouseMove (object sender,System.Windows.Forms.MouseEventArgs e) {
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left) {
				if (dragbox != Rectangle.Empty && !dragbox.Contains (e.X,e.Y) && dragobject != null) {
					ViewCtrl1.DragObject = dragobject;
					DragDropEffects dropEffect = ((TreeView) sender).DoDragDrop (dragobject.Name,DragDropEffects.Copy);
					///....
					dragbox = Rectangle.Empty;
				}
			}
		}

		void TreeMouseUp (object sender,System.Windows.Forms.MouseEventArgs e) {
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
				dragbox = Rectangle.Empty;
		}

		private void BeforeLabelEdit (object sender,NodeLabelEditEventArgs e) {
			object obj = ProjectTree.GetNodeObject (e.Node);
			e.CancelEdit = !(obj != null && obj is UMLDes.GUI.View);
		}

		private void AfterLabelEdit (object sender,NodeLabelEditEventArgs e) {
			object obj = ProjectTree.GetNodeObject (e.Node);
			if (obj != null && obj is UMLDes.GUI.View) {
				UMLDes.GUI.View v = obj as UMLDes.GUI.View;
				if (e.Label != null)
					v.name = e.Label;
			}
			RefreshTitle ();
		}

		private void tree_GiveFeedback (object sender,System.Windows.Forms.GiveFeedbackEventArgs e) {

			e.UseDefaultCursors = false;
			if ((e.Effect & DragDropEffects.Copy) == DragDropEffects.Copy)
				Cursor.Current = Cursors.Hand;
			else
				Cursor.Current = Cursors.No;
		}

		#endregion

		#region “帮助”菜单

		private void Help_Popup (object sender,System.EventArgs e) {
			menu_GC_Collect.Text = "GC.Collect (" + GC.GetTotalMemory (false) / 1024 + " Kb alloc)";
		}

		private void menu_GC_Collect_Click (object sender,System.EventArgs e) {
			GC.Collect ();
		}

		//yyj
		private void menu_About_Click (object sender,System.EventArgs e) {
			About aboutfrm = new About ();
			aboutfrm.ShowDialog ();
		}
		#endregion

		#region 状态栏相关

		internal void SetStatus (string text) {
			status_panel.Text = text;
		}

		internal void SetAdvise (string text) {
			//advise_panel.Text = text;
		}

		#endregion

	}
}
