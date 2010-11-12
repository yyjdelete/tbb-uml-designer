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
			this.components = new System.ComponentModel.Container ();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (MainWnd));
			this.menu_About = new UMLDes.Controls.FlatMenuItem ();
			this.toolbarImages = new System.Windows.Forms.ImageList (this.components);
			this.menumain_Help = new UMLDes.Controls.FlatMenuItem ();
			this.menu_show_hints = new UMLDes.Controls.FlatMenuItem ();
			this.menu_GC_Collect = new UMLDes.Controls.FlatMenuItem ();
			this.mainMenu1 = new System.Windows.Forms.MainMenu (this.components);
			this.menumain_File = new UMLDes.Controls.FlatMenuItem ();
			this.menu_NewProject = new UMLDes.Controls.FlatMenuItem ();
			this.menu_OpenProject = new UMLDes.Controls.FlatMenuItem ();
			this.menu_SaveProject = new UMLDes.Controls.FlatMenuItem ();
			this.menu_SaveProjAs = new UMLDes.Controls.FlatMenuItem ();
			this.menuItem4 = new UMLDes.Controls.FlatMenuItem ();
			this.menu_Print = new UMLDes.Controls.FlatMenuItem ();
			this.menu_PrintPreview = new UMLDes.Controls.FlatMenuItem ();
			this.menu_SaveToImage = new UMLDes.Controls.FlatMenuItem ();
			this.menuItem1 = new UMLDes.Controls.FlatMenuItem ();
			this.menu_Exit = new UMLDes.Controls.FlatMenuItem ();
			this.menumain_Edit = new UMLDes.Controls.FlatMenuItem ();
			this.menu_Undo = new UMLDes.Controls.FlatMenuItem ();
			this.menu_Redo = new UMLDes.Controls.FlatMenuItem ();
			this.menuItem26 = new UMLDes.Controls.FlatMenuItem ();
			this.menu_Cut = new UMLDes.Controls.FlatMenuItem ();
			this.menu_Copy = new UMLDes.Controls.FlatMenuItem ();
			this.menu_Paste = new UMLDes.Controls.FlatMenuItem ();
			this.menu_Delete = new UMLDes.Controls.FlatMenuItem ();
			this.menuItem31 = new UMLDes.Controls.FlatMenuItem ();
			this.menu_SelectAll = new UMLDes.Controls.FlatMenuItem ();
			this.menu_copyAsImage = new UMLDes.Controls.FlatMenuItem ();
			this.menuItem2 = new UMLDes.Controls.FlatMenuItem ();
			this.menu_ZoomIn = new UMLDes.Controls.FlatMenuItem ();
			this.menu_ZoomOut = new UMLDes.Controls.FlatMenuItem ();
			this.menumain_Project = new UMLDes.Controls.FlatMenuItem ();
			this.menu_AddFiles = new UMLDes.Controls.FlatMenuItem ();
			this.menu_AddStaticView = new UMLDes.Controls.FlatMenuItem ();
			this.menu_Parse = new UMLDes.Controls.FlatMenuItem ();
			this.treeImages = new System.Windows.Forms.ImageList (this.components);
			this.toolBar1 = new UMLDes.Controls.FlatToolBar ();
			this.panel1 = new System.Windows.Forms.Panel ();
			this.splitter1 = new System.Windows.Forms.Splitter ();
			this.ViewCtrl1 = new UMLDes.ViewCtrl ();
			this.statusBar1 = new System.Windows.Forms.StatusBar ();
			this.status_panel = new System.Windows.Forms.StatusBarPanel ();
			this.ProjectTree = new UMLDes.Controls.UmlSolutionTree ();
			this.panel1.SuspendLayout ();
			((System.ComponentModel.ISupportInitialize) (this.status_panel)).BeginInit ();
			this.SuspendLayout ();
			// 
			// menu_About
			// 
			this.menu_About.ImageIndex = 14;
			this.menu_About.Images = this.toolbarImages;
			this.menu_About.Index = 0;
			this.menu_About.OwnerDraw = true;
			this.menu_About.Text = "关于(&A)";
			this.menu_About.Click += new System.EventHandler (this.menu_About_Click);
			// 
			// toolbarImages
			// 
			this.toolbarImages.ImageStream = ((System.Windows.Forms.ImageListStreamer) (resources.GetObject ("toolbarImages.ImageStream")));
			this.toolbarImages.TransparentColor = System.Drawing.Color.Silver;
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
			this.menumain_Help.ImageIndex = 0;
			this.menumain_Help.Images = null;
			this.menumain_Help.Index = 4;
			this.menumain_Help.MenuItems.AddRange (new System.Windows.Forms.MenuItem[] {
            this.menu_About,
            this.menu_show_hints,
            this.menu_GC_Collect});
			this.menumain_Help.OwnerDraw = true;
			this.menumain_Help.Text = "帮助(&H)";
			this.menumain_Help.Popup += new System.EventHandler (this.Help_Popup);
			// 
			// menu_show_hints
			// 
			this.menu_show_hints.ImageIndex = 0;
			this.menu_show_hints.Images = null;
			this.menu_show_hints.Index = 1;
			this.menu_show_hints.OwnerDraw = true;
			this.menu_show_hints.Text = "显示提示(&H)";
			// 
			// menu_GC_Collect
			// 
			this.menu_GC_Collect.ImageIndex = 0;
			this.menu_GC_Collect.Images = null;
			this.menu_GC_Collect.Index = 2;
			this.menu_GC_Collect.OwnerDraw = true;
			this.menu_GC_Collect.Text = "GC.Collect";
			this.menu_GC_Collect.Click += new System.EventHandler (this.menu_GC_Collect_Click);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange (new System.Windows.Forms.MenuItem[] {
            this.menumain_File,
            this.menumain_Edit,
            this.menuItem2,
            this.menumain_Project,
            this.menumain_Help});
			// 
			// menumain_File
			// 
			this.menumain_File.ImageIndex = 0;
			this.menumain_File.Images = null;
			this.menumain_File.Index = 0;
			this.menumain_File.MenuItems.AddRange (new System.Windows.Forms.MenuItem[] {
            this.menu_NewProject,
            this.menu_OpenProject,
            this.menu_SaveProject,
            this.menu_SaveProjAs,
            this.menuItem4,
            this.menu_Print,
            this.menu_PrintPreview,
            this.menu_SaveToImage,
            this.menuItem1,
            this.menu_Exit});
			this.menumain_File.OwnerDraw = true;
			this.menumain_File.Text = "文件(&F)";
			// 
			// menu_NewProject
			// 
			this.menu_NewProject.ImageIndex = 0;
			this.menu_NewProject.Images = this.toolbarImages;
			this.menu_NewProject.Index = 0;
			this.menu_NewProject.OwnerDraw = true;
			this.menu_NewProject.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.menu_NewProject.Text = "新建工程(&N)";
			this.menu_NewProject.Click += new System.EventHandler (this.menu_NewProject_Click);
			// 
			// menu_OpenProject
			// 
			this.menu_OpenProject.ImageIndex = 1;
			this.menu_OpenProject.Images = this.toolbarImages;
			this.menu_OpenProject.Index = 1;
			this.menu_OpenProject.OwnerDraw = true;
			this.menu_OpenProject.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.menu_OpenProject.Text = "打开工程(&O)";
			this.menu_OpenProject.Click += new System.EventHandler (this.LoadProject);
			// 
			// menu_SaveProject
			// 
			this.menu_SaveProject.ImageIndex = 2;
			this.menu_SaveProject.Images = this.toolbarImages;
			this.menu_SaveProject.Index = 2;
			this.menu_SaveProject.OwnerDraw = true;
			this.menu_SaveProject.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.menu_SaveProject.Text = "保存工程(&S)";
			this.menu_SaveProject.Click += new System.EventHandler (this.SaveProject);
			// 
			// menu_SaveProjAs
			// 
			this.menu_SaveProjAs.ImageIndex = 0;
			this.menu_SaveProjAs.Images = null;
			this.menu_SaveProjAs.Index = 3;
			this.menu_SaveProjAs.OwnerDraw = true;
			this.menu_SaveProjAs.Text = "另存为(&A) ...";
			this.menu_SaveProjAs.Click += new System.EventHandler (this.SaveAsProject);
			// 
			// menuItem4
			// 
			this.menuItem4.ImageIndex = 0;
			this.menuItem4.Images = null;
			this.menuItem4.Index = 4;
			this.menuItem4.OwnerDraw = true;
			this.menuItem4.Text = "-";
			// 
			// menu_Print
			// 
			this.menu_Print.ImageIndex = 18;
			this.menu_Print.Images = this.toolbarImages;
			this.menu_Print.Index = 5;
			this.menu_Print.OwnerDraw = true;
			this.menu_Print.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
			this.menu_Print.Text = "打印(&P)";
			this.menu_Print.Click += new System.EventHandler (this.menu_Print_Click);
			// 
			// menu_PrintPreview
			// 
			this.menu_PrintPreview.ImageIndex = 24;
			this.menu_PrintPreview.Images = this.toolbarImages;
			this.menu_PrintPreview.Index = 6;
			this.menu_PrintPreview.OwnerDraw = true;
			this.menu_PrintPreview.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftP;
			this.menu_PrintPreview.Text = "打印预览(&V)";
			this.menu_PrintPreview.Click += new System.EventHandler (this.menu_PrintPreview_Click);
			// 
			// menu_SaveToImage
			// 
			this.menu_SaveToImage.ImageIndex = 0;
			this.menu_SaveToImage.Images = null;
			this.menu_SaveToImage.Index = 7;
			this.menu_SaveToImage.OwnerDraw = true;
			this.menu_SaveToImage.Shortcut = System.Windows.Forms.Shortcut.CtrlI;
			this.menu_SaveToImage.Text = "Save diagram as Image";
			this.menu_SaveToImage.Click += new System.EventHandler (this.menu_SaveToImage_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.ImageIndex = 0;
			this.menuItem1.Images = null;
			this.menuItem1.Index = 8;
			this.menuItem1.OwnerDraw = true;
			this.menuItem1.Text = "-";
			// 
			// menu_Exit
			// 
			this.menu_Exit.ImageIndex = 0;
			this.menu_Exit.Images = null;
			this.menu_Exit.Index = 9;
			this.menu_Exit.OwnerDraw = true;
			this.menu_Exit.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.menu_Exit.Text = "退出(&X)";
			this.menu_Exit.Click += new System.EventHandler (this.Exit);
			// 
			// menumain_Edit
			// 
			this.menumain_Edit.ImageIndex = 0;
			this.menumain_Edit.Images = null;
			this.menumain_Edit.Index = 1;
			this.menumain_Edit.MenuItems.AddRange (new System.Windows.Forms.MenuItem[] {
            this.menu_Undo,
            this.menu_Redo,
            this.menuItem26,
            this.menu_Cut,
            this.menu_Copy,
            this.menu_Paste,
            this.menu_Delete,
            this.menuItem31,
            this.menu_SelectAll,
            this.menu_copyAsImage});
			this.menumain_Edit.OwnerDraw = true;
			this.menumain_Edit.Text = "编辑(&E)";
			this.menumain_Edit.Popup += new System.EventHandler (this.EditMenuPopup);
			// 
			// menu_Undo
			// 
			this.menu_Undo.ImageIndex = 15;
			this.menu_Undo.Images = this.toolbarImages;
			this.menu_Undo.Index = 0;
			this.menu_Undo.OwnerDraw = true;
			this.menu_Undo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
			this.menu_Undo.Text = "撤销(&U)";
			this.menu_Undo.Click += new System.EventHandler (this.menu_Undo_Click);
			// 
			// menu_Redo
			// 
			this.menu_Redo.ImageIndex = 16;
			this.menu_Redo.Images = this.toolbarImages;
			this.menu_Redo.Index = 1;
			this.menu_Redo.OwnerDraw = true;
			this.menu_Redo.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
			this.menu_Redo.Text = "重做(&R)";
			this.menu_Redo.Click += new System.EventHandler (this.menu_Redo_Click);
			// 
			// menuItem26
			// 
			this.menuItem26.ImageIndex = 0;
			this.menuItem26.Images = null;
			this.menuItem26.Index = 2;
			this.menuItem26.OwnerDraw = true;
			this.menuItem26.Text = "-";
			// 
			// menu_Cut
			// 
			this.menu_Cut.ImageIndex = 4;
			this.menu_Cut.Images = this.toolbarImages;
			this.menu_Cut.Index = 3;
			this.menu_Cut.OwnerDraw = true;
			this.menu_Cut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.menu_Cut.Text = "剪切(&T)";
			this.menu_Cut.Click += new System.EventHandler (this.menu_Cut_Click);
			// 
			// menu_Copy
			// 
			this.menu_Copy.ImageIndex = 5;
			this.menu_Copy.Images = this.toolbarImages;
			this.menu_Copy.Index = 4;
			this.menu_Copy.OwnerDraw = true;
			this.menu_Copy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.menu_Copy.Text = "复制(&C)";
			this.menu_Copy.Click += new System.EventHandler (this.menu_Copy_Click);
			// 
			// menu_Paste
			// 
			this.menu_Paste.ImageIndex = 6;
			this.menu_Paste.Images = this.toolbarImages;
			this.menu_Paste.Index = 5;
			this.menu_Paste.OwnerDraw = true;
			this.menu_Paste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
			this.menu_Paste.Text = "粘贴(&P)";
			this.menu_Paste.Click += new System.EventHandler (this.menu_Paste_Click);
			// 
			// menu_Delete
			// 
			this.menu_Delete.ImageIndex = 19;
			this.menu_Delete.Images = this.toolbarImages;
			this.menu_Delete.Index = 6;
			this.menu_Delete.OwnerDraw = true;
			this.menu_Delete.Shortcut = System.Windows.Forms.Shortcut.Del;
			this.menu_Delete.Text = "删除(&D)";
			this.menu_Delete.Click += new System.EventHandler (this.menuDeleteClick);
			// 
			// menuItem31
			// 
			this.menuItem31.ImageIndex = 0;
			this.menuItem31.Images = null;
			this.menuItem31.Index = 7;
			this.menuItem31.OwnerDraw = true;
			this.menuItem31.Text = "-";
			// 
			// menu_SelectAll
			// 
			this.menu_SelectAll.ImageIndex = 0;
			this.menu_SelectAll.Images = null;
			this.menu_SelectAll.Index = 8;
			this.menu_SelectAll.OwnerDraw = true;
			this.menu_SelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
			this.menu_SelectAll.Text = "全选(&A)";
			this.menu_SelectAll.Click += new System.EventHandler (this.menu_SelectAll_Click);
			// 
			// menu_copyAsImage
			// 
			this.menu_copyAsImage.ImageIndex = 0;
			this.menu_copyAsImage.Images = null;
			this.menu_copyAsImage.Index = 9;
			this.menu_copyAsImage.OwnerDraw = true;
			this.menu_copyAsImage.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftC;
			this.menu_copyAsImage.Text = "Copy diagram as Image";
			this.menu_copyAsImage.Click += new System.EventHandler (this.menu_copyAsImage_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.ImageIndex = 0;
			this.menuItem2.Images = null;
			this.menuItem2.Index = 2;
			this.menuItem2.MenuItems.AddRange (new System.Windows.Forms.MenuItem[] {
            this.menu_ZoomIn,
            this.menu_ZoomOut});
			this.menuItem2.OwnerDraw = true;
			this.menuItem2.Text = "查看(&V)";
			// 
			// menu_ZoomIn
			// 
			this.menu_ZoomIn.ImageIndex = 0;
			this.menu_ZoomIn.Images = null;
			this.menu_ZoomIn.Index = 0;
			this.menu_ZoomIn.OwnerDraw = true;
			this.menu_ZoomIn.Shortcut = System.Windows.Forms.Shortcut.CtrlJ;
			this.menu_ZoomIn.Text = "放大";
			this.menu_ZoomIn.Click += new System.EventHandler (this.menu_ZoomIn_Click);
			// 
			// menu_ZoomOut
			// 
			this.menu_ZoomOut.ImageIndex = 0;
			this.menu_ZoomOut.Images = null;
			this.menu_ZoomOut.Index = 1;
			this.menu_ZoomOut.OwnerDraw = true;
			this.menu_ZoomOut.Shortcut = System.Windows.Forms.Shortcut.CtrlK;
			this.menu_ZoomOut.Text = "缩小";
			this.menu_ZoomOut.Click += new System.EventHandler (this.menu_ZoomOut_Click);
			// 
			// menumain_Project
			// 
			this.menumain_Project.ImageIndex = 0;
			this.menumain_Project.Images = null;
			this.menumain_Project.Index = 3;
			this.menumain_Project.MenuItems.AddRange (new System.Windows.Forms.MenuItem[] {
            this.menu_AddFiles,
            this.menu_AddStaticView,
            this.menu_Parse});
			this.menumain_Project.OwnerDraw = true;
			this.menumain_Project.Text = "工程(&P)";
			// 
			// menu_AddFiles
			// 
			this.menu_AddFiles.ImageIndex = 20;
			this.menu_AddFiles.Images = this.toolbarImages;
			this.menu_AddFiles.Index = 0;
			this.menu_AddFiles.OwnerDraw = true;
			this.menu_AddFiles.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
			this.menu_AddFiles.Text = "添加文件(&A)";
			this.menu_AddFiles.Click += new System.EventHandler (this.AddFiles);
			// 
			// menu_AddStaticView
			// 
			this.menu_AddStaticView.ImageIndex = 13;
			this.menu_AddStaticView.Images = this.toolbarImages;
			this.menu_AddStaticView.Index = 1;
			this.menu_AddStaticView.OwnerDraw = true;
			this.menu_AddStaticView.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftN;
			this.menu_AddStaticView.Text = "&Add static view";
			this.menu_AddStaticView.Click += new System.EventHandler (this.menu_AddStaticView_Click);
			// 
			// menu_Parse
			// 
			this.menu_Parse.ImageIndex = 17;
			this.menu_Parse.Images = this.toolbarImages;
			this.menu_Parse.Index = 2;
			this.menu_Parse.OwnerDraw = true;
			this.menu_Parse.Shortcut = System.Windows.Forms.Shortcut.F5;
			this.menu_Parse.Text = "Parse files, refresh tree";
			this.menu_Parse.Click += new System.EventHandler (this.RefreshProject);
			// 
			// treeImages
			// 
			this.treeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer) (resources.GetObject ("treeImages.ImageStream")));
			this.treeImages.TransparentColor = System.Drawing.Color.Transparent;
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
			this.toolBar1.BackColor = System.Drawing.Color.FromArgb (((int) (((byte) (219)))),((int) (((byte) (216)))),((int) (((byte) (209)))));
			this.toolBar1.Dock = System.Windows.Forms.DockStyle.Top;
			this.toolBar1.ForeColor = System.Drawing.Color.FromArgb (((int) (((byte) (219)))),((int) (((byte) (216)))),((int) (((byte) (209)))));
			this.toolBar1.images = this.toolbarImages;
			this.toolBar1.Location = new System.Drawing.Point (0,0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.Size = new System.Drawing.Size (784,26);
			this.toolBar1.TabIndex = 10;
			this.toolBar1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add (this.ProjectTree);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point (0,26);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size (259,286);
			this.panel1.TabIndex = 13;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point (259,26);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size (4,286);
			this.splitter1.TabIndex = 14;
			this.splitter1.TabStop = false;
			// 
			// ViewCtrl1
			// 
			this.ViewCtrl1.AllowDrop = true;
			this.ViewCtrl1.Curr = null;
			this.ViewCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ViewCtrl1.Font = new System.Drawing.Font ("Arial",9F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte) (204)));
			this.ViewCtrl1.Location = new System.Drawing.Point (263,26);
			this.ViewCtrl1.Name = "ViewCtrl1";
			this.ViewCtrl1.Size = new System.Drawing.Size (521,286);
			this.ViewCtrl1.TabIndex = 15;
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point (0,312);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange (new System.Windows.Forms.StatusBarPanel[] {
            this.status_panel});
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size (784,19);
			this.statusBar1.TabIndex = 1;
			// 
			// status_panel
			// 
			this.status_panel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.status_panel.Name = "status_panel";
			this.status_panel.Text = "Ready";
			this.status_panel.ToolTipText = "Status";
			this.status_panel.Width = 767;
			// 
			// ProjectTree
			// 
			this.ProjectTree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ProjectTree.Location = new System.Drawing.Point (0,0);
			this.ProjectTree.Name = "ProjectTree";
			this.ProjectTree.Size = new System.Drawing.Size (259,286);
			this.ProjectTree.TabIndex = 2;
			// 
			// MainWnd
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size (6,14);
			this.ClientSize = new System.Drawing.Size (784,331);
			this.Controls.Add (this.ViewCtrl1);
			this.Controls.Add (this.splitter1);
			this.Controls.Add (this.panel1);
			this.Controls.Add (this.toolBar1);
			this.Controls.Add (this.statusBar1);
			this.Icon = ((System.Drawing.Icon) (resources.GetObject ("$this.Icon")));
			this.Location = new System.Drawing.Point (0,0);
			this.Menu = this.mainMenu1;
			this.Name = "MainWnd";
			this.Text = "TBB UML Designer";
			this.panel1.ResumeLayout (false);
			((System.ComponentModel.ISupportInitialize) (this.status_panel)).EndInit ();
			this.ResumeLayout (false);

		}
		#endregion

		private UMLDes.Controls.FlatMenuItem menuItem4;
		private System.Windows.Forms.MainMenu mainMenu1;
		public System.Windows.Forms.ImageList treeImages;
		public UMLDes.Controls.FlatToolBar toolBar1;
		private System.Windows.Forms.ImageList toolbarImages;

		public UmlDesignerSolution p;
		private UMLDes.Controls.FlatMenuItem menuItem26;
		private UMLDes.Controls.FlatMenuItem menuItem31;
		private UMLDes.Controls.FlatMenuItem menu_About;
		private UMLDes.Controls.FlatMenuItem menu_NewProject;
		private UMLDes.Controls.FlatMenuItem menu_OpenProject;
		private UMLDes.Controls.FlatMenuItem menu_SaveProject;
		private UMLDes.Controls.FlatMenuItem menu_SaveProjAs;
		private UMLDes.Controls.FlatMenuItem menu_Print;
		private UMLDes.Controls.FlatMenuItem menu_Exit;
		private UMLDes.Controls.FlatMenuItem menu_Undo;
		private UMLDes.Controls.FlatMenuItem menu_Cut;
		private UMLDes.Controls.FlatMenuItem menu_Copy;
		private UMLDes.Controls.FlatMenuItem menu_Paste;
		private UMLDes.Controls.FlatMenuItem menu_Delete;
		private UMLDes.Controls.FlatMenuItem menu_SelectAll;
		private UMLDes.Controls.FlatMenuItem menu_AddFiles;
		private UMLDes.Controls.FlatMenuItem menu_AddStaticView;
		private UMLDes.Controls.FlatMenuItem menu_Parse;
		private UMLDes.Controls.FlatMenuItem menumain_Help;
		private UMLDes.Controls.FlatMenuItem menumain_File;
		private UMLDes.Controls.FlatMenuItem menumain_Edit;
		private UMLDes.Controls.FlatMenuItem menumain_Project;
		private UMLDes.Controls.FlatMenuItem menu_Redo;
		private UMLDes.Controls.FlatMenuItem menu_GC_Collect;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private UMLDes.ViewCtrl ViewCtrl1;
		private UMLDes.Controls.UmlSolutionTree ProjectTree;
		private UMLDes.Controls.FlatMenuItem menu_PrintPreview;
		private UMLDes.Controls.FlatMenuItem menu_show_hints;
		private System.Windows.Forms.StatusBar statusBar1;
		internal System.Windows.Forms.StatusBarPanel status_panel;
		private UMLDes.Controls.FlatMenuItem menuItem1;
		private UMLDes.Controls.FlatMenuItem menu_SaveToImage;
		private UMLDes.Controls.FlatMenuItem menuItem2;
		private UMLDes.Controls.FlatMenuItem menu_ZoomIn;
		private UMLDes.Controls.FlatMenuItem menu_ZoomOut;
		private UMLDes.Controls.FlatMenuItem menu_copyAsImage;
		public System.Windows.Forms.ImageList list;
		public UMLDes.Controls.UmlSolutionTree SolutionTree {
			get {
				return ProjectTree;
			}
		}

		#region ToolBar/Tree initialization
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

	}
}
