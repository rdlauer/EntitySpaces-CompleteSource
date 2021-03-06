
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0319.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/17/2012 4:51:53 AM
'===============================================================================

Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text
Imports System.Linq
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery



Namespace BusinessObjects

	' <summary>
	' Encapsulates the 'Customers' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(Customers))> _
	<XmlType("Customers")> _ 
	<Table(Name:="Customers")> _	
	Partial Public Class Customers 
		Inherits esCustomers
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New Customers()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal customerID As System.String)
			Dim obj As New Customers()
			obj.CustomerID = customerID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal customerID As System.String, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New Customers()
			obj.CustomerID = customerID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
				
		#Region "Implicit Casts"

		Public Shared Widening Operator CType(ByVal entity As Customers) As CustomersProxyStub
			Return New CustomersProxyStub(entity)
		End Operator

		#End Region
		

		#Region "LINQtoSQL overrides (shame but we must do this)"

		<Column(IsPrimaryKey: = true, CanBeNull: = false)> _
		Public Overrides Property CustomerID As System.String
			Get
				Return MyBase.CustomerID
			End Get
			Set
				MyBase.CustomerID = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = false)> _
		Public Overrides Property CompanyName As System.String
			Get
				Return MyBase.CompanyName
			End Get
			Set
				MyBase.CompanyName = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property ContactName As System.String
			Get
				Return MyBase.ContactName
			End Get
			Set
				MyBase.ContactName = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property ContactTitle As System.String
			Get
				Return MyBase.ContactTitle
			End Get
			Set
				MyBase.ContactTitle = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Address As System.String
			Get
				Return MyBase.Address
			End Get
			Set
				MyBase.Address = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property City As System.String
			Get
				Return MyBase.City
			End Get
			Set
				MyBase.City = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Region As System.String
			Get
				Return MyBase.Region
			End Get
			Set
				MyBase.Region = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property PostalCode As System.String
			Get
				Return MyBase.PostalCode
			End Get
			Set
				MyBase.PostalCode = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Country As System.String
			Get
				Return MyBase.Country
			End Get
			Set
				MyBase.Country = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Phone As System.String
			Get
				Return MyBase.Phone
			End Get
			Set
				MyBase.Phone = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = true)> _
		Public Overrides Property Fax As System.String
			Get
				Return MyBase.Fax
			End Get
			Set
				MyBase.Fax = value
			End Set
		End Property
			
		#End Region
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<DebuggerVisualizer(GetType(EntitySpaces.DebuggerVisualizer.esVisualizer))> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("CustomersCollection")> _
	Partial Public Class CustomersCollection
		Inherits esCustomersCollection
		Implements IEnumerable(Of Customers)
	
		Public Function FindByPrimaryKey(ByVal customerID As System.String) As Customers
			Return MyBase.SingleOrDefault(Function(e) e.CustomerID = customerID)
		End Function

        #Region "Implicit Casts"
		
        Public Shared Widening Operator CType(ByVal coll As CustomersCollection) As CustomersCollectionProxyStub
            Return New CustomersCollectionProxyStub(coll)
        End Operator
        
		#End Region

				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(Customers))> _
		Public Class CustomersCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of CustomersCollection)
			
			Public Shared Widening Operator CType(packet As CustomersCollectionWCFPacket) As CustomersCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As CustomersCollection) As CustomersCollectionWCFPacket
				Return New CustomersCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	<DataContract(Name := "CustomersQuery", [Namespace]:= "http://www.entityspaces.net")> _ 
	Partial Public Class CustomersQuery 
		Inherits esCustomersQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "CustomersQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As CustomersQuery) As String
			Return CustomersQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As CustomersQuery
			Return DirectCast(CustomersQuery.SerializeHelper.FromXml(query, GetType(CustomersQuery)), CustomersQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esCustomers
		Inherits EntityBase
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal customerID As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(customerID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(customerID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal customerID As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(customerID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(customerID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal customerID As System.String) As Boolean
		
			Dim query As New CustomersQuery()
			query.Where(query.CustomerID = customerID)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal customerID As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("CustomerID", customerID)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to Customers.CustomerID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CustomerID As System.String
			Get
				Return MyBase.GetSystemString(CustomersMetadata.ColumnNames.CustomerID)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CustomersMetadata.ColumnNames.CustomerID, value) Then
					OnPropertyChanged(CustomersMetadata.PropertyNames.CustomerID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Customers.CompanyName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property CompanyName As System.String
			Get
				Return MyBase.GetSystemString(CustomersMetadata.ColumnNames.CompanyName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CustomersMetadata.ColumnNames.CompanyName, value) Then
					OnPropertyChanged(CustomersMetadata.PropertyNames.CompanyName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Customers.ContactName
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ContactName As System.String
			Get
				Return MyBase.GetSystemString(CustomersMetadata.ColumnNames.ContactName)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CustomersMetadata.ColumnNames.ContactName, value) Then
					OnPropertyChanged(CustomersMetadata.PropertyNames.ContactName)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Customers.ContactTitle
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property ContactTitle As System.String
			Get
				Return MyBase.GetSystemString(CustomersMetadata.ColumnNames.ContactTitle)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CustomersMetadata.ColumnNames.ContactTitle, value) Then
					OnPropertyChanged(CustomersMetadata.PropertyNames.ContactTitle)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Customers.Address
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Address As System.String
			Get
				Return MyBase.GetSystemString(CustomersMetadata.ColumnNames.Address)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CustomersMetadata.ColumnNames.Address, value) Then
					OnPropertyChanged(CustomersMetadata.PropertyNames.Address)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Customers.City
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(CustomersMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CustomersMetadata.ColumnNames.City, value) Then
					OnPropertyChanged(CustomersMetadata.PropertyNames.City)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Customers.Region
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Region As System.String
			Get
				Return MyBase.GetSystemString(CustomersMetadata.ColumnNames.Region)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CustomersMetadata.ColumnNames.Region, value) Then
					OnPropertyChanged(CustomersMetadata.PropertyNames.Region)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Customers.PostalCode
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property PostalCode As System.String
			Get
				Return MyBase.GetSystemString(CustomersMetadata.ColumnNames.PostalCode)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CustomersMetadata.ColumnNames.PostalCode, value) Then
					OnPropertyChanged(CustomersMetadata.PropertyNames.PostalCode)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Customers.Country
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Country As System.String
			Get
				Return MyBase.GetSystemString(CustomersMetadata.ColumnNames.Country)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CustomersMetadata.ColumnNames.Country, value) Then
					OnPropertyChanged(CustomersMetadata.PropertyNames.Country)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Customers.Phone
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Phone As System.String
			Get
				Return MyBase.GetSystemString(CustomersMetadata.ColumnNames.Phone)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CustomersMetadata.ColumnNames.Phone, value) Then
					OnPropertyChanged(CustomersMetadata.PropertyNames.Phone)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Customers.Fax
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property Fax As System.String
			Get
				Return MyBase.GetSystemString(CustomersMetadata.ColumnNames.Fax)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(CustomersMetadata.ColumnNames.Fax, value) Then
					OnPropertyChanged(CustomersMetadata.PropertyNames.Fax)
				End If
			End Set
		End Property	
		
