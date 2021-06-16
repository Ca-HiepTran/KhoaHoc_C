using System;
using System.Collections.Generic;

namespace Buoi7_C
{
    class Buoi7
    {
        static void Main()
        {
            //VD1();
            //VD2();
            TranTheHiep_0968880402 _TenClass = new TranTheHiep_0968880402();
            _TenClass.Test_class();
            Console.ReadLine();
            
        }
        static void VD1()
        {
            //Danh sách đa chiều Array
            List<string> _lts_str = new List<string>(); //Khai báo danh sách
            //Khởi tạo các phần tử;
            string _b1 = "b"; //0
            string _b2 = "a"; //1
            string _b3 = "c"; //2
            //Thêm các phần tử đó vào danh sách
            _lts_str.Add(_b1);
            _lts_str.Add(_b2);
            _lts_str.Add(_b3);
            //in ra màn hình
            /*foreach(string _item_str in _lts_str)
            {
                Console.WriteLine(_item_str);
            }
            Console.ReadLine();*/
            string[] _mang_str = { _b1, _b2, _b3 }; //Thêm 1 mảng vào trong danh sách
            _lts_str.AddRange(_mang_str);
            _lts_str.Sort(); //Sắp xếp theo alphabet
            for (int i = 0; i < _lts_str.Count; i++)
            {
                Console.WriteLine(_lts_str[i]);
            }
            Console.ReadLine();
        }
        static void VD2()
        {
            //Tạo danh sách mảng
            List<string[]> _lst_mang_str = new List<string[]>();
            //tạo dòng 1 : tên cột
            string[] _mang_str_tencot = { "Ten", "Dien Tich","Don Vi" };
            _lst_mang_str.Add(_mang_str_tencot);
            //tạo dòng thứ 2: dữ liệu
            string[] _mang_str_1 = { "Hv1", "35.6", "(cm2)" };
            _lst_mang_str.Add(_mang_str_1);
            //tạo dòng thứ 3 : dữ liệu
            string[] _mang_str_2 = { "Hv2", "24.4", "(cm2)" };
            _lst_mang_str.Add(_mang_str_2);
            //in ra màn hình
            foreach (string[] _item_str in _lst_mang_str)
            {
                Console.Write("{0,-10}", _item_str[0]);
                Console.Write("{0,-15}", _item_str[1]);
                Console.Write("{0,-10} \n", _item_str[2]);
            }
            Console.ReadLine();

        }
        
    }
}
