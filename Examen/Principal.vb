Public Class Principal

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ExamenDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
        Me.AlumnosTableAdapter.Fill(Me.ExamenDataSet.Alumnos)
        'TODO: esta línea de código carga datos en la tabla 'ExamenDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
        Me.AlumnosTableAdapter.Fill(Me.ExamenDataSet.Alumnos)
        NombresTextBox.Select()

    End Sub

    Private Sub AlumnosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AlumnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ExamenDataSet)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class
