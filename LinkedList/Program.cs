using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Linked_List n1 = new Linked_List();
            n1.AddLast(1);
            n1.AddLast(8);
            n1.AddLast(9);
            n1.AddFirst(4);

            n1.Display();
            n1.Remove(8);
            n1.Display();
            n1.AddPos(3, 4);
            n1.Display();


        }
    }
}
