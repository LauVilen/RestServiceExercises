using System;

namespace ModelLib
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Quality { get; set; }
        public double Quantity { get; set; }

        public Item(int id, string name, string quality, double quantity)
        {
            ID = id;
            Name = name;
            Quality = quality;
            Quantity = quantity;
        }

        public Item()
        {
            
        }

        public override string ToString()
        {
            return $"Id: {ID}, {Name} of {Quality} quality. Quantity: {Quantity}";
        }
    }
}
