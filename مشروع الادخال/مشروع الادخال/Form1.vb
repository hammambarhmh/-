Public Class Form1

    Dim x, y, w, k As String

    Dim i As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        x = "هل تريد الخروج من الخروج؟ " + w
        y = "تحذير "

        MsgBox(x, MsgBoxStyle.YesNo + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight, y)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        i = InputBox("الرجاء أدخال العدد بين ال15 و الصفر", "صندوق الادخال")

        If i >= 0 And i <= 15 Then
            Me.BackColor = System.Drawing.ColorTranslator.FromOle(QBColor(Val(i)))

        Else

            MsgBox("ألادخال خطاء", "تنبيه")



        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Randomize()

        Me.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(Rnd() * 255, Rnd() * 255, Rnd() * 255))





    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        w = Chr(13) + Chr(10)

        TextBox1.Text = "الحمدلله" + w + "رب العالمين"
        Label1.Text = "الحمدلله" + w + "رب العالمين"


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        w = Chr(13) + Chr(10)

        x = "كلية الحاسوب" + w
        x = "ايتي" + w
        x = "2025.2026 العام الدراسي " + w
        y = "المشروع"

        MsgBox(x, MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight, y)

    End Sub
End Class
