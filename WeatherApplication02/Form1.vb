Public Class FormWeather
    Private Sub FormWeather_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim url As String = "https://weather.yahoo.co.jp/weather/jp/14/4610.html"        'Yahoo!天気 - 神奈川県東部（横浜）
        Dim wc As System.Net.WebClient = New System.Net.WebClient
        Dim st As System.IO.Stream = wc.OpenRead(url)
        Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("UTF-8")
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(st, enc)
        Dim html As String = sr.ReadToEnd
        sr.Close()
        st.Close()

        Dim doc As HtmlAgilityPack.HtmlDocument = New HtmlAgilityPack.HtmlDocument
        doc.LoadHtml(html)

        Dim node1 As HtmlAgilityPack.HtmlNodeCollection =
            doc.DocumentNode.SelectNodes("//div[@class='yjw_title_h2 yjw_clr']//p[@class='yjSt yjw_note_h2']")
        LabelAnounce.Text = node1(0).InnerText
        Console.WriteLine("Anounce: " & node1(0).InnerText)       'Anounce Date & Time

        Dim node2 As HtmlAgilityPack.HtmlNodeCollection =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//p[@class='date']")
        LabelWdate.Text = node2(0).InnerText
        Console.WriteLine("Date: " & node2(0).InnerText)          'WeatherDate

        Dim node3 As HtmlAgilityPack.HtmlNodeCollection =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//p[@class='pict']")
        LabelWeather.Text = node3(0).InnerText
        Console.WriteLine("Weather: " & node3(0).InnerText)          'Weather

        Dim node4 As HtmlAgilityPack.HtmlNodeCollection =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//ul[@class='temp']//li[@class='high']")
        LabelHighTemp.Text = "最高気温 [前日差]： " + node4(0).InnerText
        Console.WriteLine("High Temp: " & node4(0).InnerText)          'High Temp

        Dim node5 As HtmlAgilityPack.HtmlNodeCollection =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//ul[@class='temp']//li[@class='low']")
        LabelLowTemp.Text = "最低気温 [前日差]： " + node5(0).InnerText
        Console.WriteLine("Low Temp: " & node5(0).InnerText)          'Low Temp

        Dim node6 As HtmlAgilityPack.HtmlNodeCollection =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//tr[@class='precip']//td")
        LabelPrecipi01.Text = node6(0).InnerText
        Console.WriteLine("降水確率[0-6]: " & node6(0).InnerText)          'Precip1[0-6]

        LabelPrecipi02.Text = node6(1).InnerText
        Console.WriteLine("降水確率[6-12]: " & node6(1).InnerText)          'Precip1[6-12]

        LabelPrecipi03.Text = node6(2).InnerText
        Console.WriteLine("降水確率[12-18]: " & node6(2).InnerText)          'Precip1[12-18]

        LabelPrecipi04.Text = node6(3).InnerText
        Console.WriteLine("降水確率[18-24]: " & node6(3).InnerText)          'Precip1[18-24]

        Dim node7 As HtmlAgilityPack.HtmlNodeCollection =
            doc.DocumentNode.SelectNodes("//div[@class='forecastCity']//p[@class='pict']//img")
        Console.WriteLine(node7(0).Attributes("src").Value)
        PictureWeather.ImageLocation = node7(0).Attributes("src").Value       'WeatherPicture

    End Sub
End Class
