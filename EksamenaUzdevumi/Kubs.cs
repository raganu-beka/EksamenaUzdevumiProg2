namespace EksamenaUzdevumi
{
    class Kubs : IDisposable
    {
        public int MalasGarums
        {
            get { return malasGarums; }
            set
            {
                if (value >= 2 || value <= 10)
                {
                    malasGarums = value;
                } 
                else
                {
                    throw new Exception("Nepareizs malas garums");
                }
            }
        }

        private int malasGarums;

        public void Dispose()
        {
            // Šo sauc par Descructor
            Console.WriteLine("Objekts tika izdzēsts");
            GC.SuppressFinalize(this);
        }
    }
}
