Imports System.Net


Imports System.Net.Dns
Public Class Form1
    Dim arquivo As String
    Dim url_intall As String
    Dim caminho As String

    WithEvents webclient1 As New WebClient
    WithEvents webclient2 As New WebClient


    Private Sub btn_baixar_Click(sender As Object, e As EventArgs) Handles btn_baixar.Click

        webclient2.DownloadFileAsync(New Uri("" & url_intall & ""), "" & caminho & " \ " & arquivo & "")

    End Sub

    Private Sub webclient2_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles webclient2.DownloadProgressChanged

        If barra.Value <> barra.Maximum Then
            barra.Maximum = e.TotalBytesToReceive
            barra.Value = e.BytesReceived
            lbl_valor.Text = (barra.Maximum)

        Else
            MsgBox("CONCLUIDO !")
            barra.Value = 0
        End If

    End Sub

    Private Sub links_mediworks()

        If lista.SelectedItem = "Mediworks 1" Then

            url_intall = "http://localhost:2605/novo/MediWorks.zip"
            arquivo = "MediWorks.zip"
        ElseIf lista.SelectedItem = "Mediworks 2" Then
            url_intall = "http://medilab.tecnologia.ws/download/Atualizacao/MediWorks80.7z"
            arquivo = "MediWorks80.7z"
        ElseIf lista.SelectedItem = "Mediworks 3" Then
            url_intall = "http://medilab.tecnologia.ws/download/Atualizacao/MediWorks80.7z"
            arquivo = "MediWorks80.7z"
        ElseIf lista.SelectedItem = "Mediworks 4" Then
            url_intall = "http://medilab.tecnologia.ws/download/Atualizacao/MediWorks80.7z"
            arquivo = "MediWorks80.7z"
        ElseIf lista.SelectedItem = "Mediworks 5" Then
            url_intall = "http://medilab.tecnologia.ws/download/Atualizacao/MediWorks80.7z"
            arquivo = "MediWorks80.7z"
        End If

    End Sub

    Private Sub links_medicenter()

        If lista.SelectedItem = "Medicenter 1" Then
            url_intall = "http://medilab.tecnologia.ws/download/Atualizacao/MediCenter.7z"
        ElseIf lista.SelectedItem = "Medicenter 2" Then
            url_intall = "http://medilab.tecnologia.ws/download/Atualizacao/MediCenter.7z"
        ElseIf lista.SelectedItem = "Medicenter 3" Then
            url_intall = "http://medilab.tecnologia.ws/download/Atualizacao/MediCenter.7z"
        ElseIf lista.SelectedItem = "Medicenter 4" Then
            url_intall = "http://medilab.tecnologia.ws/download/Atualizacao/MediCenter.7z"
        ElseIf lista.SelectedItem = "Medicenter 5" Then
            url_intall = "http://medilab.tecnologia.ws/download/Atualizacao/MediCenter.7z"
        End If


    End Sub

    Private Sub links_mediremote()

        If lista.SelectedItem = "Mediremote 1" Then
            url_intall = "http://medilab.tecnologia.ws/download/Atualizacao/MediRemote.7z"
        ElseIf lista.SelectedItem = "Mediremote 2" Then
            url_intall = "http://medilab.tecnologia.ws/download/Atualizacao/MediRemote.7z"
        ElseIf lista.SelectedItem = "Mediremote 3" Then
            url_intall = "http://medilab.tecnologia.ws/download/Atualizacao/MediRemote.7z"
        ElseIf lista.SelectedItem = "Mediremote 4" Then
            url_intall = "http://medilab.tecnologia.ws/download/Atualizacao/MediRemote.7z"
        ElseIf lista.SelectedItem = "Mediremote 5" Then
            url_intall = "http://medilab.tecnologia.ws/download/Atualizacao/MediRemote.7z"
        End If

    End Sub
    Private Sub links_medicapture()

        If lista.SelectedItem = "Medicapture 1" Then
            capture = "http://medilab.tecnologia.ws/download/Atualizacao/MediRemote.7z"
        ElseIf lista.SelectedItem = "Medicapture 2" Then
            capture = "http://medilab.tecnologia.ws/download/Atualizacao/MediRemote.7z"
        ElseIf lista.SelectedItem = "Medicapture 3" Then
            capture = "http://medilab.tecnologia.ws/download/Atualizacao/MediRemote.7z"
        ElseIf lista.SelectedItem = "Medicapture 4" Then
            capture = "http://medilab.tecnologia.ws/download/Atualizacao/MediRemote.7z"
        ElseIf lista.SelectedItem = "Medicapture 5" Then
            capture = "http://medilab.tecnologia.ws/download/Atualizacao/MediRemote.7z"
        End If

    End Sub

    Private Sub lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista.SelectedIndexChanged
        links_mediworks()
        links_medicenter()
        links_mediremote()
        links_medicapture()
        btn_baixar.Enabled = True
        'nome_software.Text = lista.SelectedItem.ToString()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        links_mediworks()

        extrair_arquivos()

    End Sub

    Private Sub btn_mediworks_Click(sender As Object, e As EventArgs) Handles btn_mediworks.Click
        lista.Items.Clear()
        lista.Items.Add("Mediworks 1")
        lista.Items.Add("Mediworks 2")
        lista.Items.Add("Mediworks 3")
        lista.Items.Add("Mediworks 4")
        lista.Items.Add("Mediworks 5")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lista.Items.Clear()
        lista.Items.Add("Medicenter 1")
        lista.Items.Add("Medicenter 2")
        lista.Items.Add("Medicenter 3")
        lista.Items.Add("Medicenter 4")
        lista.Items.Add("Medicenter 5")

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        lista.Items.Clear()
        lista.Items.Add("Mediremote 1")
        lista.Items.Add("Mediremote 2")
        lista.Items.Add("Mediremote 3")
        lista.Items.Add("Mediremote 4")
        lista.Items.Add("Mediremote 5")

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        lista.Items.Clear()
        lista.Items.Add("Medicapture 1")
        lista.Items.Add("Medicapture 2")
        lista.Items.Add("Medicapture 3")
        lista.Items.Add("Medicapture 4")
        lista.Items.Add("Medicapture 5")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.pasta_dialog.ShowDialog()
        txt_caminho.Text = pasta_dialog.SelectedPath

        If txt_caminho.Text = "" Then
            btn_baixar.Enabled = False
        Else
            btn_baixar.Enabled = True

        End If
        '' MsgBox(caminho , arquivo"""")

        MsgBox("""" & caminho & "\" & arquivo & """")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_baixar.Enabled = False
        caminho = txt_caminho.Text

    End Sub


    Private Sub extrair_arquivos()

        Dim sc As New Shell32.Shell
        Dim _pasta As Shell32.Folder = sc.NameSpace("C:\medilab")

        'Dim _arquivo As Shell32.Folder = sc.NameSpace("" & caminho & "\" & arquivo & "")

        Dim _arquivo As Shell32.Folder = sc.NameSpace("C:\medilab\MediWorks.zip")

        _pasta.CopyHere(_arquivo.Items, 4)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Este trecho de código mostra como obter o IP
        'da máquina local



            Dim h As IPHostEntry = GetHostEntry(GetHostName)
            Dim IP As String = CType(h.AddressList.GetValue(0),  _
              IPAddress).ToString()

        MsgBox("O IP local é: " & IP)

        ' Console.WriteLine("Pressione uma tecla para sair...")
        'Console.ReadKey()
        End Sub


End Class
