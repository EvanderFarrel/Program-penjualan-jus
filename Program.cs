using System.Net;
using System.Runtime.CompilerServices;
internal class Program
{
    static int[] hargaJus = { 10000, 10000, 10000 };
    static string[] namaJus = { "Jus Mangga", "Jus Pisang", "Jus Alpukat" };

    static int[] hargaTopping = { 2000, 2000, 2000 };
    static string[] namaTopping = { "Oreo", "Keju", "Boba" };

    static int Topping(int hargaawal)
    {
        int totalharga = hargaawal;
        Console.Write("Apakah anda ingin menggunakan topping tambahan ? (ya/tidak) : ");
        string pilihtopping = Console.ReadLine();
        if (pilihtopping == "ya")
        {
            Console.WriteLine("Pilih Topping : ");
            for (int i = 0; i < hargaTopping.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {namaTopping[i]} = Rp {hargaTopping[i]}");
            }
            Console.Write("Pilih Tambahan Topping (1/2/3) : ");
            int pilihantopping = Convert.ToInt32(Console.ReadLine()) - 1;
            if (pilihantopping >= 0 && pilihantopping < hargaTopping.Length)
            {
                totalharga += hargaTopping[pilihantopping];
                Console.WriteLine($"Anda memilih topping {namaTopping[pilihantopping]}, total menjadi Rp {totalharga}");
            }
            else
            {
                Console.WriteLine("== Maaf Pilihan Topping tidak ada ==");
            }
        }
        else
        {
            Console.WriteLine($"Oke, maka total anda menjadi Rp {totalharga}");
        }
        return totalharga;
    }

    static void menu(int juiceIndex)
    {
        if (juiceIndex < 0 || juiceIndex >= hargaJus.Length)
        {
            Console.WriteLine("== Pilihan menu tidak valid ==");
            return;
        }

        int hargaawal = hargaJus[juiceIndex];
        string namajus = namaJus[juiceIndex];

        Console.WriteLine($"Baik anda memilih untuk membeli {namajus} dengan harga Rp {hargaawal}");
        int totalharga = Topping(hargaawal);

        Console.Write("Apakah Anda ingin menambah pesanan ? (ya/tidak) : ");
        string tambahanpesanan = Console.ReadLine();
        if (tambahanpesanan == "ya")
        {
            tambahpesanan();
        }
        else
        {
            Console.WriteLine($"Baiklah, totalnya adalah Rp {totalharga}");
        }
        Console.WriteLine("== Tekan enter untuk kembali ==");
        Console.ReadKey();
    }

    static void tambahpesanan()
    {
        Console.WriteLine("== Silahkan pilih menu tambahan ==");
        for (int i = 0; i < namaJus.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {namaJus[i]} = Rp {hargaJus[i]}");
        }
        Console.Write("Pilih menu untuk dijadikan tambahan (1/2/3) : ");
        int pilihanmenutambahan = Convert.ToInt32(Console.ReadLine()) - 1;
        if (pilihanmenutambahan >= 0 && pilihanmenutambahan < namaJus.Length)
        {
            menu(pilihanmenutambahan);
        }
        else
        {
            Console.WriteLine("Maaf Pilihan untuk menu tambahan tidak ada");
        }
        Console.WriteLine("== Tekan enter untuk kembali ==");
        Console.ReadKey();
    }

    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("=== Selamat Datang di GetJuice ===");
            Console.WriteLine("==================================");
            Console.WriteLine("============ MENU JUS ============");
            Console.WriteLine("1. Jus Mangga : Rp 10.000");
            Console.WriteLine("2. Jus Pisang : Rp 10.000");
            Console.WriteLine("3. Jus Alpukat : Rp 10.000");
            Console.WriteLine("4. Keluar");
            Console.Write("Masukkan Pilihan Menu (1/2/3/4): ");
            int pilihanmenu = Convert.ToInt32(Console.ReadLine());
            switch (pilihanmenu)
            {
            case 1:
            {
                menu(1);
            }
            break;

            case 2:
            {
                menu(2);
            }
            break;

            case 3:
            {
                menu(3);
            }
            break;

            default:
            {
                Console.WriteLine("== Terimakasih sudah datang ==");
            }
            continue;
            }
        }
    }
}
