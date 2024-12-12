Public Structure Account
    Dim usrName As String
    Dim pin As String
    Dim money As Single
End Structure

Public Class Form1
    Public a As Account



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call SignUp()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Login()
    End Sub

    Sub Login()
        Dim namePut As String
        Dim passPut As String

        namePut = InputBox("What's your username?")
        passPut = InputBox("What's your password?")


        If a.usrName = namePut And a.pin = passPut Then
            MsgBox("Authentication Successful.")
            MainPage.Show()
            Me.Hide()
        Else
            MsgBox("Your username or PIN was incorrect. Try again.")
        End If
    End Sub

    Sub SignUp()
        Dim name As String
        Dim pass As Integer


        MsgBox("Thanks for choosing XYZ Bank! Before you start your exquisite financial journey, we need some information from you.", MsgBoxStyle.Information, "Signup")

        name = InputBox("What's your username?", "Signup")
        a.usrName = name
        pass = InputBox("Cool " & name & "! Now, what's your PIN? Keep it so hard to guess that hackers won't have an easy chance of taking your money, but easy enough for you to remember! 5 characters is the limit.", "Signup")

        If pass.ToString().Length >= 5 Then
            MsgBox("Error! You have entered a PIN that's too big. Try Again.")
            pass = InputBox("Cool " & name & "! Now, what's your PIN? Keep it so hard to guess that hackers won't have an easy chance of taking your money, but easy enough for you to remember! 5 characters is the limit.", "Signup")
        Else
            a.pin = pass
        End If

        MsgBox("You have now completed the sign up process for XYZ Bank - simple, right? - We look forward to banking with you.")
    End Sub
End Class
