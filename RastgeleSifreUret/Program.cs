namespace RastgeleSifreUret
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
            List<string> YeniDizi = new List<string>();
            for (char b = 'A'; b <= 'Z'; b++)
            {
                YeniDizi.Add(b.ToString());
            }
            for (int s = 0; s <= 9; s++)
            {
                YeniDizi.Add(s.ToString());
            }
            Console.WriteLine("KAÇ HANELİ ŞİFRE OLUŞTURMAK İSTİYORSUN ?");
            int hane = Convert.ToInt32(Console.ReadLine());

            Random rd = new Random();
            for (int i = 0; i < hane; i++)
            {
          
                Console.Write(YeniDizi[rd.Next(YeniDizi.Count)]);

            }






        }
    }
}
