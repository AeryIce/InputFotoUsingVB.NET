Imports System.Data.SqlClient
Imports System.IO

Public Class FormInputFoto
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub FormInputFoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
    End Sub

    Private Sub ButtonPilihGambar_Click(sender As Object, e As EventArgs) Handles ButtonPilihGambar.Click
        OFDGambar.ShowDialog()
        PBGambar.Image = Image.FromFile(OFDGambar.FileName)
        PBGambar.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextBoxNoId.Text = ""
        PBGambar.Image = Nothing
    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        Call Koneksi()
        Dim Ms As New MemoryStream
        'Dim Cmd As New SqlCommand
        PBGambar.Image.Save(Ms, PBGambar.Image.RawFormat)
        'Dim Simpan As String = "INSERT INTO InputFoto (NoId,Foto) VALUES (@NoId,@Foto)"
        'Cmd.Parameters.Add("@NoId", SqlDbType.VarChar).Value = TextBoxNoId.Text
        'Cmd.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = Ms.ToArray()

        'Cmd = New SqlCommand(Simpan, Conn)
        'Cmd.ExecuteNonQuery()

        'MsgBox("DataTelah Tersimpan")
        Dim Command As New SqlCommand("INSERT INTO InputFoto (NoId,Foto) VALUES (@NoId,@Foto)", Conn)
        Command.Parameters.Add("@NoId", SqlDbType.VarChar).Value = TextBoxNoId.Text
        Command.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = Ms.ToArray()

        'Conn.Open()
        If Command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Sudah Tersimpan")
        Else
            MessageBox.Show("Gagal Menyimpan")
        End If

    End Sub
End Class
