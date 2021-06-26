Imports System.Data.SqlClient

Public Class HomePage

    Dim con As SqlConnection = New SqlConnection()
    Dim commd As SqlCommand = New SqlCommand()
    Dim sql As String
    Dim dr As SqlDataReader
    Dim typee As String
    Dim da As New SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Dim addCoffee As Object

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CustomerDetail.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        EmployeeDetail.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        PlaceOrder.Show()
        Me.Hide()
    End Sub

    Private Sub Home_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Home.LinkClicked
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\documets\21May2020\CoffeeShopManagementSystem\CoffeeShopManagementSystem\CoffeeShopManagementSystem.mdf;Integrated Security=True")
            sql = "Select * from Addcoffee_Table"
            commd = New SqlCommand(sql, con)
            da = New SqlDataAdapter(commd)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            AddElectronics_TableDataGridView.DataSource = New BindingSource(dt, addCoffee)

        End Using

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Addcoffee_TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Addcoffee_TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AddElectronics_TableBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ElectronicsShopManagementSystemDataSet31)

    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ElectronicsShopManagementSystemDataSet31.AddElectronics_Table' table. You can move, or remove it, as needed.
        Me.AddElectronics_TableTableAdapter.Fill(Me.ElectronicsShopManagementSystemDataSet31.AddElectronics_Table)

        'TODO: This line of code loads data into the 'CoffeeShopManagementSystemDataSet3.Addcoffee_Table' table. You can move, or remove it, as needed.
        Me.AddElectronics_TableTableAdapter.Fill(Me.ElectronicsShopManagementSystemDataSet31.AddElectronics_Table)

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\documets\21May2020\CoffeeShopManagementSystem\CoffeeShopManagementSystem\CoffeeShopManagementSystem.mdf;Integrated Security=True"

        con.Open()
        sql = "select nextID=MAX(ID) + 1 from Addcoffee_Table"
        commd = New SqlCommand(sql, con)
        dr = commd.ExecuteReader

        If dr.Read Then
            id.Text = dr.GetValue(0).ToString
            If id.Text = "" Then
                id.Text = 1
            End If
        End If

        con.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If custName.Text = "" Then
            MsgBox("Please provide vlaue for Name!")
        ElseIf compName.Text = "" Then
            MsgBox("Please select Company Name!")
        ElseIf qty.Text = "" Then
            MsgBox("Please provide Quantity!")
        ElseIf size.Text = "" Then
            MsgBox("Please provide Size")
        ElseIf unitprice.Text = "" Then
            MsgBox("Please provide Unit Price!")
        Else

            con.Open()
            sql = "insert into Addcoffee_Table values (" & id.Text & ", '" & custName.Text & "', '" & compName.Text & "', '" & size.Text & "','" & qty.Text & "', '" & unitprice.Text & "')"
            commd = New SqlCommand(sql, con)
            commd.ExecuteNonQuery()
            con.Close()
            MsgBox("Information Inserted Successfully!")

            id.Text = ""
            custName.Text = ""
            compName.Text = ""
            size.Text = ""
            unitprice.Text = ""
            qty.Text = ""


            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\documets\21May2020\CoffeeShopManagementSystem\CoffeeShopManagementSystem\CoffeeShopManagementSystem.mdf;Integrated Security=True")
                sql = "Select * from Addcoffee_Table"
                commd = New SqlCommand(sql, con)
                da = New SqlDataAdapter(commd)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)
                AddElectronics_TableDataGridView.DataSource = New BindingSource(dt, addCoffee)

            End Using


            con.Open()
            sql = "select nextID=MAX(ID) + 1 from Addcoffee_Table"
            commd = New SqlCommand(sql, con)
            dr = commd.ExecuteReader

            If dr.Read Then
                id.Text = dr.GetValue(0).ToString
                If id.Text = "" Then
                    id.Text = 1
                End If
            End If

            con.Close()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If custName.Text = "" Then
            MessageBox.Show("Please Eneter Item Name To Search Recored..!")

        Else

            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\documets\21May2020\CoffeeShopManagementSystem\CoffeeShopManagementSystem\CoffeeShopManagementSystem.mdf;Integrated Security=True")
                sql = "Select * from Addcoffee_Table where name = '" & custName.Text & "' "
                commd = New SqlCommand(sql, con)
                da = New SqlDataAdapter(commd)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)
                AddElectronics_TableDataGridView.DataSource = New BindingSource(dt, addCoffee)

            End Using
        End If
    End Sub

    Private Sub Addcoffee_TableDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If custName.Text = "" Then
            MsgBox("Please provide vlaue for Name!")
        ElseIf compName.Text = "" Then
            MsgBox("Please select Company Name!")
        ElseIf qty.Text = "" Then
            MsgBox("Please provide Quantity!")
        ElseIf size.Text = "" Then
            MsgBox("Please provide Size")
        ElseIf unitprice.Text = "" Then
            MsgBox("Please provide Unit Price!")
        Else
            con.Open()

            sql = "Update Addcoffee_Table set name = '" & custName.Text & "' , company = '" & compName.Text & "', size = '" & size.Text & "' , qty = '" & qty.Text & "', unit_price = '" & unitprice.Text & "'
            where name = '" & custName.Text & "'"
            MsgBox(sql)
            commd = New SqlCommand(sql, con)
            commd.ExecuteNonQuery()
            con.Close()
            MsgBox(" Detail updated successfully!")

            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\documets\21May2020\CoffeeShopManagementSystem\CoffeeShopManagementSystem\CoffeeShopManagementSystem.mdf;Integrated Security=True")
                sql = "Select * from Addcoffee_Table"
                commd = New SqlCommand(sql, con)
                da = New SqlDataAdapter(commd)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)
                AddElectronics_TableDataGridView.DataSource = New BindingSource(dt, addCoffee)

            End Using
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If idtext.Visible = False Then
            MessageBox.Show("Please Enter Item Record Id To Delete Record..!")
            idtext.Visible = True
        Else
            con.Open()
            sql = "delete from Addcoffee_Table where id = '" & idtext.Text & "'"
            commd = New SqlCommand(sql, con)
            commd.ExecuteNonQuery()
            con.Close()
            MsgBox("Recored deleted successfully...!")

        End If

        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\documets\21May2020\CoffeeShopManagementSystem\CoffeeShopManagementSystem\CoffeeShopManagementSystem.mdf;Integrated Security=True")
            sql = "Select * from Addcoffee_Table"
            commd = New SqlCommand(sql, con)
            da = New SqlDataAdapter(commd)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            AddElectronics_TableDataGridView.DataSource = New BindingSource(dt, addCoffee)

        End Using


        con.Open()
        sql = "select nextID=MAX(ID) + 1 from Addcoffee_Table"
        commd = New SqlCommand(sql, con)
        dr = commd.ExecuteReader

        If dr.Read Then
            id.Text = dr.GetValue(0).ToString
            If id.Text = "" Then
                id.Text = 1
            End If
        End If
        con.Close()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\documets\21May2020\CoffeeShopManagementSystem\CoffeeShopManagementSystem\CoffeeShopManagementSystem.mdf;Integrated Security=True")
            sql = "Select * from Addcoffee_Table"
            commd = New SqlCommand(sql, con)
            da = New SqlDataAdapter(commd)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            AddElectronics_TableDataGridView.DataSource = New BindingSource(dt, addCoffee)

        End Using
    End Sub
End Class