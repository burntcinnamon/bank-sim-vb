Public Class MainPage
    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HiText.Text = "Hi " + Form1.a.usrName + "!"

        moneyTxt.Text = "£" & Form1.a.money
    End Sub

    Private Sub depositBtn_Click(sender As Object, e As EventArgs) Handles depositBtn.Click
        Dim moneyInput As Single ' input of deposit

        moneyInput = InputBox("How much money do you want to deposit?")

        Call DepositMoney(moneyInput)
    End Sub

    Sub DepositMoney(money As Single)
        Form1.a.money += money

        moneyTxt.Text = "£" & Form1.a.money
    End Sub

    Private Sub withdrawBtn_Click(sender As Object, e As EventArgs) Handles withdrawBtn.Click
        Dim moneyInput As Single ' withdraw amount

        moneyInput = InputBox("How much do you want to widthdraw from your account?")

        WithdrawMoney(moneyInput)
    End Sub

    Sub WithdrawMoney(money As Single)
        Form1.a.money -= money

        moneyTxt.Text = "£" & Form1.a.money
    End Sub

    Private Sub logOutBtn_Click(sender As Object, e As EventArgs) Handles logOutBtn.Click
        Call logOut()
    End Sub

    Sub logOut()
        MsgBox("Goodbye, we hope you come back soon!", , "Goodbye!")

        Me.Hide()
        Form1.Show()
    End Sub
End Class