'Insertamos las Librerías'
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class Form1
    'Luego hacemos la conexion'
    Dim con As SqlConnection = New SqlConnection(My.Settings.conexion)
    Dim Conexion As Conexion = New Conexion

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_ingresar_Click_1(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        'Declaración de Variables'
        Dim f2 = Administrador
        'Funcion que realizara para confirmar el login'
        Dim verificar As String = "Update USUARIO set Roll=Roll where USUARIO = '" + txt_usuario.Text + "' AND CONTRASEÑA = '" + txt_contraseña.Text + "' and ROLL= 'Administrador'"
        Dim verificar2 As String = "Update USUARIO set Roll=Roll where USUARIO = '" + txt_usuario.Text + "' AND CONTRASEÑA = '" + txt_contraseña.Text + "' and ROLL= 'Usuario'"
        Dim verificar3 As String = "Update USUARIO set Roll=Roll where USUARIO = '" + txt_usuario.Text + "' AND CONTRASEÑA = '" + txt_contraseña.Text + "' and ROLL= 'Secretario'"
        'If en función del Login para verificar en que rango y posición esta'
        If Conexion.Verificacion(verificar) Then

            Me.Hide()
            f2.Show()
            txt_contraseña.Text = ""
            txt_usuario.Text = ""

        Else

            If Conexion.Verificacion(verificar2) Then

                Me.Hide()
                MsgBox("Usuario")
                f2.Show()
                'En el caso del usuario no mostraremos los siguientes datos'
                f2.lbl_id.Visible = False
                f2.lbl_nombre.Visible = False
                f2.lbl_apellido.Visible = False
                f2.lbl_correo.Visible = False
                f2.lbl_edad.Visible = False
                f2.lbl_usuario.Visible = False
                f2.lbl_contraseña.Visible = False
                f2.lbl_rol.Visible = False
                f2.txt_id.Visible = False
                f2.txt_nombre.Visible = False
                f2.txt_apellido.Visible = False
                f2.txt_edad.Visible = False
                f2.txt_correo.Visible = False
                f2.txt_usuario.Visible = False
                f2.txt_contraseña.Visible = False
                f2.txt_rol.Visible = False
                f2.btn_eliminar.Visible = False
                f2.btn_insertar.Visible = False
                f2.btn_mostrar.Visible = False
                f2.btn_editar.Visible = False
                f2.DTG1.Enabled = False
                txt_contraseña.Text = ""
                txt_usuario.Text = ""

            Else
                If Conexion.Verificacion(verificar3) Then

                    Me.Hide()
                    MsgBox("Secretario")
                    f2.Show()
                    txt_contraseña.Text = ""
                    txt_usuario.Text = ""

                Else

                    MsgBox("La contraseña o usuario son incorrectos intentelo nuevamente")
                    txt_contraseña.Text = ""
                    txt_usuario.Text = ""

                End If
            End If
        End If
    End Sub
End Class
