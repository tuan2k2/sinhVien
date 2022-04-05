using System;
using System.Text;

namespace SinhVien
{
    class Program
    {
           
       

        static string getString_317(string mess)
        {
            Console.Write(mess);
            string value_317 = Console.ReadLine();
            return value_317;
        }

        static float getFloat_317(string mess)
        {
            Console.Write(mess);
            float value_317 = float.Parse(Console.ReadLine());
            return value_317;
        }
        static int getInt_317(string mess)
        {
            Console.Write(mess);
            int value_317 = Convert.ToInt32(Console.ReadLine());
            return value_317;
        }
        struct sv_317
        {
            public int msv_317;
            public string tenSV_317;
            public string lop_317;
            public float toan_317;
            public float ly_317;
            public float hoa_317;
        }

        static void NhapSinhVien_317(ref sv_317 SV_317)
        {
            SV_317.msv_317 = getInt_317("\nnhập mã sinh viên");
            SV_317.tenSV_317 = getString_317("nhập họ tên sinh viên");
            SV_317.lop_317 = getString_317("nhập lớp");
            SV_317.toan_317 = getFloat_317("nhập điểm toán");
            SV_317.ly_317 = getFloat_317("nhập điểm lý");
            SV_317.hoa_317 = getFloat_317("nhập điểm hóa");
        }

        static void nhapN_317(ref sv_317 []SV_317,int n)
        { 
            Console.Write("\n____________________________________\n");
            for (int i_317 = 0; i_317 < n; ++i_317)
            {
                Console.Write("\nNhap SV thu {0}:", (i_317 + 1));
                NhapSinhVien_317(ref SV_317[i_317]);
            }
            Console.Write("\n____________________________________\n");
        }

        static void xuatN_317(sv_317 [] SV_317, int n)
        {
            Console.Write("\n____________________________________\n");
            foreach (sv_317 item in SV_317)
            {
                InSinhVien_317(item);
            }
            Console.Write("\n____________________________________\n");
        }
        static void InSinhVien_317(sv_317 SV_317)
        {
            Console.WriteLine(" Mã Sinh Viên: " + SV_317.msv_317);
            Console.WriteLine(" Họ Tên: " + SV_317.tenSV_317);
            Console.WriteLine(" Lớp: " + SV_317.lop_317);
            Console.WriteLine(" Điểm Toán: " + SV_317.toan_317);
            Console.WriteLine(" Điểm Lý: " + SV_317.ly_317);
            Console.WriteLine(" Điểm Hóa: " + SV_317.hoa_317);
            Console.WriteLine("dtb:" + DiemTB_317(SV_317));
        }

        static float DiemTB_317(sv_317 SV_317)
        {
            
            return (SV_317.toan_317 + SV_317.ly_317 + SV_317.hoa_317) / 3;
        }

        static void timSV_317(sv_317[] sV_317, string ten)
        {
            for (int i = 0; i < sV_317.Length; i++)
            {
                if (string.Equals(ten, sV_317[i].tenSV_317))
                {
                    InSinhVien_317(sV_317[i]);
                }

            }
        }
            static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int n_317 = getInt_317(" nhập số sinh viên: ");
            sv_317[] SV_317 = new sv_317[n_317];
            nhapN_317(ref SV_317, n_317);
            xuatN_317(SV_317, n_317);
            string name_317 = getString_317("nhập tên sv:");
            timSV_317(SV_317, name_317);
            Console.ReadKey();

        }
    }
}
