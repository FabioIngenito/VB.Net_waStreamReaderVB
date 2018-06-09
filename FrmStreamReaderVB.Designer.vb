<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStreamReaderVB
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblCurrentFile = New System.Windows.Forms.Label()
        Me.LblLastFile = New System.Windows.Forms.Label()
        Me.LblLinesOfText = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.TxtData = New System.Windows.Forms.TextBox()
        Me.BtnRemoveText = New System.Windows.Forms.Button()
        Me.TxtPathFileName = New System.Windows.Forms.TextBox()
        Me.lblPathFileName = New System.Windows.Forms.Label()
        Me.BtnChange = New System.Windows.Forms.Button()
        Me.lblTextOrigin = New System.Windows.Forms.Label()
        Me.TxtOrigin = New System.Windows.Forms.TextBox()
        Me.LblTextDestiny = New System.Windows.Forms.Label()
        Me.TxtDestiny = New System.Windows.Forms.TextBox()
        Me.LblFileNameDestinyRemove = New System.Windows.Forms.Label()
        Me.TxtPathNameFileDestiny = New System.Windows.Forms.TextBox()
        Me.LblFileNameDestinyChange = New System.Windows.Forms.Label()
        Me.TxtPathNameFileChange = New System.Windows.Forms.TextBox()
        Me.RbtYes = New System.Windows.Forms.RadioButton()
        Me.RbtNo = New System.Windows.Forms.RadioButton()
        Me.lblDeleteFileDestiny = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblCurrentFile
        '
        Me.LblCurrentFile.Location = New System.Drawing.Point(12, 473)
        Me.LblCurrentFile.Name = "LblCurrentFile"
        Me.LblCurrentFile.Size = New System.Drawing.Size(370, 16)
        Me.LblCurrentFile.TabIndex = 20
        Me.LblCurrentFile.Text = "Arquivo aberto: Nenhum"
        '
        'LblLastFile
        '
        Me.LblLastFile.Location = New System.Drawing.Point(12, 457)
        Me.LblLastFile.Name = "LblLastFile"
        Me.LblLastFile.Size = New System.Drawing.Size(370, 16)
        Me.LblLastFile.TabIndex = 19
        Me.LblLastFile.Text = "Último arquivo aberto:"
        '
        'LblLinesOfText
        '
        Me.LblLinesOfText.Location = New System.Drawing.Point(12, 441)
        Me.LblLinesOfText.Name = "LblLinesOfText"
        Me.LblLinesOfText.Size = New System.Drawing.Size(179, 16)
        Me.LblLinesOfText.TabIndex = 18
        Me.LblLinesOfText.Text = "Número de linhas lidas: 0"
        '
        'BtnClear
        '
        Me.BtnClear.Enabled = False
        Me.BtnClear.Location = New System.Drawing.Point(310, 41)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 2
        Me.BtnClear.Text = "&Limpar"
        '
        'BtnOpen
        '
        Me.BtnOpen.Location = New System.Drawing.Point(310, 12)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(75, 23)
        Me.BtnOpen.TabIndex = 1
        Me.BtnOpen.Text = "&Abrir"
        '
        'TxtData
        '
        Me.TxtData.Location = New System.Drawing.Point(12, 12)
        Me.TxtData.Multiline = True
        Me.TxtData.Name = "TxtData"
        Me.TxtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtData.Size = New System.Drawing.Size(289, 192)
        Me.TxtData.TabIndex = 21
        '
        'BtnRemoveText
        '
        Me.BtnRemoveText.Enabled = False
        Me.BtnRemoveText.Location = New System.Drawing.Point(310, 152)
        Me.BtnRemoveText.Name = "BtnRemoveText"
        Me.BtnRemoveText.Size = New System.Drawing.Size(75, 23)
        Me.BtnRemoveText.TabIndex = 3
        Me.BtnRemoveText.Text = "&Remover"
        '
        'TxtPathFileName
        '
        Me.TxtPathFileName.Location = New System.Drawing.Point(9, 232)
        Me.TxtPathFileName.Name = "TxtPathFileName"
        Me.TxtPathFileName.Size = New System.Drawing.Size(373, 20)
        Me.TxtPathFileName.TabIndex = 6
        '
        'lblPathFileName
        '
        Me.lblPathFileName.AutoSize = True
        Me.lblPathFileName.Location = New System.Drawing.Point(12, 216)
        Me.lblPathFileName.Name = "lblPathFileName"
        Me.lblPathFileName.Size = New System.Drawing.Size(145, 13)
        Me.lblPathFileName.TabIndex = 5
        Me.lblPathFileName.Text = "Caminho e Nome do Arquivo:"
        '
        'BtnChange
        '
        Me.BtnChange.Enabled = False
        Me.BtnChange.Location = New System.Drawing.Point(310, 181)
        Me.BtnChange.Name = "BtnChange"
        Me.BtnChange.Size = New System.Drawing.Size(75, 23)
        Me.BtnChange.TabIndex = 4
        Me.BtnChange.Text = "A&lterar"
        '
        'lblTextOrigin
        '
        Me.lblTextOrigin.AutoSize = True
        Me.lblTextOrigin.Location = New System.Drawing.Point(12, 261)
        Me.lblTextOrigin.Name = "lblTextOrigin"
        Me.lblTextOrigin.Size = New System.Drawing.Size(88, 13)
        Me.lblTextOrigin.TabIndex = 7
        Me.lblTextOrigin.Text = "Texto de Origem:"
        '
        'TxtOrigin
        '
        Me.TxtOrigin.Location = New System.Drawing.Point(109, 258)
        Me.TxtOrigin.Name = "TxtOrigin"
        Me.TxtOrigin.Size = New System.Drawing.Size(273, 20)
        Me.TxtOrigin.TabIndex = 8
        Me.TxtOrigin.Text = "dddddddd"
        '
        'LblTextDestiny
        '
        Me.LblTextDestiny.AutoSize = True
        Me.LblTextDestiny.Location = New System.Drawing.Point(12, 287)
        Me.LblTextDestiny.Name = "LblTextDestiny"
        Me.LblTextDestiny.Size = New System.Drawing.Size(91, 13)
        Me.LblTextDestiny.TabIndex = 9
        Me.LblTextDestiny.Text = "Texto de Destino:"
        '
        'TxtDestiny
        '
        Me.TxtDestiny.Location = New System.Drawing.Point(109, 284)
        Me.TxtDestiny.Name = "TxtDestiny"
        Me.TxtDestiny.Size = New System.Drawing.Size(273, 20)
        Me.TxtDestiny.TabIndex = 10
        Me.TxtDestiny.Text = "Replacement"
        '
        'LblFileNameDestinyRemove
        '
        Me.LblFileNameDestinyRemove.AutoSize = True
        Me.LblFileNameDestinyRemove.Location = New System.Drawing.Point(12, 312)
        Me.LblFileNameDestinyRemove.Name = "LblFileNameDestinyRemove"
        Me.LblFileNameDestinyRemove.Size = New System.Drawing.Size(254, 13)
        Me.LblFileNameDestinyRemove.TabIndex = 11
        Me.LblFileNameDestinyRemove.Text = "Caminho e Nome do Arquivo Destino para Remover:"
        '
        'TxtPathNameFileDestiny
        '
        Me.TxtPathNameFileDestiny.Location = New System.Drawing.Point(9, 328)
        Me.TxtPathNameFileDestiny.Name = "TxtPathNameFileDestiny"
        Me.TxtPathNameFileDestiny.Size = New System.Drawing.Size(373, 20)
        Me.TxtPathNameFileDestiny.TabIndex = 12
        Me.TxtPathNameFileDestiny.Text = "C:\Temp\Tester.txt"
        '
        'LblFileNameDestinyChange
        '
        Me.LblFileNameDestinyChange.AutoSize = True
        Me.LblFileNameDestinyChange.Location = New System.Drawing.Point(12, 358)
        Me.LblFileNameDestinyChange.Name = "LblFileNameDestinyChange"
        Me.LblFileNameDestinyChange.Size = New System.Drawing.Size(241, 13)
        Me.LblFileNameDestinyChange.TabIndex = 13
        Me.LblFileNameDestinyChange.Text = "Caminho e Nome do Arquivo Destino para Alterar:"
        '
        'TxtPathNameFileChange
        '
        Me.TxtPathNameFileChange.Location = New System.Drawing.Point(9, 374)
        Me.TxtPathNameFileChange.Name = "TxtPathNameFileChange"
        Me.TxtPathNameFileChange.Size = New System.Drawing.Size(373, 20)
        Me.TxtPathNameFileChange.TabIndex = 14
        Me.TxtPathNameFileChange.Text = "C:\Temp\Tester2.txt"
        '
        'RbtYes
        '
        Me.RbtYes.AutoSize = True
        Me.RbtYes.Checked = True
        Me.RbtYes.Location = New System.Drawing.Point(234, 404)
        Me.RbtYes.Name = "RbtYes"
        Me.RbtYes.Size = New System.Drawing.Size(42, 17)
        Me.RbtYes.TabIndex = 16
        Me.RbtYes.TabStop = True
        Me.RbtYes.Text = "Sim"
        Me.RbtYes.UseVisualStyleBackColor = True
        '
        'RbtNo
        '
        Me.RbtNo.AutoSize = True
        Me.RbtNo.Location = New System.Drawing.Point(282, 404)
        Me.RbtNo.Name = "RbtNo"
        Me.RbtNo.Size = New System.Drawing.Size(45, 17)
        Me.RbtNo.TabIndex = 17
        Me.RbtNo.Text = "Não"
        Me.RbtNo.UseVisualStyleBackColor = True
        '
        'lblDeleteFileDestiny
        '
        Me.lblDeleteFileDestiny.AutoSize = True
        Me.lblDeleteFileDestiny.Location = New System.Drawing.Point(12, 408)
        Me.lblDeleteFileDestiny.Name = "lblDeleteFileDestiny"
        Me.lblDeleteFileDestiny.Size = New System.Drawing.Size(217, 13)
        Me.lblDeleteFileDestiny.TabIndex = 15
        Me.lblDeleteFileDestiny.Text = "Apaga Arquivo de Destino Antes de Gravar?"
        '
        'FrmStreamReaderVB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 497)
        Me.Controls.Add(Me.lblDeleteFileDestiny)
        Me.Controls.Add(Me.RbtNo)
        Me.Controls.Add(Me.RbtYes)
        Me.Controls.Add(Me.LblFileNameDestinyChange)
        Me.Controls.Add(Me.TxtPathNameFileChange)
        Me.Controls.Add(Me.LblFileNameDestinyRemove)
        Me.Controls.Add(Me.TxtPathNameFileDestiny)
        Me.Controls.Add(Me.LblTextDestiny)
        Me.Controls.Add(Me.TxtDestiny)
        Me.Controls.Add(Me.lblTextOrigin)
        Me.Controls.Add(Me.TxtOrigin)
        Me.Controls.Add(Me.BtnChange)
        Me.Controls.Add(Me.lblPathFileName)
        Me.Controls.Add(Me.TxtPathFileName)
        Me.Controls.Add(Me.BtnRemoveText)
        Me.Controls.Add(Me.LblCurrentFile)
        Me.Controls.Add(Me.LblLastFile)
        Me.Controls.Add(Me.LblLinesOfText)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.TxtData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmStreamReaderVB"
        Me.ShowIcon = False
        Me.Text = "StreamReader VB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCurrentFile As Label
    Friend WithEvents LblLastFile As Label
    Friend WithEvents LblLinesOfText As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnOpen As Button
    Friend WithEvents TxtData As TextBox
    Friend WithEvents BtnRemoveText As Button
    Friend WithEvents TxtPathFileName As TextBox
    Friend WithEvents lblPathFileName As Label
    Friend WithEvents BtnChange As Button
    Friend WithEvents lblTextOrigin As Label
    Friend WithEvents TxtOrigin As TextBox
    Friend WithEvents LblTextDestiny As Label
    Friend WithEvents TxtDestiny As TextBox
    Friend WithEvents LblFileNameDestinyRemove As Label
    Friend WithEvents TxtPathNameFileDestiny As TextBox
    Friend WithEvents LblFileNameDestinyChange As Label
    Friend WithEvents TxtPathNameFileChange As TextBox
    Friend WithEvents RbtYes As RadioButton
    Friend WithEvents RbtNo As RadioButton
    Friend WithEvents lblDeleteFileDestiny As Label
End Class
