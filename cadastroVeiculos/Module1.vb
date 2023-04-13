Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public diretorio = Application.StartupPath & "\BANCO\tb_cadastroVeiculos.accdb"
    Public sql As String

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.ACE.OLEDB.12.0;data source=" & diretorio)
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
        End Try
    End Sub

    Sub limpar_cadastro()
        With Form1
            .txt_renavam.Clear()
            .txt_descricao.Clear()
            .txt_valor.Clear()
            .txt_placa.Clear()
            .cmb_montadora.SelectedIndex = -1
            .cmb_cor.SelectedIndex = -1
            .img_montadora.Load(Application.StartupPath & "\FOTOS\foto_original.png")
        End With
    End Sub
End Module
