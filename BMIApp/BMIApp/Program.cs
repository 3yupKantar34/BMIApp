using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vücut Kitle İndeksi (BMİ) Hesaplama");
            

            try
            {
                
                Console.Write("Lütfen boyunuzu (Virgül Kullanin) girin: ");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.Write("Lütfen kilonuzu (Virgül Kullanin) girin: ");
                double weight = Convert.ToDouble(Console.ReadLine());

                
                double bmi = weight / (height * height);

                
                Console.WriteLine($"BMİ: {bmi:F2}");

                
                if (bmi < 18.5)
                {
                    Console.WriteLine("Durum: Zayıf");
                }
                else if (bmi < 24.9)
                {
                    Console.WriteLine("Durum: Normal");
                }
                else if (bmi < 29.9)
                {
                    Console.WriteLine("Durum: Fazla Kilolu");
                }
                else
                {
                    Console.WriteLine("Durum: Obez");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçerli bir sayı girmediniz.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Boy değeri sıfır olamaz.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }
            Console.ReadLine();



        }
    }
}
