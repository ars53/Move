﻿Public Class Add
    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LookupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LookupToolStripMenuItem.Click
        Lookup.Show()
        Me.Close()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Delete.Show()
        Me.Close()

    End Sub

    Private Sub UpdateUserInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateUserInfoToolStripMenuItem.Click
        UpdateInfo.Show()
        Me.Close()

    End Sub
End Class