<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAño
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.lblAño = New System.Windows.Forms.Label()
        Me.btnToday = New System.Windows.Forms.Button()
        Me.btnPrevAño = New System.Windows.Forms.Button()
        Me.btnProxAño = New System.Windows.Forms.Button()
        Me.calAño = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.BackColor = System.Drawing.Color.Transparent
        Me.lblAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAño.Location = New System.Drawing.Point(9, 10)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(87, 37)
        Me.lblAño.TabIndex = 0
        Me.lblAño.Text = "2016"
        '
        'btnToday
        '
        Me.btnToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.btnToday.Location = New System.Drawing.Point(919, 16)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(58, 23)
        Me.btnToday.TabIndex = 25
        Me.btnToday.Text = "Hoy"
        Me.btnToday.UseVisualStyleBackColor = True
        '
        'btnPrevAño
        '
        Me.btnPrevAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.btnPrevAño.Location = New System.Drawing.Point(895, 16)
        Me.btnPrevAño.Name = "btnPrevAño"
        Me.btnPrevAño.Size = New System.Drawing.Size(25, 23)
        Me.btnPrevAño.TabIndex = 26
        Me.btnPrevAño.Text = "<"
        Me.btnPrevAño.UseVisualStyleBackColor = True
        '
        'btnProxAño
        '
        Me.btnProxAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.btnProxAño.Location = New System.Drawing.Point(976, 16)
        Me.btnProxAño.Name = "btnProxAño"
        Me.btnProxAño.Size = New System.Drawing.Size(25, 23)
        Me.btnProxAño.TabIndex = 27
        Me.btnProxAño.Text = ">"
        Me.btnProxAño.UseVisualStyleBackColor = True
        '
        'calAño
        '
        Me.calAño.CalendarDimensions = New System.Drawing.Size(4, 3)
        Me.calAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calAño.Location = New System.Drawing.Point(63, 92)
        Me.calAño.Margin = New System.Windows.Forms.Padding(0)
        Me.calAño.MaxDate = New Date(2016, 12, 31, 0, 0, 0, 0)
        Me.calAño.MaxSelectionCount = 1
        Me.calAño.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        Me.calAño.Name = "calAño"
        Me.calAño.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.calAño.RightToLeftLayout = True
        Me.calAño.ShowToday = False
        Me.calAño.TabIndex = 28
        '
        'frmAño
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.btnProxAño)
        Me.Controls.Add(Me.btnPrevAño)
        Me.Controls.Add(Me.btnToday)
        Me.Controls.Add(Me.lblAño)
        Me.Controls.Add(Me.calAño)
        Me.DoubleBuffered = True
        Me.Name = "frmAño"
        Me.Size = New System.Drawing.Size(1012, 679)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAño As System.Windows.Forms.Label
    Friend WithEvents btnToday As System.Windows.Forms.Button
    Friend WithEvents btnPrevAño As System.Windows.Forms.Button
    Friend WithEvents btnProxAño As System.Windows.Forms.Button
    Friend WithEvents calAño As System.Windows.Forms.MonthCalendar

End Class
