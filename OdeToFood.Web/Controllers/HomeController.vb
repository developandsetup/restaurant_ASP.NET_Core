Using System.Web;

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Public String Index()
        {
        Return "Hello, World!";
        'Return View()
        }

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
