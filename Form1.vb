Public Class Form1
    Friend Hasil As Single = 0
    Dim operasi As String = ""
    Dim operasiHitung As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operasiHitung = False
        operasi = ""
        Hasil = 0
        txtHasil.Text = "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If operasiHitung = True Or txtHasil.Text = "0" Then
            txtHasil.Text = "1"
            operasiHitung = False
        Else
            txtHasil.Text = txtHasil.Text + "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If operasiHitung = True Or txtHasil.Text = "0" Then
            txtHasil.Text = "2"
            operasiHitung = False
        Else
            txtHasil.Text = txtHasil.Text + "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If operasiHitung = True Or txtHasil.Text = "0" Then
            txtHasil.Text = "3"
            operasiHitung = False
        Else
            txtHasil.Text = txtHasil.Text + "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If operasiHitung = True Or txtHasil.Text = "0" Then
            txtHasil.Text = "4"
            operasiHitung = False
        Else
            txtHasil.Text = txtHasil.Text + "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If operasiHitung = True Or txtHasil.Text = "0" Then
            txtHasil.Text = "5"
            operasiHitung = False
        Else
            txtHasil.Text = txtHasil.Text + "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If operasiHitung = True Or txtHasil.Text = "0" Then
            txtHasil.Text = "6"
            operasiHitung = False
        Else
            txtHasil.Text = txtHasil.Text + "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If operasiHitung = True Or txtHasil.Text = "0" Then
            txtHasil.Text = "7"
            operasiHitung = False
        Else
            txtHasil.Text = txtHasil.Text + "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If operasiHitung = True Or txtHasil.Text = "0" Then
            txtHasil.Text = "8"
            operasiHitung = False
        Else
            txtHasil.Text = txtHasil.Text + "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If operasiHitung = True Or txtHasil.Text = "0" Then
            txtHasil.Text = "9"
            operasiHitung = False
        Else
            txtHasil.Text = txtHasil.Text + "9"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If operasiHitung = True Or txtHasil.Text = "0" Then
            txtHasil.Text = "0"
            operasiHitung = False
        Else
            txtHasil.Text = txtHasil.Text + "0"
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        operasi = "tambah"
        Hasil = Val(txtHasil.Text)
        operasiHitung = True
    End Sub

    Private Sub btnHasil_Click(sender As Object, e As EventArgs) Handles btnHasil.Click
        Select Case operasi
            Case "tambah"
                Hasil = Hasil + Val(txtHasil.Text)
            Case "kurang"
                Hasil = Hasil - Val(txtHasil.Text)
            Case "kali"
                Hasil = Hasil * Val(txtHasil.Text)
            Case "bagi"
                Hasil = Hasil / Val(txtHasil.Text)
        End Select

        txtHasil.Text = Hasil
        operasiHitung = True
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtHasil.Text = ""
    End Sub

    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
        operasi = "kurang"
        Hasil = Val(txtHasil.Text)
        operasiHitung = True
    End Sub

    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
        operasi = "kali"
        Hasil = Val(txtHasil.Text)
        operasiHitung = True
    End Sub

    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
        operasi = "bagi"
        Hasil = Val(txtHasil.Text)
        operasiHitung = True
    End Sub

    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If txtHasil.Text.Length <> 0 Then
            txtHasil.Text = txtHasil.Text.Remove(txtHasil.Text.Length - 1)
        End If
    End Sub
End Class
