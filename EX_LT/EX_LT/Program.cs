using System;

namespace LT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.WriteLine("Bài 1: Kiểm tra số dương, âm, hoặc bằng không" +
                "\nBài 2: Hiển thị tên ngày trong tuần" +
                "\nBài 3: Tính giai thừa" +
                "\nBài 4: Hiển thị hình dấu sao" +
                "\nBài 5: Trò chơi đoán số bí mật" +
                "\nBài 6: Tính tổng các số dương" +
                "\nChọn bài tập (1-6):");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    //Bài 1: Kiểm tra số dương, âm, hoặc bằng không
                    CheckNumber();
                    break;

                case 2:
                    //Bài 2: Hiển thị tên ngày trong tuần
                    DisplayDayOfWeek();
                    break;

                case 3:
                    //Bài 3: Tính giai thừa
                    CalculateFactorial();
                    break;

                case 4:
                    //Bài 4: Hiển thị hình dấu sao
                    DisplayAsteriskPattern();
                    break;

                case 5:
                    //Bài 5: Trò chơi đoán số bí mật
                    GuessSecretNumber();
                    break;

                case 6:
                    //Bài 6: Tính tổng các số dương
                    SumPositiveNumbers();
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }

        //Bài 1: Kiểm tra số dương, âm, hoặc bằng không
        static void CheckNumber()
        {
            Console.Write("Nhập một số: ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number > 0)
                Console.WriteLine("Số dương.");
            else if (number < 0)
                Console.WriteLine("Số âm.");
            else
                Console.WriteLine("Số bằng không.");
        }

        //Bài 2: Hiển thị tên ngày trong tuần
        static void DisplayDayOfWeek()
        {
            Console.Write("Nhập số ngày trong tuần (1-7): ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Thứ Hai");
                    break;
                case 2:
                    Console.WriteLine("Thứ Ba");
                    break;
                case 3:
                    Console.WriteLine("Thứ Tư");
                    break;
                case 4:
                    Console.WriteLine("Thứ Năm");
                    break;
                case 5:
                    Console.WriteLine("Thứ Sáu");
                    break;
                case 6:
                    Console.WriteLine("Thứ Bảy");
                    break;
                case 7:
                    Console.WriteLine("Chủ Nhật");
                    break;
               
                default:
                    Console.WriteLine("Ngày không hợp lệ.");
                    break;
            }
        }

        //Bài 3: Tính giai thừa
        static void CalculateFactorial()
        {
            Console.Write("Nhập một số nguyên dương: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Giai thừa của {n} là {factorial}");
        }

        //Bài 4: Hiển thị hình dấu sao
        static void DisplayAsteriskPattern()
        {
            Console.Write("Nhập số hàng và cột: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        //Bài 5: Trò chơi đoán số bí mật
        static void GuessSecretNumber()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101);

            Console.WriteLine("Chào mừng bạn đến với trò chơi đoán số bí mật!");
            Console.WriteLine("Số bí mật đã được tạo. Hãy bắt đầu đoán!");

            int guess;
            int attempts = 0;

            do
            {
                Console.Write("Nhập số dự đoán của bạn (1-100): ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess < secretNumber)
                    Console.WriteLine("Số bạn đoán thấp hơn số bí mật.");
                else if (guess > secretNumber)
                    Console.WriteLine("Số bạn đoán cao hơn số bí mật.");
                else
                    Console.WriteLine($"Chúc mừng! Bạn đã đoán đúng số bí mật ({secretNumber}) sau {attempts} lần đoán.");
            } while (guess != secretNumber);
        }

        //Bài 6: Tính tổng các số dương
        static void SumPositiveNumbers()
        {
            double sum = 0;
            while (true)
            {
                Console.Write("Nhập một số (nhập 0 để dừng): ");
                double number = Convert.ToDouble(Console.ReadLine());

                if (number == 0)
                    break;

                if (number > 0)
                    sum += number;
            }

            Console.WriteLine($"Tổng các số dương: {sum}");
        }
    }
}
