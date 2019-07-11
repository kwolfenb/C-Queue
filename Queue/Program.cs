using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }
    }
    public class Queue
    {

        public Node first;
        public Node last;
        public int size;

        Queue()
        {
            this.first = null;
            this.last = null;
            this.size = 0;
        }
        public void Enqueue(int data) // add to end of queue
        {
            Node newNode = new Node(data);
            if (this.last != null)
            {
                this.last.next = newNode;
                this.last = newNode;
            }
            if (this.first == null)
            {
                this.first = newNode;
                this.last = newNode;
            }
            this.size++;
        }

        public Node Dequeue() // remove from front of queue
        {
            if (this.first == null)
            {
                return null;
            }
            Node result = this.first;
            if (size == 1)
            {
                this.first = null;
                last = null;
            }
            else
            {
                this.first = this.first.next;
            }
            this.size--;
            return result;
        }

        public int CountQueue()
        {
            Node node = this.first;
            int result = 1;
            while (node.next != null)
            {
                result++;
                node = node.next;
            }
            return result;
        }
        public bool IsEmpty()
        {
            return first == null;
        }

        public int Peak()
        {
            return first.data;
        }
        public void Traverse()
        {
            if (this.first == null) Console.WriteLine("Queue is empty");
            else
            {
                Console.WriteLine("There are " + this.size + " nodes:");
                Node currentNode = this.first;
                while (currentNode != null)
                {
                    if (currentNode == this.first)
                    {
                        Console.WriteLine("First: " + currentNode.data);
                    }
                    else if (currentNode == this.last)
                    {
                        Console.WriteLine("Last: " + currentNode.data);
                    }
                    else
                    {
                        Console.WriteLine(currentNode.data);
                    }
                    if (currentNode.next != null)
                    {
                        currentNode = currentNode.next;
                    }
                    else break;
                }
            }
        }
        public static void Main()
        {
            //Create Nodes
            Queue queue = new Queue();
            queue.Traverse();
            queue.Enqueue(1); queue.Enqueue(2); queue.Enqueue(3); queue.Enqueue(4);
            queue.Traverse();
            Node node = queue.Dequeue();
            Console.WriteLine("Dequeue: " + node.data);
            queue.Traverse();
            Console.WriteLine("Peak: " + queue.Peak());
            Console.WriteLine("IsEmpty: " + queue.IsEmpty());
        }

    }
}
