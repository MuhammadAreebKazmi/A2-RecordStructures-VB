Module Module1
    Structure PlayerInfo
        Dim PlayerID As String
        Dim PlayerName As String
        Dim Position As String
        Dim PlayedMatches As Integer
        Dim WinMatches As Integer
        Dim LostMatches As Integer
    End Structure
    Sub Main()
        Dim Player(10) As PlayerInfo
        Dim index As Integer = 0

        For index = 1 To 10
            Console.Write("Enter the player name: ")
            Player(index).PlayerName = Console.ReadLine

            Console.Write("Enter the player ID: ")
            Player(index).PlayerID = Console.ReadLine

            Console.Write("Enter the Position: ")
            Player(index).Position = Console.ReadLine

            Console.Write("Enter the played matches: ")
            Player(index).PlayedMatches = Console.ReadLine

            Console.Write("Enter the matches won: ")
            Player(index).WinMatches = Console.ReadLine

            Console.Write("Enter the matches lost: ")
            Player(index).LostMatches = Console.ReadLine

            Console.WriteLine(Player(index).PlayerID & " " & Player(index).PlayerName & " " & Player(index).Position & " " & Player(index).PlayedMatches & " " & Player(index).WinMatches & " " & Player(index).LostMatches)
        Next
        Console.ReadKey()
    End Sub

End Module
