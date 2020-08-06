Module Module1
    Structure CitizenInfo
        Dim CitizenID As String
        Dim CitizenName As String
        Dim Address As String
        Dim BloodGroup As String
        Dim Age As Integer
        Dim Salary() As Integer
    End Structure
    Sub Main()
        Dim Citizen(2000) As CitizenInfo
        Dim index As Integer = 0
        Dim months As Integer = 1
        For index = 1 To 2000
            Console.Write("Enter the citizen ID: ")
            Citizen(index).CitizenName = Console.ReadLine

            Console.Write("Enter the name: ")
            Citizen(index).CitizenName = Console.ReadLine

            Console.Write("Enter their address: ")
            Citizen(index).Address = Console.ReadLine

            Console.Write("Enter their blood group: ")
            Citizen(index).BloodGroup = Console.ReadLine

            Console.Write("Enter the age of person: ")
            Citizen(index).Age = Console.ReadLine

            For months = 1 To 12
                Console.Write("Enter the salary for the month: ")
                Citizen(index).Salary(months) = Console.ReadLine
            Next

        Next
        For index = 1 To 2000
            Console.Write(Citizen(index).CitizenID & " " & Citizen(index).CitizenName & " " & Citizen(index).Address & " " & Citizen(index).BloodGroup & " " & Citizen(index).Age)
            For months = 1 To 12
                Console.WriteLine(Citizen(index).Salary(months))
            Next
        Next

        'or

        For index = 1 To 2000
            Console.WriteLine(Citizen(index).CitizenID)
            Console.WriteLine(Citizen(index).CitizenName)
            Console.WriteLine(Citizen(index).Address)
            Console.WriteLine(Citizen(index).BloodGroup)
            Console.WriteLine(Citizen(index).Age)
            For months = 1 To 12
                Console.WriteLine(Citizen(index).Salary(months))
            Next
        Next


        Console.ReadKey()
    End Sub

End Module
