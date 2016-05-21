Imports System
Imports System.IO
Imports System.Environment
Imports XBOX_Z.My
Imports Windows
Imports Microsoft.VisualBasic
Imports Microsoft.Win32
Imports Windows.System
Imports Windows.Data

Imports Windows.System.MemoryManager
' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage

    ' Create a collection of type CounterCreationDataCollection.


    Inherits Page
    Dim DoubleBytes As Double

    'Private objOS As Management.ManagementObjectSearcher
    'Private objCS As Management.ManagementObjectSearcher
    'Private objMgmt As Management.ManagementObject
    Private m_strComputerName As String
    Private m_strManufacturer As String
    Private m_StrModel As String
    Private m_strOSName As String
    Private m_strOSVersion As String
    Private m_strSystemType As String
    Private m_strTPM As String
    Private m_strWindowsDir As String
    Public Property SystemParameters As Object
    Public Property SystemParameters2 As Object

    Private Sub MainPage_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Try

            Dim msgBox = New messageBox()
            Dim ram As ULong = AppMemoryUsage + AppMemoryUsageLimit

            'If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim CalculatedSize As Decimal
            Dim TheSize As ULong

            Dim limitMEM As ULong = AppMemoryUsageLimit
            Dim MemUs As ULong = AppMemoryUsage
            Dim SizeType As String = "B"

            TheSize = limitMEM


            If TheSize < 1024 Then
                    CalculatedSize = TheSize

                ElseIf TheSize > 1024 AndAlso TheSize < (1024 ^ 2) Then 'KB
                    CalculatedSize = Math.Round((TheSize / 1024), 2)
                    SizeType = "KB"

                ElseIf TheSize > (1024 ^ 2) AndAlso TheSize < (1024 ^ 3) Then 'MB
                    CalculatedSize = Math.Round((TheSize / (1024 ^ 2)), 2)
                    SizeType = "MB"

                ElseIf TheSize > (1024 ^ 3) AndAlso TheSize < (1024 ^ 4) Then 'GB
                    CalculatedSize = Math.Round((TheSize / (1024 ^ 3)), 2)
                    SizeType = "GB"

                ElseIf TheSize > (1024 ^ 4) Then 'TB
                    CalculatedSize = Math.Round((TheSize / (1024 ^ 4)), 2)
                    SizeType = "TB"

                End If

            'lblScreenResolution.Text = ("File size is: " & CalculatedSize.ToString & " " & SizeType, "File size", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' End If

            txtCores.Text = ProcessorCount
            txtMem.Text = CalculatedSize.ToString & "" & SizeType
            'blScreenResolution.Text = S

        Catch ex As Exception


            lblScreenResolution.Text = ex.Message



        End Try

    End Sub


End Class
