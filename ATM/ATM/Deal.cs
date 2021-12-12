using System;

namespace ATM
{
    class Deal
    {
        public int Deal_size { get; set; }
        DateTime dateTime;
        public Deal(int deal)
        {
            Deal_size = deal;
            dateTime = DateTime.Now;
        }

        public void Print()
        {
            Console.WriteLine($"Deal size: {Deal_size}$\tDate: {dateTime}");
        }
    }
}
