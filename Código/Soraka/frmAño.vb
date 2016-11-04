Public Class frmAño

    Friend año As Integer

    Private Sub frmAño_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnToday.PerformClick()
    End Sub

    Public Sub actCalendario()
        lblAño.Text = año.ToString()
        Try
            calAño.MaxDate = New DateTime(año.ToString(), 12, 31)
            calAño.MinDate = New DateTime(año.ToString(), 1, 1)
        Catch ex As Exception
            calAño.MinDate = New DateTime(año.ToString(), 1, 1)
            calAño.MaxDate = New DateTime(año.ToString(), 12, 31)
        End Try
    End Sub

    Private Sub btnPrevAño_Click(sender As Object, e As EventArgs) Handles btnPrevAño.Click
        año -= 1
        actCalendario()
    End Sub

    Private Sub btnProxAño_Click(sender As Object, e As EventArgs) Handles btnProxAño.Click
        año += 1
        actCalendario()
    End Sub

    Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click
        año = Date.Today.Year
        actCalendario()
    End Sub

    Private Sub calAño_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calAño.DateChanged

    End Sub
End Class
