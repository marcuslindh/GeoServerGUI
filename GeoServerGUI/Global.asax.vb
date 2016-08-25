Imports System.Web.Http
Imports System.Web.Optimization

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        RouteConfig.RegisterRoutes(RouteTable.Routes)

        Application("LoggedInUsers") = New List(Of User)


    End Sub


End Class
