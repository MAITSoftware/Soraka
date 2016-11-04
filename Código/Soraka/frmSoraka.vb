Public Class frmSoraka

    Dim año As frmAño
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub frmSoraka_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        año = New frmAño()
        año.Location = New Point(230, 42)
        Me.Controls.Add(año)
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        año.año = MonthCalendar1.SelectionRange.Start.Year
        año.actCalendario()
    End Sub
End Class
