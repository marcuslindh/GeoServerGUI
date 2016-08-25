Public Class Tools
    Public Shared Function BasicAuthToken(Username As String, password As String) As String
        Return System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(Username + ":" + password))
    End Function
    Public Shared Function BasicAuthToken(LoggdInUser As User) As String
        Return System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(LoggdInUser.User + ":" + LoggdInUser.Password))
    End Function



End Class
