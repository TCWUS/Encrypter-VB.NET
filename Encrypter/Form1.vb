Imports System.Net
Public Class Form1
    Dim wclient As New System.Net.WebClient
    Public Function startup()
        If My.Computer.Network.Ping("www.tcwapihandler.download") Then

        Else
            MessageBox.Show("Could not connect to the api server")
        End If
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startup()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim method As String
        If rbtnMD5.Checked = True Then
            method = "md5"
        ElseIf rbtnBlowfish.Checked = True Then
            method = "blowfish"
        ElseIf rbtnSha256.Checked = True Then
            method = "sha256"
        End If
        Dim r As String = wclient.DownloadString("https://tcwapihandler.download/" + method + ".php?text=" + txtText.Text)

        txtOutput.Text = r
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
