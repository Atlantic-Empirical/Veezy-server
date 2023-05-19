'Copyright (c) 2008, Jonathan Allen

Public Class CatalogTitleCollection
    Inherits ObjectModel.ReadOnlyCollection(Of CatalogTitle)
    Sub New(ByVal list As IList(Of CatalogTitle))
        MyBase.New(list)
    End Sub
End Class
