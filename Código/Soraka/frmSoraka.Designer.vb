<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoraka
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSoraka))
        Me.pnlBorde = New System.Windows.Forms.Panel()
        Me.radAnio = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.radMes = New System.Windows.Forms.RadioButton()
        Me.radSemana = New System.Windows.Forms.RadioButton()
        Me.radDia = New System.Windows.Forms.RadioButton()
        Me.pnlSeparacion1 = New System.Windows.Forms.Panel()
        Me.pnlIziquierda = New System.Windows.Forms.Panel()
        Me.pnlDerecha = New System.Windows.Forms.Panel()
        Me.pnlSeparacion2 = New System.Windows.Forms.Panel()
        Me.pnlSeparacion3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlBorde.SuspendLayout()
        Me.pnlIziquierda.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBorde
        '
        Me.pnlBorde.BackColor = System.Drawing.Color.LightGray
        Me.pnlBorde.Controls.Add(Me.radSemana)
        Me.pnlBorde.Controls.Add(Me.radAnio)
        Me.pnlBorde.Controls.Add(Me.Button1)
        Me.pnlBorde.Controls.Add(Me.radMes)
        Me.pnlBorde.Controls.Add(Me.radDia)
        Me.pnlBorde.Location = New System.Drawing.Point(0, 0)
        Me.pnlBorde.Name = "pnlBorde"
        Me.pnlBorde.Size = New System.Drawing.Size(1280, 40)
        Me.pnlBorde.TabIndex = 0
        '
        'radAnio
        '
        Me.radAnio.Appearance = System.Windows.Forms.Appearance.Button
        Me.radAnio.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.radAnio.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radAnio.Checked = True
        Me.radAnio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radAnio.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.radAnio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.radAnio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.radAnio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.radAnio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.radAnio.ForeColor = System.Drawing.Color.White
        Me.radAnio.Location = New System.Drawing.Point(742, 8)
        Me.radAnio.Name = "radAnio"
        Me.radAnio.Size = New System.Drawing.Size(65, 25)
        Me.radAnio.TabIndex = 9
        Me.radAnio.TabStop = True
        Me.radAnio.Text = "Año"
        Me.radAnio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radAnio.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'radMes
        '
        Me.radMes.Appearance = System.Windows.Forms.Appearance.Button
        Me.radMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.radMes.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radMes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radMes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.radMes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.radMes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.radMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.radMes.Location = New System.Drawing.Point(678, 8)
        Me.radMes.Name = "radMes"
        Me.radMes.Size = New System.Drawing.Size(65, 25)
        Me.radMes.TabIndex = 8
        Me.radMes.Text = "Mes"
        Me.radMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radMes.UseVisualStyleBackColor = False
        '
        'radSemana
        '
        Me.radSemana.Appearance = System.Windows.Forms.Appearance.Button
        Me.radSemana.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.radSemana.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radSemana.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radSemana.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.radSemana.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.radSemana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.radSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.radSemana.Location = New System.Drawing.Point(614, 8)
        Me.radSemana.Name = "radSemana"
        Me.radSemana.Size = New System.Drawing.Size(65, 25)
        Me.radSemana.TabIndex = 7
        Me.radSemana.Text = "Semana"
        Me.radSemana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radSemana.UseVisualStyleBackColor = False
        '
        'radDia
        '
        Me.radDia.Appearance = System.Windows.Forms.Appearance.Button
        Me.radDia.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.radDia.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radDia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radDia.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.radDia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.radDia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.radDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!)
        Me.radDia.Location = New System.Drawing.Point(550, 8)
        Me.radDia.Name = "radDia"
        Me.radDia.Size = New System.Drawing.Size(65, 25)
        Me.radDia.TabIndex = 6
        Me.radDia.Text = "Día"
        Me.radDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radDia.UseVisualStyleBackColor = False
        '
        'pnlSeparacion1
        '
        Me.pnlSeparacion1.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.pnlSeparacion1.Location = New System.Drawing.Point(0, 40)
        Me.pnlSeparacion1.Name = "pnlSeparacion1"
        Me.pnlSeparacion1.Size = New System.Drawing.Size(1280, 2)
        Me.pnlSeparacion1.TabIndex = 1
        '
        'pnlIziquierda
        '
        Me.pnlIziquierda.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlIziquierda.Controls.Add(Me.Panel2)
        Me.pnlIziquierda.Controls.Add(Me.MonthCalendar1)
        Me.pnlIziquierda.Location = New System.Drawing.Point(0, 42)
        Me.pnlIziquierda.Name = "pnlIziquierda"
        Me.pnlIziquierda.Size = New System.Drawing.Size(226, 678)
        Me.pnlIziquierda.TabIndex = 2
        '
        'pnlDerecha
        '
        Me.pnlDerecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlDerecha.Location = New System.Drawing.Point(880, 42)
        Me.pnlDerecha.Name = "pnlDerecha"
        Me.pnlDerecha.Size = New System.Drawing.Size(400, 678)
        Me.pnlDerecha.TabIndex = 3
        Me.pnlDerecha.Visible = False
        '
        'pnlSeparacion2
        '
        Me.pnlSeparacion2.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.pnlSeparacion2.Location = New System.Drawing.Point(226, 42)
        Me.pnlSeparacion2.Name = "pnlSeparacion2"
        Me.pnlSeparacion2.Size = New System.Drawing.Size(2, 678)
        Me.pnlSeparacion2.TabIndex = 4
        '
        'pnlSeparacion3
        '
        Me.pnlSeparacion3.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.pnlSeparacion3.Location = New System.Drawing.Point(878, 42)
        Me.pnlSeparacion3.Name = "pnlSeparacion3"
        Me.pnlSeparacion3.Size = New System.Drawing.Size(2, 678)
        Me.pnlSeparacion3.TabIndex = 5
        Me.pnlSeparacion3.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(2, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 2)
        Me.Panel1.TabIndex = 5
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MonthCalendar1.Location = New System.Drawing.Point(0, 526)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(0)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowToday = False
        Me.MonthCalendar1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(0, 522)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(226, 17)
        Me.Panel2.TabIndex = 7
        '
        'frmSoraka
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.pnlBorde)
        Me.Controls.Add(Me.pnlSeparacion3)
        Me.Controls.Add(Me.pnlSeparacion2)
        Me.Controls.Add(Me.pnlDerecha)
        Me.Controls.Add(Me.pnlIziquierda)
        Me.Controls.Add(Me.pnlSeparacion1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSoraka"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Soraka"
        Me.pnlBorde.ResumeLayout(False)
        Me.pnlIziquierda.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBorde As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pnlSeparacion1 As System.Windows.Forms.Panel
    Friend WithEvents pnlIziquierda As System.Windows.Forms.Panel
    Friend WithEvents pnlDerecha As System.Windows.Forms.Panel
    Friend WithEvents pnlSeparacion2 As System.Windows.Forms.Panel
    Friend WithEvents pnlSeparacion3 As System.Windows.Forms.Panel
    Friend WithEvents radDia As System.Windows.Forms.RadioButton
    Friend WithEvents radSemana As System.Windows.Forms.RadioButton
    Friend WithEvents radMes As System.Windows.Forms.RadioButton
    Friend WithEvents radAnio As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
