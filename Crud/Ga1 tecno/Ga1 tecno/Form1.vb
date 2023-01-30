Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class Form1
    Public conexion As SqlConnection = New SqlConnection(My.Settings.conexion)
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public cmd As SqlCommand
    Function verificacion(ByVal sql)
        conexion.Open()
        cmd = New SqlCommand(sql, conexion)
        Dim i As Integer = cmd.ExecuteNonQuery
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f2 = Crud

        Dim verificar As String = "update login set rol=rol where nombre = '" + TextBox1.Text + "' and contraseña = '" + TextBox2.Text + "' and rol = 'administrador'"
        If verificacion(verificar) Then
            Crud.Show()
            Me.Hide()


        End If
        Dim verificar1 As String = "update login set rol=rol where nombre = '" + TextBox1.Text + "' and contraseña = '" + TextBox2.Text + "' and rol = 'cliente'"
        If verificacion(verificar1) Then
            Crud.Show()
            Me.Hide()
            f2.btn_actualizar.Visible = False
            f2.btn_insertar.Visible = False
            f2.btn_eliminar.Visible = False

        End If
        Dim verificar2 As String = "update login set rol=rol where nombre = '" + TextBox1.Text + "' and contraseña = '" + TextBox2.Text + "' and rol = 'secretaria'"
        If verificacion(verificar2) Then
            Crud.Show()
            Me.Hide()
            f2.btn_actualizar.Visible = False
            f2.btn_eliminar.Visible = False
        End If
    End Sub
End Class
