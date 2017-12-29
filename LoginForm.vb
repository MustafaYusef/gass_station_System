Public Class LoginForm
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
    Function chackDuplcait() As Boolean
        Dim f As Boolean = False
        For x As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(x).Cells(1).Value = TextBox1.Text And DataGridView1.Rows(x).Cells(2).Value = TextBox2.Text Then
                f = True

            End If
        Next
        Return f
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And chackDuplcait() Then
            frmMain.Show()
            details.checkTime()
            Me.Hide()

        Else
            MetroFramework.MetroMessageBox.Show(Me, "you should creat account", "You dont have account", MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End If


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub




    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SignUp.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SignUp.FillTable()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class