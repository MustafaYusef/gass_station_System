Imports System.Data.OleDb
Public Class SignUp
    Dim conn As New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=lisinsPlate.accdb")

    Dim cmd As New OleDbCommand("", conn)

    Sub RunCommond(SQLCommond As String, Optional messag As String = "")
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            cmd.CommandText = SQLCommond
            cmd.ExecuteNonQuery()
            If messag <> "" Then MsgBox(messag)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
    Function GetTable(SQLselect As String) As DataTable
        Try
            Dim dataTable As New DataTable()
            If conn.State = ConnectionState.Closed Then conn.Open()
            cmd.CommandText = SQLselect
            dataTable.Load(cmd.ExecuteReader())
            Return dataTable
        Catch ex As Exception
            MsgBox(ex.Message)
            Return New DataTable()
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function
    Sub FillTable(Optional selectFill As String = "")
        If selectFill = "" Then selectFill = "select * from login"
        LoginForm.DataGridView1.DataSource = GetTable(selectFill)
    End Sub
    Function AutoNum(TableName As String, colName As String) As String
        Dim str As String = "select max(" & colName & ") + 1 from " & TableName
        Dim tb1 As New DataTable
        tb1 = GetTable(str)
        Dim autNum As String
        If tb1.Rows(0)(0) Is DBNull.Value Then
            autNum = "1"
        Else autNum = tb1.Rows(0)(0)

        End If
        Return autNum
    End Function
    Function chackDuplcait() As Boolean
        Dim f As Boolean = False
        For x As Integer = 0 To LoginForm.DataGridView1.Rows.Count - 1
            If LoginForm.DataGridView1.Rows(x).Cells(1).Value = TextBox1.Text And LoginForm.DataGridView1.Rows(x).Cells(2).Value = TextBox2.Text Then
                f = True

            End If
        Next
        Return f
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id As String = AutoNum("login", "ID")
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "you shoul fill all field", "Please", MessageBoxButtons.OK,
                MessageBoxIcon.Error)


        ElseIf chackDuplcait() <> True Then
            RunCommond("insert into login values(" & id & ",'" & TextBox1.Text & "','" & TextBox2.Text & "') ")
            MetroFramework.MetroMessageBox.Show(Me, "you creat account", "seccussful", MessageBoxButtons.OK,
                MessageBoxIcon.Information)
            LoginForm.Show()
            LoginForm.TextBox1.Text = TextBox1.Text
            LoginForm.TextBox2.Text = TextBox2.Text
            Me.Hide()
        Else MetroFramework.MetroMessageBox.Show(Me, "this account exist", "change password or username", MessageBoxButtons.OK,
               MessageBoxIcon.Error)
        End If
        FillTable()

    End Sub
End Class