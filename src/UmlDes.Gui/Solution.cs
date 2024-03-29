using System;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Serialization;
using System.IO;
using UMLDes.Model;
using UMLDes.Model.CSharp;

namespace UMLDes {

	public class UmlDesignerSolution : GUI.IPostload, GUI.ISolution {

        [XmlAttribute]	
		public string projectfile, name = "(未保存)";
		public UmlModel model;
		[XmlArrayItem(typeof(GUI.StaticView))]   
		public ArrayList diagrams = new ArrayList();

		internal ArrayList projects = new ArrayList();
		internal MainWnd container;
		internal bool modified { get { return false; } }

		public UmlDesignerSolution() {
			projectfile = String.Empty;
			model = ModelBuilder.CreateEmptyModel();
		}

		public void Save( bool saveas ) {
			if( projectfile.Length == 0 || saveas ) {
#if DEBUG
				projectfile = "c:\\temp\\proj.udf";
#else
				SaveFileDialog f = new SaveFileDialog();
				f.AddExtension = true;
				f.DefaultExt = "udf";
				f.Filter = "TBB UML设计器工程文件 (*.udf)|*.udf|All files (*.*)|*.*";
				if( f.ShowDialog() != DialogResult.OK )
					return;
				projectfile = f.FileName;
#endif
				name = Path.GetFileNameWithoutExtension( projectfile );
				container.RefreshTitle();
			}
			XmlSerializer s = new XmlSerializer( typeof(UmlDesignerSolution) );
			Stream file = new FileStream( projectfile, FileMode.Create );
			s.Serialize( file, this );
			file.Close();
		}

		public static UmlDesignerSolution Load( MainWnd m ) {
			string fname;
#if DEBUG
			fname = "C:\\temp\\proj.udf";
#else
			OpenFileDialog f = new OpenFileDialog();
			f.CheckFileExists = true;
			f.Filter = "TBB UML设计器工程文件 (*.udf)|*.udf|All files (*.*)|*.*";
			if( f.ShowDialog() != DialogResult.OK )
				return null;
			fname = f.FileName;
#endif

			UmlDesignerSolution p;
			XmlSerializer s = new XmlSerializer( typeof(UmlDesignerSolution) );
			Stream file = new FileStream( fname, FileMode.Open );
			p = s.Deserialize( file ) as UmlDesignerSolution;
			file.Close();
			if( p != null ) {
				// post load steps
				p.projectfile = fname;
				p.container = m;
				p.PostLoad();
			}
			return p;
		}

		public static UmlDesignerSolution createNew() {
			UmlDesignerSolution p = new UmlDesignerSolution(); 
			p.diagrams.Add( new GUI.StaticView() );
			p.PostLoad();
			return p;
		}

		private void SelectNameFor( GUI.View v ) {
			string name = v.name, tname;
			if( name.IndexOf( '1' ) != -1 )
				name = name.Substring( 0, name.IndexOf( '1' ) );
			int i = 1;
			do {
				tname = name + i.ToString();
				foreach( GUI.View d in diagrams )
					if( d.name.Equals( tname ) ) {
						tname = null;
						break;
					}
				i++;

			} while(tname == null);
			v.name = tname;
		}

		public GUI.View newStaticView() {
			GUI.StaticView d = new GUI.StaticView();
			SelectNameFor( d );
			diagrams.Add( d );
			d.proj = this;
			container.SolutionTree.RefreshDiagrams();
			return d;
		}

		/// <summary>
		/// Fixes GUI trees and references
		/// </summary>
		public void PostLoad( ) {

			if( model != null )
				ModelBuilder.PostLoad( model );
			else
				model = ModelBuilder.CreateEmptyModel();

			foreach( GUI.View d in diagrams )	{
				d.proj = this;
				if( container != null )
					container.SelectView( d, false );	// TODO bad code
				d.PostLoad();
			}
		}

		/// <summary>
		/// Shows AddFile to project dialog
		/// </summary>
		public void AddFile() {
			OpenFileDialog f = new OpenFileDialog();
			f.Multiselect = true;
			f.Filter = "Supported files (*.sln, *.csproj)|*.sln;*.csproj|Solutions Files (*.sln)|*.|C# project files (*.csproj)|*.csproj|All files (*.*)|*.*";
			if( f.ShowDialog() != DialogResult.OK )
				return;
			foreach( string name in f.FileNames ) {
				if( name.ToLower().EndsWith( ".csproj" ) )
					ModelBuilder.AddProject( model, name );
				else if( name.ToLower().EndsWith( ".sln" ) ) {
					ModelBuilder.AddProjectFromSLN( model, name );
				} else
					MessageBox.Show( "未知文件类型:\n" + name, "加载失败", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
			container.SolutionTree.RefreshModel();
		}

		/// <summary>
		/// Parses all project files, rebuilds project tree
		/// </summary>
		public void Refresh() {
			ArrayList errors;
			ModelBuilder.UpdateModel( model, out errors, new StatusNotifier(container.SetStatus) );
			container.SetStatus( "Refreshing diagrams" );
			if( errors != null && errors.Count > 0 ) {
				System.Text.StringBuilder sb = new System.Text.StringBuilder();
				foreach( string s in errors )
					sb.Append( s + "\n" );
				MessageBox.Show( sb.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error );
			} else {
				container.SolutionTree.RefreshModel();
				UMLDes.GUI.View before = container.GetCurrentView();
				foreach( UMLDes.GUI.View v in diagrams ) {
					if( container != null )
						container.SelectView( v, false );
					v.RefreshContent();
				}
				if( before != null )
					container.SelectView( before, true );
			}
			GC.Collect();
			container.SetStatus ("就绪");
		}
		
		#region ISolution support

		UmlModel GUI.ISolution.model { 
			get {
				return model;
			}
		}

		ImageList GUI.ISolution.icon_list { 
			get {
				return container.list;
			}
		}

		UMLDes.Controls.FlatToolBar GUI.ISolution.tool_bar {
			get {
				return container.toolBar1;
			}
		}

		void GUI.ISolution.UpdateToolBar() {
			container.UpdateToolBar();
		}

		ImageList GUI.ISolution.project_icon_list {
			get {
				return container.treeImages;
			}
		}

		#endregion
	}
}
