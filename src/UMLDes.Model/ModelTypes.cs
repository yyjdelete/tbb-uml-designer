using System;
using System.Collections;
using System.Xml.Serialization;

namespace UMLDes.Model {

	/// <summary>
	/// some declaration in Namespace: Class, Interface, Struct, Delegate or Enum
	/// </summary>
	public abstract class UmlType:UmlObject {
		[XmlIgnore]
		public string file;
		[XmlIgnore]
		public int start_offset,end_offset;
		[XmlIgnore]
		public UsingBlock using_chain;
		[XmlAttribute]
		public string name;

		public override string Name {
			get {
				return name;
			}
		}
	}


	/// <summary>
	/// Class, Interface or Struct
	/// </summary>
	public class UmlClass:UmlType,UmlTypeHolder {
		[XmlAttribute]
		public UmlKind kind;						// Class, Struct, Interface

		[XmlElement ("Class",typeof (UmlClass)),XmlElement ("Enum",typeof (UmlEnum)),XmlElement ("Delegate",typeof (UmlDelegate))]
		public ArrayList Types;

		[XmlIgnore]
		public Hashtable Children;

		[
		XmlElement ("Field",typeof (UmlField)),
		XmlElement ("Const",typeof (UmlConstant)),
		XmlElement ("Method",typeof (UmlMethod)),
		XmlElement ("Property",typeof (UmlProperty)),
		XmlElement ("Event",typeof (UmlEvent)),
		XmlElement ("Indexer",typeof (UmlIndexer)),
		XmlElement ("Ctor",typeof (UmlConstructor)),
		XmlElement ("Dtor",typeof (UmlDestructor)),
		XmlElement ("Operator",typeof (UmlOperator)),
		]
		public ArrayList Members;

		[XmlIgnore]
		public ArrayList BaseList;
		[XmlElement ("base",typeof (string))]
		public ArrayList BaseObjects;

		ArrayList UmlTypeHolder.Types {
			get {
				if (Types == null)
					Types = new ArrayList ();
				return Types;
			}
		}

		[XmlAttribute]
		public bool IsAbstract; // TODO

		#region ����UmlObject

		[XmlIgnore]
		public override UmlKind Kind {
			get {
				return kind;
			}
		}

		public override void Visit (Visitor v,UmlObject parent) {
			if (Types != null)
				foreach (UmlObject o in Types)
					o.Visit (v,this);
			if (Members != null)
				foreach (UmlObject o in Members)
					o.Visit (v,this);
			v (this,parent);
		}
		#endregion
	}

	/// <summary>
	/// Delegate
	/// </summary>
	public class UmlDelegate:UmlType {

		public string ReturnType;
		public ArrayList Parameters;

		#region ����UmlObject

		[XmlIgnore]
		public override UmlKind Kind {
			get {
				return UmlKind.Delegate;
			}
		}

		public override void Visit (UMLDes.Model.UmlObject.Visitor v,UmlObject parent) {
			//if( Parameters != null )
			//	foreach( UmlObject o in Parameters )
			//		o.Visit( v, this );
			v (this,parent);
		}

		#endregion
	}

	/// <summary>
	/// Enumeration
	/// </summary>
	public class UmlEnum:UmlType {

		[XmlElement ("field",typeof (UmlEnumField))]
		public ArrayList Members;

		#region ����UmlObject

		[XmlIgnore]
		public override UmlKind Kind {
			get {
				return UmlKind.Enum;
			}
		}

		public override void Visit (UMLDes.Model.UmlObject.Visitor v,UmlObject parent) {
			//if( Members != null )
			//	foreach( UmlObject o in Members )
			//		o.Visit( v, this );
			v (this,parent);
		}

		#endregion

	}
}