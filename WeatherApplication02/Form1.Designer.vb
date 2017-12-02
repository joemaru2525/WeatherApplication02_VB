<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWeather
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelTittle = New System.Windows.Forms.Label()
        Me.LabelAnounce = New System.Windows.Forms.Label()
        Me.LabelWdate = New System.Windows.Forms.Label()
        Me.PictureWeather = New System.Windows.Forms.PictureBox()
        Me.LabelHighTemp = New System.Windows.Forms.Label()
        Me.LabelLowTemp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelPrecipi01 = New System.Windows.Forms.Label()
        Me.LabelPrecipi02 = New System.Windows.Forms.Label()
        Me.LabelPrecipi03 = New System.Windows.Forms.Label()
        Me.LabelPrecipi04 = New System.Windows.Forms.Label()
        Me.LabelWeather = New System.Windows.Forms.Label()
        CType(Me.PictureWeather, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTittle
        '
        Me.LabelTittle.AutoSize = True
        Me.LabelTittle.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelTittle.Location = New System.Drawing.Point(13, 13)
        Me.LabelTittle.Name = "LabelTittle"
        Me.LabelTittle.Size = New System.Drawing.Size(204, 15)
        Me.LabelTittle.TabIndex = 0
        Me.LabelTittle.Text = "神奈川県 東部（横浜）の天気"
        '
        'LabelAnounce
        '
        Me.LabelAnounce.AutoSize = True
        Me.LabelAnounce.Location = New System.Drawing.Point(20, 38)
        Me.LabelAnounce.Name = "LabelAnounce"
        Me.LabelAnounce.Size = New System.Drawing.Size(76, 12)
        Me.LabelAnounce.TabIndex = 1
        Me.LabelAnounce.Text = "LabelAnounce"
        '
        'LabelWdate
        '
        Me.LabelWdate.AutoSize = True
        Me.LabelWdate.Location = New System.Drawing.Point(20, 70)
        Me.LabelWdate.Name = "LabelWdate"
        Me.LabelWdate.Size = New System.Drawing.Size(97, 12)
        Me.LabelWdate.TabIndex = 2
        Me.LabelWdate.Text = "LabelWeatherDate"
        '
        'PictureWeather
        '
        Me.PictureWeather.Location = New System.Drawing.Point(20, 110)
        Me.PictureWeather.Name = "PictureWeather"
        Me.PictureWeather.Size = New System.Drawing.Size(100, 50)
        Me.PictureWeather.TabIndex = 3
        Me.PictureWeather.TabStop = False
        '
        'LabelHighTemp
        '
        Me.LabelHighTemp.AutoSize = True
        Me.LabelHighTemp.Location = New System.Drawing.Point(20, 170)
        Me.LabelHighTemp.Name = "LabelHighTemp"
        Me.LabelHighTemp.Size = New System.Drawing.Size(119, 12)
        Me.LabelHighTemp.TabIndex = 4
        Me.LabelHighTemp.Text = "LabelHighTemperature"
        '
        'LabelLowTemp
        '
        Me.LabelLowTemp.AutoSize = True
        Me.LabelLowTemp.Location = New System.Drawing.Point(20, 190)
        Me.LabelLowTemp.Name = "LabelLowTemp"
        Me.LabelLowTemp.Size = New System.Drawing.Size(116, 12)
        Me.LabelLowTemp.TabIndex = 5
        Me.LabelLowTemp.Text = "LabelLowTemperature"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "時間帯"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "降水確率"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "0-6"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(120, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "6-12"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "12-18"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(200, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 12)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "18-24"
        '
        'LabelPrecipi01
        '
        Me.LabelPrecipi01.AutoSize = True
        Me.LabelPrecipi01.Location = New System.Drawing.Point(80, 230)
        Me.LabelPrecipi01.Name = "LabelPrecipi01"
        Me.LabelPrecipi01.Size = New System.Drawing.Size(38, 12)
        Me.LabelPrecipi01.TabIndex = 12
        Me.LabelPrecipi01.Text = "Label7"
        '
        'LabelPrecipi02
        '
        Me.LabelPrecipi02.AutoSize = True
        Me.LabelPrecipi02.Location = New System.Drawing.Point(120, 230)
        Me.LabelPrecipi02.Name = "LabelPrecipi02"
        Me.LabelPrecipi02.Size = New System.Drawing.Size(38, 12)
        Me.LabelPrecipi02.TabIndex = 13
        Me.LabelPrecipi02.Text = "Label8"
        '
        'LabelPrecipi03
        '
        Me.LabelPrecipi03.AutoSize = True
        Me.LabelPrecipi03.Location = New System.Drawing.Point(160, 230)
        Me.LabelPrecipi03.Name = "LabelPrecipi03"
        Me.LabelPrecipi03.Size = New System.Drawing.Size(38, 12)
        Me.LabelPrecipi03.TabIndex = 14
        Me.LabelPrecipi03.Text = "Label9"
        '
        'LabelPrecipi04
        '
        Me.LabelPrecipi04.AutoSize = True
        Me.LabelPrecipi04.Location = New System.Drawing.Point(200, 230)
        Me.LabelPrecipi04.Name = "LabelPrecipi04"
        Me.LabelPrecipi04.Size = New System.Drawing.Size(44, 12)
        Me.LabelPrecipi04.TabIndex = 15
        Me.LabelPrecipi04.Text = "Label10"
        '
        'LabelWeather
        '
        Me.LabelWeather.AutoSize = True
        Me.LabelWeather.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelWeather.Location = New System.Drawing.Point(20, 90)
        Me.LabelWeather.Name = "LabelWeather"
        Me.LabelWeather.Size = New System.Drawing.Size(112, 16)
        Me.LabelWeather.TabIndex = 16
        Me.LabelWeather.Text = "LabelWeather"
        '
        'FormWeather
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.LabelWeather)
        Me.Controls.Add(Me.LabelPrecipi04)
        Me.Controls.Add(Me.LabelPrecipi03)
        Me.Controls.Add(Me.LabelPrecipi02)
        Me.Controls.Add(Me.LabelPrecipi01)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelLowTemp)
        Me.Controls.Add(Me.LabelHighTemp)
        Me.Controls.Add(Me.PictureWeather)
        Me.Controls.Add(Me.LabelWdate)
        Me.Controls.Add(Me.LabelAnounce)
        Me.Controls.Add(Me.LabelTittle)
        Me.Name = "FormWeather"
        Me.Text = "Yahoo!天気予報"
        CType(Me.PictureWeather, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTittle As Label
    Friend WithEvents LabelAnounce As Label
    Friend WithEvents LabelWdate As Label
    Friend WithEvents PictureWeather As PictureBox
    Friend WithEvents LabelHighTemp As Label
    Friend WithEvents LabelLowTemp As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelPrecipi01 As Label
    Friend WithEvents LabelPrecipi02 As Label
    Friend WithEvents LabelPrecipi03 As Label
    Friend WithEvents LabelPrecipi04 As Label
    Friend WithEvents LabelWeather As Label
End Class
