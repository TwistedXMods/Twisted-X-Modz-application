Public Class frmMain
    Private Sub btnFoods_Click(sender As Object, e As EventArgs) Handles btnFoods.Click
        Process.Start("http://terrormodz.tk")
    End Sub

    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click

    End Sub

    Private Sub btnDeserts_Click(sender As Object, e As EventArgs) Handles btnDeserts.Click
        Form2.Show()
    End Sub

    Private Sub btnMyCart_Click(sender As Object, e As EventArgs) Handles btnMyCart.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\Twisted AI.exe")
    End Sub

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        Form1.Show()
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub picMaximize_Click(sender As Object, e As EventArgs) Handles picMaximize.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://discord.io/TwistedXModz")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://twistedxmodz.com")
        Process.Start("https://www.youtube.com/c/TwistedExecutor")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("https://twistedxmodz.com/index.php?adcreditshop-categories/shop.1/view")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\RGHC.exe")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\Smokey Bo1.exe")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\Bo2 Shit.exe")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\R34sMods.exe")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\ZambiesV3.exe")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\GtaV 100% Save Injector.exe")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\Tsunami.exe")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\Project Rebirth.exe")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\Blue Sky Tool.exe")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\VexSpoofer.exe")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\KV_Checker.exe")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\RecoveryTool.exe")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\MSP-Spoofer.exe")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim Ip As String
        Ip = TextBox1.Text
        If My.Computer.Network.Ping(Ip) Then
            Label3.ForeColor = Color.Green
            MsgBox("Online")
        Else
            Label3.ForeColor = Color.Red
            MsgBox("Offline")
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs)
        Process.Start("C:\Program Files (x86)\Twisted Modz\XBOX360 SDK.exe")
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)
        Process.Start("C:\Program Files (x86)\Twisted Modz\rufus-3.4.exe")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs)
        Process.Start("C:\Program Files (x86)\Twisted Modz\VMware 14.exe")
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs)
        Process.Start("C:\Program Files (x86)\Twisted Modz\VirtualBox.exe")
    End Sub

    Private Sub Button18_Click_1(sender As Object, e As EventArgs) Handles Button18.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\XBOX360 SDK.exe")
    End Sub

    Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\rufus-3.4.exe")
    End Sub

    Private Sub Button20_Click_1(sender As Object, e As EventArgs) Handles Button20.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\VMware 14.exe")
    End Sub

    Private Sub Button21_Click_1(sender As Object, e As EventArgs) Handles Button21.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\VirtualBox.exe")
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\Notepad++Installer.exe")
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\DaVinci Resolve.exe")
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\OBS Studio.exe")
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\putty 64bit.exe")
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\Visual Studio 2017.exe")
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Process.Start("C:\Program Files (x86)\Twisted Modz\winrar-x64-561.exe")
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim FILE_NAME As String = "C:\Program Files (x86)\Twisted Modz\VMware 14 pro keys.txt"

        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub pnlTopSide_Paint(sender As Object, e As PaintEventArgs) Handles pnlTopSide.Paint

    End Sub
End Class
