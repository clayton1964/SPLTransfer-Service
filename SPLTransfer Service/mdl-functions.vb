Imports System.Xml
Module mdl_functions

	Public Function ReadXmlConfig(configFilePath As String) As Dictionary(Of String, String)
		' Create a dictionary to store key-value pairs from the XML configuration.
		Dim configData As New Dictionary(Of String, String)()

		Try
			' Load the XML document from the specified file.
			Dim xmlDoc As New XmlDocument()
			xmlDoc.Load(configFilePath)

			' Select all elements with the name "setting" in the XML.
			Dim settings As XmlNodeList = xmlDoc.SelectNodes("//setting")

			' Iterate through the "setting" elements and extract key-value pairs.
			For Each setting As XmlNode In settings
				' Get the "key" and "value" attributes from the "setting" element.
				Dim key As String = setting.Attributes("key").Value
				Dim value As String = setting.Attributes("value").Value

				' Add the key-value pair to the dictionary.
				configData.Add(key, value)
			Next

			' Return the dictionary with configuration data.
			Return configData
		Catch ex As Exception
			' Handle any exceptions that may occur during the XML reading process.
			' You can add your own error handling logic here.
			Console.WriteLine("Error reading XML configuration: " & ex.Message)
			Return Nothing
		End Try
	End Function
End Module
