Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")


        routes.MapMvcAttributeRoutes()

        routes.MapRoute(
            name:="iris",
            url:="iris{page}/iris{id}",
            defaults:=New With {.controller = "Home", .action = "Iris", .page = "200", .id = "200"},
            constraints:=New With {.page = "2[0-9][0-9]", .id = "2[0-9][0-9]"}
            )

        routes.MapRoute(
            name:="Default",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional}
        )

    End Sub
End Module