Module GlobalData
    Public Connector As SqlServerConnector = Nothing
    Dim Conn As New SqlClient.SqlConnection("Server=NITROV\SQLEXPRESS;Database=DBCentsible;Integrated Security=True;")

    Public Function CheckLogin(ByVal username As String, ByVal Password As String) As Boolean
        Dim Count As Integer
        Using cmd As New SqlClient.SqlCommand("SELECT COUNT(*) FROM Login WHERE Username = @Username AND Password = @Password", Conn)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", Password)
            Conn.Open()
            Count = Convert.ToInt32(cmd.ExecuteScalar())
            Conn.Close()
        End Using
        Return Count > 0
    End Function

    Public Function CreateAccount(ByVal Email As String, ByVal Username As String, ByVal Password As String, ByVal FirstName As String, ByVal LastName As String, ByVal Gender As String, ByVal Birthday As Date)
        Using cmd As New SqlClient.SqlCommand("INSERT INTO Login (email,Username,password,firstname,lastname,gender,birthday) VALUES (@email,@username,@password,@firstname,@lastname,@gender,@birthday)", Conn)
            cmd.Parameters.AddWithValue("@Email", Email)
            cmd.Parameters.AddWithValue("@Username", Username)
            cmd.Parameters.AddWithValue("@Password", Password)
            cmd.Parameters.AddWithValue("@FirstName", FirstName)
            cmd.Parameters.AddWithValue("@LastName", LastName)
            cmd.Parameters.AddWithValue("@Gender", Gender)
            cmd.Parameters.AddWithValue("@Birthday", Birthday)
            Conn.Open()
            cmd.ExecuteNonQuery()
            Conn.Close()
        End Using
    End Function

    Public Function GetAccountID(ByVal email As String) As Integer
        Dim UserID As Integer = -1
        Using cmd As New SqlClient.SqlCommand("SELECT AccountID FROM Login WHERE email = @email", Conn)
            cmd.Parameters.AddWithValue("@email", email)
            Conn.Open()

            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                UserID = Convert.ToInt32(result)
            End If
            Conn.Close()
        End Using
        Return UserID
    End Function

    Public Function AddSalary(ByVal Salary As Decimal, ByVal AccountID As Integer, ByVal AllocationPlan As String)
        Using cmd As New SqlClient.SqlCommand("INSERT INTO AccountDetails (Salary, AccountID, AllocationPlan) VALUES (@Salary, @UserID, @AllocationPlan)", Conn)
            cmd.Parameters.AddWithValue("@Salary", Salary)
            cmd.Parameters.AddWithValue("@UserID", AccountID)
            cmd.Parameters.AddWithValue("@AllocationPlan", AllocationPlan)
            Conn.Open()
            cmd.ExecuteNonQuery()
            Conn.Close()
        End Using
    End Function

    Public Function GetSalary(ByVal AccountID As Integer) As Decimal
        Dim Salary As Decimal = 0
        Using cmd As New SqlClient.SqlCommand("SELECT Salary FROM AccountDetails WHERE AccountID = @UserID", Conn)
            cmd.Parameters.AddWithValue("@UserID", AccountID)
            Conn.Open()
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                Salary = Convert.ToDecimal(result)
            End If
            Conn.Close()
        End Using
        Return Salary
    End Function

    Public Function UpdateSalary(ByVal AccountID As Integer, ByVal UpdatedSalary As Decimal)
        Using cmd As New SqlClient.SqlCommand("UPDATE AccountDetails SET Salary = @salary WHERE AccountID = @AccountID", Conn)
            cmd.Parameters.AddWithValue("@salary", UpdatedSalary)
            cmd.Parameters.AddWithValue("@AccountID", AccountID)
            Conn.Open()
            cmd.ExecuteNonQuery()
            Conn.Close()
        End Using
    End Function

    Public Function AddExpenses(ByRef Expense As Decimal, ByVal AccountID As Integer, ByVal Type As String)
        Using cmd As New SqlClient.SqlCommand("INSERT INTO Expenses (Expense, AccountID, Type) VALUES (@Expense, @AccountID, @Type)", Conn)
            cmd.Parameters.AddWithValue("@Expense", Expense)
            cmd.Parameters.AddWithValue("@AccountID", AccountID)
            cmd.Parameters.AddWithValue("@Type", Type)
            Conn.Open()
            cmd.ExecuteNonQuery()
            Conn.Close()
        End Using
    End Function

    Public Function GetTotalExpenses(ByVal AccountID As Integer) As Decimal
        Dim totalExpense As Decimal = 0
        Using cmd As New SqlClient.SqlCommand("
SELECT
    SUM(latestamount)
FROM
    (
        SELECT
            AccountID,
            [Type],
            DateChanged,
            Amount AS latestamount,
            ROW_NUMBER() OVER (PARTITION BY AccountID, [Type] ORDER BY DateChanged DESC) AS rn
        FROM
            Expenses
        WHERE
            AccountID = @AccountID
    ) AS RankedExpenses
WHERE
    rn = 1;", Conn)
            cmd.Parameters.AddWithValue("@AccountID", AccountID)
            Conn.Open()
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                totalExpense = Convert.ToDecimal(result)
            End If
            Conn.Close()
        End Using
        Return totalExpense
    End Function
End Module