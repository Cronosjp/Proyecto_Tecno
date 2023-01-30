'Insertamos las Librerías'
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class Administrador
    'Conexión en Administrador'
    Dim con As New SqlConnection(My.Settings.conexion)
    Dim sentencia, mensaje As String
    'elaboración de un sub para ejecutar'
    Sub Ejecutarsql(ByVal sql As String, ByVal msg As String)
        'Realizamos un try catch'
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    'Boton para mostrar la informacion'
    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Dim da As New SqlDataAdapter("Select * from ADMINISTRADOR", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DTG1.DataSource = ds.Tables(0)

    End Sub

    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Boton para insertar la informacion'
    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        sentencia = "insert ADMINISTRADOR values(" + txt_id.Text + ",'" + txt_nombre.Text + "','" + txt_apellido.Text + "'," + txt_edad.Text + ",'" + txt_correo.Text + "','" + txt_usuario.Text + "','" + txt_contraseña.Text + "','" + txt_rol.Text + "')"
        mensaje = "Datos ingresados"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select *from ADMINISTRADOR", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DTG1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Boton para eliminar la informacion'
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        sentencia = "delete from Administrador where ID = " + txt_id.Text + ""
        mensaje = "Datos eliminados"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select *from Administrador ", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DTG1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Boton para regresar al login'
    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        Me.Hide()
        Form1.Show()
    End Sub
    'Boton para buscar la informacion'
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim da As New SqlDataAdapter("Select * from Administrador where Apellido = '" + txt_buscar.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DTG1.DataSource = ds.Tables(0)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
    'Boton para editar la informacion'
    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        sentencia = "update ADMINISTRADOR set ID = " + txt_id.Text + ",Nombre = '" + txt_nombre.Text + "',Apellido = '" + txt_apellido.Text + "',Edad = '" + txt_edad.Text + "',Correo = '" + txt_correo.Text + "',Usuario ='" + txt_usuario.Text + "',Contraseña = '" + txt_contraseña.Text + "',Rol = '" + txt_rol.Text + "' where ID = " + txt_id.Text + ""
        mensaje = "Datos actualizados"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select * from ADMINISTRADOR", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DTG1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



End Class