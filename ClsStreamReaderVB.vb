Imports System.IO

Public Class ClsStreamReaderVB
    Public Remove_text As Integer = 1
    Public Replace_text As Integer = 2

    ''' <summary>
    ''' Carrega o arquivo e devolve o conteúdo e o número de linhas
    ''' </summary>
    ''' <param name="strFile">Recebe o arquivo</param>
    ''' <param name="intLineCount">Devolve o número de Linhas</param>
    ''' <returns>Retorna o conteúdo do aquivo</returns>
    Public Function ProcessFile(ByVal strFile As String, ByRef intLineCount As Integer) As String
        'DECLARA UM OBJETO PARA A CLASSE STREAMREADER
        Dim objReader As StreamReader
        Dim strLine As String = ""
        Dim strData As String = ""

        'ABRE O ARQUIVO
        objReader = File.OpenText(strFile)

        'FAZ UM LOOP CONTANDO E CARREGANDO AS LINHAS
        Do
            strLine = objReader.ReadLine
            intLineCount += 1
            strData &= strLine & vbCrLf
        Loop While strLine <> Nothing

        'LIMPEZA
        objReader.Close()
        objReader = Nothing

        Return strData
    End Function

    ''' <summary>
    ''' Modificar o arquivo
    ''' Baseado em:
    ''' https://www.portugal-a-programar.pt/forums/topic/25760-apagar-linhas-especificas-do-txt/
    ''' </summary>
    ''' <param name="sFileName">Arquivo de Origem</param>
    ''' <param name="Sfileoutput">Arquivo de Destino</param>
    ''' <param name="Operation">Tipo da Operação</param>
    ''' <param name="Str1">Texto a ser procurado dentro do Arquivo de Origem</param>
    ''' <param name="str2">Texto a ser substituído dentro do Arquivo de Origem</param>
    Public Sub Modify_File(ByVal sFileName As String, ByVal Sfileoutput As String, ByVal Operation As Integer, ByVal Str1 As String, ByVal str2 As String, ByVal blnDeleteFile As Boolean)
        Dim srFileReader As StreamReader
        Dim sInputLine As String
        Dim objStreamWriter As StreamWriter

        'Verificar se existe o arquivo origem
        If IO.File.Exists(sFileName) Then
            srFileReader = System.IO.File.OpenText(sFileName)
            sInputLine = srFileReader.ReadLine()

            'Apagar o arquivo destino caso exista
            'If IO.File.Exists(Sfileoutput) Then File.Delete(Sfileoutput)

            objStreamWriter = New IO.StreamWriter(Sfileoutput, blnDeleteFile, System.Text.Encoding.Default)

            Do Until sInputLine Is Nothing

                If sInputLine = Str1 Then
                    'Replace line
                    If Operation = 2 Then objStreamWriter.WriteLine(str2)

                Else
                    objStreamWriter.WriteLine(sInputLine)
                End If

                sInputLine = srFileReader.ReadLine()
            Loop

            objStreamWriter.Close()
        End If

    End Sub

End Class
