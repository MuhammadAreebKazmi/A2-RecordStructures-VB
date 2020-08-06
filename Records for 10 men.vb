Module Module1
    Structure EMPLOYEE
        Dim HoursWorked As Integer
        Dim EmpID As String
        Dim PerHourRate As Integer
        Dim AmountToBePaid As Integer
    End Structure

    Sub Main()
        Dim Employee(10) As EMPLOYEE
        Dim index As Integer = 0

        For index = 1 To 10
            Console.Write("Enter hours worked:")
            Employee(index).HoursWorked = Console.ReadLine

            Console.Write("Enter EmplyerID")
            Employee(index).EmpID = Console.ReadLine

            Console.Write("Enter Perhour rate")
            Employee(index).PerHourRate = Console.ReadLine

            Employee(index).AmountToBePaid = Employee(index).HoursWorked * Employee(index).PerHourRate


            Console.WriteLine(Employee(index).EmpID & " " & Employee(index).HoursWorked & " " & Employee(index).PerHourRate & " " & Employee(index).AmountToBePaid)
        Next
        Console.ReadKey()
    End Sub

End Module
