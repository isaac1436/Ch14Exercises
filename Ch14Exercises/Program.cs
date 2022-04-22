namespace AnimalShelter
{
    public class animal
    {
        public enum species { cat, dog }

        public int serNo { get; set; }

        public species Type { get; set; }

        public string name { get; set; }

        public animal(int no, string type, string name)
        {
            this.serNo = no;

            if (type.ToLower() == species.cat.ToString())
            {
                this.Type = species.cat;
            }

            else if (type.ToLower() == species.dog.ToString())
            {
                this.Type = species.dog;
            }

            this.name = name;
        }
    }

    public class Dog : animal
    {
        public Dog(int no,string type, string name):base(no,type,name)
        {
            base.serNo = no;
            base.name = name;
            base.Type = species.dog;
        }

    }

    public class Cat : animal
    {
        public Cat(int no, string type, string name) : base(no, type, name)
        {
            base.serNo = no;
            base.name = name;
            base.Type = species.cat;
        }

    }
}