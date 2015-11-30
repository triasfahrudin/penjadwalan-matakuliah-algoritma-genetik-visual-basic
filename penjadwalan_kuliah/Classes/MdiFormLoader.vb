
Imports System.Collections.Specialized

Namespace Classes
    NotInheritable Class MdiFormLoader
        Private Sub New()
        End Sub
        Private Shared ReadOnly MInitializedForms As New HybridDictionary()

        Public Shared Sub LoadFormType(formType As Type, mdiParentForm As System.Windows.Forms.Form)
            If IsAlreadyLoaded(formType) Then
                Return
            End If
            FlagAsLoaded(formType)
            Dim frm As System.Windows.Forms.Form = DirectCast(Activator.CreateInstance(formType), System.Windows.Forms.Form)
            frm.MdiParent = mdiParentForm
            AddHandler frm.Closed, AddressOf FormClosed
            frm.Show()
        End Sub

        Private Shared Sub FlagAsLoaded(formType As Type)
            MInitializedForms(formType.Name) = True
        End Sub

        Private Shared Sub FlagAsNotLoaded(formType As Type)
            MInitializedForms(formType.Name) = False
        End Sub

        Private Shared Function IsAlreadyLoaded(formType As Type) As Boolean
            Return ((MInitializedForms(formType.Name) IsNot Nothing) AndAlso CBool(MInitializedForms(formType.Name)))
        End Function

        Private Shared Sub FormClosed(sender As Object, e As EventArgs)
            Dim closingForm As System.Windows.Forms.Form = DirectCast(sender, System.Windows.Forms.Form)
            RemoveHandler closingForm.Closed, AddressOf FormClosed
            FlagAsNotLoaded(sender.[GetType]())
        End Sub
    End Class
End Namespace

