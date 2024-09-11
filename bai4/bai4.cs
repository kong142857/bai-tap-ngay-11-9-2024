// See https://aka.ms/new-console-template for more information
using System;

public class bai4
{
    public void Bai1()
    {
        Console.Write("Nhap so luong cua mang:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap phan tu thu {0}:", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[i];
        }
        Console.WriteLine("Tong phan tu trong mang la: " + sum);
    }
    public void Bai2()
    {
        Console.Write("Nhap vao chuoi:");
        string input = Console.ReadLine();

        int charCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            if (!char.IsWhiteSpace(c) && !char.IsPunctuation(c))
            {
                charCount++;
            }
        }

        Console.WriteLine("So luong ki tu trong chuoi(khong tinh khoang trang va dau cau): " + charCount);
    }
    public void Bai3()
    {
        Console.Write("Nhap so luong cua mang:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap phan tu thu {0}:", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        int max = array[0];
        for (int i = 0; i < n; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        Console.WriteLine("Phan tu lon nhat trong mang la: " + max);
    }
    public void Bai4()
    {
        Console.Write("Nhap vao chuoi:");
        string input = Console.ReadLine();

        string reversed = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        Console.WriteLine("Chuoi dao nguoc: " + reversed);
    }
    public void Bai5()
    {
        Console.Write("Nhap so luong cua mang:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap phan tu thu {0}:", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        bool isPalindrome = true;

        for (int i = 0; i < n; i++)
        {
            if (array[i] != array[n - i - 1])
            {
                isPalindrome = false;
                break;
            }
        }
        if (isPalindrome)
        {
            Console.WriteLine("La mang doi xung!");
        }
        else
        {
            Console.WriteLine("Khong phai mang doi xung!");
        }
    }
    public void Bai6()
    {
        Console.Write("Nhap vao chuoi:");
        string input = Console.ReadLine();

        Console.WriteLine("Nhap ki tu can dem:");
        char characterToCount = Console.ReadKey().KeyChar;
        Console.WriteLine();

        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == characterToCount)
            {
                count++;
            }
        }

        Console.WriteLine("Ky tu'{0}' xuat hien {1} lan trong chuoi! ", characterToCount, count);
    }
}
