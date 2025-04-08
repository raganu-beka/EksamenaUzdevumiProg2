using System.Net.Mail;

namespace EksamenaUzdevumi
{
    class Kubs : IDisposable
    {
        public int MalasGarums
        {
            get { return malasGarums; }
            set
            {
                if (value >= 2 && value <= 10)
                {
                    malasGarums = value;
                } 
                else
                {
                    malasGarums = 2;
                }
            }
        }
        public string KrasasNosaukums;

        private int malasGarums;

        public Kubs(int malasGarums, string krasasNosaukums)
        {
            this.malasGarums = malasGarums;
            KrasasNosaukums = krasasNosaukums;
        }

        public void Dispose()
        {
            // Šo sauc par Descructor
            Console.WriteLine("Objekts tika izdzēsts");
            GC.SuppressFinalize(this);
        }

        public int AprekinatTilpumu()
        {
            return malasGarums * malasGarums * malasGarums;
        }
    }
}
