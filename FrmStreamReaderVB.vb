Public Class FrmStreamReaderVB
    Inherits System.Windows.Forms.Form

    Dim strLastFile As String = "None"
    Dim clsSR As ClsStreamReaderVB = New ClsStreamReaderVB()
    Public Remove_text As Integer = 1
    Public Replace_text As Integer = 2

    Private Sub FrmStreamReaderVB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' ABRE O ARQUIVO
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        'DECLARA UM OBJETO PARA A CLASSE OPENFILEDIALOG
        Dim objOpenFileDialog As OpenFileDialog = New OpenFileDialog()
        Dim intLineCount As Integer = 0

        'CONFIGURA A CAIXA
        With objOpenFileDialog
            .Filter = "Arquivos de texto (*.txt)|*.txt|Todos arquivos(*.*)|*.*"
            .FilterIndex = 1
            .InitialDirectory = "c:\temp\"
            .Title = "Abrir arquivo"
            .CheckFileExists = False
        End With

        'EXIBE O DIÁLOGO
        If objOpenFileDialog.ShowDialog = DialogResult.OK Then
            'PROCESSO O ARQUIVO ESCOLHIDO e CARREGA A CAIXA DE TEXTO 
            Me.TxtData.Text = clsSR.ProcessFile(objOpenFileDialog.FileName, intLineCount)
            'EXIBE O NÚMERO DE LINHAS
            Me.LblLinesOfText.Text = "Número de linhas lidas:  " & intLineCount - 1
            'EXIBE O ÚLTIMO ARQUIVO ABERTO
            Me.LblLastFile.Text = "Último arquivo aberto: " & strLastFile
            'EXIBE O ATUAL ARQUIVO
            Me.LblCurrentFile.Text = "Arquivo aberto: " & objOpenFileDialog.FileName
            'SALVA O NOVO ARQUIVO COMO ÚLTIMO ARQUIVO ABERTO
            strLastFile = objOpenFileDialog.FileName
            '
            Me.TxtPathFileName.Text = strLastFile

            'LIGA OS BOTÕES
            BtnClear.Enabled = True
            BtnRemoveText.Enabled = True
            BtnChange.Enabled = True
        End If

        'LIMPEZA
        objOpenFileDialog = Nothing

    End Sub

    ''' <summary>
    ''' Outra forma de abrir o arquivo
    ''' Baseado em:
    ''' https://www.portugal-a-programar.pt/forums/topic/25760-apagar-linhas-especificas-do-txt/
    ''' </summary>
    ''' <param name="startline">Procurar por esse texto</param>
    ''' <param name="endline">Substiruir por esse texto</param>
    ''' <param name="sFileName">Arquivo de saída</param>
    Public Sub Read(ByVal startline As String, ByVal endline As String, ByVal sFileName As String)
        Dim srFileReader As System.IO.StreamReader
        Dim sInputLine As String
        Dim watch As Boolean = False

        If IO.File.Exists(sFileName) Then
            srFileReader = System.IO.File.OpenText(sFileName)
            sInputLine = srFileReader.ReadLine()

            Do Until sInputLine Is Nothing

                If sInputLine = startline Then
                    watch = True
                End If

                If watch = True Then
                    TxtPathFileName.Text += sInputLine & vbCrLf
                End If

                If sInputLine = endline Then
                    watch = False
                End If

                sInputLine = srFileReader.ReadLine()
            Loop

        Else
            MsgBox("Arquivo não existe!")
        End If

    End Sub

    ''' <summary>
    ''' Esse botão chama a função "Modify_File" para remover o texto do arquivo passando algus parâmetros.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnRemoveText_Click(sender As Object, e As EventArgs) Handles BtnRemoveText.Click
        Dim blnApaga As Boolean = True

        If RbtYes.Checked Then blnApaga = False

        clsSR.Modify_File(strLastFile, TxtPathNameFileDestiny.Text, Remove_text, TxtOrigin.Text, TxtDestiny.Text, blnApaga)

        MessageBox.Show("O novo arquivo foi salvo modificado e a linha foi apagada.", "Linha Apagada!")
    End Sub

    ''' <summary>
    ''' Esse botão chama a função "Modify_File" para substituir o texto do arquivo passando algus parâmetros.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnChange_Click(sender As Object, e As EventArgs) Handles BtnChange.Click
        Dim blnApaga As Boolean = True

        If RbtYes.Checked Then blnApaga = False

        clsSR.Modify_File(strLastFile, TxtPathNameFileChange.Text, Replace_text, TxtOrigin.Text, TxtDestiny.Text, blnApaga)

        MessageBox.Show("O novo arquivo foi salvo modificado e a linha foi substituída.", "Linha Substituída!")
    End Sub

    ''' <summary>
    ''' LIMPA VARIÁVEIS / LIMPA CAMPOS DO FORMULÁRIO
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        'LIMPA VARIÁVEIS
        strLastFile = ""
        'LIMPA CAMPOS DO FORMULÁRIO
        Me.TxtData.Text = ""
        Me.TxtPathFileName.Text = ""
        Me.LblLinesOfText.Text = "Número de linhas lidas: 0"
        Me.LblLastFile.Text = "Último arquivo aberto : "
        Me.LblCurrentFile.Text = "Arquivo Aberto: Nenhum"

        'DESLIGA OS BOTÕES
        Me.BtnClear.Enabled = False
        Me.BtnRemoveText.Enabled = False
        Me.BtnChange.Enabled = False
        Me.BtnOpen.Select()
    End Sub

End Class
