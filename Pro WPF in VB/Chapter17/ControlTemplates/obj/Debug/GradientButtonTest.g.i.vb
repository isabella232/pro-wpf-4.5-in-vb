﻿#ExternalChecksum("..\..\GradientButtonTest.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","C47FB88B473899AE8D29365A93D0B1C4")
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
'''GradientButtonTest
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class GradientButtonTest
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\GradientButtonTest.xaml",14)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cmdOne As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\GradientButtonTest.xaml",16)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cmdTwo As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\GradientButtonTest.xaml",18)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cmdThree As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\GradientButtonTest.xaml",20)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cmdFour As System.Windows.Controls.Button
    
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
        Dim resourceLocater As System.Uri = New System.Uri("/ControlTemplates;component/gradientbuttontest.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\GradientButtonTest.xaml",1)
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
            Me.cmdOne = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\GradientButtonTest.xaml",14)
            AddHandler Me.cmdOne.Click, New System.Windows.RoutedEventHandler(AddressOf Me.Clicked)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 2) Then
            Me.cmdTwo = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\GradientButtonTest.xaml",16)
            AddHandler Me.cmdTwo.Click, New System.Windows.RoutedEventHandler(AddressOf Me.Clicked)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 3) Then
            Me.cmdThree = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\GradientButtonTest.xaml",18)
            AddHandler Me.cmdThree.Click, New System.Windows.RoutedEventHandler(AddressOf Me.Clicked)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 4) Then
            Me.cmdFour = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\GradientButtonTest.xaml",20)
            AddHandler Me.cmdFour.Click, New System.Windows.RoutedEventHandler(AddressOf Me.Clicked)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 5) Then
            
            #ExternalSource("..\..\GradientButtonTest.xaml",22)
            AddHandler CType(target,System.Windows.Controls.CheckBox).Checked, New System.Windows.RoutedEventHandler(AddressOf Me.chkGreen_Checked)
            
            #End ExternalSource
            
            #ExternalSource("..\..\GradientButtonTest.xaml",22)
            AddHandler CType(target,System.Windows.Controls.CheckBox).Unchecked, New System.Windows.RoutedEventHandler(AddressOf Me.chkGreen_Unchecked)
            
            #End ExternalSource
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class
