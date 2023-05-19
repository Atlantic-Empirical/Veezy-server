'Copyright (c) 2008, Jonathan Allen
Imports WrapNetflix


Public Class ResourceLinkCollection
    Inherits ObjectModel.ReadOnlyCollection(Of ResourceLink)
    Sub New(ByVal list As IList(Of ResourceLink))
        MyBase.New(list)
    End Sub
End Class
