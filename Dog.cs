using System;

namespace Module1_AssignmentB
{
    public class Dog:Pet,ITalkable
    {
        private bool _friendly;

        public Dog(string name, bool friendly) : base(name)
        {
            _friendly = friendly;
        }

        public bool IsFriendly() { return _friendly; }
        
        public string Talk() { return "Bark"; }
        
        public override string ToString() {return "Dog: " + "name=" + Name + " friendly=" + _friendly;}
    }
}