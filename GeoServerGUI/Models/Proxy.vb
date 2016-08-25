Public Class Proxy

    Public Shared Function [Get](Url As String, LoggdinUser As User) As String
        Dim req As System.Net.WebRequest = System.Net.WebRequest.Create("http://wms.umea.se/geoserver/rest/" & Url)
        req.Headers.Add("authorization", "Basic " & Tools.BasicAuthToken(LoggdinUser))
        req.Method = "GET"
        Dim resp As System.Net.WebResponse = req.GetResponse()
        If resp Is Nothing Then
            Return Nothing
        End If
        Dim sr As New System.IO.StreamReader(resp.GetResponseStream())
        Return sr.ReadToEnd().Trim()
    End Function


End Class
