﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPC.AAD.DA
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbupcaad")]
	public partial class dbupcaadDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcourse(course instance);
    partial void Updatecourse(course instance);
    partial void Deletecourse(course instance);
    partial void Insertstudent(student instance);
    partial void Updatestudent(student instance);
    partial void Deletestudent(student instance);
    partial void Insertcourse_student(course_student instance);
    partial void Updatecourse_student(course_student instance);
    partial void Deletecourse_student(course_student instance);
    #endregion
		
		public dbupcaadDataContext() : 
				base(global::UPC.AAD.DA.Properties.Settings.Default.dbupcaadConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbupcaadDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbupcaadDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbupcaadDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbupcaadDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<course> courses
		{
			get
			{
				return this.GetTable<course>();
			}
		}
		
		public System.Data.Linq.Table<student> students
		{
			get
			{
				return this.GetTable<student>();
			}
		}
		
		public System.Data.Linq.Table<course_student> course_students
		{
			get
			{
				return this.GetTable<course_student>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.course")]
	public partial class course : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private int _idusercreator;
		
		private System.DateTime _datecreator;
		
		private System.Nullable<int> _idusermodify;
		
		private System.Nullable<System.DateTime> _datemodify;
		
		private bool _active;
		
		private EntitySet<course_student> _course_students;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnidusercreatorChanging(int value);
    partial void OnidusercreatorChanged();
    partial void OndatecreatorChanging(System.DateTime value);
    partial void OndatecreatorChanged();
    partial void OnidusermodifyChanging(System.Nullable<int> value);
    partial void OnidusermodifyChanged();
    partial void OndatemodifyChanging(System.Nullable<System.DateTime> value);
    partial void OndatemodifyChanged();
    partial void OnactiveChanging(bool value);
    partial void OnactiveChanged();
    #endregion
		
		public course()
		{
			this._course_students = new EntitySet<course_student>(new Action<course_student>(this.attach_course_students), new Action<course_student>(this.detach_course_students));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idusercreator", DbType="Int NOT NULL")]
		public int idusercreator
		{
			get
			{
				return this._idusercreator;
			}
			set
			{
				if ((this._idusercreator != value))
				{
					this.OnidusercreatorChanging(value);
					this.SendPropertyChanging();
					this._idusercreator = value;
					this.SendPropertyChanged("idusercreator");
					this.OnidusercreatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datecreator", DbType="DateTime NOT NULL")]
		public System.DateTime datecreator
		{
			get
			{
				return this._datecreator;
			}
			set
			{
				if ((this._datecreator != value))
				{
					this.OndatecreatorChanging(value);
					this.SendPropertyChanging();
					this._datecreator = value;
					this.SendPropertyChanged("datecreator");
					this.OndatecreatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idusermodify", DbType="Int")]
		public System.Nullable<int> idusermodify
		{
			get
			{
				return this._idusermodify;
			}
			set
			{
				if ((this._idusermodify != value))
				{
					this.OnidusermodifyChanging(value);
					this.SendPropertyChanging();
					this._idusermodify = value;
					this.SendPropertyChanged("idusermodify");
					this.OnidusermodifyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datemodify", DbType="DateTime")]
		public System.Nullable<System.DateTime> datemodify
		{
			get
			{
				return this._datemodify;
			}
			set
			{
				if ((this._datemodify != value))
				{
					this.OndatemodifyChanging(value);
					this.SendPropertyChanging();
					this._datemodify = value;
					this.SendPropertyChanged("datemodify");
					this.OndatemodifyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_active", DbType="Bit NOT NULL")]
		public bool active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((this._active != value))
				{
					this.OnactiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("active");
					this.OnactiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="course_course_student", Storage="_course_students", ThisKey="id", OtherKey="idcourse")]
		public EntitySet<course_student> course_students
		{
			get
			{
				return this._course_students;
			}
			set
			{
				this._course_students.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_course_students(course_student entity)
		{
			this.SendPropertyChanging();
			entity.course = this;
		}
		
		private void detach_course_students(course_student entity)
		{
			this.SendPropertyChanging();
			entity.course = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.student")]
	public partial class student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _lastname;
		
		private System.DateTime _birthdate;
		
		private string _email;
		
		private decimal _ponderado;
		
		private string _picture;
		
		private int _idusercreator;
		
		private System.DateTime _datecreator;
		
		private System.Nullable<int> _idusermodify;
		
		private System.Nullable<System.DateTime> _datemodify;
		
		private bool _active;
		
		private EntitySet<course_student> _course_students;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnlastnameChanging(string value);
    partial void OnlastnameChanged();
    partial void OnbirthdateChanging(System.DateTime value);
    partial void OnbirthdateChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnponderadoChanging(decimal value);
    partial void OnponderadoChanged();
    partial void OnpictureChanging(string value);
    partial void OnpictureChanged();
    partial void OnidusercreatorChanging(int value);
    partial void OnidusercreatorChanged();
    partial void OndatecreatorChanging(System.DateTime value);
    partial void OndatecreatorChanged();
    partial void OnidusermodifyChanging(System.Nullable<int> value);
    partial void OnidusermodifyChanged();
    partial void OndatemodifyChanging(System.Nullable<System.DateTime> value);
    partial void OndatemodifyChanged();
    partial void OnactiveChanging(bool value);
    partial void OnactiveChanged();
    #endregion
		
		public student()
		{
			this._course_students = new EntitySet<course_student>(new Action<course_student>(this.attach_course_students), new Action<course_student>(this.detach_course_students));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string lastname
		{
			get
			{
				return this._lastname;
			}
			set
			{
				if ((this._lastname != value))
				{
					this.OnlastnameChanging(value);
					this.SendPropertyChanging();
					this._lastname = value;
					this.SendPropertyChanged("lastname");
					this.OnlastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birthdate", DbType="Date NOT NULL")]
		public System.DateTime birthdate
		{
			get
			{
				return this._birthdate;
			}
			set
			{
				if ((this._birthdate != value))
				{
					this.OnbirthdateChanging(value);
					this.SendPropertyChanging();
					this._birthdate = value;
					this.SendPropertyChanged("birthdate");
					this.OnbirthdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ponderado", DbType="Decimal(18,2) NOT NULL")]
		public decimal ponderado
		{
			get
			{
				return this._ponderado;
			}
			set
			{
				if ((this._ponderado != value))
				{
					this.OnponderadoChanging(value);
					this.SendPropertyChanging();
					this._ponderado = value;
					this.SendPropertyChanged("ponderado");
					this.OnponderadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_picture", DbType="VarChar(200)")]
		public string picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if ((this._picture != value))
				{
					this.OnpictureChanging(value);
					this.SendPropertyChanging();
					this._picture = value;
					this.SendPropertyChanged("picture");
					this.OnpictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idusercreator", DbType="Int NOT NULL")]
		public int idusercreator
		{
			get
			{
				return this._idusercreator;
			}
			set
			{
				if ((this._idusercreator != value))
				{
					this.OnidusercreatorChanging(value);
					this.SendPropertyChanging();
					this._idusercreator = value;
					this.SendPropertyChanged("idusercreator");
					this.OnidusercreatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datecreator", DbType="DateTime NOT NULL")]
		public System.DateTime datecreator
		{
			get
			{
				return this._datecreator;
			}
			set
			{
				if ((this._datecreator != value))
				{
					this.OndatecreatorChanging(value);
					this.SendPropertyChanging();
					this._datecreator = value;
					this.SendPropertyChanged("datecreator");
					this.OndatecreatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idusermodify", DbType="Int")]
		public System.Nullable<int> idusermodify
		{
			get
			{
				return this._idusermodify;
			}
			set
			{
				if ((this._idusermodify != value))
				{
					this.OnidusermodifyChanging(value);
					this.SendPropertyChanging();
					this._idusermodify = value;
					this.SendPropertyChanged("idusermodify");
					this.OnidusermodifyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datemodify", DbType="DateTime")]
		public System.Nullable<System.DateTime> datemodify
		{
			get
			{
				return this._datemodify;
			}
			set
			{
				if ((this._datemodify != value))
				{
					this.OndatemodifyChanging(value);
					this.SendPropertyChanging();
					this._datemodify = value;
					this.SendPropertyChanged("datemodify");
					this.OndatemodifyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_active", DbType="Bit NOT NULL")]
		public bool active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((this._active != value))
				{
					this.OnactiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("active");
					this.OnactiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_course_student", Storage="_course_students", ThisKey="id", OtherKey="idstudent")]
		public EntitySet<course_student> course_students
		{
			get
			{
				return this._course_students;
			}
			set
			{
				this._course_students.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_course_students(course_student entity)
		{
			this.SendPropertyChanging();
			entity.student = this;
		}
		
		private void detach_course_students(course_student entity)
		{
			this.SendPropertyChanging();
			entity.student = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.course_student")]
	public partial class course_student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idstudent;
		
		private int _idcourse;
		
		private int _idusercreator;
		
		private System.DateTime _datecreator;
		
		private System.Nullable<int> _idusermodify;
		
		private System.Nullable<System.DateTime> _datemodify;
		
		private bool _active;
		
		private EntityRef<course> _course;
		
		private EntityRef<student> _student;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidstudentChanging(int value);
    partial void OnidstudentChanged();
    partial void OnidcourseChanging(int value);
    partial void OnidcourseChanged();
    partial void OnidusercreatorChanging(int value);
    partial void OnidusercreatorChanged();
    partial void OndatecreatorChanging(System.DateTime value);
    partial void OndatecreatorChanged();
    partial void OnidusermodifyChanging(System.Nullable<int> value);
    partial void OnidusermodifyChanged();
    partial void OndatemodifyChanging(System.Nullable<System.DateTime> value);
    partial void OndatemodifyChanged();
    partial void OnactiveChanging(bool value);
    partial void OnactiveChanged();
    #endregion
		
		public course_student()
		{
			this._course = default(EntityRef<course>);
			this._student = default(EntityRef<student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idstudent", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idstudent
		{
			get
			{
				return this._idstudent;
			}
			set
			{
				if ((this._idstudent != value))
				{
					if (this._student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidstudentChanging(value);
					this.SendPropertyChanging();
					this._idstudent = value;
					this.SendPropertyChanged("idstudent");
					this.OnidstudentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idcourse", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idcourse
		{
			get
			{
				return this._idcourse;
			}
			set
			{
				if ((this._idcourse != value))
				{
					if (this._course.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidcourseChanging(value);
					this.SendPropertyChanging();
					this._idcourse = value;
					this.SendPropertyChanged("idcourse");
					this.OnidcourseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idusercreator", DbType="Int NOT NULL")]
		public int idusercreator
		{
			get
			{
				return this._idusercreator;
			}
			set
			{
				if ((this._idusercreator != value))
				{
					this.OnidusercreatorChanging(value);
					this.SendPropertyChanging();
					this._idusercreator = value;
					this.SendPropertyChanged("idusercreator");
					this.OnidusercreatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datecreator", DbType="DateTime NOT NULL")]
		public System.DateTime datecreator
		{
			get
			{
				return this._datecreator;
			}
			set
			{
				if ((this._datecreator != value))
				{
					this.OndatecreatorChanging(value);
					this.SendPropertyChanging();
					this._datecreator = value;
					this.SendPropertyChanged("datecreator");
					this.OndatecreatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idusermodify", DbType="Int")]
		public System.Nullable<int> idusermodify
		{
			get
			{
				return this._idusermodify;
			}
			set
			{
				if ((this._idusermodify != value))
				{
					this.OnidusermodifyChanging(value);
					this.SendPropertyChanging();
					this._idusermodify = value;
					this.SendPropertyChanged("idusermodify");
					this.OnidusermodifyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datemodify", DbType="DateTime")]
		public System.Nullable<System.DateTime> datemodify
		{
			get
			{
				return this._datemodify;
			}
			set
			{
				if ((this._datemodify != value))
				{
					this.OndatemodifyChanging(value);
					this.SendPropertyChanging();
					this._datemodify = value;
					this.SendPropertyChanged("datemodify");
					this.OndatemodifyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_active", DbType="Bit NOT NULL")]
		public bool active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((this._active != value))
				{
					this.OnactiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("active");
					this.OnactiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="course_course_student", Storage="_course", ThisKey="idcourse", OtherKey="id", IsForeignKey=true)]
		public course course
		{
			get
			{
				return this._course.Entity;
			}
			set
			{
				course previousValue = this._course.Entity;
				if (((previousValue != value) 
							|| (this._course.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._course.Entity = null;
						previousValue.course_students.Remove(this);
					}
					this._course.Entity = value;
					if ((value != null))
					{
						value.course_students.Add(this);
						this._idcourse = value.id;
					}
					else
					{
						this._idcourse = default(int);
					}
					this.SendPropertyChanged("course");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_course_student", Storage="_student", ThisKey="idstudent", OtherKey="id", IsForeignKey=true)]
		public student student
		{
			get
			{
				return this._student.Entity;
			}
			set
			{
				student previousValue = this._student.Entity;
				if (((previousValue != value) 
							|| (this._student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._student.Entity = null;
						previousValue.course_students.Remove(this);
					}
					this._student.Entity = value;
					if ((value != null))
					{
						value.course_students.Add(this);
						this._idstudent = value.id;
					}
					else
					{
						this._idstudent = default(int);
					}
					this.SendPropertyChanged("student");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591