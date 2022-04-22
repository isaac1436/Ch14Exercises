using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_19
{
    internal class Call
    {
        public DateOnly date { get { return DateOnly.FromDateTime(DateTime.Now); } }
        public TimeOnly time { get { return TimeOnly.FromDateTime(DateTime.Now); } }
        public double duration
        {
            get
            {
                Random random = new Random();
                return random.Next(1, 1000);
            }
        }

        public Call[] callHistory = new Call[20];

        public double callPrices()
        {
            double totalDuration = 0;

            for (int i = 0; i < callHistory.Length; i++)
            {
                totalDuration += callHistory[i].duration;
            }
            return totalDuration;
        }

        public void printArchive()
        {
            Console.WriteLine("S/N \tTime \t\tDuration \t\tDate");

            for (int i = 0; i < callHistory.Length; i++)
            {
                Console.WriteLine("{0} \t{1} \t\t{2} \t\t{3}", i + 1, callHistory[i].time, callHistory[i].duration, callHistory[i].date);
            }
        }

        public Call()
        {
            for(int i = 0; i < callHistory.Length; i++)
            {
                callHistory[i]=new Call(this.date,this.time,this.duration);
            }
        }

        public Call(DateOnly date,TimeOnly time,double duration)
        {

        }
    }

    internal class main
    {
        static void Main()
        {
            Console.WriteLine("Please fill in this phone registration survey");
            GSM myPhone = new GSM();

            Console.Write("\nWhat is your name : ");
            myPhone.owner = Console.ReadLine();

            Console.Write("\nWhat is the model of your phone : ");
            myPhone.model = Console.ReadLine();

            Console.Write("\nWhat is the price of your phone : ");
            myPhone.price = double.Parse(Console.ReadLine());

            myPhone.showInfo(myPhone);

            Call myCalls = new Call();

            myCalls.printArchive();

            double dur = myCalls.callPrices();

            Console.WriteLine("\nYou're calls lasted a total duration of {0} seconds and they accumulate to a price of ${1}", dur, dur * 0.67);
        }
    }
}
