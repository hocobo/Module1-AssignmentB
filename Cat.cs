namespace Module1_AssignmentB
{
    public class Cat:Pet,ITalkable
    {
        private int _mousesKilled;


        public Cat(string name, int mousesKilled) : base(name)
        {
            _mousesKilled = mousesKilled;
        }

        public int GetMousesKilled() { return _mousesKilled; }

        public void AddMouse() { _mousesKilled++; }

        public string Talk() { return "Meow"; }

        public override string ToString()  { return "Cat: " + "name=" + Name + " mousesKilled=" + _mousesKilled; }
    }
}