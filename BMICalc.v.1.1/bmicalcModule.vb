Module bmicalcModule
    Dim A, B, C, D, E, F, I, G As Primitive
    Sub Main()
        Program.Delay(3000)
        TextWindow.ForegroundColor = 1
        Program.Delay(1000)
        TextWindow.WriteLine(" /$$$$$$$  /$$      /$$ /$$$$$$                     /$$          ")
        Program.Delay(30)
        TextWindow.WriteLine("| $$__  $$| $$$    /$$$|_  $$_/                    | $$          ")
        Program.Delay(30)
        TextWindow.ForegroundColor = 2
        TextWindow.WriteLine("| $$  \ $$| $$$$  /$$$$  | $$    /$$$$$$$  /$$$$$$ | $$  /$$$$$$$")
        Program.Delay(30)
        TextWindow.WriteLine("| $$$$$$$ | $$ $$/$$ $$  | $$   /$$_____/ |____  $$| $$ /$$_____/")
        Program.Delay(30)
        TextWindow.ForegroundColor = 6
        TextWindow.WriteLine("| $$__  $$| $$  $$$| $$  | $$  | $$        /$$$$$$$| $$| $$      ")
        Program.Delay(30)
        TextWindow.WriteLine("| $$  \ $$| $$\  $ | $$  | $$  | $$       /$$__  $$| $$| $$      ")
        Program.Delay(30)
        TextWindow.ForegroundColor = 8
        TextWindow.WriteLine("| $$$$$$$/| $$ \/  | $$ /$$$$$$|  $$$$$$$|  $$$$$$$| $$|  $$$$$$$")
        Program.Delay(30)
        TextWindow.WriteLine("|_______/ |__/     |__/|______/ \_______/ \_______/|__/ \_______/")
        Program.Delay(790)
        TextWindow.ForegroundColor = 15
        TextWindow.WriteLine("")
        TextWindow.WriteLine("")
        TextWindow.WriteLine("")
        TextWindow.WriteLine("")
        TextWindow.WriteLine("Microsoft (R) Small Basic v.1.2")
        TextWindow.WriteLine("Copyright (R) Horizon Corp, Created with Microsoft (R) Small Basic")
        TextWindow.WriteLine("All Rights Reserved")
        TextWindow.ForegroundColor = 7
        TextWindow.Pause()
        TextWindow.Clear()
        TextWindow.ForegroundColor = 3
        TextWindow.Write("Enter your height in inches:")
        A = TextWindow.ReadNumber()
        B = A * 2.54
        C = A * 0.0254
        D = A * 0.0833
        TextWindow.ForegroundColor = 10
        Program.Delay(100)
        TextWindow.Write("Your Height in centimeter (cm) is:")
        TextWindow.WriteLine(B)
        Program.Delay(80)
        TextWindow.ForegroundColor = 11
        TextWindow.Write("Your Height in meter is:")
        TextWindow.WriteLine(C)
        Program.Delay(60)
        TextWindow.ForegroundColor = 14
        TextWindow.Write("Your height in feet is:")
        TextWindow.WriteLine(D)
        TextWindow.ForegroundColor = 7
        TextWindow.WriteLine("Press any key to continue the program...")
        TextWindow.PauseWithoutMessage()
        TextWindow.Clear()
        TextWindow.ForegroundColor = 15
        TextWindow.Write("Enter your weight in pounds:")
        E = TextWindow.ReadNumber()
        F = E * 0.453592
        TextWindow.ForegroundColor = 14
        TextWindow.Write("Your weight in kilogram is:")
        Program.Delay(80)
        TextWindow.WriteLine(F)
        I = C * C
        G = F / I
        TextWindow.ForegroundColor = 10
        TextWindow.Write("Your BMI is:")
        TextWindow.WriteLine(G)
        TextWindow.WriteLine("")
        Program.Delay(60)
        TextWindow.ForegroundColor = 14
        TextWindow.WriteLine("[BMI Less than 18.5 = Underweight]")
        TextWindow.WriteLine("")
        Program.Delay(30)
        TextWindow.ForegroundColor = 10
        TextWindow.WriteLine("[BMI 18.5 - 24.9 = Normal] ")
        TextWindow.WriteLine("")
        Program.Delay(30)
        TextWindow.ForegroundColor = 13
        TextWindow.WriteLine("[BMI 25.0 - 29.9 = Overweight]")
        TextWindow.WriteLine("")
        Program.Delay(30)
        TextWindow.ForegroundColor = 5
        TextWindow.WriteLine("[BMI 30.0 - 34.9 = Obesity (Class 1)]")
        TextWindow.WriteLine("")
        Program.Delay(30)
        TextWindow.ForegroundColor = 12
        TextWindow.WriteLine("[BMI 35.0 - 39.9 = Obesity (Class 2)]")
        TextWindow.WriteLine("")
        Program.Delay(30)
        TextWindow.ForegroundColor = 4
        TextWindow.WriteLine("[BMI More than 40.0 = Extreme Obesity]")
        TextWindow.WriteLine("")
        Program.Delay(30)
        TextWindow.ForegroundColor = 7
        TextWindow.WriteLine("Press any key to see the credits...")
        TextWindow.PauseWithoutMessage()
        TextWindow.Clear()
        TextWindow.ForegroundColor = 7
        TextWindow.WriteLine("Thank you for using this program.")
        TextWindow.ForegroundColor = 10
        TextWindow.WriteLine("   _______   __       __  ______   ______             __           ")
        TextWindow.WriteLine("  |       \ |  \     /  \|      \ /      \           |  \          ")
        TextWindow.WriteLine("  | $$$$$$$\| $$\   /  $$ \$$$$$$|  $$$$$$\  ______  | $$  _______ ")
        TextWindow.WriteLine("  | $$__/ $$| $$$\ /  $$$  | $$  | $$   \$$ |      \ | $$ /       \")
        TextWindow.WriteLine("  | $$    $$| $$$$\  $$$$  | $$  | $$        \$$$$$$\| $$|  $$$$$$$")
        TextWindow.WriteLine("  | $$$$$$$\| $$\$$ $$ $$  | $$  | $$   __  /      $$| $$| $$      ")
        TextWindow.WriteLine("  | $$__/ $$| $$ \$$$| $$ _| $$_ | $$__/  \|  $$$$$$$| $$| $$_____ ")
        TextWindow.WriteLine("  | $$    $$| $$  \$ | $$|   $$ \ \$$    $$ \$$    $$| $$ \$$     \")
        TextWindow.WriteLine("   \$$$$$$$  \$$      \$$ \$$$$$$  \$$$$$$   \$$$$$$$ \$$  \$$$$$$$")
        TextWindow.ForegroundColor = 7
        TextWindow.WriteLine("Copyright @2022 HorizonCorp")
        TextWindow.ForegroundColor = 11
        TextWindow.WriteLine("     _____                 ____   ____             _     ")
        TextWindow.WriteLine("    / ___/____ ___  ____ _/ / /  / __ )____ ______(_)____")
        TextWindow.WriteLine("    \__ \/ __ `__ \/ __ `/ / /  / __  / __ `/ ___/ / ___/")
        TextWindow.WriteLine("   ___/ / / / / / / /_/ / / /  / /_/ / /_/ (__  ) / /__  ")
        TextWindow.WriteLine("  /____/_/ /_/ /_/\__,_/_/_/  /_____/\__,_/____/_/\___/  ")
        TextWindow.ForegroundColor = 7
        TextWindow.WriteLine("Copyright (R) 1985 - 2015 Microsoft Corporation")
        TextWindow.ForegroundColor = 8
        TextWindow.Pause()
        Program.End()
    End Sub
End Module