#End Region	

#Region ".str() Properties"

		Public Overrides Sub SetProperties(values as IDictionary)

		Dim propertyName As String
			For Each propertyName In values.Keys
				Me.SetProperty(propertyName, values(propertyName))
			Next

		End Sub

		Public Overrides Sub SetProperty(name as string, value as object)

			Dim col As esColumnMetadata = Me.Meta.Columns.FindByPropertyName(name)
			If Not col Is Nothing Then

				If value Is Nothing OrElse value.GetType().ToString() = "System.String" Then

					' Use the strongly typed property
					Select Case name
												
						Case "CustomerID"
							Me.str().CustomerID = CType(value, string)
												
						Case "CompanyName"
							Me.str().CompanyName = CType(value, string)
												
						Case "ContactName"
							Me.str().ContactName = CType(value, string)
												
						Case "ContactTitle"
							Me.str().ContactTitle = CType(value, string)
												
						Case "Address"
							Me.str().Address = CType(value, string)
												
						Case "City"
							Me.str().City = CType(value, string)
												
						Case "Region"
							Me.str().Region = CType(value, string)
												
						Case "PostalCode"
							Me.str().PostalCode = CType(value, string)
												
						Case "Country"
							Me.str().Country = CType(value, string)
												
						Case "Phone"
							Me.str().Phone = CType(value, string)
												
						Case "Fax"
							Me.str().Fax = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
					
						Case Else
						
					End Select
				End If

			Else If Me.ContainsColumn(name) Then
				Me.SetColumn(name, value)
			Else
				throw New Exception("SetProperty Error: '" + name + "' not found")
			End If	

		End Sub

		Public Function str() As esStrings
		
			If _esstrings Is Nothing Then
				_esstrings = New esStrings(Me)
			End If
			Return _esstrings
			
		End Function

		NotInheritable Public Class esStrings
		
			Public Sub New(ByVal entity As esCustomers)
				Me.entity = entity
			End Sub				
		
	
			Public Property CustomerID As System.String 
				Get
					Dim data_ As System.String = entity.CustomerID
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustomerID = Nothing
					Else
						entity.CustomerID = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompanyName As System.String 
				Get
					Dim data_ As System.String = entity.CompanyName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompanyName = Nothing
					Else
						entity.CompanyName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ContactName As System.String 
				Get
					Dim data_ As System.String = entity.ContactName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ContactName = Nothing
					Else
						entity.ContactName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ContactTitle As System.String 
				Get
					Dim data_ As System.String = entity.ContactTitle
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ContactTitle = Nothing
					Else
						entity.ContactTitle = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Address As System.String 
				Get
					Dim data_ As System.String = entity.Address
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Address = Nothing
					Else
						entity.Address = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property City As System.String 
				Get
					Dim data_ As System.String = entity.City
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.City = Nothing
					Else
						entity.City = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Region As System.String 
				Get
					Dim data_ As System.String = entity.Region
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Region = Nothing
					Else
						entity.Region = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PostalCode As System.String 
				Get
					Dim data_ As System.String = entity.PostalCode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PostalCode = Nothing
					Else
						entity.PostalCode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Country As System.String 
				Get
					Dim data_ As System.String = entity.Country
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Country = Nothing
					Else
						entity.Country = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Phone As System.String 
				Get
					Dim data_ As System.String = entity.Phone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Phone = Nothing
					Else
						entity.Phone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fax As System.String 
				Get
					Dim data_ As System.String = entity.Fax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fax = Nothing
					Else
						entity.Fax = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esCustomers
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return CustomersMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As CustomersQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New CustomersQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As CustomersQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As CustomersQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As CustomersQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esCustomersCollection
		Inherits CollectionBase(Of Customers)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return CustomersMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "CustomersCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As CustomersQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New CustomersQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As CustomersQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New CustomersQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As CustomersQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, CustomersQuery))
		End Sub
		
		#End Region
						
		Private m_query As CustomersQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esCustomersQuery 
		Inherits QueryBase 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CustomersMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "CustomerID" 
					Return Me.CustomerID
				Case "CompanyName" 
					Return Me.CompanyName
				Case "ContactName" 
					Return Me.ContactName
				Case "ContactTitle" 
					Return Me.ContactTitle
				Case "Address" 
					Return Me.Address
				Case "City" 
					Return Me.City
				Case "Region" 
					Return Me.Region
				Case "PostalCode" 
					Return Me.PostalCode
				Case "Country" 
					Return Me.Country
				Case "Phone" 
					Return Me.Phone
				Case "Fax" 
					Return Me.Fax
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property CustomerID As esQueryItem
			Get
				Return New esQueryItem(Me, CustomersMetadata.ColumnNames.CustomerID, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompanyName As esQueryItem
			Get
				Return New esQueryItem(Me, CustomersMetadata.ColumnNames.CompanyName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ContactName As esQueryItem
			Get
				Return New esQueryItem(Me, CustomersMetadata.ColumnNames.ContactName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ContactTitle As esQueryItem
			Get
				Return New esQueryItem(Me, CustomersMetadata.ColumnNames.ContactTitle, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Address As esQueryItem
			Get
				Return New esQueryItem(Me, CustomersMetadata.ColumnNames.Address, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, CustomersMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Region As esQueryItem
			Get
				Return New esQueryItem(Me, CustomersMetadata.ColumnNames.Region, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PostalCode As esQueryItem
			Get
				Return New esQueryItem(Me, CustomersMetadata.ColumnNames.PostalCode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Country As esQueryItem
			Get
				Return New esQueryItem(Me, CustomersMetadata.ColumnNames.Country, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Phone As esQueryItem
			Get
				Return New esQueryItem(Me, CustomersMetadata.ColumnNames.Phone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fax As esQueryItem
			Get
				Return New esQueryItem(Me, CustomersMetadata.ColumnNames.Fax, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class Customers 
		Inherits esCustomers
		
	
		#Region "UpToCustomerDemographicsCollection - Many To Many"
		''' <summary>
		''' Many to Many
		''' Foreign Key Name - FK_CustomerCustomerDemo_Customers
		''' </summary>

		<XmlIgnore()> _
		Public Property UpToCustomerDemographicsCollection As CustomerDemographicsCollection
		
			Get
				If Me._UpToCustomerDemographicsCollection Is Nothing Then
					Me._UpToCustomerDemographicsCollection = New CustomerDemographicsCollection()
					Me._UpToCustomerDemographicsCollection.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("UpToCustomerDemographicsCollection", Me._UpToCustomerDemographicsCollection)
					If Not Me.es.IsLazyLoadDisabled And Not Me.CustomerID.Equals(Nothing) Then 
				
						Dim m As New CustomerDemographicsQuery("m")
						Dim j As New CustomerCustomerDemoQuery("j")
						m.Select(m)
						m.InnerJoin(j).On(m.CustomerTypeID = j.CustomerTypeID)
                        m.Where(j.CustomerID = Me.CustomerID)

						Me._UpToCustomerDemographicsCollection.Load(m)

					End If
				End If

				Return Me._UpToCustomerDemographicsCollection
			End Get
			
			Set(ByVal value As CustomerDemographicsCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._UpToCustomerDemographicsCollection Is Nothing Then

					Me.RemovePostSave("UpToCustomerDemographicsCollection")
					Me._UpToCustomerDemographicsCollection = Nothing
					Me.OnPropertyChanged("UpToCustomerDemographicsCollection")

				End If
			End Set	
			
		End Property

		''' <summary>
		''' Many to Many Associate
		''' Foreign Key Name - FK_CustomerCustomerDemo_Customers
		''' </summary>
		Public Sub AssociateCustomerDemographicsCollection(entity As CustomerDemographics)
			If Me._CustomerCustomerDemoCollection Is Nothing Then
				Me._CustomerCustomerDemoCollection = New CustomerCustomerDemoCollection()
				Me._CustomerCustomerDemoCollection.es.Connection.Name = Me.es.Connection.Name
				Me.SetPostSave("CustomerCustomerDemoCollection", Me._CustomerCustomerDemoCollection)
			End If
			
			Dim obj As CustomerCustomerDemo = Me._CustomerCustomerDemoCollection.AddNew()
			obj.CustomerID = Me.CustomerID
			obj.CustomerTypeID = entity.CustomerTypeID			
			
		End Sub

		''' <summary>
		''' Many to Many Dissociate
		''' Foreign Key Name - FK_CustomerCustomerDemo_Customers
		''' </summary>
		Public Sub DissociateCustomerDemographicsCollection(entity As CustomerDemographics)
			If Me._CustomerCustomerDemoCollection Is Nothing Then
				Me._CustomerCustomerDemoCollection = new CustomerCustomerDemoCollection()
				Me._CustomerCustomerDemoCollection.es.Connection.Name = Me.es.Connection.Name
				Me.SetPostSave("CustomerCustomerDemoCollection", Me._CustomerCustomerDemoCollection)
			End If

			Dim obj As CustomerCustomerDemo = Me._CustomerCustomerDemoCollection.AddNew()
			obj.CustomerID = Me.CustomerID
            obj.CustomerTypeID = entity.CustomerTypeID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
		End Sub

		Private _UpToCustomerDemographicsCollection As CustomerDemographicsCollection
		Private _CustomerCustomerDemoCollection As CustomerCustomerDemoCollection
		#End Region

		#Region "CustomerCustomerDemoCollectionByCustomerID - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_CustomerCustomerDemoCollectionByCustomerID() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.Customers.CustomerCustomerDemoCollectionByCustomerID_Delegate)
				map.PropertyName = "CustomerCustomerDemoCollectionByCustomerID"
				map.MyColumnName = "CustomerID"
				map.ParentColumnName = "CustomerID"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub CustomerCustomerDemoCollectionByCustomerID_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New CustomersQuery(data.NextAlias())
			
			Dim mee As CustomerCustomerDemoQuery = If(data.You IsNot Nothing, TryCast(data.You, CustomerCustomerDemoQuery), New CustomerCustomerDemoQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.CustomerID = mee.CustomerID)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_CustomerCustomerDemo_Customers
		''' </summary>

		<XmlIgnore()> _ 
		Public Property CustomerCustomerDemoCollectionByCustomerID As CustomerCustomerDemoCollection 
		
			Get
				If Me._CustomerCustomerDemoCollectionByCustomerID Is Nothing Then
					Me._CustomerCustomerDemoCollectionByCustomerID = New CustomerCustomerDemoCollection()
					Me._CustomerCustomerDemoCollectionByCustomerID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("CustomerCustomerDemoCollectionByCustomerID", Me._CustomerCustomerDemoCollectionByCustomerID)
				
					If Not Me.CustomerID.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._CustomerCustomerDemoCollectionByCustomerID.Query.Where(Me._CustomerCustomerDemoCollectionByCustomerID.Query.CustomerID = Me.CustomerID)
							Me._CustomerCustomerDemoCollectionByCustomerID.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._CustomerCustomerDemoCollectionByCustomerID.fks.Add(CustomerCustomerDemoMetadata.ColumnNames.CustomerID, Me.CustomerID)
					End If
				End If

				Return Me._CustomerCustomerDemoCollectionByCustomerID
			End Get
			
			Set(ByVal value As CustomerCustomerDemoCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._CustomerCustomerDemoCollectionByCustomerID Is Nothing Then

					Me.RemovePostSave("CustomerCustomerDemoCollectionByCustomerID")
					Me._CustomerCustomerDemoCollectionByCustomerID = Nothing
					Me.OnPropertyChanged("CustomerCustomerDemoCollectionByCustomerID")

				End If
			End Set				
			
		End Property
		

		private _CustomerCustomerDemoCollectionByCustomerID As CustomerCustomerDemoCollection
		#End Region

		#Region "OrdersCollectionByCustomerID - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_OrdersCollectionByCustomerID() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.Customers.OrdersCollectionByCustomerID_Delegate)
				map.PropertyName = "OrdersCollectionByCustomerID"
				map.MyColumnName = "CustomerID"
				map.ParentColumnName = "CustomerID"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub OrdersCollectionByCustomerID_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New CustomersQuery(data.NextAlias())
			
			Dim mee As OrdersQuery = If(data.You IsNot Nothing, TryCast(data.You, OrdersQuery), New OrdersQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.CustomerID = mee.CustomerID)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_Orders_Customers
		''' </summary>

		<XmlIgnore()> _ 
		Public Property OrdersCollectionByCustomerID As OrdersCollection 
		
			Get
				If Me._OrdersCollectionByCustomerID Is Nothing Then
					Me._OrdersCollectionByCustomerID = New OrdersCollection()
					Me._OrdersCollectionByCustomerID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("OrdersCollectionByCustomerID", Me._OrdersCollectionByCustomerID)
				
					If Not Me.CustomerID.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._OrdersCollectionByCustomerID.Query.Where(Me._OrdersCollectionByCustomerID.Query.CustomerID = Me.CustomerID)
							Me._OrdersCollectionByCustomerID.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._OrdersCollectionByCustomerID.fks.Add(OrdersMetadata.ColumnNames.CustomerID, Me.CustomerID)
					End If
				End If

				Return Me._OrdersCollectionByCustomerID
			End Get
			
			Set(ByVal value As OrdersCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._OrdersCollectionByCustomerID Is Nothing Then

					Me.RemovePostSave("OrdersCollectionByCustomerID")
					Me._OrdersCollectionByCustomerID = Nothing
					Me.OnPropertyChanged("OrdersCollectionByCustomerID")

				End If
			End Set				
			
		End Property
		

		private _OrdersCollectionByCustomerID As OrdersCollection
		#End Region

		
		
		
		Protected Overrides Function CreateCollectionForPrefetch(name As String) As esEntityCollectionBase
			Dim coll As esEntityCollectionBase = Nothing

			Select Case name
			
				Case "CustomerCustomerDemoCollectionByCustomerID"
					coll = Me.CustomerCustomerDemoCollectionByCustomerID
					Exit Select
				Case "OrdersCollectionByCustomerID"
					coll = Me.OrdersCollectionByCustomerID
					Exit Select	
			End Select

			Return coll
		End Function
					
		''' <summary>
		''' Used internally by the entity's hierarchical properties.
		''' </summary>
		Protected Overrides Function GetHierarchicalProperties() As List(Of esPropertyDescriptor)
		
			Dim props As New List(Of esPropertyDescriptor)
			props.Add(new esPropertyDescriptor(Me, "CustomerCustomerDemoCollectionByCustomerID", GetType(CustomerCustomerDemoCollection), New CustomerCustomerDemo()))
			props.Add(new esPropertyDescriptor(Me, "OrdersCollectionByCustomerID", GetType(OrdersCollection), New Orders()))
			Return props
			
		End Function
	End Class
		



    <DataContract(Namespace:="http://tempuri.org/", Name:="Customers")> _
    <XmlType(TypeName:="CustomersProxyStub")> _
    <Serializable> _
    Partial Public Class CustomersProxyStub
	
		Public Sub New()
            Me._entity = New Customers()
            Me.theEntity = Me._entity
		End Sub
		
		Public Sub New(ByVal obj As Customers)
            Me.Entity = obj
            Me.theEntity = Me._entity
		End Sub
		
		Public Sub New(ByVal obj As Customers, ByVal dirtyColumnsOnly As Boolean)
            Me.Entity = obj
            Me.theEntity = Me._entity
			Me.dirtyColumnsOnly = dirtyColumnsOnly
		End Sub	
		
			
		#Region "Implicit Casts"

		Public Shared Widening Operator CType(ByVal entity As CustomersProxyStub) As Customers
			Return entity.Entity
		End Operator

		#End Region			

        Public Function GetEntityType() As Type
 	        Return GetType(Customers)
        End Function
		

		<DataMember(Name:="a0", Order:=1, EmitDefaultValue:=False)> _		
        Public Property CustomerID As System.String
        
            Get
				If Me.Entity.es.IsDeleted Then
                    Dim o As Object = Me.Entity. _
                       GetOriginalColumnValue(CustomersMetadata.ColumnNames.CustomerID)
					Return CType(o, System.String)
                Else
					Return Me.Entity.CustomerID
				End If				
			End Get
			
            Set(ByVal value As System.String)
				Me.Entity.CustomerID = value
			End Set
			
		End Property

		<DataMember(Name:="a1", Order:=2, EmitDefaultValue:=False)> _		
        Public Property CompanyName As System.String
        
            Get
                If Me.IncludeColumn(CustomersMetadata.ColumnNames.CompanyName) Then
                    Return Me.Entity.CompanyName
                Else
                    Return Nothing
				End If				
			End Get
			
            Set(ByVal value As System.String)
				Me.Entity.CompanyName = value
			End Set
			
		End Property

		<DataMember(Name:="a2", Order:=3, EmitDefaultValue:=False)> _		
        Public Property ContactName As System.String
        
            Get
                If Me.IncludeColumn(CustomersMetadata.ColumnNames.ContactName) Then
                    Return Me.Entity.ContactName
                Else
                    Return Nothing
				End If				
			End Get
			
            Set(ByVal value As System.String)
				Me.Entity.ContactName = value
			End Set
			
		End Property

		<DataMember(Name:="a3", Order:=4, EmitDefaultValue:=False)> _		
        Public Property ContactTitle As System.String
        
            Get
                If Me.IncludeColumn(CustomersMetadata.ColumnNames.ContactTitle) Then
                    Return Me.Entity.ContactTitle
                Else
                    Return Nothing
				End If				
			End Get
			
            Set(ByVal value As System.String)
				Me.Entity.ContactTitle = value
			End Set
			
		End Property

		<DataMember(Name:="a4", Order:=5, EmitDefaultValue:=False)> _		
        Public Property Address As System.String
        
            Get
                If Me.IncludeColumn(CustomersMetadata.ColumnNames.Address) Then
                    Return Me.Entity.Address
                Else
                    Return Nothing
				End If				
			End Get
			
            Set(ByVal value As System.String)
				Me.Entity.Address = value
			End Set
			
		End Property

		<DataMember(Name:="a5", Order:=6, EmitDefaultValue:=False)> _		
        Public Property City As System.String
        
            Get
                If Me.IncludeColumn(CustomersMetadata.ColumnNames.City) Then
                    Return Me.Entity.City
                Else
                    Return Nothing
				End If				
			End Get
			
            Set(ByVal value As System.String)
				Me.Entity.City = value
			End Set
			
		End Property

		<DataMember(Name:="a6", Order:=7, EmitDefaultValue:=False)> _		
        Public Property Region As System.String
        
            Get
                If Me.IncludeColumn(CustomersMetadata.ColumnNames.Region) Then
                    Return Me.Entity.Region
                Else
                    Return Nothing
				End If				
			End Get
			
            Set(ByVal value As System.String)
				Me.Entity.Region = value
			End Set
			
		End Property

		<DataMember(Name:="a7", Order:=8, EmitDefaultValue:=False)> _		
        Public Property PostalCode As System.String
        
            Get
                If Me.IncludeColumn(CustomersMetadata.ColumnNames.PostalCode) Then
                    Return Me.Entity.PostalCode
                Else
                    Return Nothing
				End If				
			End Get
			
            Set(ByVal value As System.String)
				Me.Entity.PostalCode = value
			End Set
			
		End Property

		<DataMember(Name:="a8", Order:=9, EmitDefaultValue:=False)> _		
        Public Property Country As System.String
        
            Get
                If Me.IncludeColumn(CustomersMetadata.ColumnNames.Country) Then
                    Return Me.Entity.Country
                Else
                    Return Nothing
				End If				
			End Get
			
            Set(ByVal value As System.String)
				Me.Entity.Country = value
			End Set
			
		End Property

		<DataMember(Name:="a9", Order:=10, EmitDefaultValue:=False)> _		
        Public Property Phone As System.String
        
            Get
                If Me.IncludeColumn(CustomersMetadata.ColumnNames.Phone) Then
                    Return Me.Entity.Phone
                Else
                    Return Nothing
				End If				
			End Get
			
            Set(ByVal value As System.String)
				Me.Entity.Phone = value
			End Set
			
		End Property

		<DataMember(Name:="a10", Order:=11, EmitDefaultValue:=False)> _		
        Public Property Fax As System.String
        
            Get
                If Me.IncludeColumn(CustomersMetadata.ColumnNames.Fax) Then
                    Return Me.Entity.Fax
                Else
                    Return Nothing
				End If				
			End Get
			
            Set(ByVal value As System.String)
				Me.Entity.Fax = value
			End Set
			
		End Property


		<DataMember(Name := "a10000", Order := 10000)> _
        Public Property esRowState As String
            Get
				Return Me.TheRowState
            End Get

            Set 
				Me.TheRowState = value
            End Set
        End Property
		
		<DataMember(Name := "a10001", Order := 10001, EmitDefaultValue := False)> _
		Private Property ModifiedColumns() As List(Of String)
			Get
				Return Entity.es.ModifiedColumns
			End Get
			Set(ByVal value As List(Of String))
				Entity.es.ModifiedColumns.AddRange(value)
			End Set
		End Property		
		
		<DataMember(Name := "a10002", Order := 10002, EmitDefaultValue := False)> _
        <XmlIgnore> _		
		Public Property esExtraColumns() As Dictionary(Of String, Object)
			Get
				Return Entity.GetExtraColumns()
			End Get
			Set(ByVal value As Dictionary(Of String, Object))
				Entity.SetExtraColumns(value)
			End Set
		End Property
		
		<XmlArray("_x_ExtraColumns")> _
		<XmlArrayItem("_x_ExtraColumns", Type := GetType(DictionaryEntry))> _
		Public Property _x_ExtraColumns() As DictionaryEntry()
			Get
				Dim extra As Dictionary(Of String, Object) = Entity.GetExtraColumns()

				' Make an array of DictionaryEntries to return   
				Dim ret As DictionaryEntry() = New DictionaryEntry(extra.Count - 1) {}
				Dim i As Integer = 0
				Dim de As DictionaryEntry

				' Iterate through the extra columns to load items into the array.   
				For Each kv As KeyValuePair(Of String, Object) In extra
					de = New DictionaryEntry()
					de.Key = kv.Key
					de.Value = kv.Value
					ret(i) = de
					i += 1
				Next
				Return ret
			End Get
			Set
				Dim extra As New Dictionary(Of String, Object)()
				For i As Integer = 0 To value.Length - 1
					extra.Add(DirectCast(value(i).Key, String), CInt(value(i).Value))
				Next
				Entity.SetExtraColumns(extra)
			End Set
		End Property
		
        <XmlIgnore> _		
        Public Property Entity As Customers
        
            Get
                If Me._entity Is Nothing Then
                    Me.entity = New Customers()
					Me.theEntity = Me._entity					
                End If

                Return _entity
            End Get

            Set
                Me._entity = value
            End Set
        End Property
		
		Protected Property TheRowState() As String
			Get
				Return theEntity.es.RowState.ToString()
			End Get
			
			Set(ByVal value As String)
				Select Case value
					Case "Unchanged"
						theEntity.AcceptChanges()
						Exit Select
					
					Case "Added"
						theEntity.AcceptChanges()
						theEntity.es.RowState = esDataRowState.Added
						Exit Select
					
					Case "Modified"
						theEntity.AcceptChanges()
						theEntity.es.RowState = esDataRowState.Modified
						Exit Select
					
					Case "Deleted"
						theEntity.AcceptChanges()
						theEntity.MarkAsDeleted()
						Exit Select
				End Select
			End Set
		End Property	
		
		Protected Function IncludeColumn(ByVal columnName As String) As Boolean
			Dim include As Boolean = False
			
			If dirtyColumnsOnly Then
				If theEntity.es.ModifiedColumns IsNot Nothing AndAlso theEntity.es.ModifiedColumns.Contains(columnName) Then
					include = True
				End If
			ElseIf Not theEntity.es.IsDeleted Then
				include = True
			End If
			
			Return include
		End Function	

        <NonSerialized(), XmlIgnore(), CLSCompliant(False)> _
        Public _entity As Customers
		
        <NonSerialized(), XmlIgnore(), CLSCompliant(False)> _
        Protected theEntity As esEntity

        <NonSerialized(), XmlIgnore()> _
        Protected dirtyColumnsOnly As Boolean		

	End Class
	



    <DataContract(Namespace:="http://tempuri.org/", Name:="CustomersCollection")> _
    <XmlType(TypeName:="CustomersCollectionProxyStub")> _
    <Serializable> _
    Partial Public Class CustomersCollectionProxyStub
	
		Protected Sub New()
			
		End Sub	
		
		Public Sub New(ByVal coll As esEntityCollection(Of Customers))
			Me.New(coll, False, False)
		End Sub

		Public Sub New(ByVal coll As esEntityCollection(Of Customers), ByVal dirtyRowsOnly As Boolean)
			Me.New(coll, dirtyRowsOnly, False)
		End Sub
		
		#Region "Implicit Casts"

		Public Shared Widening Operator CType(ByVal proxyStubCollection As CustomersCollectionProxyStub) As CustomersCollection
			Return proxyStubCollection.GetCollection()
		End Operator

		#End Region	
		
        Public Function GetEntityType() As Type
 	        Return GetType(Customers)
        End Function
		
		Public Sub New(ByVal coll As esEntityCollection(Of Customers), ByVal dirtyRowsOnly As Boolean, ByVal dirtyColumnsOnly As Boolean)

            For Each entity As Customers In coll
                Select Case entity.RowState
                    Case esDataRowState.Added, esDataRowState.Modified

                        Collection.Add(New CustomersProxyStub(entity, dirtyColumnsOnly))
                        Exit Select

                    Case esDataRowState.Unchanged

                        If Not dirtyRowsOnly Then
                            Collection.Add(New CustomersProxyStub(entity, dirtyColumnsOnly))
                        End If
                        Exit Select
                End Select
            Next

            If coll.es.DeletedEntities IsNot Nothing Then
                For Each entity As Customers In coll.es.DeletedEntities
                    Collection.Add(New CustomersProxyStub(entity, dirtyColumnsOnly))
                Next
            End If

        End Sub		

        <DataMember(Name := "Collection", EmitDefaultValue := False)> _
		Public Collection As New List(Of CustomersProxyStub)		

        Public Function GetCollection As CustomersCollection
			
                If Me._coll is Nothing Then
                    Me._coll = New CustomersCollection()
					
		            Dim proxy As CustomersProxyStub

                    For Each proxy In Me.Collection
                        Me._coll.AttachEntity(proxy.Entity)
                    Next
                End If

                Return Me._coll

        End Function

        <NonSerialized> _
		<XmlIgnore> _
        Private _coll As CustomersCollection
		
    End Class
	



	<Serializable> _
	Partial Public Class CustomersMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(CustomersMetadata.ColumnNames.CustomerID, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomersMetadata.PropertyNames.CustomerID
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 5
			m_columns.Add(c)
				
			c = New esColumnMetadata(CustomersMetadata.ColumnNames.CompanyName, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomersMetadata.PropertyNames.CompanyName
			c.CharacterMaxLength = 40
			m_columns.Add(c)
				
			c = New esColumnMetadata(CustomersMetadata.ColumnNames.ContactName, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomersMetadata.PropertyNames.ContactName
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CustomersMetadata.ColumnNames.ContactTitle, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomersMetadata.PropertyNames.ContactTitle
			c.CharacterMaxLength = 30
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CustomersMetadata.ColumnNames.Address, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomersMetadata.PropertyNames.Address
			c.CharacterMaxLength = 60
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CustomersMetadata.ColumnNames.City, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomersMetadata.PropertyNames.City
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CustomersMetadata.ColumnNames.Region, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomersMetadata.PropertyNames.Region
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CustomersMetadata.ColumnNames.PostalCode, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomersMetadata.PropertyNames.PostalCode
			c.CharacterMaxLength = 10
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CustomersMetadata.ColumnNames.Country, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomersMetadata.PropertyNames.Country
			c.CharacterMaxLength = 15
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CustomersMetadata.ColumnNames.Phone, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomersMetadata.PropertyNames.Phone
			c.CharacterMaxLength = 24
			c.IsNullable = True
			m_columns.Add(c)
				
			c = New esColumnMetadata(CustomersMetadata.ColumnNames.Fax, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomersMetadata.PropertyNames.Fax
			c.CharacterMaxLength = 24
			c.IsNullable = True
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As CustomersMetadata
			Return _meta
		End Function
		
		Public ReadOnly Property DataID() As System.Guid Implements IMetadata.DataID
			Get
				Return MyBase.m_dataID
			End Get
		End Property

		Public ReadOnly Property MultiProviderMode() As Boolean Implements IMetadata.MultiProviderMode
			Get
				Return true
			End Get
		End Property

		Public ReadOnly Property Columns() As esColumnMetadataCollection Implements IMetadata.Columns
			Get
				Return MyBase.m_columns
			End Get
		End Property

#Region "ColumnNames"
		Public Class ColumnNames
			 Public Const CustomerID As String = "CustomerID"
			 Public Const CompanyName As String = "CompanyName"
			 Public Const ContactName As String = "ContactName"
			 Public Const ContactTitle As String = "ContactTitle"
			 Public Const Address As String = "Address"
			 Public Const City As String = "City"
			 Public Const Region As String = "Region"
			 Public Const PostalCode As String = "PostalCode"
			 Public Const Country As String = "Country"
			 Public Const Phone As String = "Phone"
			 Public Const Fax As String = "Fax"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const CustomerID As String = "CustomerID"
			 Public Const CompanyName As String = "CompanyName"
			 Public Const ContactName As String = "ContactName"
			 Public Const ContactTitle As String = "ContactTitle"
			 Public Const Address As String = "Address"
			 Public Const City As String = "City"
			 Public Const Region As String = "Region"
			 Public Const PostalCode As String = "PostalCode"
			 Public Const Country As String = "Country"
			 Public Const Phone As String = "Phone"
			 Public Const Fax As String = "Fax"
		End Class
#End Region	

		Public Function GetProviderMetadata(ByVal mapName As String) As esProviderSpecificMetadata _
			Implements IMetadata.GetProviderMetadata

			Dim mapMethod As MapToMeta = mapDelegates(mapName)

			If (Not mapMethod = Nothing) Then
				Return mapMethod(mapName)
			Else
				Return Nothing
			End If

		End Function
		
#Region "MAP esDefault"

		Private Shared Function RegisterDelegateesDefault() As Integer
		
			' This is only executed once per the life of the application
			SyncLock GetType(CustomersMetadata)
			
				If CustomersMetadata.mapDelegates Is Nothing Then
					CustomersMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If CustomersMetadata._meta Is Nothing Then
					CustomersMetadata._meta = New CustomersMetadata()
				End If

				Dim mapMethod As New MapToMeta(AddressOf _meta.esDefault)
				mapDelegates.Add("esDefault", mapMethod)
				mapMethod("esDefault")
				Return 0

			End SyncLock
			
		End Function

		Private Function esDefault(ByVal mapName As String) As esProviderSpecificMetadata

			If (Not m_providerMetadataMaps.ContainsKey(mapName)) Then
			
				Dim meta As esProviderSpecificMetadata = New esProviderSpecificMetadata()
				


				meta.AddTypeMap("CustomerID", new esTypeMap("nchar", "System.String"))
				meta.AddTypeMap("CompanyName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ContactName", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ContactTitle", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Address", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("City", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Region", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("PostalCode", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Country", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Phone", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Fax", new esTypeMap("nvarchar", "System.String"))			
				meta.Catalog = "Northwind"
				meta.Schema = "dbo"
				 
				meta.Source = "Customers"
				meta.Destination = "Customers"
				
				meta.spInsert = "proc_CustomersInsert"
				meta.spUpdate = "proc_CustomersUpdate"
				meta.spDelete = "proc_CustomersDelete"
				meta.spLoadAll = "proc_CustomersLoadAll"
				meta.spLoadByPrimaryKey = "proc_CustomersLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As CustomersMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
