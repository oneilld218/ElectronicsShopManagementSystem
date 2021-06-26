Partial Class ElectronicsShopManagementSystemDataSet3
    Partial Public Class Customer_TableDataTable
        Private Sub Customer_TableDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.nameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class Place_Order_TableDataTable
        Private Sub Place_Order_TableDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            '  If (e.Column.ColumnName = Me.addressColumn.ColumnName) Then
            'Add user code here
            ' End If

        End Sub

    End Class
End Class
Namespace ElectronicsShopManagementSystemDataSet3TableAdapters
    Partial Public Class Place_Order_TableTableAdapter
    End Class
End Namespace
