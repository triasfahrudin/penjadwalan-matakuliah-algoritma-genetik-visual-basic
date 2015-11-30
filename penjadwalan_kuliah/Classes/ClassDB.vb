Option Infer On
'INSTANT VB NOTE: This code snippet uses implicit typing. You will need to set 'Option Infer On' in the VB file or set 'Option Infer' at the project level.
Imports System.Data
Imports System.Windows.Forms
Imports IniParser
Imports MySql.Data.MySqlClient

'ExecuteNonQuery: Used to execute a command that will not return any data, for example Insert, update or delete.
'ExecuteReader: Used to execute a command that will return 0 or more records, for example Select.
'ExecuteScalar: Used to execute a command that will return only 1 value, for example Select Count(*).

Namespace Classes
    Friend Class ClassDbConnect
        Private _connection As MySqlConnection
        Private _host As String
        Private _database As String
        Private _username As String
        Private _password As String
        Private _port As String

        Public Sub New()
            Initialize()
        End Sub

        Private Sub Initialize()
            Dim parser = New FileIniDataParser()
            Dim data = parser.LoadFile("config.ini")
            _host = data("database")("hostname")
            _database = data("database")("database")
            _username = data("database")("user")
            _password = data("database")("password")
            _port = data("database")("port")

            Dim conString = String.Format("SERVER={0};PORT={1};DATABASE={2};UID={3};PASSWORD={4};", _host, _port, _database, _username, _password)

            _connection = New MySqlConnection(conString)
        End Sub

        Private Function OpenConnection() As Boolean
            Try
                _connection.Open()
                Return True

            Catch e1 As MySqlException
                Return False
            End Try
        End Function

        Private Sub CloseConnection()
            Try
                _connection.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        'Used to execute a command that will not return any data, 
        'for example Insert, update or delete. 
        Public Sub ExecuteNonQuery(ByVal query As String)
            If Not OpenConnection() Then
                Return
            End If
            Dim cmd = New MySqlCommand(query, _connection)
            cmd.ExecuteNonQuery()
            CloseConnection()
        End Sub

        Public Function ExecuteScalar(ByVal query As String) As String
            Dim str As String = Nothing
            If OpenConnection() Then
                Dim cmd = New MySqlCommand(query, _connection)
                str = CStr(cmd.ExecuteScalar())
                CloseConnection()
            End If
            Return str
        End Function

        Public Function GetRecord(ByVal query As String) As DataTable
            Dim adapter = New MySqlDataAdapter(query, _connection)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            Return ds.Tables(0)
        End Function
    End Class
End Namespace
