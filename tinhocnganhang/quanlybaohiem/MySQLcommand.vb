Imports System.Data.SqlClient

Public Class MySQLcommand

    Protected Friend Const DE_CONNECT_SQL As String = "data source=hp-pc;initial catalog=qlhdbh;integrated security=true"

    Private Shared shareInstance As MySQLcommand

    Dim con As New SqlConnection


    Protected Sub New()
        'initialization code goes here
    End Sub

    Public Shared ReadOnly Property GetInstance As MySQLcommand
        Get
            Static Instance As MySQLcommand = New MySQLcommand
            Return Instance
        End Get
    End Property


    Public Sub taoketnoi()
        Try
            Dim strketnoi As String = DE_CONNECT_SQL
            con.ConnectionString = strketnoi
            con.Open()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Public Sub dongketnoi()
        Try
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

End Class
