using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Buoi7_C
{
    class TranTheHiep_0968880402
    {
        public void Test_class()
        {
            Bai1();
            
            static void Bai1()
            {
                
                string _Hoten_KQ = NhapTen();
                Console.WriteLine("Day la hoc sinh " + _Hoten_KQ); 
                double _DiemHoa = NhapDiem("Hoa");
                double _DiemToan = NhapDiem("Toan");
                double _DiemLy = NhapDiem("Ly");              
                double _DTB = Math.Round((_DiemHoa + _DiemLy + _DiemToan) / 3, 2); 
                string _HocLuc = Danhgiahocluc(_DTB);                             
                Console.WriteLine("=======TONG KET=======");
                Console.Write("{0,-20}", "Ho va ten ");
                Console.Write("{0}", "|");
                Console.Write("{0,-5}|", "Hoa");

                Console.Write("{0,-5}|", "Toan");

                Console.Write("{0,-5}|", "Ly");

                Console.Write("{0,-5}|", "DTB");

                Console.WriteLine("{0,-10}", "Hoc Luc \n");

                Console.Write("{0,-20}", _Hoten_KQ);
                Console.Write("{0}", "|");
                Console.Write("{0,-5}|", _DiemHoa);

                Console.Write("{0,-5}|", _DiemToan);

                Console.Write("{0,-5}|", _DiemLy);

                Console.Write("{0,-5}|", _DTB);

                Console.Write("{0,-10}", _HocLuc);
                Console.ReadLine();
            }
            static string NhapTen() 
            {
                Console.Write("Ho ten cua ban la: ");
                string _Hoten = Console.ReadLine();
                if (_Hoten != "" && _Hoten != " ") 
                {
                    if (!char.IsNumber(_Hoten, 0)) 
                    {
                        if (_Hoten.Length > 3) 
                        {
                            return _Hoten;
                        }
                        else
                        {
                            Console.WriteLine("Ho ten cua ban qua ngan! ");
                            NhapTen();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Khong duoc nhap so vao ho ten! ");
                        NhapTen();
                    }
                }
                else
                {
                    Console.WriteLine("Ban chua nhap ho ten cua ban ! ");
                    NhapTen();
                }
                
                return ""; 
            }
            static double NhapDiem(string _TenMonHoc)
            {
                double _dbl_Diem = 0.0;
                Console.Write("Diem mon {0} ban la: ", _TenMonHoc);
                string _str_Diem = Console.ReadLine();
                if (_str_Diem != "" && _str_Diem != " ") 
                {
                    if (char.IsNumber(_str_Diem, 0)) 
                    {
                        _dbl_Diem = double.Parse(_str_Diem);
                        if (_dbl_Diem >= 0) 
                        {
                            if (_dbl_Diem <= 10) 
                            {
                                return _dbl_Diem;
                            }
                            else
                            {
                                Console.WriteLine("Diem khong hop ly! ");
                                NhapDiem(_TenMonHoc);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ban phai nhap so duong! ");
                            NhapDiem(_TenMonHoc);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ban phai nhap so! ");
                        NhapDiem(_TenMonHoc);
                    }
                }
                else
                {
                    Console.WriteLine("Ban chua nhap diem! ");
                    NhapDiem(_TenMonHoc);
                }
                return _dbl_Diem;
            }
            static string Danhgiahocluc(double _DTB)
            {
                string _HocLuc = "";
                if (_DTB >= 0 && _DTB < 5)
                {
                    _HocLuc = "Trung Binh";
                }
                else if (_DTB >= 5 && _DTB < 7)
                {
                    _HocLuc = "Kha";
                }
                else if (_DTB >= 7 && _DTB < 10)
                {
                    _HocLuc = "Gioi";
                }
                return _HocLuc;
            }
        }

    }
        
               
    
}
