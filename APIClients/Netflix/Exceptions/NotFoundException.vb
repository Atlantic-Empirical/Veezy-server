'Copyright (c) 2008, Jonathan Allen






Public Class NotFoundException
	Inherits NetflixException

	Public Sub New(ByVal message As String, ByVal innerException As Net.WebException)
		MyBase.New(message, innerException)
	End Sub

End Class
