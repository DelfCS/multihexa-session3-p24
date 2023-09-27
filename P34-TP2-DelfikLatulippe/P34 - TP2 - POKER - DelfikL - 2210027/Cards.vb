Imports System.Security.Cryptography

Public Class Cards

    ' Where - 0 is Cubs - 1 is Spades - 2 is Hearts - 3 is Diamonds
    ' Where - 0 is ace - 1 is 2 - 2 is 3.... king is 12

    Shared _couleur = New Integer
    Shared _valeur = New Integer


    Sub New(c As Integer, v As Integer)
        _couleur = c
        _valeur = v
    End Sub




    ' Sub New()
    'Static valueGenerator As System.Random = New System.Random()
    '   _couleur = randomGenerator(4, valueGenerator)
    '  _valeur = randomGenerator(13, valueGenerator)
    'End Sub

    ReadOnly Property couleur As Integer
        Get
            Return _couleur
        End Get
    End Property

    ReadOnly Property valeur As Integer
        Get
            Return _valeur
        End Get
    End Property

    Public Property carte = couleur + valeur




End Class
