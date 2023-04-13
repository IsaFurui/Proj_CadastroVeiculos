Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub img_montadora_Click(sender As System.Object, e As System.EventArgs) Handles img_montadora.Click
        With carregar_foto
            .Title = "Selecione uma foto"
            .InitialDirectory = Application.StartupPath & "\MONTADORAS\"
            .ShowDialog()
            diretorio = .FileName
            img_montadora.Load(diretorio)
        End With
    End Sub

    Private Sub RENAVAM_DoubleClick(sender As Object, e As EventArgs) Handles txt_renavam.DoubleClick
        limpar_cadastro()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            sql = "select * from tb_veiculos where renavam='" & txt_renavam.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tb_veiculos(renavam, descricao, montadora, placa, cor, valor, foto) values ('" & txt_renavam.Text & "', '" & txt_descricao.Text & "', '" & cmb_montadora.Text & "', '" & txt_placa.Text & "', '" & cmb_cor.Text & "', '" & txt_valor.Text & "', '" & diretorio & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados Gravados com Sucesso!")
                limpar_cadastro()
            Else
                MsgBox("Cliente já cadastrado!")
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÂO")
        End Try
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        Try
            If txt_renavam.Text = "" Then
                MsgBox("Para excluir, digite o RENAVAM", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                Exit Sub
            Else
                sql = "select * from tb_veiculos where renavam='" & txt_renavam.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    sql = "delete * from tb_veiculos where renavam='" & txt_renavam.Text & "'"
                    rs = db.Execute(sql)
                    MsgBox("RENAVAM excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    limpar_cadastro()
                Else
                    MsgBox("RENAVAM não encontrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao EXCLUIR", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub btn_pesquisar_Click(sender As Object, e As EventArgs) Handles btn_pesquisar.Click
        Try
            sql = "select * from tb_veiculos where renavam='" & txt_renavam.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_descricao.Text = rs.Fields(1).Value
                cmb_montadora.Text = rs.Fields(2).Value
                txt_placa.Text = rs.Fields(3).Value
                cmb_cor.Text = rs.Fields(4).Value
                txt_valor.Text = rs.Fields(5).Value
                img_montadora.Load(rs.Fields(6).Value)
            Else
                MsgBox("RENAVAM não localizado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Erro ao pesquisar", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÂO")
        End Try
    End Sub

    Private Sub cmb_montadora_LostFocus(sender As Object, e As EventArgs) Handles cmb_montadora.LostFocus
        Try
            If cmb_montadora.Text = "Chevrolet" Then
                img_montadora.Load(Application.StartupPath & "\MONTADORAS\Chevrolet.png")
            ElseIf cmb_montadora.Text = "Ford" Then
                img_montadora.Load(Application.StartupPath & "\MONTADORAS\Ford.png")
            ElseIf cmb_montadora.Text = "BMW" Then
                img_montadora.Load(Application.StartupPath & "\MONTADORAS\BWM.png")
            ElseIf cmb_montadora.Text = "Citroën" Then
                img_montadora.Load(Application.StartupPath & "\MONTADORAS\Citroen.png")
            ElseIf cmb_montadora.Text = "Fiat" Then
                img_montadora.Load(Application.StartupPath & "\MONTADORAS\Fiat.png")
            ElseIf cmb_montadora.Text = "Honda" Then
                img_montadora.Load(Application.StartupPath & "\MONTADORAS\Honda.png")
            ElseIf cmb_montadora.Text = "Hyundai" Then
                img_montadora.Load(Application.StartupPath & "\MONTADORAS\Hyundai.png")
            ElseIf cmb_montadora.Text = "Nissan" Then
                img_montadora.Load(Application.StartupPath & "\MONTADORAS\Nissan.png")
            ElseIf cmb_montadora.Text = "Peugeot" Then
                img_montadora.Load(Application.StartupPath & "\MONTADORAS\Peugeot.png")
            ElseIf cmb_montadora.Text = "Toyota" Then
                img_montadora.Load(Application.StartupPath & "\MONTADORAS\Toyota.png")
            ElseIf cmb_montadora.Text = "Volvo" Then
                img_montadora.Load(Application.StartupPath & "\MONTADORAS\Volvo.png")
            ElseIf cmb_montadora.Text = "Volkswagen" Then
                img_montadora.Load(Application.StartupPath & "\MONTADORAS\Volkswagen.png")
            End If
        Catch ex As Exception
            MsgBox("Erro ao exibir foto de conssecionária", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÂO")
        End Try
    End Sub
End Class
