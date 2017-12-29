Imports System.Data.OleDb
Public Class details


    Dim conn As New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=lisinsPlate.accdb")

    Dim cmd As New OleDbCommand("", conn)

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
        If selectFill = "" Then selectFill = "select * from car"
        DataGridView1.DataSource = GetTable(selectFill)
    End Sub

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
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        While Panel2.Height > 25
            Panel2.Height -= 1


        End While
        Button6.Hide()
        Button7.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        While Panel2.Height < 80
            Panel2.Height += 1
        End While
        Button7.Hide()
        Button6.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkTime()
        FillTable()
        clear()
        Button5.Enabled = False
        Button4.Enabled = False

        'TextBox1.Text = AutoNum("car", "ID")
    End Sub

    Function CheckTime1(num As String, ch As String) As Boolean

        Dim f As Boolean = True
        Dim dateNow As Date = Now

        For x As Integer = 0 To DataGridView1.Rows.Count - 1
            If num = DataGridView1.Rows(x).Cells(1).Value And ch = DataGridView1.Rows(x).Cells(2).Value Then
                f = False




            End If





        Next
        Return f
    End Function

    Sub checkTime()
        Dim diff As Integer = 0
        Dim datereal As Date = Now
        For x As Integer = 0 To DataGridView1.Rows.Count - 1

            diff = CInt(DateDiff(DateInterval.Day, DataGridView1.Rows(x).Cells(3).Value, datereal))

            If diff >= 1 Then
                RunCommond("delete from car where ID=" & CInt(DataGridView1.Rows(x).Cells(0).Value) & " ")

            End If




        Next

        FillTable()


    End Sub
    Sub clear()
        TextBox1.Text = ""
        ComboBox1.Text = ""
        Button5.Enabled = False
        Button4.Enabled = False
        DataGridView1.ClearSelection()

    End Sub
    Function chackDuplcait() As Boolean
        Dim f As Boolean = True
        For x As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(x).Cells(1).Value = TextBox1.Text And DataGridView1.Rows(x).Cells(2).Value = ComboBox1.Text Then
                f = False

            End If
        Next
        Return f
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dateNow As Date = Now
        Dim id As String = AutoNum("car", "ID")
        If TextBox1.Text.Trim() = "" And ComboBox1.Text = "" Then

            MsgBox("should enter values of all filds ")

        ElseIf chackDuplcait() Then
            RunCommond("insert into car values(" & id & ",'" & TextBox1.Text & "','" & ComboBox1.Text & "','" & dateNow & "') ")
            FillTable()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "cannot add this car", "this car exsist in the database", MessageBoxButtons.OK,
                MessageBoxIcon.Information)
        End If
        clear()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Hide()
        frmMain.Show()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        clear()
        clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MetroFramework.MetroMessageBox.Show(Me, "you will delet it", "Do you want delet?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Hand) Then
            For x As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(x).Selected Then

                    RunCommond("delete from car where ID=" & DataGridView1.Rows(x).Cells(0).Value & " ")
                End If
            Next
        End If



        clear()
        FillTable()



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dateNow As Date = Now
        RunCommond("update car set numOfPlate='" & TextBox1.Text & "' , charOfPlate='" & ComboBox1.Text & "', dateOfFull='" & dateNow & "'  where ID= " & DataGridView1.CurrentRow.Cells(0).Value & "")
        FillTable()
    End Sub

    Sub showData()
        Try
            If DataGridView1.CurrentRow IsNot Nothing Then
                TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
                ComboBox1.Text = DataGridView1.CurrentRow.Cells(2).Value
                Button5.Enabled = True
                Button4.Enabled = True



            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        showData()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim strCommond As String = "select * from car where [numOfPlate] like '%" & TextBox2.Text & "%'"
        DataGridView1.DataSource = GetTable(strCommond)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If CheckBox1.Checked Then
            Button11_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CheckTime1(TextBox1.Text, ComboBox1.Text) Then

            MetroFramework.MetroMessageBox.Show(Me, "this car is Acceptable", "this car fuel befor more than 24 hours", MessageBoxButtons.OK,
                  MessageBoxIcon.Information)
        Else
            MetroFramework.MetroMessageBox.Show(Me, "this car is Unacceptable", "this car fuel befor less than 24 hours", MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End If
    End Sub



    'Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
    '    showData()
    'End Sub

    'Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
    '    showData()
    'End Sub
End Class