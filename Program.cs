using System;

class HinhChuNhat
{
    private double chieuDai;
    private double chieuRong;

    public void SetChieuDai(double dai)
    {
        chieuDai = dai;
    }

    public void SetChieuRong(double rong)
    {
        chieuRong = rong;
    }

    public double TinhDienTich()
    {
        return chieuDai * chieuRong;
    }

    public double TinhChuVi()
    {
        return 2 * (chieuDai + chieuRong);
    }

    public void HienThiHinhChuNhat()
    {
        for (int i = 0; i < chieuRong; i++)
        {
            for (int j = 0; j < chieuDai; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        HinhChuNhat hcn = new HinhChuNhat();
        hcn.SetChieuDai(5);
        hcn.SetChieuRong(3);

        double dienTich = hcn.TinhDienTich();
        double chuVi = hcn.TinhChuVi();

        Console.WriteLine("Diện tích: " + dienTich);
        Console.WriteLine("Chu vi: " + chuVi);

        hcn.HienThiHinhChuNhat();
    }
}