using Abstract_class_Polimorphism.Models;

namespace Abstract_class_Polimorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Bir Figure abstrakt class-ı olur və onun Figure-dan miras alan zaman mütləq override edilməsi lazım olan bir CalcArea methodu olur.

            Bir Square class-ı olur side deyə bir property-i olur və side mənfi ola bilməz.
            Side dəyəri təyin olunmamış Square obyekti yaradıla bilməz.
            Square class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək.

            Bir Rectangular class-ı olur width və length deyə property-ləri olacaq, width və length mənfi ola bilməz.
            Width və length dəyərləri təyin olunmamış Rectangular obyekti yaradıla bilməz.
            Rectangular class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək.

            Program class-ında bir menu olacaq
            1. Square
            2. Rectangular
            0. Quit

            İstifadəçi 1 yazıb enter-ə click-ləsə Square-in CalcArea methodu işə düşməlidir.
            İstifadəçi 2 yazıb enter-ə click-ləsə Rectangular-in CalcArea methodu işə düşməlidir.
            İstifadəçi 0 yazıb enter-ə click-ləsə proqram sonlanmalıdı.*/

            byte input2 = 0;
            do
            {
                Console.WriteLine("1-Kvadratın sahesi hesablanacaq") ;
                Console.WriteLine("2-Düzbucaqlının sahesi hesablanacaq") ;
                Console.WriteLine("0-emeliyyat sonlanacaq") ;
                byte input = Convert.ToByte(Console.ReadLine());
                input2 = input;
                switch (input)
                {
                    case 1:
                        Console.Write("Kvadratın terefini daxil edin : ");
                        Square square = new Square(Convert.ToDouble(Console.ReadLine()));
                        square.CalcArea();
                        break;
                    case 2:
                        Console.Write("Duzbucaqlinin enini daxil edin : ");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Duzbucaqlinin uzunlugunu daxil edin : ");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Rectangular rectangular = new Rectangular(width,length);
                        rectangular.CalcArea();
                    break;
                    case 0:
                        Console.WriteLine("Emeliyyat başa çatdı");
                        break;
                    default: 
                        Console.WriteLine("Yanlis reqem daxil edildi");
                        break;
                }
            } while (input2 != 0);
            
        }
    }
}