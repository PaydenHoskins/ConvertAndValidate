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
        Static aValidNumber As Integer
        Dim UserResponse As String
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
    'fuinction to run a comparison
    Function ConversionValid(UserResponse As String, ByRef aValidNumber As Integer) As Boolean
        Dim Status As Boolean
        Status = False

        Try
            aValidNumber = CInt(UserResponse)
            Status = True
        Catch ex As Exception

        End Try
        aValidNumber = aValidNumber

        Return (Status)
    End Function
End Module
