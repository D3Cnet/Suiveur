Option Explicit On
Option Strict On

Public Class Principale

  Public gestionDB As GestionDB = New GestionDB

  Private Sub Principale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    gestionDB.OpenDataBase()

  End Sub

  Private Sub Principale_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    gestionDB.CloseDatabase()
  End Sub

End Class

