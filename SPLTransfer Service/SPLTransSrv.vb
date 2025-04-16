Public Class SPLTransSrv


	Public Sub New()
		MyBase.New()
		InitializeComponent()
		Me.EventLog1 = New System.Diagnostics.EventLog
		If Not System.Diagnostics.EventLog.SourceExists("MySource") Then
			System.Diagnostics.EventLog.CreateEventSource("MySource",
			"MyNewLog")
		End If
		EventLog1.Source = "MySource"
		EventLog1.Log = "MyNewLog"
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
