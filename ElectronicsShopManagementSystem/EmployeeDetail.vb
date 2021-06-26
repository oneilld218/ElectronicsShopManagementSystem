Imports System.Data.SqlClient

Public Class EmployeeDetail

    Dim con As SqlConnection = New SqlConnection()
    Dim commd As SqlCommand = New SqlCommand()
    Dim sql As String
    Dim dr As SqlDataReader
    Dim gen As String
    Dim da As New SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Dim emp As Object

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\irfanali.khan\Desktop\21May2020\CoffeeShopManagementSystem\CoffeeShopManagementSystem\CoffeeShopManagementSystem.mdf;Integrated Security=True")
            sql = "Select * from Employee_Table"
            commd = New SqlCommand(sql, con)
            da = New SqlDataAdapter(commd)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            DataGridView1.DataSource = New BindingSource(dt, emp)

        End Using
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        PlaceOrder.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CustomerDetail.Show()
        Me.Hide()
    End Sub

    Private Sub Home_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Home.LinkClicked
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub EmployeeDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CoffeeShopManagementSystemDataSet2.Employee_Table' table. You can move, or remove it, as needed.
        Me.Employee_TableTableAdapter.Fill(Me.ElectronicsShopManagementSystemDataSet2.Employee_Table)
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\documets\21May2020\CoffeeShopManagementSystem\CoffeeShopManagementSystem\CoffeeShopManagementSystem.mdf;Integrated Security=True"

        con.Open()
        sql = "select nextID=MAX(ID) + 1 from Employee_Table"
        commd = New SqlCommand(sql, con)
        dr = commd.ExecuteReader

        If dr.Read Then
            idLbl.Text = dr.GetValue(0).ToString
            If idLbl.Text = "" Then
                idLbl.Text = 1
            End If
        End If

        con.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles idLbl.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked Then
            gen = "Male"
        ElseIf RadioButton2.Checked Then
            gen = "Female"
        End If

        If custName.Text = "" Then
            MsgBox("Please provide vlaue for Name!")
        ElseIf gen = "" Then
            MsgBox("Please select Gender!")
        ElseIf email.Text = "" Then
            MsgBox("Please provide Email!")
        ElseIf contact.Text = "" Then
            MsgBox("Please provide Contact!")
        ElseIf city.Text = "" Then
            MsgBox("Please provide City!")
        ElseIf address.Text = "" Then
            MsgBox("Please provide Address!")
        ElseIf doj.Text = "" Then
            MsgBox("Please provide Date of Birth!")
        ElseIf salary.Text = "" Then
            MsgBox("Please provide value for Salary!")
        Else

            con.Open()
            sql = "insert into Employee_Table values (" & idLbl.Text & ", '" & custName.Text & "', '" & address.Text & "', '" & city.Text & "', '" & contact.Text & "', '" & gen & "', '" & email.Text & "', '" & doj.Text & "', '" & salary.Text & "')"
            commd = New SqlCommand(sql, con)
            commd.ExecuteNonQuery()
            con.Close()
            MsgBox("Employee Information Inserted Successfully!")
            custName.Text = ""
            address.Text = ""
            city.Text = ""
            contact.Text = ""
            gen = ""
            email.Text = ""
            doj.Text = ""
            salary.Text = ""

            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\documets\21May2020\CoffeeShopManagementSystem\CoffeeShopManagementSystem\CoffeeShopManagementSystem.mdf;Integrated Security=True")
                sql = "Select * from Employee_Table"
                commd = New SqlCommand(sql, con)
                da = New SqlDataAdapter(commd)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)
                DataGridView1.DataSource = New BindingSource(dt, emp)
            End Using

            con.Open()
            sql = "select nextID=MAX(ID) + 1 from Employee_Table"
            commd = New SqlCommand(sql, con)
            dr = commd.ExecuteReader

            If dr.Read Then
                idLbl.Text = dr.GetValue(0).ToString
                If idLbl.Text = "" Then
                    idLbl.Text = 1
                End If
            End If
            con.Close()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\documets\21May2020\CoffeeShopManagementSystem\CoffeeShopManagementSystem\CoffeeShopManagementSystem.mdf;Integrated Security=True")
            sql = "Select * from Employee_Table where name = '" & custName.Text & "' "
            commd = New SqlCommand(sql, con)
            da = New SqlDataAdapter(commd)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            DataGridView1.DataSource = New BindingSource(dt, emp)
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If RadioButton1.Checked Then
            gen = "Male"
        ElseIf RadioButton2.Checked Then
            gen = "Female"
        End If

        If custName.Text = "" Then
            MsgBox("Please provide vlaue for Name!")
        ElseIf gen = "" Then
            MsgBox("Please select Gender!")
        ElseIf email.Text = "" Then
            MsgBox("Please provide Email!")
        ElseIf contact.Text = "" Then
            MsgBox("Please provide Contact!")
        ElseIf city.Text = "" Then
            MsgBox("Please provide City!")
        ElseIf address.Text = "" Then
            MsgBox("Please provide Address!")
        ElseIf doj.Text = "" Then
            MsgBox("Please provide Date of Birth!")
        ElseIf salary.Text = "" Then
            MsgBox("Please provide value for Salary!")
        Else
            con.Open()

            sql = "Update Employee_Table set name = '" & custName.Text & "' , address = '" & address.Text & "', city = '" & city.Text & "' , contact = '" & contact.Text & "', gender = '" & gen & "', email = '" & email.Text & "', doj = '" & doj.Text & "', salary = '" & salary.Text & "'
            where name = '" & custName.Text & "'"
            MsgBox(sql)
            commd = New SqlCommand(sql, con)
            commd.ExecuteNonQuery()
            con.Close()
            MsgBox(" Detail updated successfully!")

            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\documets\21May2020\CoffeeShopManagementSystem\CoffeeShopManagementSystem\CoffeeShopManagementSystem.mdf;Integrated Security=True")
                sql = "Select * from Employee_Table"
                commd = New SqlCommand(sql, con)
                da = New SqlDataAdapter(commd)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)
                DataGridView1.DataSource = New BindingSource(dt, emp)
            End Using


        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If idtext.Visible = False Then
            MessageBox.Show("Please Enter Employee Recored Id To Delete Record..!")
            idtext.Visible = True
        Else
            con.Open()
            sql = "delete from Employee_Table where id = '" & idtext.Text & "'"
            commd = New SqlCommand(sql, con)
            commd.ExecuteNonQuery()
            con.Close()
            MsgBox("Recored deleted successfully...!")

            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\documets\21May2020\CoffeeShopManagementSystem\CoffeeShopManagementSystem\CoffeeShopManagementSystem.mdf;Integrated Security=True")
                sql = "Select * from Employee_Table"
                commd = New SqlCommand(sql, con)
                da = New SqlDataAdapter(commd)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)
                DataGridView1.DataSource = New BindingSource(dt, emp)
            End Using

            con.Open()
            sql = "select nextID=MAX(ID) + 1 from Employee_Table"
            commd = New SqlCommand(sql, con)
            dr = commd.ExecuteReader

            If dr.Read Then
                idLbl.Text = dr.GetValue(0).ToString
                If idLbl.Text = "" Then
                    idLbl.Text = 1
                End If
            End If
            con.Close()
        End If

    End Sub
End Class