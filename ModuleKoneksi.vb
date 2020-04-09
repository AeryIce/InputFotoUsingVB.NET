Imports System.Data.SqlClient
Module ModuleKoneksi
	Public Cmd As SqlCommand
	Public Conn As SqlConnection

	Sub Koneksi()
		Try
			Conn = New SqlConnection("Data Source = AERYICE-PC666\SQLEXPRESS2012; Initial Catalog = InputFoto;Integrated Security = True")
			Conn.Open()
			FormInputFoto.LabelStatusDb.Text = "Connected"

		Catch ex As Exception
			FormInputFoto.LabelStatusDb.Text = "Not Connected"
		End Try

	End Sub
End Module
