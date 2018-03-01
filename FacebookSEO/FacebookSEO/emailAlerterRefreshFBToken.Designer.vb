﻿
'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.ComponentModel
Imports System.Data.EntityClient
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Xml.Serialization


<Assembly: EdmSchemaAttribute("f9950002-d798-4aba-b505-e3fbe36bb47e")>
#Region "Contexts"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
Public Partial Class EmailAlerterEntitiesForRefreshFBToken
    Inherits ObjectContext

    #Region "Constructors"

    ''' <summary>
    ''' Initializes a new EmailAlerterEntitiesForRefreshFBToken object using the connection string found in the 'EmailAlerterEntitiesForRefreshFBToken' section of the application configuration file.
    ''' </summary>
    Public Sub New()
        MyBase.New("name=EmailAlerterEntitiesForRefreshFBToken", "EmailAlerterEntitiesForRefreshFBToken")
        MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new EmailAlerterEntitiesForRefreshFBToken object.
    ''' </summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "EmailAlerterEntitiesForRefreshFBToken")
        MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new EmailAlerterEntitiesForRefreshFBToken object.
    ''' </summary>
    Public Sub New(ByVal connection As EntityConnection)
        MyBase.New(connection, "EmailAlerterEntitiesForRefreshFBToken")
        MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    #End Region

    #Region "Partial Methods"

    Partial Private Sub OnContextCreated()
    End Sub

    #End Region

    #Region "ObjectSet Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property EmailAlerterTokens() As ObjectSet(Of EmailAlerterToken)
        Get
            If (_EmailAlerterTokens Is Nothing) Then
                _EmailAlerterTokens = MyBase.CreateObjectSet(Of EmailAlerterToken)("EmailAlerterTokens")
            End If
            Return _EmailAlerterTokens
        End Get
    End Property

    Private _EmailAlerterTokens As ObjectSet(Of EmailAlerterToken)

    #End Region

    #Region "AddTo Methods"

    ''' <summary>
    ''' Deprecated Method for adding a new object to the EmailAlerterTokens EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddToEmailAlerterTokens(ByVal emailAlerterToken As EmailAlerterToken)
        MyBase.AddObject("EmailAlerterTokens", emailAlerterToken)
    End Sub

    #End Region

End Class

#End Region

#Region "Entities"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="EmailAlerterModel", Name:="EmailAlerterToken")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class EmailAlerterToken
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new EmailAlerterToken object.
    ''' </summary>
    ''' <param name="id">Initial value of the id property.</param>
    Public Shared Function CreateEmailAlerterToken(id As Global.System.Int32) As EmailAlerterToken
        Dim emailAlerterToken as EmailAlerterToken = New EmailAlerterToken
        emailAlerterToken.id = id
        Return emailAlerterToken
    End Function

    #End Region

    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property id() As Global.System.Int32
        Get
            Return _id
        End Get
        Set
            If (_id <> Value) Then
                OnidChanging(value)
                ReportPropertyChanging("id")
                _id = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("id")
                OnidChanged()
            End If
        End Set
    End Property

    Private _id As Global.System.Int32
    Private Partial Sub OnidChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub OnidChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property type() As Global.System.String
        Get
            Return _type
        End Get
        Set
            OntypeChanging(value)
            ReportPropertyChanging("type")
            _type = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("type")
            OntypeChanged()
        End Set
    End Property

    Private _type As Global.System.String
    Private Partial Sub OntypeChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OntypeChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property shortTimeToken() As Global.System.String
        Get
            Return _shortTimeToken
        End Get
        Set
            OnshortTimeTokenChanging(value)
            ReportPropertyChanging("shortTimeToken")
            _shortTimeToken = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("shortTimeToken")
            OnshortTimeTokenChanged()
        End Set
    End Property

    Private _shortTimeToken As Global.System.String
    Private Partial Sub OnshortTimeTokenChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnshortTimeTokenChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property longTimeToken() As Global.System.String
        Get
            Return _longTimeToken
        End Get
        Set
            OnlongTimeTokenChanging(value)
            ReportPropertyChanging("longTimeToken")
            _longTimeToken = StructuralObject.SetValidValue(value, true)
            ReportPropertyChanged("longTimeToken")
            OnlongTimeTokenChanged()
        End Set
    End Property

    Private _longTimeToken As Global.System.String
    Private Partial Sub OnlongTimeTokenChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnlongTimeTokenChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=false, IsNullable:=true)>
    <DataMemberAttribute()>
    Public Property longTokenExpireDate() As Nullable(Of Global.System.DateTime)
        Get
            Return _longTokenExpireDate
        End Get
        Set
            OnlongTokenExpireDateChanging(value)
            ReportPropertyChanging("longTokenExpireDate")
            _longTokenExpireDate = StructuralObject.SetValidValue(value)
            ReportPropertyChanged("longTokenExpireDate")
            OnlongTokenExpireDateChanged()
        End Set
    End Property

    Private _longTokenExpireDate As Nullable(Of Global.System.DateTime)
    Private Partial Sub OnlongTokenExpireDateChanging(value As Nullable(Of Global.System.DateTime))
    End Sub

    Private Partial Sub OnlongTokenExpireDateChanged()
    End Sub

    #End Region

End Class

#End Region


