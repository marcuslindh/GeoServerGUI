Imports System.Web.Mvc

Namespace Controllers
    Public Class LogoutController
        Inherits Controller

        ' GET: Logout
        Function Index() As ActionResult
            Dim u As New UserMGM

            u.Logout()


            Return RedirectToAction("index", "Login")
        End Function

        '' GET: Logout/Details/5
        'Function Details(ByVal id As Integer) As ActionResult
        '    Return View()
        'End Function

        '' GET: Logout/Create
        'Function Create() As ActionResult
        '    Return View()
        'End Function

        '' POST: Logout/Create
        '<HttpPost()>
        'Function Create(ByVal collection As FormCollection) As ActionResult
        '    Try
        '        ' TODO: Add insert logic here

        '        Return RedirectToAction("Index")
        '    Catch
        '        Return View()
        '    End Try
        'End Function

        '' GET: Logout/Edit/5
        'Function Edit(ByVal id As Integer) As ActionResult
        '    Return View()
        'End Function

        '' POST: Logout/Edit/5
        '<HttpPost()>
        'Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        '    Try
        '        ' TODO: Add update logic here

        '        Return RedirectToAction("Index")
        '    Catch
        '        Return View()
        '    End Try
        'End Function

        '' GET: Logout/Delete/5
        'Function Delete(ByVal id As Integer) As ActionResult
        '    Return View()
        'End Function

        '' POST: Logout/Delete/5
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