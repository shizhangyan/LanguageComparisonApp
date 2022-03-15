Imports System.IO

Public Class Demos
    Implements IDemos

    Public Function LoadFile() As List(Of String) Implements IDemos.LoadFile
        Dim output As List(Of String) = New List(Of String)
        Dim lines As List(Of String) = File.ReadAllLines("c:\try\myfile.txt").ToList()

        For index = 0 To lines.Count - 1
            If index Mod 2 = 0 Then
                output.Add(lines(index))
            End If
        Next
        Return output
    End Function

    Public Sub PrintFullName(firstName As String, lastName As String) Implements IDemos.PrintFullName
        Console.WriteLine($"{ firstName} {lastName}")
    End Sub
End Class
