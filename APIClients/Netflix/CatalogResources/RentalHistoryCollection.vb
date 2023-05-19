'Copyright (c) 2008, Jonathan Allen
Imports WrapNetflix


Public Class RentalHistoryCollection
    Inherits ObjectModel.ReadOnlyCollection(Of RentalHistoryItem)
    Sub New(ByVal list As IList(Of RentalHistoryItem))
        MyBase.New(list)
    End Sub
End Class
