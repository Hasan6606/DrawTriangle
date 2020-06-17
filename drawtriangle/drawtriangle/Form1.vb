Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sindeger As Double = Val(TextBox1.Text) 'Bu satırda  kullanıcan hesaplanıcak sinüs değerinin açısal olarak bir sayısal veri alınır.
        Dim sinacideger As Double = Math.Sin(sindeger) 'Bu satırda ise alınan açısal veriyi "Math()" kütüphanesinin "sin()" metodu ile açının sinüs değeri hesaplanır.
        Dim akenar As Double = Val(TextBox2.Text) 'Kullanıcıdan açının görmüş olduğu kenarın uzunluğunu alır.
        Dim bkenar As Double = (akenar / (sindeger)) 'Sinüs=Karşı/Hipotenüs olduğu için burda hipotenüs yalnız bırakarak değerine erişmiş olduk.



        Dim mypen As Pen  'Burda ise üçgeni çizicek kalemimizi tanımladık.
        Dim A As New Point(150, 150) 'Bu satırda ise üçgenin bir noktasını belirledik koordinat mantığıyla.
        Dim B As New Point(150, bkenar) 'Bu satırda ise üçgenin bir noktasını belirledik koordinat mantığıyla.
        Dim C As New Point(bkenar, 150) 'Bu satırda ise üçgenin bir noktasını belirledik koordinat mantığıyla.
        Dim mypoint As Point() = {A, B, C} 'Burda ise noktalarımızı kümeleme işlemi yapmış oldu.
        mypen = New Pen(Drawing.Color.Red, 10) 'Burda ise kalemimizin rengini kalınlığı ayarlanmıştır.
        Dim mygrap As Graphics = Me.CreateGraphics 'Burda ise grafik çercevesinde koordinat sistemi mantığıyla değişken tanımladık.
        mygrap.DrawPolygon(mypen, mypoint)  'Bu satırda ise grafik "DrawPolygon()" metodu aracılığıyla kalemimizi ve noktalarımızı tanımlayıp üçgeni çizdirmiş olduk.








    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load












    End Sub
End Class
