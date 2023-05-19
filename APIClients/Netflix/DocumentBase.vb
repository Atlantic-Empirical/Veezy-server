'Copyright (c) 2008, Jonathan Allen

Public Class DocumentBase
	Implements IDocumentBase
	Private ReadOnly m_Source As XElement
	Private ReadOnly m_Connection As NetflixConnection

	Public ReadOnly Property Connection() As NetflixConnection
		Get
			Return m_Connection
		End Get
	End Property

	Protected Sub New(ByVal connection As NetflixConnection, ByVal source As String)
		m_Source = XDocument.Parse(source).Root
		m_Connection = connection
	End Sub

	Protected Sub New(ByVal connection As NetflixConnection, ByVal source As XElement)
		m_Source = source
		m_Connection = connection
	End Sub

	Public ReadOnly Property Source() As XElement Implements IDocumentBase.Source
		Get
			Return m_Source
		End Get
	End Property

End Class
