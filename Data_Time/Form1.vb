Public Class Form1
    Private Sub DataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataToolStripMenuItem.Click
        Label1.Text = DateString
        Timer1.Enabled = False
    End Sub

    Private Sub TimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeToolStripMenuItem.Click
        Label1.Text = TimeString
        Timer1.Enabled = True
        DateTime.Now.ToString()
    End Sub

    Private Sub التاريخالحاليToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles التاريخالحاليToolStripMenuItem.Click
        Label1.Text = DateString
        Timer1.Enabled = False
    End Sub

    Private Sub التاريخوالوقتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles التاريخوالوقتToolStripMenuItem.Click
        Label1.Text = DateString
        Label1.Text = TimeString
        Timer1.Enabled = False
    End Sub

    Private Sub الشهرمنالتاريخToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الشهرمنالتاريخToolStripMenuItem.Click
        Label1.Text = Month(Now).ToString
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeString
    End Sub

    Private Sub رقميمثليوممنالاسبوعToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles رقميمثليوممنالاسبوعToolStripMenuItem.Click
        Label1.Text = Weekday(Now).ToString
        Timer1.Enabled = False
    End Sub

    Private Sub الوقتالحاليToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الوقتالحاليToolStripMenuItem.Click
        Label1.Text = TimeString
        Timer1.Enabled = True
    End Sub

    Private Sub الساعاتمنالوقتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الساعاتمنالوقتToolStripMenuItem.Click
        Label1.Text = Hour(Now).ToString
        Timer1.Enabled = False
    End Sub

    Private Sub الدقائقمنالوقتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الدقائقمنالوقتToolStripMenuItem.Click
        Label1.Text = Minute(Now).ToString
        Timer1.Enabled = False
    End Sub

    Private Sub الثوانيمنالوقتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الثوانيمنالوقتToolStripMenuItem.Click
        Label1.Text = Second(Now).ToString
        Timer1.Enabled = True
    End Sub

    Private Sub السنةمنالوقتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles السنةمنالوقتToolStripMenuItem.Click
        Label1.Text = Year(Now).ToString
        Timer1.Enabled = False
    End Sub
End Class

