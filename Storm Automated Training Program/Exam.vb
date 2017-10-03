Imports System.Data.SqlClient
Imports System.Random

Public Class Exam



    Public Sub createExam(name, desc, vidurl, order)
        Dim exam_name As String
        Dim description As String
        Dim videoUrl As String
        Dim vidOrder As Integer

        vidOrder = order
        exam_name = name
        description = desc
        videoUrl = vidurl
        Dim random As New Random(CInt(Date.Now.Ticks And &HFFFF))
        random.Next()
        Dim testexamID As Integer = random.Next()

        If testexamID = 0 Then
            testexamID = random.Next()

        End If



        Dim testconnection As SqlConnection = Connection.getConnection()
        Dim checkdupes As String = "INSERT into [dbo].[Exam] ([Examid],[Exam_Name],[Exam_Description],[Clip_Address],[Order]) VALUES('" & testexamID & "','" & exam_name & "','" & description & "','" & videoUrl & "','" & vidOrder & "')"
        testconnection.Open()
        Dim command As New SqlCommand(checkdupes, testconnection)
        command.ExecuteNonQuery()
        testexamID = 0











    End Sub
End Class
