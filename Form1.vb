Imports System.Windows.Forms.VisualStyles
Public Class Form1
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim p1card As Integer
        Dim p2card As Integer
        p1card = Int(52 * Rnd()) + 1
        Do
            p2card = Int(52 * Rnd()) + 1
        Loop untilk p1card <> p2card 
        lblP1Card.Text = p1card
        lblP2Card.Text = p2card
        picP1Card.ImageLocation = "card graphics\" & getCardName(p1card) & ".png"
        picP2Card.ImageLocation = "card graphics\" & getCardName(p2card) & ".png"
        If snapDetect(p1card, p2card) = True Then
            MsgBox("Snap!")
        End If
    End Sub
    Private Function getCardName(cardNum) As String
        Dim result As String
        Select Case cardNum
            Case 1 : result = "ad"
            Case 2 : result = "2d"
            Case 3 : result = "3d"
            Case 4 : result = "4d"
            Case 5 : result = "5d"
            Case 6 : result = "6d"
            Case 7 : result = "7d"
            Case 8 : result = "8d"
            Case 9 : result = "9d"
            Case 10 : result = "td"
            Case 11 : result = "jd"
            Case 12 : result = "qd"
            Case 13 : result = "kd"
            Case 14 : result = "ah"
            Case 15 : result = "2h"
            Case 16 : result = "3h"
            Case 17 : result = "4h"
            Case 18 : result = "5h"
            Case 19 : result = "6h"
            Case 20 : result = "7h"
            Case 21 : result = "8h"
            Case 22 : result = "9h"
            Case 23 : result = "th"
            Case 24 : result = "jh"
            Case 25 : result = "qh"
            Case 26 : result = "kh"
            Case 27 : result = "ac"
            Case 28 : result = "2c"
            Case 29 : result = "3c"
            Case 30 : result = "4c"
            Case 31 : result = "5c"
            Case 32 : result = "6c"
            Case 33 : result = "7c"
            Case 34 : result = "8c"
            Case 35 : result = "9c"
            Case 36 : result = "tc"
            Case 37 : result = "jc"
            Case 38 : result = "qc"
            Case 39 : result = "kc"
            Case 40 : result = "as"
            Case 41 : result = "2s"
            Case 42 : result = "3s"
            Case 43 : result = "4s"
            Case 44 : result = "5s"
            Case 45 : result = "6s"
            Case 46 : result = "7s"
            Case 47 : result = "8s"
            Case 48 : result = "9s"
            Case 49 : result = "ts"
            Case 50 : result = "js"
            Case 51 : result = "qs"
            Case 52 : result = "ks"
        End Select
        Return result
    End Function

    Private Function snapDetect(p1card As Integer, p2card As Integer) As Boolean
        Dim result As Boolean
        If p1card Mod 13 = p2card Mod 13 Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function
End Class
