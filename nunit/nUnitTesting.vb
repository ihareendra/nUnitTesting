Imports NUnit.Framework
Imports System


<TestFixture()> Public Class nUnitTesting

    Dim sortedNames As String
    Dim openFileDialog1 As String

    <SetUp()> Public Sub Init()
       

        openFileDialog1 = "[SMITH" + "," + " ANDREW" + Environment.NewLine + "BAKER" + "," + "THEODORE]"

    End Sub

    <Test()> Public Sub sortingNames()



        'sorting the names from the rich textbox 
        Dim LinesList As New List(Of String)
        LinesList.AddRange(openFileDialog1.Split)

        LinesList.Sort()



        For Each Str As String In LinesList
            sortedNames = (Str & Environment.NewLine)
        Next

        MsgBox(sortedNames)
    End Sub

End Class
