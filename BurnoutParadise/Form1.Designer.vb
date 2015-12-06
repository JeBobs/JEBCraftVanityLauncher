<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ConfigureButton = New System.Windows.Forms.Button()
        Me.VPLaunch = New System.Windows.Forms.Button()
        Me.DebugButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Deftone Stylus", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(390, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(446, 78)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ConfigureButton
        '
        Me.ConfigureButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConfigureButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ConfigureButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ConfigureButton.Font = New System.Drawing.Font("Deftone Stylus", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfigureButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ConfigureButton.Location = New System.Drawing.Point(390, 248)
        Me.ConfigureButton.Name = "ConfigureButton"
        Me.ConfigureButton.Size = New System.Drawing.Size(446, 78)
        Me.ConfigureButton.TabIndex = 1
        Me.ConfigureButton.Text = "Configure"
        Me.ConfigureButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ConfigureButton.UseVisualStyleBackColor = True
        '
        'VPLaunch
        '
        Me.VPLaunch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VPLaunch.BackColor = System.Drawing.SystemColors.ControlLight
        Me.VPLaunch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VPLaunch.Font = New System.Drawing.Font("Deftone Stylus", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VPLaunch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.VPLaunch.Location = New System.Drawing.Point(390, 164)
        Me.VPLaunch.Name = "VPLaunch"
        Me.VPLaunch.Size = New System.Drawing.Size(446, 78)
        Me.VPLaunch.TabIndex = 2
        Me.VPLaunch.Text = "Launch"
        Me.VPLaunch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VPLaunch.UseVisualStyleBackColor = True
        '
        'DebugButton
        '
        Me.DebugButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DebugButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DebugButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DebugButton.Font = New System.Drawing.Font("Deftone Stylus", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DebugButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DebugButton.Location = New System.Drawing.Point(390, 416)
        Me.DebugButton.Name = "DebugButton"
        Me.DebugButton.Size = New System.Drawing.Size(446, 78)
        Me.DebugButton.TabIndex = 3
        Me.DebugButton.Text = "Debug"
        Me.DebugButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DebugButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BurnoutParadise.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.DebugButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ConfigureButton)
        Me.Controls.Add(Me.VPLaunch)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Burnout Paradise Vanity Launcher -BETA-"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ConfigureButton As Button
    Friend WithEvents VPLaunch As Button
    Friend WithEvents DebugButton As Button
End Class
