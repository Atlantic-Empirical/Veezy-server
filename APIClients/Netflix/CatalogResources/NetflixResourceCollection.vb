'Copyright (c) 2008, Jonathan Allen
Imports WrapNetflix


Public Class NetflixResourceCollection
    Inherits ObjectModel.ReadOnlyCollection(Of NetflixResource)
    Sub New(ByVal list As IList(Of NetflixResource))
        MyBase.New(list)
    End Sub
End Class
