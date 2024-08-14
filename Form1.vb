Public Class Form1

    Dim archivo, extension, rutaDelEXE As String
    Dim rutaEXE As String
    Dim rutaDestino As String


    Private Sub ButtonORIGEN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonORIGEN.Click
        If OpenFileDialog1.ShowDialog Then
            TextBoxORIGEN.Text = OpenFileDialog1.FileName 'RUTA DEL ARCHIVO ORIGINAL
            archivo = System.IO.Path.GetFileNameWithoutExtension(TextBoxORIGEN.Text)

            Paso2()
        End If
    End Sub

    Private Sub ButtonIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIR.Click
        rutaDestino = My.Computer.FileSystem.SpecialDirectories.Desktop
        rutaDestino = rutaDestino & "\" & archivo & extension
        If rutaDestino.Length > 0 And TextBoxORIGEN.TextLength > 0 Then
            TextBoxDETALLES.Clear()
            Try
                Dim CONVERSOR As New Process
                CONVERSOR.StartInfo.FileName = rutaEXE 'RUTA EJECUTABLE
                CONVERSOR.StartInfo.Arguments = " -i """ + TextBoxORIGEN.Text + """ -ar 44100 -y """ + rutaDestino + """" 'ARGUMENTO
                CONVERSOR.StartInfo.UseShellExecute = False 'PARA QUE NO USE SHELL PARA ABRIR EL PROCESO
                CONVERSOR.StartInfo.RedirectStandardOutput = True 'PARA QUE REDIRIJA EL OUTPUT DEL PROCESO A NUESTRA APLICACION
                CONVERSOR.StartInfo.RedirectStandardError = True 'PARA QUE REDIRIJA EL ERROR DEL PROCESO A NUESTRA APLICACION
                CONVERSOR.StartInfo.CreateNoWindow = True 'PARA QUE NO MUESTRE LA VENTANA DEL PROCESO

                CONVERSOR.Start() 'INICIA LA EJECUCION

                While Not CONVERSOR.StandardError.EndOfStream
                    TextBoxDETALLES.AppendText(CONVERSOR.StandardError.ReadLine & vbCrLf) 'REGISTRA LOS DETALLES DE LA CONVERSION
                    Application.DoEvents()
                End While
                TextBoxORIGEN.Clear()
                MsgBox("Conversion Terminada y guardada en el Escritorio", MsgBoxStyle.Information, "By Marcelo") 'TERMINADO

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "by Marcelo")
            End Try

            Paso1()
        Else
            MsgBox("REVISA LAS RUTAS")
        End If

    End Sub



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        extension = "mp3"
        rutaDestino = My.Computer.FileSystem.SpecialDirectories.Desktop
        'rutaEXE = My.Computer.FileSystem.SpecialDirectories.Temp & "\ffmpeg.exe"
        'rutaEXE = Environment.GetFolderPath(Environment.SpecialFolder.System) & "\ffmpeg.exe"
        rutaEXE = "C:\Temp\ffmpeg.exe"
        '
        If FileIO.FileSystem.FileExists(rutaEXE) Then
            ButtonBuscarEXE.Hide()
            Paso1()
        Else
            ButtonORIGEN.Enabled = False
            ButtonIR.Enabled = False
            ButtonBuscarEXE.Show()

        End If



    End Sub

    Private Sub ButtonBuscarExe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscarEXE.Click
        If FolderBrowserDialog1.ShowDialog Then
            rutaDelEXE = FolderBrowserDialog1.SelectedPath & "\ffmpeg.exe"
            If FileIO.FileSystem.FileExists(rutaDelEXE) Then
                FileCopy(rutaDelEXE, rutaEXE)
            Else
                MessageBox.Show("Archivo no encontrado en " & rutaDelEXE & vbCrLf)

            End If
        End If

    End Sub

    Private Sub Paso1()
        ButtonORIGEN.Enabled = True
        ButtonIR.Enabled = False

        TextBoxDETALLES.Hide()

        Btn_Cancelar.BackColor = Color.DarkGray
        ButtonORIGEN.BackColor = Color.Green
        ButtonIR.BackColor = Color.DarkGray

        ButtonORIGEN.Focus()
    End Sub

    Private Sub Paso2()
        ButtonORIGEN.Enabled = False
        ButtonIR.Enabled = True

        TextBoxDETALLES.Hide()
        Btn_Cancelar.BackColor = Color.Green
        ButtonIR.BackColor = Color.Green
        ButtonORIGEN.BackColor = Color.DarkGray

        ButtonIR.Focus()
    End Sub

    Private Sub Btn_Cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Cancelar.Click
        Paso1()
    End Sub
End Class
