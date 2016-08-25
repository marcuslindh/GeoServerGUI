Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class ProxyController
        Inherits ApiController

        ' GET: api/Proxy
        'Public Function GetValues() As IEnumerable(Of String)
        '    Return New String() {"value1", "value2"}
        'End Function

        '' GET: api/Proxy/5
        'Public Function GetValue(ByVal id As Integer) As String
        '    Return "value"
        'End Function

        ' POST: api/Proxy
        Public Function PostValue(<FromBody()> ByVal value As String)
            If New UserMGM().IsLoggedin = True Then
                Return New Proxy().Get(value)
            End If
            Return ""
        End Function

        ' PUT: api/Proxy/5
        'Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        'End Sub

        '' DELETE: api/Proxy/5
        'Public Sub DeleteValue(ByVal id As Integer)

        'End Sub
    End Class
End Namespace