namespace GeradorDeCSVsImaginPhotos
{
    internal class Item
    {
        private string name;
        private object value;
        public string Name { get => name; set => name = value; }
        public object Value { get => value; set => this.value = value; }
        public Item(string name, object value)
        {
            this.name = name; this.value = value;
        }
        public override string ToString()
        {
            return name;
        }
    }
}