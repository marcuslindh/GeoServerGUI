Imports System.Web.Mvc

Namespace Controllers
    Public Class LoginController
        Inherits Controller

        ' GET: Login
        Function Index() As ActionResult
            Return View()
        End Function

        <HttpPost()>
        Public Function Login(ByVal collection As FormCollection) As ActionResult
            Dim NewUser As New User With {.User = collection("user"), .Password = collection("password")}
            Dim u As New UserMGM

            u.Login(NewUser)
            Return RedirectToAction("index", "Home")
        End Function

        '' GET: Login/Details/5
        'Function Details(ByVal id As Integer) As ActionResult
        '    Return View()
        'End Function

        '' GET: Login/Create
        'Function Create() As ActionResult
        '    Return View()
        'End Function

        '' POST: Login/Create
        '<HttpPost()>
        'Function Create(ByVal collection As FormCollection) As ActionResult
        '    Try
        '        ' TODO: Add insert logic here

        '        Return RedirectToAction("Index")
        '    Catch
        '        Return View()
        '    End Try
        'End Function

        '' GET: Login/Edit/5
        'Function Edit(ByVal id As Integer) As ActionResult
        '    Return View()
        'End Function

        '' POST: Login/Edit/5
        '<HttpPost()>
        'Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        '    Try
        '        ' TODO: Add update logic here

        '        Return RedirectToAction("Index")
        '    Catch
        '        Return View()
        '    End Try
        'End Function

        '' GET: Login/Delete/5
        'Function Delete(ByVal id As Integer) As ActionResult
        '    Return View()
        'End Function

        '' POST: Login/Delete/5
        '<HttpPost()>
        'Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        '    Try
        '        ' TODO: Add delete logic here

        '        Return RedirectToAction("Index")
        '    Catch
        '        Return View()
        '    End Try
        'End Function
    End Class
End Namespace