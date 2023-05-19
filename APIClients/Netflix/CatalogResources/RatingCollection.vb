Imports WrapNetflix

Public Class RatingCollection
    Inherits ObjectModel.ReadOnlyCollection(Of RatingItem)
    Sub New(ByVal list As IList(Of RatingItem))
        MyBase.New(list)
    End Sub
End Class
