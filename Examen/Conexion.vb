Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Conexion

    Public conexion As SqlConnection = New SqlConnection("")

    Public Sub Conectar()

        Try

            conexion.Open()

        Catch ex As Exception

        End Try

    End Sub

End Class
