using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31211025737
{
    internal class Program
    {
        static void inputNum(out float n1, out float n2, out float n3)
        {
            Console.Write("Nhập vào số thứ nhất:\t");
            n1 = float.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ hai:\t");
            n2 = float.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ ba:\t");
            n3 = float.Parse(Console.ReadLine());
        }
        static void countAngle(out double bac, out double abc, out double acb, float n1, float n2, float n3)
        {
            bac = Math.Acos((n2 * n2 + n3 * n3 - n1 * n1) / (2 * n2 * n3)) * (180 / Math.PI);
            abc = Math.Acos((n1 * n1 + n3 * n3 - n2 * n2) / (2 * n1 * n3)) * (180 / Math.PI);
            acb = 180 - bac - abc;
        }

        static void showAngle(double bac, double abc, double acb, float n1, float n2, float n3)
        {
            if (n1 > 0 && n2 > 0 && n3 > 0 && n1 + n2 > n3 && n1 + n3 > n2 && n2 + n3 > n2)
            {
                Console.WriteLine("3 số đã nhập lần lượt 3 cạnh của một tam giác");
                Console.WriteLine("Số đo 3 góc: {0} độ, {1} độ, {2} độ", bac, abc, acb);
            }
            else
            {
                Console.WriteLine("3 số đã nhập không là 3 cạnh của một tam giác");
            }
        }
        static int inputRadix()
        {
            Console.Write("Nhập vào n: ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        static double countRadix(int n)
        {
            double s = 0;
            for (int i = n + 1; i >= 1; i--)
            {
                s = Math.Pow(s + i, (float)1 / (n + 1));
            }
            double P = 1 / s;
            return P;
        }
        static void showRadix(int n)
        {
            Console.WriteLine("Mẫu số P có {0} dấu căn và có căn bậc {1} ", n + 1, n + 1);
            Console.WriteLine("Kết quả sau giải phương trình P = {0} ", countRadix(n));
        }
        static int inputArrFibonacci()
        {
            int n;
        nhaplai:
            Console.Write("Nhập vào n số hạng đầu tiên của dãy Fibonacci: ");
            n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Mời nhập lại n > 0");
                goto nhaplai;
            }
            return n;
        }
        static int[] countArrFibonacci(int n, out int[] F)
        {
            F = new int[n + 1];
            F[0] = 0;
            F[1] = 1;
            for (int i = 2; i <= n; ++i)
            {
                F[i] = F[i - 1] + F[i - 2];
            }
            return F;
        }
        static void showArrFibonacci(int n, int[] F)
        {
            Console.WriteLine("{0} số hạng đầu của dãy số Fibonacci là: \n", n);
            foreach (int i in F)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
        static void inputRowCol(out int row, out int col)
        {
        nhaplai:
            Console.Write("Nhập vào số hàng của ma trận: ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số cột của ma trận: ");
            col = int.Parse(Console.ReadLine());
            if (col <= 0 || row <= 0)
            {
                Console.WriteLine("Nhập lại hàng cột lớn hơn 0");
                goto nhaplai;
            }
        }
        static void inputMatrix(out int[,] M, int row, int col)
        {
            M = new int[row, col];
            Console.WriteLine("Nhập vào các phần tử của Ma trận:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("A[{0},{1}] = ", i, j);
                    M[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void sumMatrix(int[,] M1, int[,] M2, out int[,] M3)
        {
            M3 = new int[M1.GetLength(0), M2.GetLength(1)];
            for (int i = 0; i < M3.GetLength(0); i++)
            {
                for (int j = 0; j < M3.GetLength(1); j++)
                {
                    M3[i, j] = M1[i, j] + M2[i, j];
                }
            }
        }
        static void showMatrix(int[,] M)
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write("{0}\t", M[i, j]);
                }
                Console.WriteLine();
            }
        }
        static string inputString()
        {
            Console.WriteLine("Nhập vào chuỗi bất kì: ");
            string str = Convert.ToString(Console.ReadLine());
            return str;
        }
        static string upperFirstChar(string str)
        {
            string[] arrStr = str.Split(' ');
            StringBuilder newStr = new StringBuilder();
            for (int i = 0; i < arrStr.Length; i++)
            {
                string word = arrStr[i];
                if (word.Equals("") == false)
                {
                    string upperChar = word.Substring(0, 1).ToUpper();
                    word = upperChar + word.Substring(1).ToLower();
                    newStr.Append(word).Append(" ");
                }
            }
            return newStr.ToString().Trim();
        }
        static void inputClientInformation(object[] cl)
        {
            Console.Write("Quí Ông(Bà): ");
            cl[0] = Console.ReadLine();
            Console.Write("Số ngày ở: ");
            cl[1] = float.Parse(Console.ReadLine());
            Console.Write("Số bữa ăn: ");
            cl[2] = float.Parse(Console.ReadLine());
            Console.Write("Tiền ở (1 ngày): ");
            cl[3] = float.Parse(Console.ReadLine());
            Console.Write("Tiền ăn (1 ngày): ");
            cl[4] = float.Parse(Console.ReadLine());
            Console.Write("Phí phục vụ: ");
            cl[5] = float.Parse(Console.ReadLine());
        }
        static void outputClientInformation(object[] cl)
        {
            Console.WriteLine("Quý Ông(Bà): {0}\nSố ngày ở: {1}\t\tSố bữa ăn: {2}\nTiền ở: {3} VND\tTiền ăn: {4} VND\tPhí phục vụ: {5} VND",
                                cl[0], cl[1], cl[2], cl[3], cl[4], cl[5]);
        }
        static void inputListClient(object[][] list)
        {
            for (int i = 0; i < list.Length; i++)
                inputClientInformation(list[i]);
        }
        static void outputListClient(object[][] list)
        {
            for (int i = 0; i < list.Length; i++)
                outputClientInformation(list[i]);
        }

        static float sumMoney(object[][] list)
        {
            float sum = ((float)list[0][1]) * ((float)list[0][3]) + ((float)list[0][2]) * ((float)list[0][4] + ((float)list[0][5]));
            return sum;
        }

        const int clientNumber = 1;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("{0, 29}\n{1, 32}\n{2, 26}\n{3,28}",
            "ĐỒ ÁN: CƠ SỞ LẬP TRÌNH", "SINH VIÊN: NGUYỄN KHÁNH TOÀN", "MSSV: 31211025737", "lỚP: 22C1INF50900501");
            Console.WriteLine("{0, 33}", "******************************");
        choice:
            Console.WriteLine("1. Bài 1");
            Console.WriteLine("2. Bài 2");
            Console.WriteLine("3. Bài 3");
            Console.WriteLine("4. Bài 4");
            Console.WriteLine("5. Bài 5");
            Console.WriteLine("6. Bài 6");
            Console.Write("Vui lòng chọn yêu cầu của bạn: ");
            float Exercise = float.Parse(Console.ReadLine());
            switch (Exercise)
            {
                case 1:
                    Console.WriteLine("Bài tập 1: Nhập vào 3 số, kiểm tra chúng có tạo thành 3 cạnh của một tam giác không?\nTính ba góc của tam giác đó (nếu thỏa mãn).\nGiải");
                    Console.WriteLine("Nhập vào 3 cạnh của tam giác");
                    float n1, n2, n3;
                    double bac, abc, acb;
                    inputNum(out n1, out n2, out n3);
                    countAngle(out bac, out abc, out acb, n1, n2, n3);
                    showAngle(bac, abc, acb, n1, n2, n3);
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    goto choice;
                    break;
                case 2:
                    Console.WriteLine("Bài tập 2: Giải phương trình P với số dấu căn bằng n + 1\nGiải");
                    int n = inputRadix();
                    showRadix(n);
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    goto choice;
                    break;
                case 3:
                    Console.WriteLine("Bài tập 3: Dùng mảng 1 chiều để in ra n số hạng đầu tiên của dãy số Fibonacci\nGiải");
                    int[] F;
                    int num = inputArrFibonacci();
                    countArrFibonacci(num, out F);
                    showArrFibonacci(num, F);
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    goto choice;
                    break;
                case 4:
                    Console.WriteLine("Bài tập 4: Nhập vào 2 ma trận có cùng cấp Amxn và Bmxn. In ra kết quả của ma trận Cmxn =Amxn + Bmxn\nGiải");
                    int row, col; int[,] M1, M2, M3;
                    inputRowCol(out row, out col);
                    inputMatrix(out M1, row, col);
                    Console.WriteLine("Ma trận A"); showMatrix(M1);
                    inputMatrix(out M2, row, col);
                    Console.WriteLine("Ma trận B"); showMatrix(M2);
                    Console.WriteLine("Tổng hai ma trận A + B"); sumMatrix(M1, M2, out M3);
                    showMatrix(M3);
                    Console.WriteLine("------------------------------------------------------------------------------");
                    goto choice;
                    break;
                case 5:
                    Console.WriteLine("Bài tập 5: Đọc vào một chuỗi, đổi sang chuỗi chữ hoa đầu mỗi từ\nGiải");
                    string str = inputString();
                    Console.WriteLine("Chuỗi sau thực hiện chuyển đổi:  ");
                    Console.WriteLine(upperFirstChar(str));
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    goto choice;
                    break;
                case 6:
                    Console.WriteLine("Bài tập 6: Viết chương trình tính tiền trọ khách sạn. In hóa đơn tính tiền lên màn hình\n");
                    object[][] cl = new object[clientNumber][];
                    for (int i = 0; i < cl.Length; i++)
                        cl[i] = new object[6];
                    inputListClient(cl); for (int i = 0; i <= 70; i++) Console.Write("*");
                    Console.WriteLine();
                    Console.WriteLine("Khách sạn Five Stars\nHóa đơn khách sạn");
                    outputListClient(cl);
                    Console.WriteLine("Tổng tiền: " + sumMoney(cl).ToString("0,0") + " VND");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    goto choice;
                    break;
                default:
                    Console.WriteLine("Mời nhập lại lựa chọn");
                    goto choice;
                    break;
            }
            Console.ReadKey();
        }
    }
}
