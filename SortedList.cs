using System;
namespace SortedDoublyLinkedList
{
    public class SortedList<T> where T : IComparable
    {
        Node<T> Head;

        public SortedList()
        {
            Head = new Node<T>(default);
        }

        public void Insert(T value)
        {
            Node<T> newNode = new Node<T>(value);


            Node<T> current = Head.Next;
            Node<T> parent = Head;

            while (current != null)
            {

                if (value.CompareTo(current.Value) <= 0)
                {
                    parent.Next = newNode;
                    current.Previous = newNode;
                    newNode.Next = current;
                    newNode.Previous = parent;
                    return;
                }

                current = current.Next;
                parent = parent.Next;
            }

            parent.Next = newNode;
            newNode.Previous = parent;
        }

        public void Delete(T value)
        {
            Node<T> current = Head.Next;

            while (current.Next != null)
            {
                if (current.Value.CompareTo(value) == 0)
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    return;
                }
                current = current.Next;
            }
            throw new InvalidOperationException("number isnt in list");
        }

        public void Print()
        {
            Node<T> traverse = Head.Next;

            while (traverse != null)
            {
                Console.WriteLine(traverse.Value);

                traverse = traverse.Next;
            }
        }
    }
}
