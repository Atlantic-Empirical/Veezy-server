'Copyright (c) 2008, Jonathan Allen
Imports WrapNetflix


Public Class RecommendationCollection
    Inherits ObjectModel.ReadOnlyCollection(Of RecommendationItem)
    Sub New(ByVal list As IList(Of RecommendationItem))
        MyBase.New(list)
    End Sub
End Class
