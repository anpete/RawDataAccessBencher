﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeFluentEntities.Bencher.Person
{
    using CodeFluent.Runtime;
    using CodeFluent.Runtime.Utilities;
    
    
    // CodeFluent Entities generated (http://www.softfluent.com). Date: Tuesday, 18 March 2014 16:33.
    // Build:1.0.61214.0764
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.61214.0764")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DataObjectAttribute()]
    [System.Diagnostics.DebuggerDisplayAttribute("EK={EntityKey}, AddressLine1={AddressLine1}")]
    [System.ComponentModel.TypeConverterAttribute(typeof(CodeFluent.Runtime.Design.NameTypeConverter))]
    public partial class Address : System.ICloneable, System.IComparable, System.IComparable<CodeFluentEntities.Bencher.Person.Address>, CodeFluent.Runtime.ICodeFluentEntity, System.ComponentModel.IDataErrorInfo, CodeFluent.Runtime.ICodeFluentMemberValidator, CodeFluent.Runtime.ICodeFluentSummaryValidator, System.IEquatable<CodeFluentEntities.Bencher.Person.Address>
    {
        
        private bool _raisePropertyChangedEvents = true;
        
        private CodeFluent.Runtime.CodeFluentEntityState _entityState;
        
        private int _addressID = -1;
        
        private string _addressLine1 = default(string);
        
        private string _addressLine2 = default(string);
        
        private string _city = default(string);
        
        private string _postalCode = default(string);
        
        private byte[] _spatialLocation = default(byte[]);
        
        private System.Guid _rowguid = CodeFluentPersistence.DefaultGuidValue;
        
        private System.DateTime _modifiedDate = CodeFluentPersistence.DefaultDateTimeValue;
        
        private int _stateProvinceStateProvinceID = -1;
        
        [System.NonSerializedAttribute()]
        private CodeFluentEntities.Bencher.Person.StateProvince _stateProvince = null;
        
        public Address()
        {
            this._entityState = CodeFluent.Runtime.CodeFluentEntityState.Created;
        }
        
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool RaisePropertyChangedEvents
        {
            get
            {
                return this._raisePropertyChangedEvents;
            }
            set
            {
                this._raisePropertyChangedEvents = value;
            }
        }
        
        public virtual string EntityKey
        {
            get
            {
                return this.AddressID.ToString();
            }
            set
            {
                this.AddressID = ((int)(ConvertUtilities.ChangeType(value, typeof(int), -1)));
            }
        }
        
        public virtual string EntityDisplayName
        {
            get
            {
                return this.AddressLine1;
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(((int)(-1)))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(int))]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public int AddressID
        {
            get
            {
                return this._addressID;
            }
            set
            {
                this._addressID = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("AddressID"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string AddressLine1
        {
            get
            {
                return this._addressLine1;
            }
            set
            {
                this._addressLine1 = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("AddressLine1"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string AddressLine2
        {
            get
            {
                return this._addressLine2;
            }
            set
            {
                this._addressLine2 = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("AddressLine2"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string City
        {
            get
            {
                return this._city;
            }
            set
            {
                this._city = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("City"));
            }
        }
        
        [System.ComponentModel.DefaultValueAttribute(default(string))]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(string))]
        public string PostalCode
        {
            get
            {
                return this._postalCode;
            }
            set
            {
                this._postalCode = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("PostalCode"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Type=typeof(byte[]))]
        public byte[] SpatialLocation
        {
            get
            {
                return this._spatialLocation;
            }
            set
            {
                this._spatialLocation = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("SpatialLocation"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.Guid))]
        public System.Guid Rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this._rowguid = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("Rowguid"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false, Type=typeof(System.DateTime))]
        public System.DateTime ModifiedDate
        {
            get
            {
                return this._modifiedDate;
            }
            set
            {
                this._modifiedDate = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("ModifiedDate"));
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=false)]
        [System.ComponentModel.DataObjectFieldAttribute(true)]
        public int StateProvinceStateProvinceID
        {
            get
            {
                if (((this._stateProvinceStateProvinceID == -1) 
                            && (this._stateProvince != null)))
                {
                    this._stateProvinceStateProvinceID = this._stateProvince.StateProvinceID;
                }
                return this._stateProvinceStateProvinceID;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<int>.Default.Equals(value, this.StateProvinceStateProvinceID) == true))
                {
                    return;
                }
                this._stateProvince = null;
                this._stateProvinceStateProvinceID = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("StateProvince"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("StateProvinceStateProvinceID"));
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CodeFluentEntities.Bencher.Person.StateProvince StateProvince
        {
            get
            {
                if ((this._stateProvince == null))
                {
                    this._stateProvince = CodeFluentEntities.Bencher.Person.StateProvince.Load(this._stateProvinceStateProvinceID);
                }
                return this._stateProvince;
            }
            set
            {
                this._stateProvinceStateProvinceID = -1;
                this._stateProvince = value;
                this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Modified;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("StateProvince"));
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("StateProvinceStateProvinceID"));
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.Error
        {
            get
            {
                return this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            }
        }
        
        string System.ComponentModel.IDataErrorInfo.this[string columnName]
        {
            get
            {
                return CodeFluentPersistence.ValidateMember(System.Globalization.CultureInfo.CurrentCulture, this, columnName, null);
            }
        }
        
        public virtual CodeFluent.Runtime.CodeFluentEntityState EntityState
        {
            get
            {
                return this._entityState;
            }
            set
            {
                if ((System.Collections.Generic.EqualityComparer<CodeFluent.Runtime.CodeFluentEntityState>.Default.Equals(value, this.EntityState) == true))
                {
                    return;
                }
                this._entityState = value;
                this.OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs("EntityState"));
            }
        }
        
        [field:System.NonSerializedAttribute()]
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        [field:System.NonSerializedAttribute()]
        public event CodeFluent.Runtime.CodeFluentEntityActionEventHandler EntityAction;
        
        protected virtual void OnPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((this.RaisePropertyChangedEvents == false))
            {
                return;
            }
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, e);
            }
        }
        
        protected virtual void OnEntityAction(CodeFluent.Runtime.CodeFluentEntityActionEventArgs e)
        {
            if ((this.EntityAction != null))
            {
                this.EntityAction(this, e);
            }
        }
        
        public virtual bool Equals(CodeFluentEntities.Bencher.Person.Address address)
        {
            if ((address == null))
            {
                return false;
            }
            if ((this.AddressID == -1))
            {
                return base.Equals(address);
            }
            return (this.AddressID.Equals(address.AddressID) == true);
        }
        
        public override int GetHashCode()
        {
            return this._addressID;
        }
        
        public override bool Equals(object obj)
        {
            CodeFluentEntities.Bencher.Person.Address address = null;
			address = obj as CodeFluentEntities.Bencher.Person.Address;
            return this.Equals(address);
        }
        
        int System.IComparable.CompareTo(object value)
        {
            CodeFluentEntities.Bencher.Person.Address address = null;
address = value as CodeFluentEntities.Bencher.Person.Address;
            if ((address == null))
            {
                throw new System.ArgumentException("value");
            }
            int localCompareTo = this.CompareTo(address);
            return localCompareTo;
        }
        
        public virtual int CompareTo(CodeFluentEntities.Bencher.Person.Address address)
        {
            if ((address == null))
            {
                throw new System.ArgumentNullException("address");
            }
            int localCompareTo = this.AddressID.CompareTo(address.AddressID);
            return localCompareTo;
        }
        
        public virtual string Validate(System.Globalization.CultureInfo culture)
        {
            return CodeFluentPersistence.Validate(culture, this, null);
        }
        
        public virtual void Validate(System.Globalization.CultureInfo culture, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validating, true, results);
            evt.Culture = culture;
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                string externalValidate;
                if ((evt.Argument != null))
                {
                    externalValidate = evt.Argument.ToString();
                }
                else
                {
                    externalValidate = CodeFluentEntities.Bencher.Resources.Manager.GetStringWithDefault(culture, "CodeFluentEntities.Bencher.Person.Address.ExternalValidate", "Type \'CodeFluentEntities.Bencher.Person.Address\' cannot be validated.", null);
                }
                CodeFluentPersistence.AddValidationError(results, externalValidate);
            }
            CodeFluentPersistence.ValidateMember(culture, results, this, null);
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Validated, false, results));
        }
        
        public void Validate()
        {
            string var = this.Validate(System.Globalization.CultureInfo.CurrentCulture);
            if ((var != null))
            {
                throw new CodeFluent.Runtime.CodeFluentValidationException(var);
            }
        }
        
        string CodeFluent.Runtime.ICodeFluentValidator.Validate(System.Globalization.CultureInfo culture)
        {
            string localValidate = this.Validate(culture);
            return localValidate;
        }
        
        void CodeFluent.Runtime.ICodeFluentMemberValidator.Validate(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
            this.ValidateMember(culture, memberName, results);
        }
        
        public virtual bool Delete()
        {
            bool ret = false;
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleting, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return ret;
            }
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Deleted))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Person", "Address", "Delete");
            persistence.AddRawParameter("@AddressID", this.AddressID);
            persistence.ExecuteNonQuery();
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Deleted, false, false));
            ret = true;
            return ret;
        }
        
        protected virtual void ReadRecord(System.Data.IDataReader reader, CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            if ((((options & CodeFluent.Runtime.CodeFluentReloadOptions.Properties) 
                        == 0) 
                        == false))
            {
                this._addressID = CodeFluentPersistence.GetReaderValue(reader, "AddressID", ((int)(-1)));
                this._addressLine1 = CodeFluentPersistence.GetReaderValue(reader, "AddressLine1", ((string)(default(string))));
                this._addressLine2 = CodeFluentPersistence.GetReaderValue(reader, "AddressLine2", ((string)(default(string))));
                this._city = CodeFluentPersistence.GetReaderValue(reader, "City", ((string)(default(string))));
                this._postalCode = CodeFluentPersistence.GetReaderValue(reader, "PostalCode", ((string)(default(string))));
                this._spatialLocation = CodeFluentPersistence.GetReaderValue(reader, "SpatialLocation", ((byte[])(default(byte[]))));
                this._rowguid = CodeFluentPersistence.GetReaderValue(reader, "rowguid", ((System.Guid)(CodeFluentPersistence.DefaultGuidValue)));
                this._modifiedDate = CodeFluentPersistence.GetReaderValue(reader, "ModifiedDate", ((System.DateTime)(CodeFluentPersistence.DefaultDateTimeValue)));
                this.StateProvinceStateProvinceID = CodeFluentPersistence.GetReaderValue(reader, "StateProvinceID", ((int)(-1)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecord, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecord(System.Data.IDataReader reader)
        {
            this.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
        }
        
        protected virtual void ReadRecordOnSave(System.Data.IDataReader reader)
        {
            if ((reader == null))
            {
                throw new System.ArgumentNullException("reader");
            }
            this._addressID = CodeFluentPersistence.GetReaderValue(reader, "AddressID", ((int)(-1)));
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.ReadRecordOnSave, false, false));
        }
        
        void CodeFluent.Runtime.ICodeFluentEntity.ReadRecordOnSave(System.Data.IDataReader reader)
        {
            this.ReadRecordOnSave(reader);
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Person.Address Load(int addressID)
        {
            if ((addressID == -1))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Person.Address address = new CodeFluentEntities.Bencher.Person.Address();
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Person", "Address", "Load");
            persistence.AddRawParameter("@AddressID", addressID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    address.ReadRecord(reader, CodeFluent.Runtime.CodeFluentReloadOptions.Default);
                    address.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    return address;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return null;
        }
        
        public virtual bool Reload(CodeFluent.Runtime.CodeFluentReloadOptions options)
        {
            bool ret = false;
            if ((this.AddressID == -1))
            {
                return ret;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Person", "Address", "Load");
            persistence.AddRawParameter("@AddressID", this.AddressID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecord(reader, options);
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
                    ret = true;
                }
                else
                {
                    this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Deleted;
                }
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            return ret;
        }
        
        protected virtual bool BaseSave(bool force)
        {
            if ((this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.ToBeDeleted))
            {
                this.Delete();
                return false;
            }
            CodeFluent.Runtime.CodeFluentEntityActionEventArgs evt = new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saving, true);
            this.OnEntityAction(evt);
            if ((evt.Cancel == true))
            {
                return false;
            }
            CodeFluentPersistence.ThrowIfDeleted(this);
            this.Validate();
            if (((force == false) 
                        && (this.EntityState == CodeFluent.Runtime.CodeFluentEntityState.Unchanged)))
            {
                return false;
            }
            CodeFluent.Runtime.CodeFluentPersistence persistence = CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence;
            persistence.CreateStoredProcedureCommand("Person", "Address", "Save");
            persistence.AddRawParameter("@AddressID", this.AddressID);
            persistence.AddRawParameter("@AddressLine1", this.AddressLine1);
            persistence.AddRawParameter("@AddressLine2", this.AddressLine2);
            persistence.AddRawParameter("@City", this.City);
            persistence.AddRawParameter("@PostalCode", this.PostalCode);
            persistence.AddRawParameter("@SpatialLocation", this.SpatialLocation);
            persistence.AddRawParameter("@rowguid", this.Rowguid);
            persistence.AddRawParameter("@ModifiedDate", this.ModifiedDate);
            persistence.AddRawParameter("@StateProvinceID", this.StateProvinceStateProvinceID);
            System.Data.IDataReader reader = null;
            try
            {
                reader = persistence.ExecuteReader();
                if ((reader.Read() == true))
                {
                    this.ReadRecordOnSave(reader);
                }
                CodeFluentPersistence.NextResults(reader);
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Dispose();
                }
                persistence.CompleteCommand();
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.Saved, false, false));
            this.EntityState = CodeFluent.Runtime.CodeFluentEntityState.Unchanged;
            return true;
        }
        
        public virtual bool Save()
        {
            bool localSave = this.BaseSave(false);
            return localSave;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, true)]
        public static bool Save(CodeFluentEntities.Bencher.Person.Address address)
        {
            if ((address == null))
            {
                return false;
            }
            bool ret = address.Save();
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public static bool Insert(CodeFluentEntities.Bencher.Person.Address address)
        {
            bool ret = CodeFluentEntities.Bencher.Person.Address.Save(address);
            return ret;
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public static bool Delete(CodeFluentEntities.Bencher.Person.Address address)
        {
            if ((address == null))
            {
                return false;
            }
            bool ret = address.Delete();
            return ret;
        }
        
        public string Trace()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            System.IO.StringWriter stringWriter = new System.IO.StringWriter(stringBuilder, System.Globalization.CultureInfo.CurrentCulture);
            System.CodeDom.Compiler.IndentedTextWriter writer = new System.CodeDom.Compiler.IndentedTextWriter(stringWriter);
            this.BaseTrace(writer);
            writer.Flush();
            ((System.IDisposable)(writer)).Dispose();
            ((System.IDisposable)(stringWriter)).Dispose();
            string sr = stringBuilder.ToString();
            return sr;
        }
        
        void CodeFluent.Runtime.ICodeFluentObject.Trace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            this.BaseTrace(writer);
        }
        
        protected virtual void BaseTrace(System.CodeDom.Compiler.IndentedTextWriter writer)
        {
            writer.Write("[");
            writer.Write("AddressID=");
            writer.Write(this.AddressID);
            writer.Write(",");
            writer.Write("AddressLine1=");
            writer.Write(this.AddressLine1);
            writer.Write(",");
            writer.Write("AddressLine2=");
            writer.Write(this.AddressLine2);
            writer.Write(",");
            writer.Write("City=");
            writer.Write(this.City);
            writer.Write(",");
            writer.Write("PostalCode=");
            writer.Write(this.PostalCode);
            writer.Write(",");
            writer.Write("SpatialLocation=");
            writer.Write(this.SpatialLocation);
            writer.Write(",");
            writer.Write("Rowguid=");
            writer.Write(this.Rowguid);
            writer.Write(",");
            writer.Write("ModifiedDate=");
            writer.Write(this.ModifiedDate);
            writer.Write(",");
            writer.Write("StateProvince=");
            if ((this._stateProvince != null))
            {
                ((CodeFluent.Runtime.ICodeFluentObject)(this._stateProvince)).Trace(writer);
            }
            else
            {
                writer.Write("<null>");
            }
            writer.Write(",");
            writer.Write("_stateProvinceStateProvinceID=");
            writer.Write(this._stateProvinceStateProvinceID);
            writer.Write(", EntityState=");
            writer.Write(this.EntityState);
            writer.Write("]");
        }
        
        [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
        public static CodeFluentEntities.Bencher.Person.Address LoadByEntityKey(string key)
        {
            if ((key == string.Empty))
            {
                return null;
            }
            CodeFluentEntities.Bencher.Person.Address address;
            int var = ((int)(ConvertUtilities.ChangeType(key, typeof(int), -1)));
            address = CodeFluentEntities.Bencher.Person.Address.Load(var);
            return address;
        }
        
        protected virtual void ValidateMember(System.Globalization.CultureInfo culture, string memberName, System.Collections.Generic.IList<CodeFluent.Runtime.CodeFluentValidationException> results)
        {
        }
        
        public CodeFluentEntities.Bencher.Person.Address Clone(bool deep)
        {
            CodeFluentEntities.Bencher.Person.Address address = new CodeFluentEntities.Bencher.Person.Address();
            this.CopyTo(address, deep);
            return address;
        }
        
        public CodeFluentEntities.Bencher.Person.Address Clone()
        {
            CodeFluentEntities.Bencher.Person.Address localClone = this.Clone(true);
            return localClone;
        }
        
        object System.ICloneable.Clone()
        {
            object localClone = this.Clone();
            return localClone;
        }
        
        public virtual void CopyFrom(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            if ((dict.Contains("AddressID") == true))
            {
                this.AddressID = ((int)(ConvertUtilities.ChangeType(dict["AddressID"], typeof(int), -1)));
            }
            if ((dict.Contains("SpatialLocation") == true))
            {
                this.SpatialLocation = ((byte[])(ConvertUtilities.ChangeType(dict["SpatialLocation"], typeof(byte[]), default(byte[]))));
            }
            if ((dict.Contains("Rowguid") == true))
            {
                this.Rowguid = ((System.Guid)(ConvertUtilities.ChangeType(dict["Rowguid"], typeof(System.Guid), CodeFluentPersistence.DefaultGuidValue)));
            }
            if ((dict.Contains("ModifiedDate") == true))
            {
                this.ModifiedDate = ((System.DateTime)(ConvertUtilities.ChangeType(dict["ModifiedDate"], typeof(System.DateTime), CodeFluentPersistence.DefaultDateTimeValue)));
            }
            if ((dict.Contains("PostalCode") == true))
            {
                this.PostalCode = ((string)(ConvertUtilities.ChangeType(dict["PostalCode"], typeof(string), default(string))));
            }
            if ((dict.Contains("AddressLine1") == true))
            {
                this.AddressLine1 = ((string)(ConvertUtilities.ChangeType(dict["AddressLine1"], typeof(string), default(string))));
            }
            if ((dict.Contains("AddressLine2") == true))
            {
                this.AddressLine2 = ((string)(ConvertUtilities.ChangeType(dict["AddressLine2"], typeof(string), default(string))));
            }
            if ((dict.Contains("City") == true))
            {
                this.City = ((string)(ConvertUtilities.ChangeType(dict["City"], typeof(string), default(string))));
            }
            if ((dict.Contains("StateProvinceStateProvinceID") == true))
            {
                this.StateProvinceStateProvinceID = ((int)(ConvertUtilities.ChangeType(dict["StateProvinceStateProvinceID"], typeof(int), -1)));
            }
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyFrom, false, dict));
        }
        
        public virtual void CopyTo(CodeFluentEntities.Bencher.Person.Address address, bool deep)
        {
            if ((address == null))
            {
                throw new System.ArgumentNullException("address");
            }
            address.AddressID = this.AddressID;
            address.SpatialLocation = this.SpatialLocation;
            address.Rowguid = this.Rowguid;
            address.ModifiedDate = this.ModifiedDate;
            address.PostalCode = this.PostalCode;
            address.AddressLine1 = this.AddressLine1;
            address.AddressLine2 = this.AddressLine2;
            address.City = this.City;
            address.StateProvinceStateProvinceID = this.StateProvinceStateProvinceID;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, address));
        }
        
        public virtual void CopyTo(System.Collections.IDictionary dict, bool deep)
        {
            if ((dict == null))
            {
                throw new System.ArgumentNullException("dict");
            }
            dict["AddressID"] = this.AddressID;
            dict["SpatialLocation"] = this.SpatialLocation;
            dict["Rowguid"] = this.Rowguid;
            dict["ModifiedDate"] = this.ModifiedDate;
            dict["PostalCode"] = this.PostalCode;
            dict["AddressLine1"] = this.AddressLine1;
            dict["AddressLine2"] = this.AddressLine2;
            dict["City"] = this.City;
            dict["StateProvinceStateProvinceID"] = this.StateProvinceStateProvinceID;
            this.OnEntityAction(new CodeFluent.Runtime.CodeFluentEntityActionEventArgs(this, CodeFluent.Runtime.CodeFluentEntityAction.CopyTo, false, dict));
        }
    }
}