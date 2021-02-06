Imports System.Xml

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the caption bar text of the form.

        Me.Text = "Load XML"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1().Items.Clear()

        Dim xr As XmlReader = XmlReader.Create("movies.xml")

        Do While xr.Read()

            If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "movie" Then

                ListBox1.Items.Add(xr.GetAttribute(0))

            End If

        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox2().Items.Clear()

        Dim xr As XmlReader = XmlReader.Create("movies.xml")

        Do While xr.Read()

            If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "type" Then

                ListBox2.Items.Add(xr.ReadElementString)

            Else

                xr.Read()

            End If

        Loop
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox3().Items.Clear()

        Dim xr As XmlReader = XmlReader.Create("movies.xml")

        Do While xr.Read()

            If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "description" Then

                ListBox3.Items.Add(xr.ReadElementString)

            Else

                xr.Read()

            End If

        Loop
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim xws As XmlWriterSettings = New XmlWriterSettings()

        xws.Indent = True
        xws.NewLineOnAttributes = True

        Dim xw As XmlWriter = XmlWriter.Create("authors.xml", xws)

        xw.WriteStartDocument()
        xw.WriteStartElement("Authors")

        xw.WriteStartElement("author")
        xw.WriteAttributeString("code", "1")
        xw.WriteElementString("fname", "Carlos")
        xw.WriteElementString("lname", "López")
        xw.WriteEndElement()

        xw.WriteStartElement("author")
        xw.WriteAttributeString("code", "2")
        xw.WriteElementString("fname", "Juan")
        xw.WriteElementString("lname", "Pérez")
        xw.WriteEndElement()

        xw.WriteStartElement("author")
        xw.WriteAttributeString("code", "3")
        xw.WriteElementString("fname", "Isabel")
        xw.WriteElementString("lname", "Gómez")
        xw.WriteEndElement()

        xw.WriteStartElement("author")
        xw.WriteAttributeString("code", "4")
        xw.WriteElementString("fname", "Ana")
        xw.WriteElementString("lname", "Álvarez")
        xw.WriteEndElement()

        xw.WriteStartElement("author")
        xw.WriteAttributeString("code", "5")
        xw.WriteElementString("fname", "Sergio")
        xw.WriteElementString("lname", "Valdecasas")
        xw.WriteEndElement()
        xw.WriteEndElement()

        xw.WriteEndDocument()

        xw.Flush()
        xw.Close()

        WebBrowser1.Url = New Uri(AppDomain.CurrentDomain.BaseDirectory + "authors.xml")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox4.Items.Clear()

        Dim xd As XmlDocument = New XmlDocument()
        xd.Load("authors.xml")

        Dim newAuthor As XmlElement = xd.CreateElement("author")

        newAuthor.SetAttribute("code", "6")

        Dim fn As XmlElement = xd.CreateElement("fname")

        fn.InnerText = "Luisa"

        newAuthor.AppendChild(fn)

        Dim ln As XmlElement = xd.CreateElement("lname")

        ln.InnerText = "Ruiz"

        newAuthor.AppendChild(ln)

        xd.DocumentElement.AppendChild(newAuthor)

        Dim tr As XmlTextWriter = New XmlTextWriter("authors.xml", Nothing)

        tr.Formatting = Formatting.Indented

        xd.WriteContentTo(tr)

        tr.Close()

        Dim nl As XmlNodeList = xd.GetElementsByTagName("fname")

        For Each node As XmlNode In nl

            ListBox4.Items.Add(node.InnerText)

        Next node

    End Sub
End Class
