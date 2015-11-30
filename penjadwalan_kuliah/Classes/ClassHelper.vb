Option Infer On

Imports System
Imports System.Globalization
Imports System.Windows.Forms

Namespace Classes
    Friend Module ClassHelper

        <System.Runtime.CompilerServices.Extension> _
        Public Function AlmostEquals(ByVal double1 As Double, ByVal double2 As Double, ByVal precision As Double) As Boolean
            Return (Math.Abs(double1 - double2) <= precision)
        End Function

        Public Sub ClearTextBox(ByVal ctrl As Control)
            For Each c As Control In ctrl.Controls
                Dim textBox = TryCast(c, TextBox)
                If textBox IsNot Nothing Then
                    textBox.Clear()
                End If
                If c.HasChildren Then
                    ClearTextBox(c)
                End If
            Next c
        End Sub

        Public Sub SetReadOnlyOnTextBox(ByVal ctrl As Control, ByVal [readOnly] As Boolean)
            Dim textBoxBase As TextBoxBase = TryCast(ctrl, TextBoxBase)
            If (textBoxBase IsNot Nothing) Then
                textBoxBase.ReadOnly = [readOnly]
            End If
            For Each control As Control In ctrl.Controls
                SetReadOnlyOnTextBox(control, [readOnly])
            Next control
        End Sub

        <System.Runtime.CompilerServices.Extension> _
        Public Function ToStringArray(ByVal intArray() As Integer) As String()
            Return Array.ConvertAll(Of Integer, String)(intArray, Function(intParameter) intParameter.ToString(CultureInfo.InvariantCulture))
        End Function

        <System.Runtime.CompilerServices.Extension> _
        Public Function ToIntArray(ByVal strArray() As String) As Integer()
            Return Array.ConvertAll(Of String, Integer)(strArray, Function(intParameter) Integer.Parse(intParameter.ToString(CultureInfo.InvariantCulture)))
        End Function
    End Module
End Namespace