using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Btapvenha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bài 1 : Viết chương trình nhập vào số nguyên và kiểm tra xem số đó có chia hết cho 3 hay không.Hiển thị kết quả ra màn hình.
            //
            //Console.WriteLine(a % 3 == 0 ? $"{a} chia hết cho 3" : $"{a} không chia hết cho 3");
            //Console.ReadKey();



            //// Bài 2: Nhập vào số nguyên dương n, hiển thị bảng cửu chương từ 1 đến n ra màn hình
            //Console.Write("Nhập 1 số tự nhiên n = ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bảng cửu chương {0}", n);
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine("{0} x {1} = {2}",i,j,i*j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();


            // Bài 3: Nhập vào số nguyên dương từ n từ bàn phím, tính tổng giai thừa từ 1 đến n và hiển thị kết quả ra màn hình.
            //Console.Write("nhập 1 số nguyên dương = ");
            //int n = int.Parse(Console.ReadLine());
            //int kq = 1;
            //if (n <= 0)
            //{
            //    Console.WriteLine($"{n} không phải là số nguyên dương");
            //}
            //else
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        kq *= i;
            //    }
            //    Console.WriteLine($"{n}! = {kq}");
            //}
            //Console.ReadKey();


            // Bài 4: Viết chương trình nhập vào số nguyên từ bàn phím, kiểm tra xem số đó có phải là số chính phương hay không.Hiển thị kết quả đạt được ra màn hình

            //Console.Write("nhập 1 số nguyên = ");
            //double n = double.Parse(Console.ReadLine());
            //double sqrt = Math.Sqrt(n);
            //Console.WriteLine(sqrt * sqrt == n ? $"{n} là số chính phương":$"{n} không phải là số chính phương");
            //Console.ReadKey();


            ////Bài 5: Viết chương trình nhập vào tháng bất kỳ từ bàn phím, hiển thị số ngày có trong tháng ra màn hình

            //Console.Write("Tháng = ");
            //int thang = int.Parse(Console.ReadLine());
            //Console.Write("Năm = ");
            //int nam = int.Parse(Console.ReadLine());
            //int ngaytrongthang = 1;
            //if (thang <= 0||thang>12)
            //{
            //    Console.WriteLine("Tháng bạn nhập không phù hợp");
            //}
            //else
            //{
            //    switch (thang)
            //    {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            ngaytrongthang = 31;
            //            break;
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            ngaytrongthang = 30;
            //            break;
            //        case 2:
            //            if (DateTime.IsLeapYear(nam))
            //            {
            //                ngaytrongthang = 29;
            //            }
            //            else ngaytrongthang = 28;
            //            break;

            //    }
            //    Console.WriteLine("số ngày trong tháng đó là {0}", ngaytrongthang);
            //}

            //Console.ReadKey();



            // Bài 6: Viết chương trình nhập vào số nguyên n, tính tổng S theo công thức sau và hiển thị kết quả ra màn hình.

            //Console.Write("nhập 1 số nguyên = ");
            //double n = double.Parse(Console.ReadLine());
            //double kq1 = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //        kq1 += i*i;
            //}
            //Console.WriteLine($"Kết quả của tổng = {kq1}");

            //Console.ReadKey();



            //// Bài 7: Viết chương trình nhập vào số nguyên n, tính tổng các số lẽ từ 1 đến n và hiển thị kết quả ra màn hình

            //Console.Write("nhập 1 số nguyên = ");
            //int n = int.Parse(Console.ReadLine());
            //int tong = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 == 0) 
            //    continue;
            //    tong += i;
            //}
            //Console.WriteLine("Kết quả của tổng = {0}",tong);

            //Console.ReadKey();



            //// Bài 8: Nhập vào số nguyên dương n, hiển thị ra màn hình các số nguyên tố từ 1 đến n

            //Console.Write("nhập 1 số nguyên = ");
            //int n = int.Parse(Console.ReadLine());
            //int count = 0;
            //if (n >= 1)
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        if (n % i != 0)
            //            continue;
            //        count += 1;

            //    }
            //    Console.WriteLine(count == 2 ? $"{n} là số nguyên tố" : $"{n} không phải là số nguyên tố");
            //}
            //else Console.WriteLine("Số bạn nhập không hợp lệ");
            //Console.ReadKey();

            // Bài 8: Viết chương trình nhập vào số hàng n, vẽ tam giác * với số hàng tương ứng. Ví dụ, nhập vào 10 hàng, thì ta sẽ được 1 tam giác như hình bên dưới. Có thể thử vẽ thêm vớ hình tam giác đều, tam giác xoay ngược.

            //Console.Write("nhập số cạnh của tam giác = ");
            //int n = int.Parse(Console.ReadLine());
            //int count = 0;
            //if (n >= 1)
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        for(int j = 1; j <= i; j++)
            //        {
            //            Console.Write("*");
                    
            //        }
            //        Console.WriteLine();
            //    }
               
            //}
            //else Console.WriteLine("Số bạn nhập không hợp lệ");
            //Console.ReadKey();

            //// Tam giác xoay ngược
            //Console.Write("nhập số cạnh của tam giác = ");
            //int n = int.Parse(Console.ReadLine());
            //int count = 0;
            //if (n >= 1)
            //{
            //    for (int i = n; i >= 1; i--)
            //    {
            //        for (int j = 1; j <= i; j++)
            //        {
            //            Console.Write("*");

            //        }
            //        Console.WriteLine();
            //    }

            //}
            //else Console.WriteLine("Số bạn nhập không hợp lệ");
            //Console.ReadKey();

     




        }
    }
}
