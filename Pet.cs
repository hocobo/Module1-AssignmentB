namespace Module1_AssignmentB
{
    public abstract class Pet
    {
        protected string Name;

        public Pet(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}