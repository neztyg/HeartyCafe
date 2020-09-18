Module modConnection
    Public connDB As New SqlClient.SqlConnection
    Public comDB As New SqlClient.SqlCommand
    Public rdDB As SqlClient.SqlDataReader
    'Public Function IPv4Address() As String
    '    IPv4Address = String.Empty
    '    Dim strHostName As String = System.Net.Dns.GetHostName()
    '    Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

    '    For Each ipheal As System.Net.IPAddress In iphe.AddressList
    '        If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
    '            IPv4Address = ipheal.ToString()
    '        End If
    '    Next
    'End Function

    Public Sub initDBconn()
        'This is the connection for your MS SQL Server
        'IP Address Connection String
        Dim userDB As String = "heartyAdmin"
        Dim passDB As String = "admin"
        Dim dbName As String = "SalesInventoryHEARTY"   'Database name
        Dim ipAddressServer As String = "192.168.1.205"

        'REMOTE LOGIN
        'If connDB.State <> ConnectionState.Open Then connDB.ConnectionString = String.Format("Data Source={0},1433;Network Library=DBMSSOCN;Initial Catalog={1};User ID={2};Password={3};", ipAddressServer, dbName, userDB, passDB)
        'If connDB.State <> ConnectionState.Open Then connDB.Open()

        ''Local Database Login
        'If connDB.State <> ConnectionState.Open Then connDB.ConnectionString = String.Format("Data Source=.;Network Library=DBMSSOCN;Initial Catalog={1};User ID={2};Password={3};", IPv4Address(), ipDBName, userDB, passDB)
        'If connDB.State <> ConnectionState.Open Then connDB.Open()

        'Local Connection String
        If connDB.State <> ConnectionState.Open Then connDB.ConnectionString = "Data Source = .; Integrated Security = SSPI; Initial Catalog=" & dbName.Trim & ""
        If connDB.State <> ConnectionState.Open Then connDB.Open()

        With comDB
            .Connection = connDB
            .CommandType = CommandType.Text
            .CommandTimeout = 0
        End With
    End Sub

    'Close the connection from database
    Private Sub closeDB()
        If connDB.State <> ConnectionState.Closed Then connDB.Close()
    End Sub

    'Close DB Reader
    Private Sub closeReaderDB()
        If Not rdDB.IsClosed Then rdDB.Close()
    End Sub

    'Close both Reader and DB Connection
    Public Sub closeDBAll()
        If Not rdDB.IsClosed Then rdDB.Close()
        If connDB.State <> ConnectionState.Closed Then connDB.Close()
        SQLstr = Nothing
    End Sub

    Private SQLcmd As String

    Public Property SQLstr() As String
        Get
            Return SQLcmd
        End Get
        Set(ByVal value As String)
            SQLcmd = value
        End Set
    End Property


    'Select query passed here!
    Public Sub sqlQueryCMD(ByVal SQLstr As String)
        initDBconn()
        With comDB
            .CommandText = SQLstr
            rdDB = .ExecuteReader
        End With
    End Sub

    'Insert, Update, Drop, Alter, Create query passed here!
    Public Sub sqlNonQueryCMD(ByVal SQLstr As String)
        initDBconn()
        With comDB
            .CommandText = SQLstr
            .ExecuteNonQuery()
        End With
        closeDBAll()
    End Sub


    Public Sub passQueryArgs(ByVal argVar As String, ByVal argType As SqlDbType, ByVal passVal As Object)
        comDB.Parameters.Add(New SqlClient.SqlParameter(argVar, argType)).Value = passVal
    End Sub

    Public Sub passImgParam(ByVal argVar As String, ByVal imgPath As Object)
        comDB.Parameters.Add(New SqlClient.SqlParameter(argVar, SqlDbType.Image)).Value = IO.File.ReadAllBytes(imgPath)
    End Sub

    Public Sub passIntParam(ByVal argVar As String, ByVal intVal As Integer)
        comDB.Parameters.Add(New SqlClient.SqlParameter(argVar, SqlDbType.Int)).Value = intVal
    End Sub

    Public Sub passDateParam(ByVal argVar As String, ByVal DateVal As Date)
        comDB.Parameters.Add(New SqlClient.SqlParameter(argVar, SqlDbType.Date)).Value = DateVal
    End Sub

    Public Sub passDecParam(ByVal argVar As String, ByVal decVal As Integer)
        comDB.Parameters.Add(New SqlClient.SqlParameter(argVar, SqlDbType.Decimal)).Value = decVal
    End Sub

    Public Sub passStrParam(ByVal argVar As String, ByVal StrVal As Integer)
        comDB.Parameters.Add(New SqlClient.SqlParameter(argVar, SqlDbType.VarChar)).Value = StrVal
    End Sub

    Public Sub Delay(ByVal dblSecs As Double)
        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents() ' Allow windows messages to be processed
        Loop

    End Sub

    Public Sub NumericTypeOnly(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And
                                                                   (sender.Text.IndexOf(".") = -1 And
                                                                    sender.Text.IndexOf(",") = -1)))

    End Sub

    '' PROPERTIES
    Private categID As Integer
    Property categoryID As Integer
        Get
            Return categID
        End Get
        Set(ByVal value As Integer)
            categID = value
        End Set
    End Property

    Private prodID As Integer
    Property productID As Integer
        Get
            Return prodID
        End Get
        Set(ByVal value As Integer)
            prodID = value
        End Set
    End Property

    Private uID As Integer
    Property userID As Integer
        Get
            Return uID
        End Get
        Set(ByVal value As Integer)
            uID = value
        End Set
    End Property

    Private prodSpec As Integer
    Property prodSpecID As Integer
        Get
            Return prodSpec
        End Get
        Set(ByVal value As Integer)
            prodSpec = value
        End Set
    End Property

    Private prodNum As Integer
    Property productNum As Integer
        Get
            Return prodNum
        End Get
        Set(ByVal value As Integer)
            prodNum = value
        End Set
    End Property
End Module


