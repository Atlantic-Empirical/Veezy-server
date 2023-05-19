'Copyright (c) 2008, Jonathan Allen

Public Class DocumentCollectionBase(Of T)
	Inherits ObjectModel.Collection(Of T) 'TODO: Make a ReadOnly collection that is interanlly mutable
	Implements IDocumentBase

	Private m_Source As XElement

	Protected Sub New(ByVal source As String)
		MyBase.New()
		m_Source = XDocument.Parse(source).Root
	End Sub

	Protected Sub New(ByVal source As XElement)
		m_Source = source
	End Sub

	Public ReadOnly Property Source() As XElement Implements IDocumentBase.Source
		Get
			Return m_Source
		End Get
	End Property
End Class
