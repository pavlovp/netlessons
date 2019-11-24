using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab8_b
{

    public class MyQueue<T> : GeneralCollection<T> where T: IComparable<T>
    {
        private Node tail;

        public override void Add(T elem)
        {
            if(this.head == null)
            {
                this.head = this.tail = new Node(elem);
            }
            else
            {
                this.tail.Next = new Node(elem);
                tail = tail.Next;
            }

        }

        public T GetMaxElement()
        {
            if (this.head == null)
                throw new Exception("dsdf");

            T max = this.head.Data;
            //Node it = this.head;
            foreach (T it in this)
            {
                if(it.CompareTo(max) > 0)
                {
                    max = it;
                }
            }

            return max;
        }

        public override T Remove()
        {
            T tmp = base.Remove();
            if(this.head == null)
            {
                this.tail = null;
            }
            return tmp;
        }
    }

    public class MyStack<T> : GeneralCollection<T>
    {
       public override void Add(T elem)
        {
            Node newhead = new Node(elem);
            if(this.head == null)
            {
                this.head = newhead;
            }
            else
            {
                newhead.Next = this.head;
                this.head = newhead;
            }
        }

        public override string ToString()
        {
            return "Stack: " + base.ToString();
        }
    }

    // dodać do deklaracji odpowiednie interfejsy (jeśli będą potrzebne)
    public abstract class GeneralCollection<T> : IMyCollection<T>, IEnumerable
    {
        protected Node head;

        public int Size {
            get
            {
                if (head == null)
                    return 0;
                else
                {
                    Node it = this.head;
                    int licz = 1;
                    while (it.Next != null)
                    {
                        it = it.Next;
                        licz++;
                    }
                    return licz;
                }
            }
        }

        private Node GetEnd(out int len)
        {

            len = 0;
            if (head == null)
                return head;
            else
            {
                Node it = this.head;
                int licz = 1;
                while (it.Next != null)
                {
                    it = it.Next;
                    licz++;
                }
                len = licz;
                return it;
            }
        }

        public virtual void Add(T elem)
        {
            if(head == null)
            {
                this.head = new Node(elem);
            }
            else
            {
                Node it = this.head;

                while (it.Next != null)
                    it = it.Next;

                it.Next = new Node(elem);
            }
        }

        public T Get()
        {
            if (this.head == null)
            {
                throw new Exception("List is empty");
            }
            else return this.head.Data;
        }

        public virtual T Remove()
        {
            if (this.head == null)
            {
                throw new Exception("List is empty");
            }
            else
            {
                T res = head.Data;
                head = head.Next;
                return res;
            }
        }

        public override string ToString()
        {
            string res = "";
            if (head == null)
                return res;
            else
            {
                Node it = this.head;

                res += head.Data;
                while (it.Next != null)
                {
                    it = it.Next;
                    res += " " + it.Data;
                }
                return res;
            }
        }

        public IEnumerator GetEnumerator()
        {
            if (head != null)
            {
                Node it = this.head;
                yield return it.Data;

                while (it.Next != null)
                {
                    it = it.Next;
                    yield return it.Data;
                }
            }
        }

        protected class Node
        {
            public Node(T t)
            {
                Next = null;
                Data = t;
            }
            public Node Next { get; set; }
            public T Data { get; set; }
        }
    }


    public interface IMyCollection<T>
    {
        void Add(T elem);

        T Get();

        T Remove();

        int Size { get; }
    }



}