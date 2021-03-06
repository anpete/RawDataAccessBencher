﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace NH.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'PhoneNumberType'</summary>
	public partial class PhoneNumberType
	{
		#region Class Member Declarations
		private Iesi.Collections.Generic.ISet<PersonPhone> _personPhones;
		private System.DateTime _modifiedDate;
		private System.String _name;
		private System.Int32 _phoneNumberTypeId;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="PhoneNumberType"/> class.</summary>
		public PhoneNumberType() : base()
		{
			_personPhones = new Iesi.Collections.Generic.HashedSet<PersonPhone>();
			_phoneNumberTypeId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.PhoneNumberTypeId.GetHashCode();
			return toReturn;
		}
	
		/// <summary>Determines whether the specified object is equal to this instance.</summary>
		/// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
		/// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
		public override bool Equals(object obj)
		{
			if(obj == null) 
			{
				return false;
			}
			PhoneNumberType toCompareWith = obj as PhoneNumberType;
			return toCompareWith == null ? false : ((this.PhoneNumberTypeId == toCompareWith.PhoneNumberTypeId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the Name field. </summary>	
		public virtual System.String Name
		{ 
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>Gets the PhoneNumberTypeId field. </summary>	
		public virtual System.Int32 PhoneNumberTypeId
		{ 
			get { return _phoneNumberTypeId; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'PersonPhone.PhoneNumberType - PhoneNumberType.PersonPhones (m:1)'</summary>
		public virtual Iesi.Collections.Generic.ISet<PersonPhone> PersonPhones
		{
			get { return _personPhones; }
			set { _personPhones = value; }
		}
		
		#endregion
	}
}
