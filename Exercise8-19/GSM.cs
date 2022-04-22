namespace Exercise8_19
{
    public class GSM
    {
        public string model { get; set; }
        public double price { get; set; }
        public string owner { get; set; }
        public enum batteryType { LiIon, NiMH, NiCd }

        public batteryType Battery { get; set; }

        public GSM()
        {
            new GSM(this.owner, this.model);
        }
        public GSM(string? owner = null, string? model = null)
        {
            this.owner = owner;
            this.model = model;
            new GSM(this.price, this.model);
        }

        public GSM(double? price=null, string? model=null)
        {
            this.price = (double)price;
            this.model = model;
            Random rand = new Random();
            new GSM(this.model,rand.Next(1,4));
        }

        public GSM(string? model=null, int? battery=null)
        {
            this.model = model;

            if (battery == 1) { this.Battery = batteryType.LiIon; }

            else if (battery == 2) { this.Battery = batteryType.NiMH; }

            else if (battery == 3) { this.Battery = batteryType.NiCd; }

        }

        public void showInfo(GSM phone)
        {
            Console.WriteLine("\n\nOwner : \t{0}", phone.owner);

            Console.WriteLine("\nModel : \t{0}", phone.model);

            Console.WriteLine("\nBattery : \t{0}", phone.Battery);

            Console.WriteLine("\nPrice : \t{0}", phone.price);
        }
    }
}