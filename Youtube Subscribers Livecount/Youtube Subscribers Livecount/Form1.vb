Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Net
Imports System.Threading.Tasks

Public Class Form1

    Dim ID As String

    Public Sub New()
        InitializeComponent()
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Public Sub Livecounts()
        lname.Text = Regex.Match(New Net.WebClient().DownloadString("https://www.youtube.com/channel/" & ID), "<meta name=""title"" content=""(.*?)"">").Groups(1).Value
Live:
        Using x As New WebClient
            x.Encoding = Encoding.UTF8
            lcount.Text = FormatNumber(Regex.Match(x.DownloadString("https://www.googleapis.com/youtube/v3/channels?part=statistics&id=" & ID & "&fields=items(statistics(commentCount%2CsubscriberCount%2CvideoCount%2CviewCount))&key=AIzaSyA1n4M-fo2Y5NHUj0RsvXEAis3H6_lIjRg"), """subscriberCount"": ""(.*?)"",").Groups(1).Value, 0, TriState.True)
        End Using
        GoTo Live

    End Sub

    Private Sub lname_Click(sender As Object, e As EventArgs) Handles lname.Click
        ID = InputBox("Insert Channel ID", "Insert Channel ID", "")
        If ID = Nothing Then
            Exit Sub
        End If
        Dim SLAYER As Task = Task.Factory.StartNew(AddressOf Livecounts)
    End Sub
End Class
