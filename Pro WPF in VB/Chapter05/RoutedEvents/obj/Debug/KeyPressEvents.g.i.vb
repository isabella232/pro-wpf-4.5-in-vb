﻿#ExternalChecksum("..\..\KeyPressEvents.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","A09BA26B7C466F10BEA0F17955345E5D")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.17929
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''KeyPressEvents
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class KeyPressEvents
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\KeyPressEvents.xaml",24)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents lstMessages As System.Windows.Controls.ListBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\KeyPressEvents.xaml",25)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents chkIgnoreRepeat As System.Windows.Controls.CheckBox
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/RoutedEvents;component/keypressevents.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\KeyPressEvents.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            
            #ExternalSource("..\..\KeyPressEvents.xaml",18)
            AddHandler CType(target,System.Windows.Controls.TextBox).PreviewKeyDown, New System.Windows.Input.KeyEventHandler(AddressOf Me.KeyEvent)
            
            #End ExternalSource
            
            #ExternalSource("..\..\KeyPressEvents.xaml",18)
            AddHandler CType(target,System.Windows.Controls.TextBox).KeyDown, New System.Windows.Input.KeyEventHandler(AddressOf Me.KeyEvent)
            
            #End ExternalSource
            
            #ExternalSource("..\..\KeyPressEvents.xaml",19)
            AddHandler CType(target,System.Windows.Controls.TextBox).PreviewKeyUp, New System.Windows.Input.KeyEventHandler(AddressOf Me.KeyEvent)
            
            #End ExternalSource
            
            #ExternalSource("..\..\KeyPressEvents.xaml",19)
            AddHandler CType(target,System.Windows.Controls.TextBox).KeyUp, New System.Windows.Input.KeyEventHandler(AddressOf Me.KeyEvent)
            
            #End ExternalSource
            
            #ExternalSource("..\..\KeyPressEvents.xaml",20)
            AddHandler CType(target,System.Windows.Controls.TextBox).PreviewTextInput, New System.Windows.Input.TextCompositionEventHandler(AddressOf Me.TextInputPreview)
            
            #End ExternalSource
            
            #ExternalSource("..\..\KeyPressEvents.xaml",21)
            AddHandler CType(target,System.Windows.Controls.TextBox).TextChanged, New System.Windows.Controls.TextChangedEventHandler(AddressOf Me.TextChanged)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 2) Then
            Me.lstMessages = CType(target,System.Windows.Controls.ListBox)
            Return
        End If
        If (connectionId = 3) Then
            Me.chkIgnoreRepeat = CType(target,System.Windows.Controls.CheckBox)
            Return
        End If
        If (connectionId = 4) Then
            
            #ExternalSource("..\..\KeyPressEvents.xaml",26)
            AddHandler CType(target,System.Windows.Controls.Button).Click, New System.Windows.RoutedEventHandler(AddressOf Me.cmdClear_Click)
            
            #End ExternalSource
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

