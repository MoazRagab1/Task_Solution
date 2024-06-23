using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Linked_List
    {
        private Node head;

        public Linked_List()
        {
            this.head = null;
        }

        public void AddLast(int data)
        {


            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }
        public void Display()
        {
            var temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        //remove by data
        public void Remove(int data)
        {
            if (head == null)
                return;

            if (head.data == data)
            {
                head = head.Next;
                return;
            }

            Node temp = head;
            while (temp.Next != null && temp.Next.data != data)
            {
                temp = temp.Next;
            }

            if (temp.Next != null)
            {
                temp.Next = temp.Next.Next;
            }
        }

        // count

        public int Count()
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public void AddPos(int pos, int data)
        {
            int count = Count();
            if (count < pos)
            {
                Console.WriteLine("Out of scope");
                return;
            }

            int currentPosition = 1;
            Node prev = head;
            Node current = head;
            Node newNode = new Node(data);

            while (current != null && currentPosition < pos)
            {
                currentPosition++;
                prev = current;
                current = current.Next;
            }

            if (current == prev)
            {
                head = newNode;
                head.Next = prev;
                return;
            }

            prev.Next = newNode;
            newNode.Next = current;
        }

        public void InsertFront(int data)
        {
            var newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

    }
}

