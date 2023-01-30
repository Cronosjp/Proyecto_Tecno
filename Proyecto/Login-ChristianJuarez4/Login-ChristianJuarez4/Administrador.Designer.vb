<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Administrador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_correo = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_edad = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_contraseña = New System.Windows.Forms.Label()
        Me.lbl_rol = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_edad = New System.Windows.Forms.TextBox()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.txt_rol = New System.Windows.Forms.TextBox()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_mostrar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DTG1 = New System.Windows.Forms.DataGridView()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        CType(Me.DTG1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(19, 115)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(69, 25)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_correo
        '
        Me.lbl_correo.AutoSize = True
        Me.lbl_correo.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_correo.Location = New System.Drawing.Point(19, 227)
        Me.lbl_correo.Name = "lbl_correo"
        Me.lbl_correo.Size = New System.Drawing.Size(63, 25)
        Me.lbl_correo.TabIndex = 1
        Me.lbl_correo.Text = "Correo:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(21, 78)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(28, 25)
        Me.lbl_id.TabIndex = 2
        Me.lbl_id.Text = "ID:"
        '
        'lbl_edad
        '
        Me.lbl_edad.AutoSize = True
        Me.lbl_edad.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_edad.Location = New System.Drawing.Point(19, 185)
        Me.lbl_edad.Name = "lbl_edad"
        Me.lbl_edad.Size = New System.Drawing.Size(49, 25)
        Me.lbl_edad.TabIndex = 3
        Me.lbl_edad.Text = "Edad:"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellido.Location = New System.Drawing.Point(19, 146)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(71, 25)
        Me.lbl_apellido.TabIndex = 4
        Me.lbl_apellido.Text = "Apellido:"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.Location = New System.Drawing.Point(17, 273)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(70, 25)
        Me.lbl_usuario.TabIndex = 5
        Me.lbl_usuario.Text = "Usuario:"
        '
        'lbl_contraseña
        '
        Me.lbl_contraseña.AutoSize = True
        Me.lbl_contraseña.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contraseña.Location = New System.Drawing.Point(19, 317)
        Me.lbl_contraseña.Name = "lbl_contraseña"
        Me.lbl_contraseña.Size = New System.Drawing.Size(98, 25)
        Me.lbl_contraseña.TabIndex = 6
        Me.lbl_contraseña.Text = "Contraseña:"
        '
        'lbl_rol
        '
        Me.lbl_rol.AutoSize = True
        Me.lbl_rol.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rol.Location = New System.Drawing.Point(21, 362)
        Me.lbl_rol.Name = "lbl_rol"
        Me.lbl_rol.Size = New System.Drawing.Size(38, 25)
        Me.lbl_rol.TabIndex = 7
        Me.lbl_rol.Text = "Rol:"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(116, 82)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(160, 20)
        Me.txt_id.TabIndex = 8
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(116, 115)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(160, 20)
        Me.txt_nombre.TabIndex = 9
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(116, 153)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(160, 20)
        Me.txt_apellido.TabIndex = 10
        '
        'txt_edad
        '
        Me.txt_edad.Location = New System.Drawing.Point(116, 189)
        Me.txt_edad.Name = "txt_edad"
        Me.txt_edad.Size = New System.Drawing.Size(160, 20)
        Me.txt_edad.TabIndex = 11
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(116, 231)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(160, 20)
        Me.txt_correo.TabIndex = 12
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(116, 280)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(160, 20)
        Me.txt_usuario.TabIndex = 13
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(116, 317)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(160, 20)
        Me.txt_contraseña.TabIndex = 14
        '
        'txt_rol
        '
        Me.txt_rol.Location = New System.Drawing.Point(116, 362)
        Me.txt_rol.Name = "txt_rol"
        Me.txt_rol.Size = New System.Drawing.Size(160, 20)
        Me.txt_rol.TabIndex = 15
        '
        'btn_insertar
        '
        Me.btn_insertar.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertar.Location = New System.Drawing.Point(310, 82)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(84, 31)
        Me.btn_insertar.TabIndex = 16
        Me.btn_insertar.Text = "Insertar"
        Me.btn_insertar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Location = New System.Drawing.Point(310, 121)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(84, 33)
        Me.btn_eliminar.TabIndex = 17
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_mostrar
        '
        Me.btn_mostrar.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mostrar.Location = New System.Drawing.Point(400, 82)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.Size = New System.Drawing.Size(84, 31)
        Me.btn_mostrar.TabIndex = 18
        Me.btn_mostrar.Text = "Mostrar"
        Me.btn_mostrar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.Location = New System.Drawing.Point(400, 121)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(84, 33)
        Me.btn_editar.TabIndex = 19
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift Condensed", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(47, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(361, 45)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Bienvenido al administrador"
        '
        'DTG1
        '
        Me.DTG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTG1.Location = New System.Drawing.Point(12, 432)
        Me.DTG1.Name = "DTG1"
        Me.DTG1.Size = New System.Drawing.Size(462, 159)
        Me.DTG1.TabIndex = 21
        '
        'btn_regresar
        '
        Me.btn_regresar.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_regresar.Location = New System.Drawing.Point(397, 359)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(84, 33)
        Me.btn_regresar.TabIndex = 22
        Me.btn_regresar.Text = "Regresar"
        Me.btn_regresar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.Location = New System.Drawing.Point(24, 393)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(84, 33)
        Me.btn_buscar.TabIndex = 23
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(116, 403)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(160, 20)
        Me.txt_buscar.TabIndex = 24
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 593)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_regresar)
        Me.Controls.Add(Me.DTG1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_mostrar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_insertar)
        Me.Controls.Add(Me.txt_rol)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.txt_edad)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_rol)
        Me.Controls.Add(Me.lbl_contraseña)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.lbl_edad)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_correo)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Name = "Administrador"
        Me.Text = "v"
        CType(Me.DTG1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_correo As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_edad As Label
    Friend WithEvents lbl_apellido As Label
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents lbl_contraseña As Label
    Friend WithEvents lbl_rol As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents txt_edad As TextBox
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_contraseña As TextBox
    Friend WithEvents txt_rol As TextBox
    Friend WithEvents btn_insertar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_mostrar As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents DTG1 As DataGridView
    Friend WithEvents btn_regresar As Button
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_buscar As TextBox
End Class
