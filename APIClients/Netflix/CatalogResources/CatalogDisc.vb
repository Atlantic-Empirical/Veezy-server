'Copyright (c) 2008, Jonathan Allen
Imports WrapNetflix


Public Class CatalogDisc
    Inherits CatalogTitle

    Public Const IdPrefix As String = "http://api.netflix.com/catalog/titles/discs/"

    Public Sub New(ByVal connection As NetflixConnection, ByVal source As XElement)
        MyBase.New(connection, source)
    End Sub

End Class
