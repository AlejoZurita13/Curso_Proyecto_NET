<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.lblAcceder = New System.Windows.Forms.Label()
        Me.TxtIngreseUsuario = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.lblingreseContraseña = New System.Windows.Forms.Label()
        Me.btniniciarSesion = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(282, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "x"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.ErrorImage = CType(resources.GetObject("PictureBoxLogo.ErrorImage"), System.Drawing.Image)
        Me.PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), System.Drawing.Image)
        Me.PictureBoxLogo.InitialImage = CType(resources.GetObject("PictureBoxLogo.InitialImage"), System.Drawing.Image)
        Me.PictureBoxLogo.Location = New System.Drawing.Point(47, 48)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(210, 118)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLogo.TabIndex = 1
        Me.PictureBoxLogo.TabStop = False
        '
        'lblAcceder
        '
        Me.lblAcceder.AutoSize = True
        Me.lblAcceder.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcceder.Location = New System.Drawing.Point(90, 169)
        Me.lblAcceder.Name = "lblAcceder"
        Me.lblAcceder.Size = New System.Drawing.Size(114, 31)
        Me.lblAcceder.TabIndex = 2
        Me.lblAcceder.Text = "Acceder"
        '
        'TxtIngreseUsuario
        '
        Me.TxtIngreseUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIngreseUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtIngreseUsuario.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.TxtIngreseUsuario.Location = New System.Drawing.Point(47, 254)
        Me.TxtIngreseUsuario.Name = "TxtIngreseUsuario"
        Me.TxtIngreseUsuario.Size = New System.Drawing.Size(210, 20)
        Me.TxtIngreseUsuario.TabIndex = 3
        Me.TxtIngreseUsuario.Text = "Ingrese usuario"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(47, 232)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 0)
        Me.Panel1.TabIndex = 4
        '
        'txtContraseña
        '
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.txtContraseña.Location = New System.Drawing.Point(47, 302)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(210, 20)
        Me.txtContraseña.TabIndex = 5
        Me.txtContraseña.Text = "Contraseña"
        '
        'lblingreseContraseña
        '
        Me.lblingreseContraseña.AutoSize = True
        Me.lblingreseContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblingreseContraseña.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblingreseContraseña.Location = New System.Drawing.Point(44, 327)
        Me.lblingreseContraseña.Name = "lblingreseContraseña"
        Me.lblingreseContraseña.Size = New System.Drawing.Size(134, 17)
        Me.lblingreseContraseña.TabIndex = 6
        Me.lblingreseContraseña.Text = "Ingrese contraseña "
        '
        'btniniciarSesion
        '
        Me.btniniciarSesion.BackColor = System.Drawing.Color.LightGray
        Me.btniniciarSesion.FlatAppearance.BorderSize = 0
        Me.btniniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btniniciarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btniniciarSesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btniniciarSesion.Location = New System.Drawing.Point(47, 416)
        Me.btniniciarSesion.Name = "btniniciarSesion"
        Me.btniniciarSesion.Size = New System.Drawing.Size(210, 34)
        Me.btniniciarSesion.TabIndex = 7
        Me.btniniciarSesion.Text = "Iniciar sesión"
        Me.btniniciarSesion.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Location = New System.Drawing.Point(12, 282)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(285, 1)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Location = New System.Drawing.Point(13, 323)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(285, 1)
        Me.Panel3.TabIndex = 9
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(305, 462)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btniniciarSesion)
        Me.Controls.Add(Me.lblingreseContraseña)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtIngreseUsuario)
        Me.Controls.Add(Me.lblAcceder)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents lblAcceder As Label
    Friend WithEvents TxtIngreseUsuario As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents lblingreseContraseña As Label
    Friend WithEvents btniniciarSesion As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
