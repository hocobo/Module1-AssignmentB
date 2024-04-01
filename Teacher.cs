namespace Module1_AssignmentB
{
    public class Teacher:Person,ITalkable
    {
        private int _age;


        public Teacher(string name, int age) : base(name)
        {
            _age = age;
        }

        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public string Talk()
        {
            return "Don't forget to do the assigned reading!";
        }
    }
}