﻿Public Class DebitForm
    Private Sub AgreeButton_Click(sender As Object, e As EventArgs) Handles AgreeButton.Click
        If CardNumber.Text = "" Then
            MessageBox.Show("Input Data Dengan Benar!", "PENTING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ExpiredDate.Text = "" Then
            MessageBox.Show("Input Data Dengan Benar!", "PENTING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf SecurityNumber.Text = "" Then
            MessageBox.Show("Input Data Dengan Benar!", "PENTING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Apakah Anda Yakin Ingin Melanjutkan ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                FinishForm.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub buttonx_Click(sender As Object, e As EventArgs) Handles buttonx.Click
        MehtodePayForm.Show()
        Me.Close()
    End Sub

    Private Sub DebitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PriceCard.Text = ReceiptFormvb.total
    End Sub
End Class