Public Class UserMGM

    Private Shared Function GenerateSessionID() As String
        Return Guid.NewGuid.ToString.Replace("-", "") & Date.Now.ToString("yyyymmdd")
    End Function

    Public Sub CreateSessonCookie(SessionID As String)
        Dim NewCookie As New HttpCookie("Session")
        NewCookie("ID") = SessionID
        NewCookie.Expires = DateTime.Now.AddDays(365)
        System.Web.HttpContext.Current.Response.Cookies.Add(NewCookie)
    End Sub

    Public Function GetSessionID() As String
        Try
            Dim Cookie = System.Web.HttpContext.Current.Request.Cookies("Session")

            If Cookie IsNot Nothing Then
                Dim id As String = Cookie.Item("ID")

                If String.IsNullOrEmpty(id) Then
                    Return ""
                Else
                    Return id
                End If
            End If
            Return ""
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Sub Login(newUser As User)
        Dim Users = CType(System.Web.HttpContext.Current.Application("LoggedInUsers"), List(Of User))

        newUser.Session = GenerateSessionID()

        Users.Add(newUser)

        System.Web.HttpContext.Current.Application("LoggedInUsers") = Users

        CreateSessonCookie(newUser.Session)
    End Sub

    Public Sub Logout()
        Dim Users = CType(System.Web.HttpContext.Current.Application("LoggedInUsers"), List(Of User))
        Dim Session As String = GetSessionID()

        For Each item In Users
            If item.Session = Session Then
                Users.Remove(item)
                Exit For
            End If
        Next

        System.Web.HttpContext.Current.Application("LoggedInUsers") = Users

        System.Web.HttpContext.Current.Request.Cookies.Remove("Session")
    End Sub

    Public Function IsLoggedin() As Boolean
        Dim Users = CType(System.Web.HttpContext.Current.Application("LoggedInUsers"), List(Of User))
        Dim Session As String = GetSessionID()

        For Each item In Users
            If item.Session = Session Then
                Return True
            End If
        Next

        Return False
    End Function

    Public Function getUser() As User
        Dim Users = CType(System.Web.HttpContext.Current.Application("LoggedInUsers"), List(Of User))
        Dim Session As String = GetSessionID()

        For Each item In Users
            If item.Session = Session Then
                Return item
            End If
        Next
        Return New User
    End Function

End Class
