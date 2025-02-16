'Payden Hoskins
'RCET2265
'Spring 2025
'ConvertAndValidate
'https://github.com/PaydenHoskins/ConvertAndValidate.git

Option Explicit On
Option Compare Text
Option Strict On

Module ConvertAndValidate

    Sub Main()
        'for testing the function add this to your Sub Main()
        Dim UserResponse As String
        Dim aValidNumber As Integer
        Do
            Console.WriteLine($"Enter a number:")
            UserResponse = Console.ReadLine()
            If ConversionValid(UserResponse, aValidNumber) = True Then
                Console.WriteLine($"{UserResponse} converted successfully to {aValidNumber}!")
            Else
                Console.WriteLine($"Oops, {UserResponse} does not seem to be a number")
            End If
        Loop
    End Sub
    'function to run a comparison
    Function ConversionValid(UserResponse As String, ByRef aValidNumber As Integer) As Boolean
        Dim Status As Boolean
        Status = False
        'Run the conversion and if it works the status returns true
        Try
            aValidNumber = CInt(UserResponse)
            Status = True
        Catch ex As Exception
            Status = False
        End Try
        Return (Status)
    End Function
End Module
