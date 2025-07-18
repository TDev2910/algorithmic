using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<int> numbers = new List<int>();
            Console.WriteLine("Mời bạn nhập 5 phần tử đầu tiên :");
            for(int i = 0; i < 5; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1} : ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("Danh sách ban đầu ta có là :");
            PrintList(numbers);
            string Choice;
            do
            {
                Console.WriteLine("Mời bạn chọn thao tác chức năng!!!");
                Console.WriteLine("1.Thêm phần tử");
                Console.WriteLine("2.Xóa phần tử");
                Console.WriteLine("3.Thay thế phần tử");
                Console.WriteLine("4.Sắp xếp danh sách");
                Console.WriteLine("5.Tìm vị trí index");
                Console.WriteLine("6.In danh sách");
                Console.WriteLine("7.Kết thúc chương trình");
                Choice = Console.ReadLine();
                switch (Choice)
                {
                    case "1":
                        AddNumbers(numbers);
                        break;
                    case "2":
                        DeleteNumbers(numbers);
                        break;
                    case "3":
                        ChangeNumbers(numbers);
                        break;
                    case "4":
                        SortList(numbers);
                        break;
                    case "5":
                        FindIndex(numbers);
                        break;
                    case "6":
                        PrintList(numbers);
                        break;
                    case "7":
                        Console.WriteLine("Kết thúc chương trình. Cảm ơn bạn đã sử dụng!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại.");
                        break;
                }
            }
            while (Choice != "7");
        }   

        static void AddNumbers(List<int> list)
        {
            Console.Write("Nhập phần tử mới bạn muốn thêm vào : ");
            int newNumber = int.Parse(Console.ReadLine());
            Console.Write("Nhập vị trí index bạn muốn thêm phần tử :");
            int index = int.Parse(Console.ReadLine());
            if(index < 0 || index > list.Count)
            {
                Console.WriteLine("Vị trí nhập không hợp lệ");
                return;
            }
            list.Insert(index, newNumber);
            Console.WriteLine($"Đã thêm phần tử {newNumber} với vị trí index là {index}");
        }
        static void DeleteNumbers(List<int> list)
        {
            Console.Write("Nhập vị trí bạn muốn xóa phần tử :");
            int index = int.Parse(Console.ReadLine());
            if (index < 0 || index >= list.Count)
            {
                Console.WriteLine("Vị trí nhập không hợp lệ");
                return;
            }
            list.RemoveAt(index);
            Console.WriteLine($"Đã xóa phần tử tại vị trí {index}");
        }
        static void ChangeNumbers(List<int> list)
        {
            Console.Write("Mời bạn nhập vị trí phần tử muốn thay đổi :");
            int index = int.Parse(Console.ReadLine());
            if(index < 0 || index >= list.Count)
            {
                Console.WriteLine("Vị trí nhập không hợp lệ");
                return;
            }
            Console.Write("Nhập giá trị phần tử thay thế :");
            int newValue = int.Parse(Console.ReadLine());
            list[index] = newValue;
            Console.WriteLine($"Đã thay thế phần tử tại vị trí {index} đến phần tử mới {newValue}");
        }
        static void SortList(List<int> list)
        {
            list.Sort();
            Console.WriteLine("Danh sách đã được sắp xếp.");
        }
        static void FindIndex(List<int> list)
        {
            Console.Write("Nhập giá vị trị index bạn cần tìm :");
            int value = int.Parse(Console.ReadLine());
            int index = list.IndexOf(value);
            if (index != -1)
            {
                Console.WriteLine($"Giá trị {value} được tìm thấy tại vị trí index {index}.");
            }
            else
            {
                Console.WriteLine($"Giá trị {value} không có trong danh sách.");
            }
        }
        static void PrintList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
