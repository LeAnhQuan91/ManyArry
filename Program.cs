using System;

namespace ManyArry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap cac phan tu cua mang:");

            int[,] myArry = new int [3,3];
            //Qua trinh nhap
            for (int row = 0; row < myArry.GetLength(0); row++)
            {
                for (int colum = 0; colum < myArry.GetLength(1); colum++)
                {
                    myArry[row,colum] = Convert.ToInt32(Console.ReadLine());
                }
            } 
            //Qua trinh xuat ra man hinh
            for (int row = 0; row < myArry.GetLength(0); row++)
            {
                for (int colum = 0; colum < myArry.GetLength(1); colum++)
                {
                   Console.Write("{0,5}", myArry[row,colum]);
                }
                Console.WriteLine();    
            }
            //Qua trinh tim gia tri lon nhat
            int maxValue=0;
            int sum=0;
            int sumLine=0;
            for (int row = 0; row < myArry.GetLength(0); row++)
            {
                for (int colum = 0; colum < myArry.GetLength(1); colum++)
                {
                    sum += myArry[row,colum];
                   if (maxValue < myArry[row,colum])
                   {
                    maxValue = myArry[row,colum];
                   }
                   if (row == colum)
                   {
                    sumLine += myArry[row,colum];
                   }
                }
            }
            //In gia tri 
            Console.WriteLine("Gia tri lon nhat cua mang la: {0}", maxValue);
            Console.WriteLine("Gia tri tong cua mang la: {0}", sum);
            Console.WriteLine("Gia tri tong duong cheo chinh la: {0}", sumLine);
        }
    }
}