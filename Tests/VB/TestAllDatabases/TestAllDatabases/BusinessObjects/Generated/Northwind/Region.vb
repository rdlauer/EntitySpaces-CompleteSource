
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
	' Encapsulates the 'Region' table
	' </summary>

	<System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _ 
	<Serializable> _
	<DataContract> _
	<KnownType(GetType(Region))> _
	<XmlType("Region")> _ 
	<Table(Name:="Region")> _	
	Partial Public Class Region 
		Inherits esRegion
		
		<DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _		
		Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
			Get
				Return MyBase.Debug
			End Get
		End Property
		
		Public Overrides Function CreateInstance() as esEntity
			Return New Region()
		End Function
		
		#Region "Static Quick Access Methods"
		Public Shared Sub Delete(ByVal regionID As System.Int32)
			Dim obj As New Region()
			obj.RegionID = regionID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save()
		End Sub

		Public Shared Sub Delete(ByVal regionID As System.Int32, ByVal sqlAccessType As esSqlAccessType)
			Dim obj As New Region()
			obj.RegionID = regionID
			obj.AcceptChanges()
			obj.MarkAsDeleted()
			obj.Save(sqlAccessType)
		End Sub
		#End Region		
				
		#Region "Implicit Casts"

		Public Shared Widening Operator CType(ByVal entity As Region) As RegionProxyStub
			Return New RegionProxyStub(entity)
		End Operator

		#End Region
		

		#Region "LINQtoSQL overrides (shame but we must do this)"

		<Column(IsPrimaryKey: = true, CanBeNull: = false)> _
		Public Overrides Property RegionID As Nullable(Of System.Int32)
			Get
				Return MyBase.RegionID
			End Get
			Set
				MyBase.RegionID = value
			End Set
		End Property

		<Column(IsPrimaryKey: = false, CanBeNull: = false)> _
		Public Overrides Property RegionDescription As System.String
			Get
				Return MyBase.RegionDescription
			End Get
			Set
				MyBase.RegionDescription = value
			End Set
		End Property
			
		#End Region
			
	End Class


 
	<DebuggerDisplay("Count = {Count}")> _ 
	<DebuggerVisualizer(GetType(EntitySpaces.DebuggerVisualizer.esVisualizer))> _ 
	<Serializable> _
	<CollectionDataContract> _
	<XmlType("RegionCollection")> _
	Partial Public Class RegionCollection
		Inherits esRegionCollection
		Implements IEnumerable(Of Region)
	
		Public Function FindByPrimaryKey(ByVal regionID As System.Int32) As Region
			Return MyBase.SingleOrDefault(Function(e) e.RegionID.HasValue AndAlso e.RegionID.Value = regionID)
		End Function

        #Region "Implicit Casts"
		
        Public Shared Widening Operator CType(ByVal coll As RegionCollection) As RegionCollectionProxyStub
            Return New RegionCollectionProxyStub(coll)
        End Operator
        
		#End Region

				
		#Region "WCF Service Class"

		<DataContract> _
		<KnownType(GetType(Region))> _
		Public Class RegionCollectionWCFPacket
			Inherits esCollectionWCFPacket(Of RegionCollection)
			
			Public Shared Widening Operator CType(packet As RegionCollectionWCFPacket) As RegionCollection
				Return packet.Collection
			End Operator

			Public Shared Widening Operator CType(collection As RegionCollection) As RegionCollectionWCFPacket
				Return New RegionCollectionWCFPacket()  With {.Collection = collection}
			End Operator
			
		End Class

		#End Region
		
			
		
	End Class




	<DebuggerDisplay("Query = {Parse()}")> _ 
	<Serializable> _ 
	<DataContract(Name := "RegionQuery", [Namespace]:= "http://www.entityspaces.net")> _ 
	Partial Public Class RegionQuery 
		Inherits esRegionQuery
		
		Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
		End Sub	
		
		Protected Overrides Function GetQueryName() As String
			Return "RegionQuery"
		End Function	
		
		#Region "Explicit Casts"

		Public Shared Narrowing Operator CType(ByVal query As RegionQuery) As String
			Return RegionQuery.SerializeHelper.ToXml(query)
		End Operator

		Public Shared Narrowing Operator CType(ByVal query As String) As RegionQuery
			Return DirectCast(RegionQuery.SerializeHelper.FromXml(query, GetType(RegionQuery)), RegionQuery)
		End Operator

		#End Region
			
	End Class

	
	<DataContract> _
	<Serializable()> _
	MustInherit Public Partial Class esRegion
		Inherits EntityBase
	
		Public Sub New()
		
		End Sub
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal regionID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(regionID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(regionID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal regionID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(regionID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(regionID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal regionID As System.Int32) As Boolean
		
			Dim query As New RegionQuery()
			query.Where(query.RegionID = regionID)
			Return Me.Load(query)
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal regionID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("RegionID", regionID)
			
			Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
		
#Region "Properties"
		
		
			
		' <summary>
		' Maps to Region.RegionID
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RegionID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(RegionMetadata.ColumnNames.RegionID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(RegionMetadata.ColumnNames.RegionID, value) Then
					OnPropertyChanged(RegionMetadata.PropertyNames.RegionID)
				End If
			End Set
		End Property	
			
		' <summary>
		' Maps to Region.RegionDescription
		' </summary>
		<DataMember(EmitDefaultValue:=False)> _
		Public Overridable Property RegionDescription As System.String
			Get
				Return MyBase.GetSystemString(RegionMetadata.ColumnNames.RegionDescription)
			End Get
			
			Set(ByVal value As System.String)
				If MyBase.SetSystemString(RegionMetadata.ColumnNames.RegionDescription, value) Then
					OnPropertyChanged(RegionMetadata.PropertyNames.RegionDescription)
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
												
						Case "RegionID"
							Me.str().RegionID = CType(value, string)
												
						Case "RegionDescription"
							Me.str().RegionDescription = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "RegionID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RegionID = CType(value, Nullable(Of System.Int32))
								OnPropertyChanged(RegionMetadata.PropertyNames.RegionID)
							End If
						
					
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
		
			Public Sub New(ByVal entity As esRegion)
				Me.entity = entity
			End Sub				
		
	
			Public Property RegionID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RegionID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RegionID = Nothing
					Else
						entity.RegionID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property RegionDescription As System.String 
				Get
					Dim data_ As System.String = entity.RegionDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RegionDescription = Nothing
					Else
						entity.RegionDescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esRegion
		End Class
		

        <NonSerialized> _
        <IgnoreDataMember> _		
		Private _esstrings As esStrings
		
#End Region

#Region "Housekeeping methods"

		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return RegionMetadata.Meta()
			End Get
		End Property

#End Region

#Region "Query Logic"

		Public ReadOnly Property Query() As RegionQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New RegionQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property

		Public Overloads Function Load(ByVal query As RegionQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Me.Query.Load()
		End Function

		Protected Sub InitQuery(ByVal query As RegionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntity).Connection
			End If
		End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As RegionQuery

	End Class



	<Serializable()> _
	MustInherit Public Partial Class esRegionCollection
		Inherits CollectionBase(Of Region)
		
		#Region "Housekeeping methods"
		Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
			Get
				Return RegionMetadata.Meta()
			End Get
		End Property
		
		Protected Overloads Overrides Function GetCollectionName() As String
			Return "RegionCollection"
		End Function
		
		#End Region
		
		#Region "Query Logic"
		

		<BrowsableAttribute(False)> _ 
		Public ReadOnly Property Query() As RegionQuery
			Get
				If Me.m_query Is Nothing Then
					Me.m_query = New RegionQuery()
					InitQuery(Me.m_query)
				End If
				
				Return Me.m_query
			End Get
		End Property
		
		Public Overloads Function Load(ByVal query As RegionQuery) As Boolean
			Me.m_query = query
			InitQuery(Me.m_query)
			Return Query.Load()
		End Function
		
		Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
			If Me.m_query Is Nothing Then
				Me.m_query = New RegionQuery()
				Me.InitQuery(m_query)
			End If
			Return Me.m_query
		End Function
		
		Protected Sub InitQuery(ByVal query As RegionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			
			If Not query.es2.HasConnection Then
				query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
			End If
		End Sub
		
		Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
			Me.InitQuery(DirectCast(query, RegionQuery))
		End Sub
		
		#End Region
						
		Private m_query As RegionQuery
	End Class



	<Serializable> _
	MustInherit Public Partial Class esRegionQuery 
		Inherits QueryBase 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return RegionMetadata.Meta()
			End Get
		End Property
		
#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
				Case "RegionID" 
					Return Me.RegionID
				Case "RegionDescription" 
					Return Me.RegionDescription
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region		
		
#Region "esQueryItems"


		Public ReadOnly Property RegionID As esQueryItem
			Get
				Return New esQueryItem(Me, RegionMetadata.ColumnNames.RegionID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property RegionDescription As esQueryItem
			Get
				Return New esQueryItem(Me, RegionMetadata.ColumnNames.RegionDescription, esSystemType.String)
			End Get
		End Property 
		
#End Region	
		
	End Class


	
	Partial Public Class Region 
		Inherits esRegion
		
	
		#Region "TerritoriesCollectionByRegionID - Zero To Many"
		
		Public Shared ReadOnly Property Prefetch_TerritoriesCollectionByRegionID() As esPrefetchMap
			Get
				Dim map As New esPrefetchMap()
				map.PrefetchDelegate = New esPrefetchDelegate(AddressOf BusinessObjects.Region.TerritoriesCollectionByRegionID_Delegate)
				map.PropertyName = "TerritoriesCollectionByRegionID"
				map.MyColumnName = "RegionID"
				map.ParentColumnName = "RegionID"
				map.IsMultiPartKey = false
				Return map
			End Get
		End Property

		Private Shared Sub TerritoriesCollectionByRegionID_Delegate(ByVal data As esPrefetchParameters)
		
			Dim parent As New RegionQuery(data.NextAlias())
			
			Dim mee As TerritoriesQuery = If(data.You IsNot Nothing, TryCast(data.You, TerritoriesQuery), New TerritoriesQuery(data.NextAlias()))

			If data.Root Is Nothing Then
				data.Root = mee
			End If
			
			data.Root.InnerJoin(parent).On(parent.RegionID = mee.RegionID)

			data.You = parent
			
		End Sub		

		''' <summary>
		''' Zero to Many
		''' Foreign Key Name - FK_Territories_Region
		''' </summary>

		<XmlIgnore()> _ 
		Public Property TerritoriesCollectionByRegionID As TerritoriesCollection 
		
			Get
				If Me._TerritoriesCollectionByRegionID Is Nothing Then
					Me._TerritoriesCollectionByRegionID = New TerritoriesCollection()
					Me._TerritoriesCollectionByRegionID.es.Connection.Name = Me.es.Connection.Name
					Me.SetPostSave("TerritoriesCollectionByRegionID", Me._TerritoriesCollectionByRegionID)
				
					If Not Me.RegionID.Equals(Nothing) Then
					
						If Not Me.es.IsLazyLoadDisabled Then
						
							Me._TerritoriesCollectionByRegionID.Query.Where(Me._TerritoriesCollectionByRegionID.Query.RegionID = Me.RegionID)
							Me._TerritoriesCollectionByRegionID.Query.Load()
						End If

						' Auto-hookup Foreign Keys
						Me._TerritoriesCollectionByRegionID.fks.Add(TerritoriesMetadata.ColumnNames.RegionID, Me.RegionID)
					End If
				End If

				Return Me._TerritoriesCollectionByRegionID
			End Get
			
			Set(ByVal value As TerritoriesCollection)
				If Not value Is Nothing Then Throw New Exception("'value' Must be null")

				If Not Me._TerritoriesCollectionByRegionID Is Nothing Then

					Me.RemovePostSave("TerritoriesCollectionByRegionID")
					Me._TerritoriesCollectionByRegionID = Nothing
					Me.OnPropertyChanged("TerritoriesCollectionByRegionID")

				End If
			End Set				
			
		End Property
		

		private _TerritoriesCollectionByRegionID As TerritoriesCollection
		#End Region

		
		
		
		Protected Overrides Function CreateCollectionForPrefetch(name As String) As esEntityCollectionBase
			Dim coll As esEntityCollectionBase = Nothing

			Select Case name
			
				Case "TerritoriesCollectionByRegionID"
					coll = Me.TerritoriesCollectionByRegionID
					Exit Select	
			End Select

			Return coll
		End Function
					
		''' <summary>
		''' Used internally by the entity's hierarchical properties.
		''' </summary>
		Protected Overrides Function GetHierarchicalProperties() As List(Of esPropertyDescriptor)
		
			Dim props As New List(Of esPropertyDescriptor)
			props.Add(new esPropertyDescriptor(Me, "TerritoriesCollectionByRegionID", GetType(TerritoriesCollection), New Territories()))
			Return props
			
		End Function
	End Class
		



    <DataContract(Namespace:="http://tempuri.org/", Name:="Region")> _
    <XmlType(TypeName:="RegionProxyStub")> _
    <Serializable> _
    Partial Public Class RegionProxyStub
	
		Public Sub New()
            Me._entity = New Region()
            Me.theEntity = Me._entity
		End Sub
		
		Public Sub New(ByVal obj As Region)
            Me.Entity = obj
            Me.theEntity = Me._entity
		End Sub
		
		Public Sub New(ByVal obj As Region, ByVal dirtyColumnsOnly As Boolean)
            Me.Entity = obj
            Me.theEntity = Me._entity
			Me.dirtyColumnsOnly = dirtyColumnsOnly
		End Sub	
		
			
		#Region "Implicit Casts"

		Public Shared Widening Operator CType(ByVal entity As RegionProxyStub) As Region
			Return entity.Entity
		End Operator

		#End Region			

        Public Function GetEntityType() As Type
 	        Return GetType(Region)
        End Function
		

		<DataMember(Name:="a0", Order:=1, EmitDefaultValue:=False)> _		
        Public Property RegionID As Nullable(Of System.Int32)
        
            Get
				If Me.Entity.es.IsDeleted Then
                    Dim o As Object = Me.Entity. _
                       GetOriginalColumnValue(RegionMetadata.ColumnNames.RegionID)
					Return CType(o, Nullable(Of System.Int32))
                Else
					Return Me.Entity.RegionID
				End If				
			End Get
			
            Set(ByVal value As Nullable(Of System.Int32))
				Me.Entity.RegionID = value
			End Set
			
		End Property

		<DataMember(Name:="a1", Order:=2, EmitDefaultValue:=False)> _		
        Public Property RegionDescription As System.String
        
            Get
                If Me.IncludeColumn(RegionMetadata.ColumnNames.RegionDescription) Then
                    Return Me.Entity.RegionDescription
                Else
                    Return Nothing
				End If				
			End Get
			
            Set(ByVal value As System.String)
				Me.Entity.RegionDescription = value
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
        Public Property Entity As Region
        
            Get
                If Me._entity Is Nothing Then
                    Me.entity = New Region()
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
        Public _entity As Region
		
        <NonSerialized(), XmlIgnore(), CLSCompliant(False)> _
        Protected theEntity As esEntity

        <NonSerialized(), XmlIgnore()> _
        Protected dirtyColumnsOnly As Boolean		

	End Class
	



    <DataContract(Namespace:="http://tempuri.org/", Name:="RegionCollection")> _
    <XmlType(TypeName:="RegionCollectionProxyStub")> _
    <Serializable> _
    Partial Public Class RegionCollectionProxyStub
	
		Protected Sub New()
			
		End Sub	
		
		Public Sub New(ByVal coll As esEntityCollection(Of Region))
			Me.New(coll, False, False)
		End Sub

		Public Sub New(ByVal coll As esEntityCollection(Of Region), ByVal dirtyRowsOnly As Boolean)
			Me.New(coll, dirtyRowsOnly, False)
		End Sub
		
		#Region "Implicit Casts"

		Public Shared Widening Operator CType(ByVal proxyStubCollection As RegionCollectionProxyStub) As RegionCollection
			Return proxyStubCollection.GetCollection()
		End Operator

		#End Region	
		
        Public Function GetEntityType() As Type
 	        Return GetType(Region)
        End Function
		
		Public Sub New(ByVal coll As esEntityCollection(Of Region), ByVal dirtyRowsOnly As Boolean, ByVal dirtyColumnsOnly As Boolean)

            For Each entity As Region In coll
                Select Case entity.RowState
                    Case esDataRowState.Added, esDataRowState.Modified

                        Collection.Add(New RegionProxyStub(entity, dirtyColumnsOnly))
                        Exit Select

                    Case esDataRowState.Unchanged

                        If Not dirtyRowsOnly Then
                            Collection.Add(New RegionProxyStub(entity, dirtyColumnsOnly))
                        End If
                        Exit Select
                End Select
            Next

            If coll.es.DeletedEntities IsNot Nothing Then
                For Each entity As Region In coll.es.DeletedEntities
                    Collection.Add(New RegionProxyStub(entity, dirtyColumnsOnly))
                Next
            End If

        End Sub		

        <DataMember(Name := "Collection", EmitDefaultValue := False)> _
		Public Collection As New List(Of RegionProxyStub)		

        Public Function GetCollection As RegionCollection
			
                If Me._coll is Nothing Then
                    Me._coll = New RegionCollection()
					
		            Dim proxy As RegionProxyStub

                    For Each proxy In Me.Collection
                        Me._coll.AttachEntity(proxy.Entity)
                    Next
                End If

                Return Me._coll

        End Function

        <NonSerialized> _
		<XmlIgnore> _
        Private _coll As RegionCollection
		
    End Class
	



	<Serializable> _
	Partial Public Class RegionMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			m_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(RegionMetadata.ColumnNames.RegionID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = RegionMetadata.PropertyNames.RegionID
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			m_columns.Add(c)
				
			c = New esColumnMetadata(RegionMetadata.ColumnNames.RegionDescription, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = RegionMetadata.PropertyNames.RegionDescription
			c.CharacterMaxLength = 50
			m_columns.Add(c)
				
		End Sub
#End Region	
	
		Shared Public Function Meta() As RegionMetadata
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
			 Public Const RegionID As String = "RegionID"
			 Public Const RegionDescription As String = "RegionDescription"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const RegionID As String = "RegionID"
			 Public Const RegionDescription As String = "RegionDescription"
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
			SyncLock GetType(RegionMetadata)
			
				If RegionMetadata.mapDelegates Is Nothing Then
					RegionMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

				If RegionMetadata._meta Is Nothing Then
					RegionMetadata._meta = New RegionMetadata()
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
				


				meta.AddTypeMap("RegionID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("RegionDescription", new esTypeMap("nchar", "System.String"))			
				meta.Catalog = "Northwind"
				meta.Schema = "dbo"
				 
				meta.Source = "Region"
				meta.Destination = "Region"
				
				meta.spInsert = "proc_RegionInsert"
				meta.spUpdate = "proc_RegionUpdate"
				meta.spDelete = "proc_RegionDelete"
				meta.spLoadAll = "proc_RegionLoadAll"
				meta.spLoadByPrimaryKey = "proc_RegionLoadByPrimaryKey"
				
				Me.m_providerMetadataMaps.Add("esDefault", meta)

			End If

			Return Me.m_providerMetadataMaps("esDefault")

		End Function
		
#End Region	
		
        Private Shared _meta As RegionMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
