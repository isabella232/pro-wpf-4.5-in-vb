﻿#ExternalChecksum("..\..\CustomControlWithCommand.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","4CC0C2DF280FB2253E3848021426FA57")
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

Imports Commands
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
'''CustomControlWithCommand
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class CustomControlWithCommand
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\CustomControlWithCommand.xaml",23)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents FontSlider As Commands.CommandSlider
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\CustomControlWithCommand.xaml",57)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtBoxTarget As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\CustomControlWithCommand.xaml",83)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtValue As System.Windows.Controls.TextBox
    
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
        Dim resourceLocater As System.Uri = New System.Uri("/Commands;component/customcontrolwithcommand.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\CustomControlWithCommand.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
    Friend Function _CreateDelegate(ByVal delegateType As System.Type, ByVal handler As String) As System.[Delegate]
        Return System.[Delegate].CreateDelegate(delegateType, Me, handler)
    End Function
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.FontSlider = CType(target,Commands.CommandSlider)
            Return
        End If
        If (connectionId = 2) Then
            
            #ExternalSource("..\..\CustomControlWithCommand.xaml",52)
            AddHandler CType(target,System.Windows.Controls.CheckBox).Checked, New System.Windows.RoutedEventHandler(AddressOf Me.OnReadOnlyChecked)
            
            #End ExternalSource
            
            #ExternalSource("..\..\CustomControlWithCommand.xaml",53)
            AddHandler CType(target,System.Windows.Controls.CheckBox).Unchecked, New System.Windows.RoutedEventHandler(AddressOf Me.OnReadOnlyUnChecked)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 3) Then
            Me.txtBoxTarget = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 4) Then
            
            #ExternalSource("..\..\CustomControlWithCommand.xaml",60)
            AddHandler CType(target,System.Windows.Input.CommandBinding).Executed, New System.Windows.Input.ExecutedRoutedEventHandler(AddressOf Me.SliderUpdateExecuted)
            
            #End ExternalSource
            
            #ExternalSource("..\..\CustomControlWithCommand.xaml",61)
            AddHandler CType(target,System.Windows.Input.CommandBinding).CanExecute, New System.Windows.Input.CanExecuteRoutedEventHandler(AddressOf Me.SliderUpdateCanExecute)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 5) Then
            Me.txtValue = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

