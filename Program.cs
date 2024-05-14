using System.Globalization;

namespace FormattingIdr
{
    static class Program
    {
        static void Main()
        {
            // Set CultureInfo ke Indonesia
            CultureInfo indonesiaCulture = new("id-ID");

            // Jumlah uang
            double amount = 7250050.35;

            // Format C2 - angka dibelakang koma akan menjadi sen
            string formattedAmountC2 = amount.ToString("C2", indonesiaCulture);
            string formattedAmountC0 = amount.ToString("C0", indonesiaCulture);

            // Output
            Console.WriteLine(formattedAmountC2); // Output: Rp7.250.050
            Console.WriteLine(formattedAmountC0); // Output: Rp7.250.050,35 
        }
    }
}
