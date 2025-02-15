'Payden Hoskins

Option Explicit On
Option Compare Text
Option Strict On

Module ConvertAndValidate

    Sub Main()
        Dim aValidNumber As Integer
        Dim UserResponse As String
        Do

            Console.WriteLine($"Enter a number:")
            UserResponse = Console.ReadLine()
            aValidNumber = ConvertInteger(UserResponse, aValidNumber)
            If ConversionValid(UserResponse, aValidNumber) = True Then
                Console.WriteLine("Status ""Successful"".")
                Console.WriteLine($"{UserResponse} converted successfully to {aValidNumber}!")
            Else
                Console.WriteLine($"Oops, {UserResponse} does not seem to be a number")
            End If

        Loop

    End Sub
    'first fuinction to run a comparison
    Function ConversionValid(UserResponse As String, aValidNumber As Integer) As Boolean
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

    '2nd Function used to convert a string to integer
    Function ConvertInteger(UserResponse As String, aValidNumber As Integer) As Integer
        Try
            aValidNumber = CInt(UserResponse)
        Catch ex As Exception

        End Try
        Return (aValidNumber)
    End Function
End Module
