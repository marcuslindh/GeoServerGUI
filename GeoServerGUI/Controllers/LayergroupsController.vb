Imports System.Web.Mvc

Namespace Controllers
    Public Class LayergroupsController
        Inherits Controller

        ' GET: Layergroups
        Function Index() As ActionResult
            If New UserMGM().IsLoggedin = False Then Return RedirectToAction("index", "Login")

            Return View()
        End Function

        '' GET: Layergroups/Details/5
        'Function Details(ByVal id As Integer) As ActionResult
        '    Return View()
        'End Function

        '' GET: Layergroups/Create
        'Function Create() As ActionResult
        '    Return View()
        'End Function

        '' POST: Layergroups/Create
        '<HttpPost()>
        'Function Create(ByVal collection As FormCollection) As ActionResult
        '    Try
        '        ' TODO: Add insert logic here

        '        Return RedirectToAction("Index")
        '    Catch
        '        Return View()
        '    End Try
        'End Function

        '' GET: Layergroups/Edit/5
        'Function Edit(ByVal id As Integer) As ActionResult
        '    Return View()
        'End Function

        '' POST: Layergroups/Edit/5
        '<HttpPost()>
        'Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        '    Try
        '        ' TODO: Add update logic here

        '        Return RedirectToAction("Index")
        '    Catch
        '        Return View()
        '    End Try
        'End Function

        '' GET: Layergroups/Delete/5
        'Function Delete(ByVal id As Integer) As ActionResult
        '    Return View()
        'End Function

        '' POST: Layergroups/Delete/5
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