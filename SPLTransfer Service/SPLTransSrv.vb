﻿Public Class SPLTransSrv
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub

	Protected Overrides Sub OnStart(ByVal args() As String)
		' Add code here to start your service. This method should set things
		' in motion so your service can do its work.

	End Sub

	Protected Overrides Sub OnStop()
		' Add code here to perform any tear-down necessary to stop your service.
	End Sub

	Private Sub SPLTransSrv_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

	End Sub
End Class
