
/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 9/23/2012 6:16:12 PM
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using EntitySpaces.Core;
using EntitySpaces.Interfaces;
using EntitySpaces.DynamicQuery;



namespace BusinessObjects
{
	/// <summary>
	/// Encapsulates the 'Customers' table
	/// </summary>

    [DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(Customers))]	
	[XmlType("Customers")]
	public partial class Customers : esCustomers
	{	
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override esEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public esEntity CreateInstance()
		{
			return new Customers();
		}
		
		#region Static Quick Access Methods
		static public void Delete(System.String customerID)
		{
			var obj = new Customers();
			obj.CustomerID = customerID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

	    static public void Delete(System.String customerID, esSqlAccessType sqlAccessType)
		{
			var obj = new Customers();
			obj.CustomerID = customerID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion

		
					
		
	
	}



    [DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("CustomersCollection")]
	public partial class CustomersCollection : esCustomersCollection, IEnumerable<Customers>
	{
		public Customers FindByPrimaryKey(System.String customerID)
		{
			return this.SingleOrDefault(e => e.CustomerID == customerID);
		}

		
		
		#region WCF Service Class
		
		[DataContract]
		[KnownType(typeof(Customers))]
		public class CustomersCollectionWCFPacket : esCollectionWCFPacket<CustomersCollection>
		{
			public static implicit operator CustomersCollection(CustomersCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator CustomersCollectionWCFPacket(CustomersCollection collection)
			{
				return new CustomersCollectionWCFPacket() { Collection = collection };
			}
		}
		
		#endregion
		
				
	}



    [DebuggerDisplay("Query = {Parse()}")]
	[Serializable]
	[DataContract(Name = "CustomersQuery", Namespace = "http://www.entityspaces.net")]	
	public partial class CustomersQuery : esCustomersQuery
	{
		public CustomersQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	

		override protected string GetQueryName()
		{
			return "CustomersQuery";
		}
		
					
	
		#region Explicit Casts
		
		public static explicit operator string(CustomersQuery query)
		{
			return CustomersQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator CustomersQuery(string query)
		{
			return (CustomersQuery)CustomersQuery.SerializeHelper.FromXml(query, typeof(CustomersQuery));
		}
		
		#endregion		
	}

	[DataContract]
	[Serializable]
	abstract public partial class esCustomers : esEntity
	{
		public esCustomers()
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.String customerID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(customerID);
			else
				return LoadByPrimaryKeyStoredProcedure(customerID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.String customerID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(customerID);
			else
				return LoadByPrimaryKeyStoredProcedure(customerID);
		}

		private bool LoadByPrimaryKeyDynamic(System.String customerID)
		{
			CustomersQuery query = new CustomersQuery();
			query.Where(query.CustomerID == customerID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.String customerID)
		{
			esParameters parms = new esParameters();
			parms.Add("CustomerID", customerID);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		#region Properties
		
		
		
		/// <summary>
		/// Maps to Customers.CustomerID
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CustomerID
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.CustomerID);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.CustomerID, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.CustomerID);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customers.CompanyName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String CompanyName
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.CompanyName);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.CompanyName, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.CompanyName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customers.ContactName
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ContactName
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.ContactName);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.ContactName, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.ContactName);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customers.ContactTitle
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String ContactTitle
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.ContactTitle);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.ContactTitle, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.ContactTitle);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customers.Address
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Address
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.Address);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.Address, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.Address);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customers.City
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String City
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.City);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.City, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.City);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customers.Region
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Region
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.Region);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.Region, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.Region);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customers.PostalCode
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String PostalCode
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.PostalCode);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.PostalCode, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.PostalCode);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customers.Country
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Country
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.Country);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.Country, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.Country);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customers.Phone
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Phone
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.Phone);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.Phone, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.Phone);
				}
			}
		}		
		
		/// <summary>
		/// Maps to Customers.Fax
		/// </summary>
		[DataMember(EmitDefaultValue=false)]
		virtual public System.String Fax
		{
			get
			{
				return base.GetSystemString(CustomersMetadata.ColumnNames.Fax);
			}
			
			set
			{
				if(base.SetSystemString(CustomersMetadata.ColumnNames.Fax, value))
				{
					OnPropertyChanged(CustomersMetadata.PropertyNames.Fax);
				}
			}
		}		
		
		#endregion
		
		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return CustomersMetadata.Meta();
			}
		}

		#endregion		
		
		#region Query Logic

		public CustomersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomersQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomersQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}
		
		protected void InitQuery(CustomersQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntity)this).Connection;
			}			
		}

		#endregion
		
        [IgnoreDataMember]
		private CustomersQuery query;		
	}



	[Serializable]
	abstract public partial class esCustomersCollection : esEntityCollection<Customers>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return CustomersMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "CustomersCollection";
		}

		#endregion		
		
		#region Query Logic

	#if (!WindowsCE)
		[BrowsableAttribute(false)]
	#endif
		public CustomersQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new CustomersQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(CustomersQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new CustomersQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(CustomersQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			
			if (!query.es2.HasConnection)
			{
				query.es2.Connection = ((IEntityCollection)this).Connection;
			}			
		}

		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery((CustomersQuery)query);
		}

		#endregion
		
		private CustomersQuery query;
	}



	[Serializable]
	abstract public partial class esCustomersQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return CustomersMetadata.Meta();
			}
		}	
		
		#region QueryItemFromName
		
        protected override esQueryItem QueryItemFromName(string name)
        {
            switch (name)
            {
				case "CustomerID": return this.CustomerID;
				case "CompanyName": return this.CompanyName;
				case "ContactName": return this.ContactName;
				case "ContactTitle": return this.ContactTitle;
				case "Address": return this.Address;
				case "City": return this.City;
				case "Region": return this.Region;
				case "PostalCode": return this.PostalCode;
				case "Country": return this.Country;
				case "Phone": return this.Phone;
				case "Fax": return this.Fax;

                default: return null;
            }
        }		
		
		#endregion
		
		#region esQueryItems

		public esQueryItem CustomerID
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.CustomerID, esSystemType.String); }
		} 
		
		public esQueryItem CompanyName
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.CompanyName, esSystemType.String); }
		} 
		
		public esQueryItem ContactName
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.ContactName, esSystemType.String); }
		} 
		
		public esQueryItem ContactTitle
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.ContactTitle, esSystemType.String); }
		} 
		
		public esQueryItem Address
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.Address, esSystemType.String); }
		} 
		
		public esQueryItem City
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.City, esSystemType.String); }
		} 
		
		public esQueryItem Region
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.Region, esSystemType.String); }
		} 
		
		public esQueryItem PostalCode
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.PostalCode, esSystemType.String); }
		} 
		
		public esQueryItem Country
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.Country, esSystemType.String); }
		} 
		
		public esQueryItem Phone
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.Phone, esSystemType.String); }
		} 
		
		public esQueryItem Fax
		{
			get { return new esQueryItem(this, CustomersMetadata.ColumnNames.Fax, esSystemType.String); }
		} 
		
		#endregion
		
	}


	
	public partial class Customers : esCustomers
	{

		#region UpToCustomerDemographicsCollection - Many To Many
		/// <summary>
		/// Many to Many
		/// Foreign Key Name - FK_CustomerCustomerDemo_Customers
		/// </summary>

		[XmlIgnore]
		public CustomerDemographicsCollection UpToCustomerDemographicsCollection
		{
			get
			{
				if(this._UpToCustomerDemographicsCollection == null)
				{
					this._UpToCustomerDemographicsCollection = new CustomerDemographicsCollection();
					this._UpToCustomerDemographicsCollection.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("UpToCustomerDemographicsCollection", this._UpToCustomerDemographicsCollection);
					if (!this.es.IsLazyLoadDisabled && this.CustomerID != null)
					{
						CustomerDemographicsQuery m = new CustomerDemographicsQuery("m");
						CustomerCustomerDemoQuery j = new CustomerCustomerDemoQuery("j");
						m.Select(m);
						m.InnerJoin(j).On(m.CustomerTypeID == j.CustomerTypeID);
                        m.Where(j.CustomerID == this.CustomerID);

						this._UpToCustomerDemographicsCollection.Load(m);
					}
				}

				return this._UpToCustomerDemographicsCollection;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._UpToCustomerDemographicsCollection != null) 
				{ 
					this.RemovePostSave("UpToCustomerDemographicsCollection"); 
					this._UpToCustomerDemographicsCollection = null;
					this.OnPropertyChanged("UpToCustomerDemographicsCollection");
				} 
			}  			
		}

		/// <summary>
		/// Many to Many Associate
		/// Foreign Key Name - FK_CustomerCustomerDemo_Customers
		/// </summary>
		public void AssociateCustomerDemographicsCollection(CustomerDemographics entity)
		{
			if (this._CustomerCustomerDemoCollection == null)
			{
				this._CustomerCustomerDemoCollection = new CustomerCustomerDemoCollection();
				this._CustomerCustomerDemoCollection.es.Connection.Name = this.es.Connection.Name;
				this.SetPostSave("CustomerCustomerDemoCollection", this._CustomerCustomerDemoCollection);
			}

			CustomerCustomerDemo obj = this._CustomerCustomerDemoCollection.AddNew();
			obj.CustomerID = this.CustomerID;
			obj.CustomerTypeID = entity.CustomerTypeID;
		}

		/// <summary>
		/// Many to Many Dissociate
		/// Foreign Key Name - FK_CustomerCustomerDemo_Customers
		/// </summary>
		public void DissociateCustomerDemographicsCollection(CustomerDemographics entity)
		{
			if (this._CustomerCustomerDemoCollection == null)
			{
				this._CustomerCustomerDemoCollection = new CustomerCustomerDemoCollection();
				this._CustomerCustomerDemoCollection.es.Connection.Name = this.es.Connection.Name;
				this.SetPostSave("CustomerCustomerDemoCollection", this._CustomerCustomerDemoCollection);
			}

			CustomerCustomerDemo obj = this._CustomerCustomerDemoCollection.AddNew();
			obj.CustomerID = this.CustomerID;
            obj.CustomerTypeID = entity.CustomerTypeID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
		}

		private CustomerDemographicsCollection _UpToCustomerDemographicsCollection;
		private CustomerCustomerDemoCollection _CustomerCustomerDemoCollection;
		#endregion

		#region CustomerCustomerDemoCollectionByCustomerID - Zero To Many
		
		static public esPrefetchMap Prefetch_CustomerCustomerDemoCollectionByCustomerID
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap();
				map.PrefetchDelegate = BusinessObjects.Customers.CustomerCustomerDemoCollectionByCustomerID_Delegate;
				map.PropertyName = "CustomerCustomerDemoCollectionByCustomerID";
				map.MyColumnName = "CustomerID";
				map.ParentColumnName = "CustomerID";
				map.IsMultiPartKey = false;
				return map;
			}
		}		
		
		static private void CustomerCustomerDemoCollectionByCustomerID_Delegate(esPrefetchParameters data)
		{
			CustomersQuery parent = new CustomersQuery(data.NextAlias());

			CustomerCustomerDemoQuery me = data.You != null ? data.You as CustomerCustomerDemoQuery : new CustomerCustomerDemoQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.CustomerID == me.CustomerID);

			data.You = parent;
		}			
		
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_CustomerCustomerDemo_Customers
		/// </summary>

		[XmlIgnore]
		public CustomerCustomerDemoCollection CustomerCustomerDemoCollectionByCustomerID
		{
			get
			{
				if(this._CustomerCustomerDemoCollectionByCustomerID == null)
				{
					this._CustomerCustomerDemoCollectionByCustomerID = new CustomerCustomerDemoCollection();
					this._CustomerCustomerDemoCollectionByCustomerID.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("CustomerCustomerDemoCollectionByCustomerID", this._CustomerCustomerDemoCollectionByCustomerID);
				
					if (this.CustomerID != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._CustomerCustomerDemoCollectionByCustomerID.Query.Where(this._CustomerCustomerDemoCollectionByCustomerID.Query.CustomerID == this.CustomerID);
							this._CustomerCustomerDemoCollectionByCustomerID.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._CustomerCustomerDemoCollectionByCustomerID.fks.Add(CustomerCustomerDemoMetadata.ColumnNames.CustomerID, this.CustomerID);
					}
				}

				return this._CustomerCustomerDemoCollectionByCustomerID;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._CustomerCustomerDemoCollectionByCustomerID != null) 
				{ 
					this.RemovePostSave("CustomerCustomerDemoCollectionByCustomerID"); 
					this._CustomerCustomerDemoCollectionByCustomerID = null;
					this.OnPropertyChanged("CustomerCustomerDemoCollectionByCustomerID");
				} 
			} 			
		}
		
        // For DataContract Serialization Only
        [DataMember(Name="CustomerCustomerDemoCollectionByCustomerID", EmitDefaultValue = false)]
        private CustomerCustomerDemoCollection __CustomerCustomerDemoCollectionByCustomerID
        {
            get 
			{ 
                if (this._CustomerCustomerDemoCollectionByCustomerID != null)
                {
                    this._CustomerCustomerDemoCollectionByCustomerID.CombineDeletedEntities();
                }			
				return this._CustomerCustomerDemoCollectionByCustomerID; 
			}
			
            set
            {
                this._CustomerCustomerDemoCollectionByCustomerID = value;
				this._CustomerCustomerDemoCollectionByCustomerID.SeparateDeletedEntities();
                this.SetPostSave("CustomerCustomerDemoCollectionByCustomerID", this._CustomerCustomerDemoCollectionByCustomerID);
				
				if (this.CustomerID != null)
				{
					// Auto-hookup Foreign Keys
					this._CustomerCustomerDemoCollectionByCustomerID.fks.Add(CustomerCustomerDemoMetadata.ColumnNames.CustomerID, this.CustomerID);
				}
            }
        }	
		
		private CustomerCustomerDemoCollection _CustomerCustomerDemoCollectionByCustomerID;
		#endregion

		#region OrdersCollectionByCustomerID - Zero To Many
		
		static public esPrefetchMap Prefetch_OrdersCollectionByCustomerID
		{
			get
			{
				esPrefetchMap map = new esPrefetchMap();
				map.PrefetchDelegate = BusinessObjects.Customers.OrdersCollectionByCustomerID_Delegate;
				map.PropertyName = "OrdersCollectionByCustomerID";
				map.MyColumnName = "CustomerID";
				map.ParentColumnName = "CustomerID";
				map.IsMultiPartKey = false;
				return map;
			}
		}		
		
		static private void OrdersCollectionByCustomerID_Delegate(esPrefetchParameters data)
		{
			CustomersQuery parent = new CustomersQuery(data.NextAlias());

			OrdersQuery me = data.You != null ? data.You as OrdersQuery : new OrdersQuery(data.NextAlias());

			if (data.Root == null)
			{
				data.Root = me;
			}
			
			data.Root.InnerJoin(parent).On(parent.CustomerID == me.CustomerID);

			data.You = parent;
		}			
		
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - FK_Orders_Customers
		/// </summary>

		[XmlIgnore]
		public OrdersCollection OrdersCollectionByCustomerID
		{
			get
			{
				if(this._OrdersCollectionByCustomerID == null)
				{
					this._OrdersCollectionByCustomerID = new OrdersCollection();
					this._OrdersCollectionByCustomerID.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("OrdersCollectionByCustomerID", this._OrdersCollectionByCustomerID);
				
					if (this.CustomerID != null)
					{
						if (!this.es.IsLazyLoadDisabled)
						{
							this._OrdersCollectionByCustomerID.Query.Where(this._OrdersCollectionByCustomerID.Query.CustomerID == this.CustomerID);
							this._OrdersCollectionByCustomerID.Query.Load();
						}

						// Auto-hookup Foreign Keys
						this._OrdersCollectionByCustomerID.fks.Add(OrdersMetadata.ColumnNames.CustomerID, this.CustomerID);
					}
				}

				return this._OrdersCollectionByCustomerID;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._OrdersCollectionByCustomerID != null) 
				{ 
					this.RemovePostSave("OrdersCollectionByCustomerID"); 
					this._OrdersCollectionByCustomerID = null;
					this.OnPropertyChanged("OrdersCollectionByCustomerID");
				} 
			} 			
		}
		
        // For DataContract Serialization Only
        [DataMember(Name="OrdersCollectionByCustomerID", EmitDefaultValue = false)]
        private OrdersCollection __OrdersCollectionByCustomerID
        {
            get 
			{ 
                if (this._OrdersCollectionByCustomerID != null)
                {
                    this._OrdersCollectionByCustomerID.CombineDeletedEntities();
                }			
				return this._OrdersCollectionByCustomerID; 
			}
			
            set
            {
                this._OrdersCollectionByCustomerID = value;
				this._OrdersCollectionByCustomerID.SeparateDeletedEntities();
                this.SetPostSave("OrdersCollectionByCustomerID", this._OrdersCollectionByCustomerID);
				
				if (this.CustomerID != null)
				{
					// Auto-hookup Foreign Keys
					this._OrdersCollectionByCustomerID.fks.Add(OrdersMetadata.ColumnNames.CustomerID, this.CustomerID);
				}
            }
        }	
		
		private OrdersCollection _OrdersCollectionByCustomerID;
		#endregion

		
		protected override esEntityCollectionBase CreateCollectionForPrefetch(string name)
		{
			esEntityCollectionBase coll = null;

			switch (name)
			{
				case "CustomerCustomerDemoCollectionByCustomerID":
					coll = this.CustomerCustomerDemoCollectionByCustomerID;
					break;
				case "OrdersCollectionByCustomerID":
					coll = this.OrdersCollectionByCustomerID;
					break;	
			}

			return coll;
		}		
		/// <summary>
		/// Used internally by the entity's hierarchical properties.
		/// </summary>
		protected override List<esPropertyDescriptor> GetHierarchicalProperties()
		{
			List<esPropertyDescriptor> props = new List<esPropertyDescriptor>();
			
			props.Add(new esPropertyDescriptor(this, "CustomerCustomerDemoCollectionByCustomerID", typeof(CustomerCustomerDemoCollection), new CustomerCustomerDemo()));
			props.Add(new esPropertyDescriptor(this, "OrdersCollectionByCustomerID", typeof(OrdersCollection), new Orders()));
		
			return props;
		}
		
	}
	
	[KnownType(typeof(CustomerCustomerDemo))]
	[KnownType(typeof(Orders))]	
	public partial class Customers : esCustomers
	{
	
	}



	[Serializable]
	public partial class CustomersMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected CustomersMetadata()
		{
			m_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(CustomersMetadata.ColumnNames.CustomerID, 0, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.CustomerID;
			c.IsInPrimaryKey = true;
			c.CharacterMaxLength = 5;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.CompanyName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.CompanyName;
			c.CharacterMaxLength = 40;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.ContactName, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.ContactName;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.ContactTitle, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.ContactTitle;
			c.CharacterMaxLength = 30;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.Address, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.Address;
			c.CharacterMaxLength = 60;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.City, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.City;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.Region, 6, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.Region;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.PostalCode, 7, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.PostalCode;
			c.CharacterMaxLength = 10;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.Country, 8, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.Country;
			c.CharacterMaxLength = 15;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.Phone, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.Phone;
			c.CharacterMaxLength = 24;
			c.IsNullable = true;
			m_columns.Add(c);
				
			c = new esColumnMetadata(CustomersMetadata.ColumnNames.Fax, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = CustomersMetadata.PropertyNames.Fax;
			c.CharacterMaxLength = 24;
			c.IsNullable = true;
			m_columns.Add(c);
				
		}
		#endregion	
	
		static public CustomersMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base.m_dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base.m_columns; }
		}
		
		#region ColumnNames
		public class ColumnNames
		{ 
			 public const string CustomerID = "CustomerID";
			 public const string CompanyName = "CompanyName";
			 public const string ContactName = "ContactName";
			 public const string ContactTitle = "ContactTitle";
			 public const string Address = "Address";
			 public const string City = "City";
			 public const string Region = "Region";
			 public const string PostalCode = "PostalCode";
			 public const string Country = "Country";
			 public const string Phone = "Phone";
			 public const string Fax = "Fax";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string CustomerID = "CustomerID";
			 public const string CompanyName = "CompanyName";
			 public const string ContactName = "ContactName";
			 public const string ContactTitle = "ContactTitle";
			 public const string Address = "Address";
			 public const string City = "City";
			 public const string Region = "Region";
			 public const string PostalCode = "PostalCode";
			 public const string Country = "Country";
			 public const string Phone = "Phone";
			 public const string Fax = "Fax";
		}
		#endregion	

		public esProviderSpecificMetadata GetProviderMetadata(string mapName)
		{
			MapToMeta mapMethod = mapDelegates[mapName];

			if (mapMethod != null)
				return mapMethod(mapName);
			else
				return null;
		}
		
		#region MAP esDefault
		
		static private int RegisterDelegateesDefault()
		{
			// This is only executed once per the life of the application
			lock (typeof(CustomersMetadata))
			{
				if(CustomersMetadata.mapDelegates == null)
				{
					CustomersMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (CustomersMetadata.meta == null)
				{
					CustomersMetadata.meta = new CustomersMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esDefault);
				mapDelegates.Add("esDefault", mapMethod);
				mapMethod("esDefault");
			}
			return 0;
		}			

		private esProviderSpecificMetadata esDefault(string mapName)
		{
			if(!m_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();			


				meta.AddTypeMap("CustomerID", new esTypeMap("nchar", "System.String"));
				meta.AddTypeMap("CompanyName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("ContactName", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("ContactTitle", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Address", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("City", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Region", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("PostalCode", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Country", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Phone", new esTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Fax", new esTypeMap("nvarchar", "System.String"));			
				
				
				
				meta.Source = "Customers";
				meta.Destination = "Customers";
				
				meta.spInsert = "proc_CustomersInsert";				
				meta.spUpdate = "proc_CustomersUpdate";		
				meta.spDelete = "proc_CustomersDelete";
				meta.spLoadAll = "proc_CustomersLoadAll";
				meta.spLoadByPrimaryKey = "proc_CustomersLoadByPrimaryKey";
				
				this.m_providerMetadataMaps["esDefault"] = meta;
			}
			
			return this.m_providerMetadataMaps["esDefault"];
		}

		#endregion

		static private CustomersMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
