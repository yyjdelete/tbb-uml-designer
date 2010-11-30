namespace UMLDes {
	public partial class MainWnd {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent () {
			this.components=new System.ComponentModel.Container ();
			System.ComponentModel.ComponentResourceManager resources=new System.ComponentModel.ComponentResourceManager (typeof (MainWnd));
			this.menu_About=new System.Windows.Forms.ToolStripMenuItem ();
			this.toolbarImages=new System.Windows.Forms.ImageList (this.components);
			this.menumain_Help=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_show_hints=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_GC_Collect=new System.Windows.Forms.ToolStripMenuItem ();
			this.menuStrip1=new System.Windows.Forms.MenuStrip ();
			this.menumain_File=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_NewProject=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_OpenProject=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_SaveProject=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_SaveProjAs=new System.Windows.Forms.ToolStripMenuItem ();
			this.menuSeparator1=new System.Windows.Forms.ToolStripSeparator ();
			this.menu_Print=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_PrintPreview=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_SaveToImage=new System.Windows.Forms.ToolStripMenuItem ();
			this.menuSeparator2=new System.Windows.Forms.ToolStripSeparator ();
			this.menu_Exit=new System.Windows.Forms.ToolStripMenuItem ();
			this.menumain_Edit=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_Undo=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_Redo=new System.Windows.Forms.ToolStripMenuItem ();
			this.menuSeparator3=new System.Windows.Forms.ToolStripSeparator ();
			this.menu_Cut=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_Copy=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_Paste=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_Delete=new System.Windows.Forms.ToolStripMenuItem ();
			this.menuSeparator4=new System.Windows.Forms.ToolStripSeparator ();
			this.menu_SelectAll=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_copyAsImage=new System.Windows.Forms.ToolStripMenuItem ();
			this.menumain_View=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_ZoomIn=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_ZoomOut=new System.Windows.Forms.ToolStripMenuItem ();
			this.menumain_Project=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_AddFiles=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_AddStaticView=new System.Windows.Forms.ToolStripMenuItem ();
			this.menu_Parse=new System.Windows.Forms.ToolStripMenuItem ();
			this.treeImages=new System.Windows.Forms.ImageList (this.components);
			this.toolBar1=new UMLDes.Controls.FlatToolBar ();
			this.panel1=new System.Windows.Forms.Panel ();
			this.ProjectTree=new UMLDes.Controls.UmlSolutionTree ();
			this.splitter1=new System.Windows.Forms.Splitter ();
			this.statusStrip1=new System.Windows.Forms.StatusStrip ();
			this.status_panel=new System.Windows.Forms.ToolStripStatusLabel ();
			this.toolStripContainer1=new System.Windows.Forms.ToolStripContainer ();
			this.ViewCtrl1=new UMLDes.ViewCtrl ();
			this.toolStrip2=new System.Windows.Forms.ToolStrip ();
			this.toolStrip6=new System.Windows.Forms.ToolStrip ();
			this.toolStrip5=new System.Windows.Forms.ToolStrip ();
			this.toolStrip4=new System.Windows.Forms.ToolStrip ();
			this.toolStrip3=new System.Windows.Forms.ToolStrip ();
			this.toolStrip1=new System.Windows.Forms.ToolStrip ();
			this.menuStrip1.SuspendLayout ();
			this.panel1.SuspendLayout ();
			this.statusStrip1.SuspendLayout ();
			this.toolStripContainer1.BottomToolStripPanel.SuspendLayout ();
			this.toolStripContainer1.ContentPanel.SuspendLayout ();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout ();
			this.toolStripContainer1.SuspendLayout ();
			this.SuspendLayout ();
			// 
			// menu_About
			// 
			this.menu_About.Image=((System.Drawing.Image) (resources.GetObject ("menu_About.Image")));
			this.menu_About.MergeIndex=0;
			this.menu_About.Name="menu_About";
			this.menu_About.ShortcutKeys=System.Windows.Forms.Keys.F1;
			this.menu_About.Size=new System.Drawing.Size (141,22);
			this.menu_About.Text="关于(&A)";
			this.menu_About.Click+=new System.EventHandler (this.menu_About_Click);
			// 
			// toolbarImages
			// 
			this.toolbarImages.ImageStream=((System.Windows.Forms.ImageListStreamer) (resources.GetObject ("toolbarImages.ImageStream")));
			this.toolbarImages.TransparentColor=System.Drawing.Color.Silver;
			this.toolbarImages.Images.SetKeyName (0,"");
			this.toolbarImages.Images.SetKeyName (1,"");
			this.toolbarImages.Images.SetKeyName (2,"");
			this.toolbarImages.Images.SetKeyName (3,"");
			this.toolbarImages.Images.SetKeyName (4,"");
			this.toolbarImages.Images.SetKeyName (5,"");
			this.toolbarImages.Images.SetKeyName (6,"");
			this.toolbarImages.Images.SetKeyName (7,"");
			this.toolbarImages.Images.SetKeyName (8,"");
			this.toolbarImages.Images.SetKeyName (9,"");
			this.toolbarImages.Images.SetKeyName (10,"");
			this.toolbarImages.Images.SetKeyName (11,"");
			this.toolbarImages.Images.SetKeyName (12,"");
			this.toolbarImages.Images.SetKeyName (13,"");
			this.toolbarImages.Images.SetKeyName (14,"");
			this.toolbarImages.Images.SetKeyName (15,"");
			this.toolbarImages.Images.SetKeyName (16,"");
			this.toolbarImages.Images.SetKeyName (17,"");
			this.toolbarImages.Images.SetKeyName (18,"");
			this.toolbarImages.Images.SetKeyName (19,"");
			this.toolbarImages.Images.SetKeyName (20,"");
			this.toolbarImages.Images.SetKeyName (21,"");
			this.toolbarImages.Images.SetKeyName (22,"");
			this.toolbarImages.Images.SetKeyName (23,"");
			this.toolbarImages.Images.SetKeyName (24,"");
			this.toolbarImages.Images.SetKeyName (25,"");
			this.toolbarImages.Images.SetKeyName (26,"");
			this.toolbarImages.Images.SetKeyName (27,"");
			this.toolbarImages.Images.SetKeyName (28,"");
			this.toolbarImages.Images.SetKeyName (29,"");
			this.toolbarImages.Images.SetKeyName (30,"");
			this.toolbarImages.Images.SetKeyName (31,"");
			this.toolbarImages.Images.SetKeyName (32,"");
			this.toolbarImages.Images.SetKeyName (33,"");
			this.toolbarImages.Images.SetKeyName (34,"");
			this.toolbarImages.Images.SetKeyName (35,"");
			this.toolbarImages.Images.SetKeyName (36,"");
			this.toolbarImages.Images.SetKeyName (37,"");
			this.toolbarImages.Images.SetKeyName (38,"");
			this.toolbarImages.Images.SetKeyName (39,"");
			this.toolbarImages.Images.SetKeyName (40,"");
			// 
			// menumain_Help
			// 
			this.menumain_Help.DropDownItems.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.menu_About,
            this.menu_show_hints,
            this.menu_GC_Collect});
			this.menumain_Help.MergeIndex=4;
			this.menumain_Help.Name="menumain_Help";
			this.menumain_Help.Size=new System.Drawing.Size (61,21);
			this.menumain_Help.Text="帮助(&H)";
			this.menumain_Help.DropDownOpening+=new System.EventHandler (this.Help_Popup);
			// 
			// menu_show_hints
			// 
			this.menu_show_hints.MergeIndex=1;
			this.menu_show_hints.Name="menu_show_hints";
			this.menu_show_hints.Size=new System.Drawing.Size (141,22);
			this.menu_show_hints.Text="显示提示(&H)";
			// 
			// menu_GC_Collect
			// 
			this.menu_GC_Collect.MergeIndex=2;
			this.menu_GC_Collect.Name="menu_GC_Collect";
			this.menu_GC_Collect.Size=new System.Drawing.Size (141,22);
			this.menu_GC_Collect.Text="GC.Collect";
			this.menu_GC_Collect.Click+=new System.EventHandler (this.menu_GC_Collect_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock=System.Windows.Forms.DockStyle.None;
			this.menuStrip1.ImageList=this.toolbarImages;
			this.menuStrip1.Items.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.menumain_File,
            this.menumain_Edit,
            this.menumain_View,
            this.menumain_Project,
            this.menumain_Help});
			this.menuStrip1.Location=new System.Drawing.Point (0,25);
			this.menuStrip1.Name="menuStrip1";
			this.menuStrip1.Size=new System.Drawing.Size (784,25);
			this.menuStrip1.TabIndex=0;
			// 
			// menumain_File
			// 
			this.menumain_File.DropDownItems.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.menu_NewProject,
            this.menu_OpenProject,
            this.menu_SaveProject,
            this.menu_SaveProjAs,
            this.menuSeparator1,
            this.menu_Print,
            this.menu_PrintPreview,
            this.menu_SaveToImage,
            this.menuSeparator2,
            this.menu_Exit});
			this.menumain_File.MergeIndex=0;
			this.menumain_File.Name="menumain_File";
			this.menumain_File.Size=new System.Drawing.Size (58,21);
			this.menumain_File.Text="文件(&F)";
			// 
			// menu_NewProject
			// 
			this.menu_NewProject.Image=((System.Drawing.Image) (resources.GetObject ("menu_NewProject.Image")));
			this.menu_NewProject.MergeIndex=0;
			this.menu_NewProject.Name="menu_NewProject";
			this.menu_NewProject.ShortcutKeys=((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.N)));
			this.menu_NewProject.Size=new System.Drawing.Size (255,22);
			this.menu_NewProject.Text="新建工程(&N)";
			this.menu_NewProject.Click+=new System.EventHandler (this.NewProject);
			// 
			// menu_OpenProject
			// 
			this.menu_OpenProject.Image=((System.Drawing.Image) (resources.GetObject ("menu_OpenProject.Image")));
			this.menu_OpenProject.MergeIndex=1;
			this.menu_OpenProject.Name="menu_OpenProject";
			this.menu_OpenProject.ShortcutKeys=((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.O)));
			this.menu_OpenProject.Size=new System.Drawing.Size (255,22);
			this.menu_OpenProject.Text="打开工程(&O)";
			this.menu_OpenProject.Click+=new System.EventHandler (this.LoadProject);
			// 
			// menu_SaveProject
			// 
			this.menu_SaveProject.Image=((System.Drawing.Image) (resources.GetObject ("menu_SaveProject.Image")));
			this.menu_SaveProject.MergeIndex=2;
			this.menu_SaveProject.Name="menu_SaveProject";
			this.menu_SaveProject.ShortcutKeys=((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.S)));
			this.menu_SaveProject.Size=new System.Drawing.Size (255,22);
			this.menu_SaveProject.Text="保存工程(&S)";
			this.menu_SaveProject.Click+=new System.EventHandler (this.SaveProject);
			// 
			// menu_SaveProjAs
			// 
			this.menu_SaveProjAs.Image=((System.Drawing.Image) (resources.GetObject ("menu_SaveProjAs.Image")));
			this.menu_SaveProjAs.MergeIndex=3;
			this.menu_SaveProjAs.Name="menu_SaveProjAs";
			this.menu_SaveProjAs.Size=new System.Drawing.Size (255,22);
			this.menu_SaveProjAs.Text="另存为(&A) ...";
			this.menu_SaveProjAs.Click+=new System.EventHandler (this.SaveAsProject);
			// 
			// menuSeparator1
			// 
			this.menuSeparator1.MergeIndex=4;
			this.menuSeparator1.Name="menuSeparator1";
			this.menuSeparator1.Size=new System.Drawing.Size (252,6);
			// 
			// menu_Print
			// 
			this.menu_Print.Image=((System.Drawing.Image) (resources.GetObject ("menu_Print.Image")));
			this.menu_Print.MergeIndex=5;
			this.menu_Print.Name="menu_Print";
			this.menu_Print.ShortcutKeys=((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.P)));
			this.menu_Print.Size=new System.Drawing.Size (255,22);
			this.menu_Print.Text="打印(&P)";
			this.menu_Print.Click+=new System.EventHandler (this.Print);
			// 
			// menu_PrintPreview
			// 
			this.menu_PrintPreview.MergeIndex=6;
			this.menu_PrintPreview.Name="menu_PrintPreview";
			this.menu_PrintPreview.ShortcutKeys=((System.Windows.Forms.Keys) (((System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.Shift)
						|System.Windows.Forms.Keys.P)));
			this.menu_PrintPreview.Size=new System.Drawing.Size (255,22);
			this.menu_PrintPreview.Text="打印预览(&V)";
			this.menu_PrintPreview.Click+=new System.EventHandler (this.PrintPreview);
			// 
			// menu_SaveToImage
			// 
			this.menu_SaveToImage.MergeIndex=7;
			this.menu_SaveToImage.Name="menu_SaveToImage";
			this.menu_SaveToImage.ShortcutKeys=((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.I)));
			this.menu_SaveToImage.Size=new System.Drawing.Size (255,22);
			this.menu_SaveToImage.Text="Save diagram as Image";
			this.menu_SaveToImage.Click+=new System.EventHandler (this.menu_SaveToImage_Click);
			// 
			// menuSeparator2
			// 
			this.menuSeparator2.MergeIndex=8;
			this.menuSeparator2.Name="menuSeparator2";
			this.menuSeparator2.Size=new System.Drawing.Size (252,6);
			// 
			// menu_Exit
			// 
			this.menu_Exit.MergeIndex=9;
			this.menu_Exit.Name="menu_Exit";
			this.menu_Exit.ShortcutKeys=((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Alt|System.Windows.Forms.Keys.F4)));
			this.menu_Exit.Size=new System.Drawing.Size (255,22);
			this.menu_Exit.Text="退出(&X)";
			this.menu_Exit.Click+=new System.EventHandler (this.Exit);
			// 
			// menumain_Edit
			// 
			this.menumain_Edit.DropDownItems.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.menu_Undo,
            this.menu_Redo,
            this.menuSeparator3,
            this.menu_Cut,
            this.menu_Copy,
            this.menu_Paste,
            this.menu_Delete,
            this.menuSeparator4,
            this.menu_SelectAll,
            this.menu_copyAsImage});
			this.menumain_Edit.MergeIndex=1;
			this.menumain_Edit.Name="menumain_Edit";
			this.menumain_Edit.Size=new System.Drawing.Size (59,21);
			this.menumain_Edit.Text="编辑(&E)";
			this.menumain_Edit.DropDownOpening+=new System.EventHandler (this.EditMenuPopup);
			// 
			// menu_Undo
			// 
			this.menu_Undo.Image=((System.Drawing.Image) (resources.GetObject ("menu_Undo.Image")));
			this.menu_Undo.MergeIndex=0;
			this.menu_Undo.Name="menu_Undo";
			this.menu_Undo.ShortcutKeys=((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.Z)));
			this.menu_Undo.Size=new System.Drawing.Size (296,22);
			this.menu_Undo.Text="撤销(&U)";
			this.menu_Undo.Click+=new System.EventHandler (this.menu_Undo_Click);
			// 
			// menu_Redo
			// 
			this.menu_Redo.Image=((System.Drawing.Image) (resources.GetObject ("menu_Redo.Image")));
			this.menu_Redo.MergeIndex=1;
			this.menu_Redo.Name="menu_Redo";
			this.menu_Redo.ShortcutKeys=((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.Y)));
			this.menu_Redo.Size=new System.Drawing.Size (296,22);
			this.menu_Redo.Text="重做(&R)";
			this.menu_Redo.Click+=new System.EventHandler (this.menu_Redo_Click);
			// 
			// menuSeparator3
			// 
			this.menuSeparator3.MergeIndex=2;
			this.menuSeparator3.Name="menuSeparator3";
			this.menuSeparator3.Size=new System.Drawing.Size (293,6);
			// 
			// menu_Cut
			// 
			this.menu_Cut.Image=((System.Drawing.Image) (resources.GetObject ("menu_Cut.Image")));
			this.menu_Cut.MergeIndex=3;
			this.menu_Cut.Name="menu_Cut";
			this.menu_Cut.ShortcutKeys=((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.X)));
			this.menu_Cut.Size=new System.Drawing.Size (296,22);
			this.menu_Cut.Text="剪切(&T)";
			this.menu_Cut.Click+=new System.EventHandler (this.menu_Cut_Click);
			// 
			// menu_Copy
			// 
			this.menu_Copy.Image=((System.Drawing.Image) (resources.GetObject ("menu_Copy.Image")));
			this.menu_Copy.MergeIndex=4;
			this.menu_Copy.Name="menu_Copy";
			this.menu_Copy.ShortcutKeys=((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.C)));
			this.menu_Copy.Size=new System.Drawing.Size (296,22);
			this.menu_Copy.Text="复制(&C)";
			this.menu_Copy.Click+=new System.EventHandler (this.menu_Copy_Click);
			// 
			// menu_Paste
			// 
			this.menu_Paste.Image=((System.Drawing.Image) (resources.GetObject ("menu_Paste.Image")));
			this.menu_Paste.MergeIndex=5;
			this.menu_Paste.Name="menu_Paste";
			this.menu_Paste.ShortcutKeys=((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.V)));
			this.menu_Paste.Size=new System.Drawing.Size (296,22);
			this.menu_Paste.Text="粘贴(&P)";
			this.menu_Paste.Click+=new System.EventHandler (this.menu_Paste_Click);
			// 
			// menu_Delete
			// 
			this.menu_Delete.Image=((System.Drawing.Image) (resources.GetObject ("menu_Delete.Image")));
			this.menu_Delete.MergeIndex=6;
			this.menu_Delete.Name="menu_Delete";
			this.menu_Delete.ShortcutKeys=System.Windows.Forms.Keys.Delete;
			this.menu_Delete.Size=new System.Drawing.Size (296,22);
			this.menu_Delete.Text="删除(&D)";
			this.menu_Delete.Click+=new System.EventHandler (this.menuDeleteClick);
			// 
			// menuSeparator4
			// 
			this.menuSeparator4.MergeIndex=7;
			this.menuSeparator4.Name="menuSeparator4";
			this.menuSeparator4.Size=new System.Drawing.Size (293,6);
			// 
			// menu_SelectAll
			// 
			this.menu_SelectAll.MergeIndex=8;
			this.menu_SelectAll.Name="menu_SelectAll";
			this.menu_SelectAll.ShortcutKeys=((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.A)));
			this.menu_SelectAll.Size=new System.Drawing.Size (296,22);
			this.menu_SelectAll.Text="全选(&A)";
			this.menu_SelectAll.Click+=new System.EventHandler (this.menu_SelectAll_Click);
			// 
			// menu_copyAsImage
			// 
			this.menu_copyAsImage.MergeIndex=9;
			this.menu_copyAsImage.Name="menu_copyAsImage";
			this.menu_copyAsImage.ShortcutKeys=((System.Windows.Forms.Keys) (((System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.Shift)
						|System.Windows.Forms.Keys.C)));
			this.menu_copyAsImage.Size=new System.Drawing.Size (296,22);
			this.menu_copyAsImage.Text="Copy diagram as Image";
			this.menu_copyAsImage.Click+=new System.EventHandler (this.menu_copyAsImage_Click);
			// 
			// menumain_View
			// 
			this.menumain_View.DropDownItems.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.menu_ZoomIn,
            this.menu_ZoomOut});
			this.menumain_View.MergeIndex=2;
			this.menumain_View.Name="menumain_View";
			this.menumain_View.Size=new System.Drawing.Size (60,21);
			this.menumain_View.Text="查看(&V)";
			// 
			// menu_ZoomIn
			// 
			this.menu_ZoomIn.Image=((System.Drawing.Image) (resources.GetObject ("menu_ZoomIn.Image")));
			this.menu_ZoomIn.MergeIndex=0;
			this.menu_ZoomIn.Name="menu_ZoomIn";
			this.menu_ZoomIn.ShortcutKeys=((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.J)));
			this.menu_ZoomIn.Size=new System.Drawing.Size (145,22);
			this.menu_ZoomIn.Text="放大";
			this.menu_ZoomIn.Click+=new System.EventHandler (this.menu_ZoomIn_Click);
			// 
			// menu_ZoomOut
			// 
			this.menu_ZoomOut.Image=((System.Drawing.Image) (resources.GetObject ("menu_ZoomOut.Image")));
			this.menu_ZoomOut.MergeIndex=1;
			this.menu_ZoomOut.Name="menu_ZoomOut";
			this.menu_ZoomOut.ShortcutKeys=((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.K)));
			this.menu_ZoomOut.Size=new System.Drawing.Size (145,22);
			this.menu_ZoomOut.Text="缩小";
			this.menu_ZoomOut.Click+=new System.EventHandler (this.menu_ZoomOut_Click);
			// 
			// menumain_Project
			// 
			this.menumain_Project.DropDownItems.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.menu_AddFiles,
            this.menu_AddStaticView,
            this.menu_Parse});
			this.menumain_Project.MergeIndex=3;
			this.menumain_Project.Name="menumain_Project";
			this.menumain_Project.Size=new System.Drawing.Size (59,21);
			this.menumain_Project.Text="工程(&P)";
			// 
			// menu_AddFiles
			// 
			this.menu_AddFiles.Image=((System.Drawing.Image) (resources.GetObject ("menu_AddFiles.Image")));
			this.menu_AddFiles.MergeIndex=0;
			this.menu_AddFiles.Name="menu_AddFiles";
			this.menu_AddFiles.ShortcutKeys=((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.F)));
			this.menu_AddFiles.Size=new System.Drawing.Size (244,22);
			this.menu_AddFiles.Text="添加文件(&A)";
			this.menu_AddFiles.Click+=new System.EventHandler (this.AddFiles);
			// 
			// menu_AddStaticView
			// 
			this.menu_AddStaticView.Image=((System.Drawing.Image) (resources.GetObject ("menu_AddStaticView.Image")));
			this.menu_AddStaticView.MergeIndex=1;
			this.menu_AddStaticView.Name="menu_AddStaticView";
			this.menu_AddStaticView.ShortcutKeys=((System.Windows.Forms.Keys) (((System.Windows.Forms.Keys.Control|System.Windows.Forms.Keys.Shift)
						|System.Windows.Forms.Keys.N)));
			this.menu_AddStaticView.Size=new System.Drawing.Size (244,22);
			this.menu_AddStaticView.Text="&Add static view";
			this.menu_AddStaticView.Click+=new System.EventHandler (this.AddStaticView);
			// 
			// menu_Parse
			// 
			this.menu_Parse.Image=((System.Drawing.Image) (resources.GetObject ("menu_Parse.Image")));
			this.menu_Parse.MergeIndex=2;
			this.menu_Parse.Name="menu_Parse";
			this.menu_Parse.ShortcutKeys=System.Windows.Forms.Keys.F5;
			this.menu_Parse.Size=new System.Drawing.Size (244,22);
			this.menu_Parse.Text="Parse files, refresh tree";
			this.menu_Parse.Click+=new System.EventHandler (this.RefreshProject);
			// 
			// treeImages
			// 
			this.treeImages.ImageStream=((System.Windows.Forms.ImageListStreamer) (resources.GetObject ("treeImages.ImageStream")));
			this.treeImages.TransparentColor=System.Drawing.Color.Transparent;
			this.treeImages.Images.SetKeyName (0,"");
			this.treeImages.Images.SetKeyName (1,"");
			this.treeImages.Images.SetKeyName (2,"");
			this.treeImages.Images.SetKeyName (3,"");
			this.treeImages.Images.SetKeyName (4,"");
			this.treeImages.Images.SetKeyName (5,"");
			this.treeImages.Images.SetKeyName (6,"");
			this.treeImages.Images.SetKeyName (7,"");
			this.treeImages.Images.SetKeyName (8,"");
			this.treeImages.Images.SetKeyName (9,"");
			this.treeImages.Images.SetKeyName (10,"");
			this.treeImages.Images.SetKeyName (11,"");
			this.treeImages.Images.SetKeyName (12,"");
			this.treeImages.Images.SetKeyName (13,"");
			this.treeImages.Images.SetKeyName (14,"");
			this.treeImages.Images.SetKeyName (15,"");
			this.treeImages.Images.SetKeyName (16,"");
			this.treeImages.Images.SetKeyName (17,"");
			this.treeImages.Images.SetKeyName (18,"");
			this.treeImages.Images.SetKeyName (19,"");
			this.treeImages.Images.SetKeyName (20,"");
			this.treeImages.Images.SetKeyName (21,"");
			this.treeImages.Images.SetKeyName (22,"");
			this.treeImages.Images.SetKeyName (23,"");
			this.treeImages.Images.SetKeyName (24,"");
			this.treeImages.Images.SetKeyName (25,"");
			this.treeImages.Images.SetKeyName (26,"");
			this.treeImages.Images.SetKeyName (27,"");
			this.treeImages.Images.SetKeyName (28,"");
			this.treeImages.Images.SetKeyName (29,"");
			this.treeImages.Images.SetKeyName (30,"");
			this.treeImages.Images.SetKeyName (31,"");
			this.treeImages.Images.SetKeyName (32,"");
			this.treeImages.Images.SetKeyName (33,"");
			this.treeImages.Images.SetKeyName (34,"");
			this.treeImages.Images.SetKeyName (35,"");
			this.treeImages.Images.SetKeyName (36,"");
			// 
			// toolBar1
			// 
			this.toolBar1.BackColor=System.Drawing.Color.FromArgb (((int) (((byte) (219)))),((int) (((byte) (216)))),((int) (((byte) (209)))));
			this.toolBar1.Dock=System.Windows.Forms.DockStyle.Top;
			this.toolBar1.ForeColor=System.Drawing.Color.FromArgb (((int) (((byte) (219)))),((int) (((byte) (216)))),((int) (((byte) (209)))));
			this.toolBar1.images=this.toolbarImages;
			this.toolBar1.Location=new System.Drawing.Point (0,0);
			this.toolBar1.Name="toolBar1";
			this.toolBar1.Size=new System.Drawing.Size (784,26);
			this.toolBar1.TabIndex=10;
			this.toolBar1.TabStop=false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add (this.ProjectTree);
			this.panel1.Dock=System.Windows.Forms.DockStyle.Left;
			this.panel1.Location=new System.Drawing.Point (0,26);
			this.panel1.Name="panel1";
			this.panel1.Size=new System.Drawing.Size (259,122);
			this.panel1.TabIndex=13;
			// 
			// ProjectTree
			// 
			this.ProjectTree.Dock=System.Windows.Forms.DockStyle.Fill;
			this.ProjectTree.Location=new System.Drawing.Point (0,0);
			this.ProjectTree.Name="ProjectTree";
			this.ProjectTree.Size=new System.Drawing.Size (259,122);
			this.ProjectTree.TabIndex=2;
			// 
			// splitter1
			// 
			this.splitter1.Location=new System.Drawing.Point (259,26);
			this.splitter1.Name="splitter1";
			this.splitter1.Size=new System.Drawing.Size (4,122);
			this.splitter1.TabIndex=14;
			this.splitter1.TabStop=false;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Dock=System.Windows.Forms.DockStyle.None;
			this.statusStrip1.Items.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.status_panel});
			this.statusStrip1.Location=new System.Drawing.Point (0,0);
			this.statusStrip1.Name="statusStrip1";
			this.statusStrip1.ShowItemToolTips=true;
			this.statusStrip1.Size=new System.Drawing.Size (784,22);
			this.statusStrip1.TabIndex=1;
			// 
			// status_panel
			// 
			this.status_panel.AutoToolTip=true;
			this.status_panel.Name="status_panel";
			this.status_panel.Size=new System.Drawing.Size (769,17);
			this.status_panel.Spring=true;
			this.status_panel.Text="就绪";
			this.status_panel.TextAlign=System.Drawing.ContentAlignment.MiddleLeft;
			this.status_panel.ToolTipText="状态";
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			this.toolStripContainer1.BottomToolStripPanel.Controls.Add (this.statusStrip1);
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.AutoScroll=true;
			this.toolStripContainer1.ContentPanel.Controls.Add (this.ViewCtrl1);
			this.toolStripContainer1.ContentPanel.Controls.Add (this.splitter1);
			this.toolStripContainer1.ContentPanel.Controls.Add (this.panel1);
			this.toolStripContainer1.ContentPanel.Controls.Add (this.toolBar1);
			this.toolStripContainer1.ContentPanel.Size=new System.Drawing.Size (784,148);
			this.toolStripContainer1.Dock=System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location=new System.Drawing.Point (0,0);
			this.toolStripContainer1.Name="toolStripContainer1";
			this.toolStripContainer1.Size=new System.Drawing.Size (784,295);
			this.toolStripContainer1.TabIndex=17;
			this.toolStripContainer1.Text="toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add (this.menuStrip1);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add (this.toolStrip3);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add (this.toolStrip4);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add (this.toolStrip1);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add (this.toolStrip2);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add (this.toolStrip6);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add (this.toolStrip5);
			// 
			// ViewCtrl1
			// 
			this.ViewCtrl1.AllowDrop=true;
			this.ViewCtrl1.Curr=null;
			this.ViewCtrl1.Dock=System.Windows.Forms.DockStyle.Fill;
			this.ViewCtrl1.Font=new System.Drawing.Font ("Arial",9F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte) (204)));
			this.ViewCtrl1.Location=new System.Drawing.Point (263,26);
			this.ViewCtrl1.Name="ViewCtrl1";
			this.ViewCtrl1.Size=new System.Drawing.Size (521,122);
			this.ViewCtrl1.TabIndex=15;
			// 
			// toolStrip2
			// 
			this.toolStrip2.Dock=System.Windows.Forms.DockStyle.None;
			this.toolStrip2.Location=new System.Drawing.Point (420,0);
			this.toolStrip2.Name="toolStrip2";
			this.toolStrip2.Size=new System.Drawing.Size (111,25);
			this.toolStrip2.TabIndex=2;
			// 
			// toolStrip6
			// 
			this.toolStrip6.Dock=System.Windows.Forms.DockStyle.None;
			this.toolStrip6.Location=new System.Drawing.Point (39,75);
			this.toolStrip6.Name="toolStrip6";
			this.toolStrip6.Size=new System.Drawing.Size (43,25);
			this.toolStrip6.TabIndex=6;
			// 
			// toolStrip5
			// 
			this.toolStrip5.Dock=System.Windows.Forms.DockStyle.None;
			this.toolStrip5.Location=new System.Drawing.Point (39,100);
			this.toolStrip5.Name="toolStrip5";
			this.toolStrip5.Size=new System.Drawing.Size (111,25);
			this.toolStrip5.TabIndex=5;
			// 
			// toolStrip4
			// 
			this.toolStrip4.Dock=System.Windows.Forms.DockStyle.None;
			this.toolStrip4.Location=new System.Drawing.Point (153,50);
			this.toolStrip4.Name="toolStrip4";
			this.toolStrip4.Size=new System.Drawing.Size (111,25);
			this.toolStrip4.TabIndex=4;
			// 
			// toolStrip3
			// 
			this.toolStrip3.Dock=System.Windows.Forms.DockStyle.None;
			this.toolStrip3.Location=new System.Drawing.Point (5,50);
			this.toolStrip3.Name="toolStrip3";
			this.toolStrip3.Size=new System.Drawing.Size (111,25);
			this.toolStrip3.TabIndex=3;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock=System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Location=new System.Drawing.Point (294,50);
			this.toolStrip1.Name="toolStrip1";
			this.toolStrip1.Size=new System.Drawing.Size (111,25);
			this.toolStrip1.TabIndex=1;
			// 
			// MainWnd
			// 
			this.AutoScaleBaseSize=new System.Drawing.Size (6,14);
			this.ClientSize=new System.Drawing.Size (784,295);
			this.Controls.Add (this.toolStripContainer1);
			this.Icon=((System.Drawing.Icon) (resources.GetObject ("$this.Icon")));
			this.Location=new System.Drawing.Point (0,0);
			this.MainMenuStrip=this.menuStrip1;
			this.Name="MainWnd";
			this.Text=" ";
			this.menuStrip1.ResumeLayout (false);
			this.menuStrip1.PerformLayout ();
			this.panel1.ResumeLayout (false);
			this.statusStrip1.ResumeLayout (false);
			this.statusStrip1.PerformLayout ();
			this.toolStripContainer1.BottomToolStripPanel.ResumeLayout (false);
			this.toolStripContainer1.BottomToolStripPanel.PerformLayout ();
			this.toolStripContainer1.ContentPanel.ResumeLayout (false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout (false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout ();
			this.toolStripContainer1.ResumeLayout (false);
			this.toolStripContainer1.PerformLayout ();
			this.ResumeLayout (false);

		}
		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		public System.Windows.Forms.ImageList treeImages;
		public UMLDes.Controls.FlatToolBar toolBar1;
		private System.Windows.Forms.ImageList toolbarImages;

		public UmlDesignerSolution p;
		private System.Windows.Forms.ToolStripMenuItem menu_About;
		private System.Windows.Forms.ToolStripMenuItem menu_NewProject;
		private System.Windows.Forms.ToolStripMenuItem menu_OpenProject;
		private System.Windows.Forms.ToolStripMenuItem menu_SaveProject;
		private System.Windows.Forms.ToolStripMenuItem menu_SaveProjAs;
		private System.Windows.Forms.ToolStripMenuItem menu_Print;
		private System.Windows.Forms.ToolStripMenuItem menu_Exit;
		private System.Windows.Forms.ToolStripMenuItem menu_Undo;
		private System.Windows.Forms.ToolStripMenuItem menu_Cut;
		private System.Windows.Forms.ToolStripMenuItem menu_Copy;
		private System.Windows.Forms.ToolStripMenuItem menu_Paste;
		private System.Windows.Forms.ToolStripMenuItem menu_Delete;
		private System.Windows.Forms.ToolStripMenuItem menu_SelectAll;
		private System.Windows.Forms.ToolStripMenuItem menu_AddFiles;
		private System.Windows.Forms.ToolStripMenuItem menu_AddStaticView;
		private System.Windows.Forms.ToolStripMenuItem menu_Parse;
		private System.Windows.Forms.ToolStripMenuItem menumain_Help;
		private System.Windows.Forms.ToolStripMenuItem menumain_File;
		private System.Windows.Forms.ToolStripMenuItem menumain_Edit;
		private System.Windows.Forms.ToolStripMenuItem menumain_Project;
		private System.Windows.Forms.ToolStripMenuItem menumain_View;
		private System.Windows.Forms.ToolStripMenuItem menu_Redo;
		private System.Windows.Forms.ToolStripMenuItem menu_GC_Collect;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private UMLDes.ViewCtrl ViewCtrl1;
		private UMLDes.Controls.UmlSolutionTree ProjectTree;
		private System.Windows.Forms.ToolStripMenuItem menu_PrintPreview;
		private System.Windows.Forms.ToolStripMenuItem menu_show_hints;
		private System.Windows.Forms.StatusStrip statusStrip1;
		internal System.Windows.Forms.ToolStripStatusLabel status_panel;
		private System.Windows.Forms.ToolStripMenuItem menu_SaveToImage;
		private System.Windows.Forms.ToolStripMenuItem menu_ZoomIn;
		private System.Windows.Forms.ToolStripMenuItem menu_ZoomOut;
		private System.Windows.Forms.ToolStripMenuItem menu_copyAsImage;
		public System.Windows.Forms.ImageList list;
		public UMLDes.Controls.UmlSolutionTree SolutionTree {
			get {
				return ProjectTree;
			}
		}

		#region 初始化 工具栏&树
		void initialize_tree_view (UMLDes.Controls.UmlSolutionTree tv) {
			tv.BackColor = System.Drawing.SystemColors.Window;
			tv.ImageList = this.treeImages;
			tv.LabelEdit = true;
			tv.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler (BeforeLabelEdit);
			tv.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler (AfterLabelEdit);
			tv.MouseDown += new System.Windows.Forms.MouseEventHandler (this.TreeMouseDown);
			tv.MouseUp += new System.Windows.Forms.MouseEventHandler (this.TreeMouseUp);
			tv.MouseMove += new System.Windows.Forms.MouseEventHandler (this.TreeMouseMove);
			tv.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler (this.tree_GiveFeedback);
		}

		UMLDes.Controls.FlatToolBarButton tool_undo,tool_redo,tool_cut,tool_copy,tool_paste;

		void PostInitialize () {
			initialize_tree_view (ProjectTree);

			UMLDes.Controls.MouseClickEvent m = new UMLDes.Controls.MouseClickEvent (ToolbarAction);
			UMLDes.Controls.FlatToolBarPanel p;

			//  project toolbar
			p = toolBar1.AddPanel (0,"Standard");
			p.AddButton (UMLDes.Controls.FlatButtonType.Simple,(int) UMLDes.GUI.ToolBarIcons.New,"新建工程",m);
			p.AddButton (UMLDes.Controls.FlatButtonType.Simple,(int) UMLDes.GUI.ToolBarIcons.Open,"打开工程",m);
			p.AddButton (UMLDes.Controls.FlatButtonType.Simple,(int) UMLDes.GUI.ToolBarIcons.Save,"保存",m);
			p.AddButton (UMLDes.Controls.FlatButtonType.Simple,(int) UMLDes.GUI.ToolBarIcons.Saveas,"另存为",m);
			p.AddButton (UMLDes.Controls.FlatButtonType.Line,0,null,null);
			p.AddButton (UMLDes.Controls.FlatButtonType.Simple,(int) UMLDes.GUI.ToolBarIcons.add_file,"Add files",m);
			p.AddButton (UMLDes.Controls.FlatButtonType.Simple,(int) UMLDes.GUI.ToolBarIcons.new_diagram,"New Static View",m);
			p.AddButton (UMLDes.Controls.FlatButtonType.Simple,(int) UMLDes.GUI.ToolBarIcons.refresh,"刷新模型",m);
			p.AddButton (UMLDes.Controls.FlatButtonType.Line,0,null,null);
			p.AddButton (UMLDes.Controls.FlatButtonType.Simple,(int) UMLDes.GUI.ToolBarIcons.print,"打印",m);
			p.AddButton (UMLDes.Controls.FlatButtonType.Simple,(int) UMLDes.GUI.ToolBarIcons.print_preview,"打印预览",m);
			p.AddButton (UMLDes.Controls.FlatButtonType.Line,0,null,null);
			tool_cut = p.AddButton (UMLDes.Controls.FlatButtonType.Simple,(int) UMLDes.GUI.ToolBarIcons.cut,"剪切",m);
			tool_copy = p.AddButton (UMLDes.Controls.FlatButtonType.Simple,(int) UMLDes.GUI.ToolBarIcons.copy,"复制",m);
			tool_paste = p.AddButton (UMLDes.Controls.FlatButtonType.Simple,(int) UMLDes.GUI.ToolBarIcons.paste,"粘贴",m);
			p.AddButton (UMLDes.Controls.FlatButtonType.Line,0,null,null);
			tool_undo = p.AddButton (UMLDes.Controls.FlatButtonType.Simple,(int) UMLDes.GUI.ToolBarIcons.undo,"撤销",m);
			tool_redo = p.AddButton (UMLDes.Controls.FlatButtonType.Simple,(int) UMLDes.GUI.ToolBarIcons.redo,"重做",m);
			tool_cut.disabled = tool_copy.disabled = tool_paste.disabled = true;

			// Scale menu
			p = toolBar1.AddPanel (0,"Scale");
			System.Windows.Forms.ComboBox cb = new System.Windows.Forms.ComboBox ();
			cb.TabStop = false;
			cb.Size = new System.Drawing.Size (90,20);
			cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cb.MaxDropDownItems = 15;

			for (int i = 0;i < ViewCtrl.scalevalue.Length;i += 2)
				cb.Items.Add ((ViewCtrl.scalevalue[i] * 100 / ViewCtrl.scalevalue[i + 1]).ToString () + "%");
			cb.SelectedIndex = 5;
			cb.SelectedIndexChanged += new System.EventHandler (ViewCtrl1.ScaleChanged);
			ViewCtrl1.scalecombo = cb;

			p.AddControl (cb);
		}
		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStripSeparator menuSeparator1;
		private System.Windows.Forms.ToolStripSeparator menuSeparator2;
		private System.Windows.Forms.ToolStripSeparator menuSeparator3;
		private System.Windows.Forms.ToolStripSeparator menuSeparator4;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStrip toolStrip6;
		private System.Windows.Forms.ToolStrip toolStrip5;
		private System.Windows.Forms.ToolStrip toolStrip4;
		private System.Windows.Forms.ToolStrip toolStrip3;
		private System.Windows.Forms.ToolStrip toolStrip2;

	}
}
