using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi_ChuaBai
{
    
    class Class1
    {
        //khởi tạo list toàn cục,thuộc kiểu danh ssasch các mảng 1 chiều :
        static List<string[]> _Danhsach_HocSinh = new List<string[]>();
        public void BaiKiemTra()
        {
            //khởi tạo tên cột
            string[] _TenCot = new string[] { "STT", "Ho va ten", "Toan", "Ly", "Hoa", "DTB", "Xep Loai" };
            //thêm mảng tên cột vào danh sách
            _Danhsach_HocSinh.Add(_TenCot);
            //bắt đầu nhập liệu
            string _KiemTra = "Y";
            int _stt = 1;
            while (_KiemTra == "Y")
            {
                //nhập các thông tin
                string _Hoten = Nhapten();
                double _dou_Toan = NhapDiem("Toan");
                double _dou_Ly = NhapDiem("Ly");
                double _dou_Hoa = NhapDiem("Hoa");
                //tính điểm trung bình:
                double _dou_DTB = (_dou_Toan + _dou_Ly + _dou_Hoa) / 3;
                //làm tròn số thập phân
                _dou_DTB = Math.Round(_dou_DTB, 2);
                //xếp loại học lực
                string _XepLoai = DanhGiaHocLuc(_dou_DTB);
                //tạo 1 dòng (mảng 1 chiều)
                string[] _dong = new string[] { Convert.ToString(_stt),//stt
                    _Hoten, //họ và tên
                    Convert.ToString(_dou_Toan), //điểm toán
                    Convert.ToString(_dou_Ly), //điểm lý
                    Convert.ToString(_dou_Hoa), //điểm hóa
                    Convert.ToString(_dou_DTB), //điểm trung bình
                    _XepLoai};

                _Danhsach_HocSinh.Add(_dong);
                //hỏi lại xem có tiếp tục không
                Console.WriteLine("___________________________________");
                Console.Write("Ban muon tiep tuc hay khong (Y/N): ");
                _KiemTra = Console.ReadLine().ToUpper();
                _stt++;
            }
            //Console.WriteLine("ban da dung!");
            //bắt đầu in danh sách;
            Console.WriteLine("=======DANH SACH HOC SINH=======");
            for (int i = 0; i < _Danhsach_HocSinh.Count; i++)
            {
                string[] _Dong = _Danhsach_HocSinh[i];
                //in kết quả
                Console.Write("{0,-5}|", _Dong[0]); //stt
                Console.Write("{0,-20}|", _Dong[1]); //họ và tên
                Console.Write("{0,-5}|", _Dong[2]); //điểm toán
                Console.Write("{0,-5}|", _Dong[3]); //điểm lý
                Console.Write("{0,-5}|", _Dong[4]); //điểm hóa
                Console.Write("{0,-5}|", _Dong[5]); //điểm tb
                Console.WriteLine("{0,-10}", _Dong[6]); //xếp loại

            }
            //Console.ReadLine();
            //sắp xếp giảm dần
            List<string[]> _DanhSachMoi_GiamDan = SapXep_GiamDan(_Danhsach_HocSinh);
            //bắt đầu in danh sách
            Console.WriteLine("_______________________________");
            Console.WriteLine("=======SAP XEP GIAM DAN========");
            for (int i = 0; i < _DanhSachMoi_GiamDan.Count; i++)
            {
                string[] _Dong = _DanhSachMoi_GiamDan[i];
                //in kết quả
                Console.Write("{0,-5}|", _Dong[0]); //stt
                Console.Write("{0,-20}|", _Dong[1]); //họ và tên
                Console.Write("{0,-5}|", _Dong[2]); //điểm toán
                Console.Write("{0,-5}|", _Dong[3]); //điểm lý
                Console.Write("{0,-5}|", _Dong[4]); //điểm hóa
                Console.Write("{0,-5}|", _Dong[5]); //điểm tb
                Console.WriteLine("{0,-10}", _Dong[6]); //xếp loại
            }
            Console.ReadLine();
        }
        static List<string[]> SapXep_GiamDan(List<string[]> _DanhSach)
        {
            for (int i = 1; i < _DanhSach.Count - 1; i++)
            {
                for (int j = i + 1; j < _DanhSach.Count; j++)
                {
                    if (Convert.ToDouble(_DanhSach[i][5]) < Convert.ToDouble(_DanhSach[j][5]))
                    {
                        string[] _Dong_TG = _DanhSach[i];
                        _DanhSach[i] = _DanhSach[j];
                        _DanhSach[i] = _Dong_TG;


                    }
                }
            }
            //đánh lại stt
            for (int i = 1; i < _DanhSach.Count; i++)
            {
                _DanhSach[i][0] = Convert.ToString(i);
            }
            return _DanhSach;
        }
        static string Nhapten()
        {
            Console.Write("Ho ten cua ban la: ");
            string _HoTen = Console.ReadLine();
            if (_HoTen != "" && _HoTen != " ")  //Cách 1: Kiểm tra rỗng
            {
                if (!char.IsNumber(_HoTen, 0)) //Kiểm tra nó là số hay không
                {
                    if (_HoTen.Length > 3) //Kiểm tra nhập quá ngắn
                    {
                        return _HoTen;
                    }
                    else
                    {
                        Console.WriteLine("Ho ten cua ban qua ngan!");
                        Nhapten();
                    }
                }
                else
                {
                    Console.WriteLine("Khong duoc nhap so vao ho ten!");
                    Nhapten();
                }
            }
            else
            {
                Console.WriteLine("Ban chua nhap ho ten cua ban!");
                Nhapten();
            }
            //if (string.IsNullOrEmpty(_HoTen) && string.IsNullOrWhiteSpace(_HoTen)) //Cách 2: Kiểm tra rỗng
            //{

            //}
            return "";

        }
        static double NhapDiem(string _TenMonHoc)
        {
            double _dbl_Diem = 0.0;
            Console.Write("diem mon {0} cua ban la: ", _TenMonHoc);
            string _str_Diem = Console.ReadLine();
            if (_str_Diem != "" && _str_Diem != " ")//DK1: Kiểm tra rỗng
            {
                if (char.IsNumber(_str_Diem, 0))//DK2: Kiem tra la so hay không
                {
                    _dbl_Diem = double.Parse(_str_Diem);
                    if (_dbl_Diem >= 0) //DK3: Kiểm tra nhâp số âm
                    {
                        if (_dbl_Diem <= 10) //DK4: Nhap diem qua to
                        {
                            return _dbl_Diem;
                        }
                        else
                        {
                            Console.WriteLine("Diem khong hop ly!");
                            return NhapDiem(_TenMonHoc);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ban phai nhap so duong!");
                        return NhapDiem(_TenMonHoc);
                    }
                }
                else
                {
                    Console.WriteLine("Ban phai nhap so!");
                    return NhapDiem(_TenMonHoc);
                }
            }
            else
            {
                Console.WriteLine("Ban chua nhap diem!");
                return NhapDiem(_TenMonHoc);
            }
            //return _dbl_Diem;
        }
        static string DanhGiaHocLuc(double _DTB)
        {
            string _HocLuc = "";
            if (_DTB >= 0 && _DTB < 5)
            {
                _HocLuc = "Trung binh";
            }
            else if (_DTB >= 5 && _DTB < 7)
            {
                _HocLuc = "Kha";

            }
            else if (_DTB >= 7 && _DTB <= 10)
            {
                _HocLuc = "Gioi";
            }
            return _HocLuc;
        }
    }
}
