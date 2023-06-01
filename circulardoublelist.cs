using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using laba16_OOP;

namespace laba16_OOP
{
    [Serializable]
    public class Node<T> : ICloneable where T : ICloneable<T>
    {
        public T? Data;
        public Node<T>? Prev;
        public Node<T>? Next;
        public Node(T data)
        {
            this.Data = data;

        }
        public Node()
        {
            Next = null;
            Data = default(T);
        }

        public Node(Node<T> newnode)
        {
            Data = newnode.Data.Clone();
        }
        public object Clone()
        {
            return new Node<T>(this);
        }


    }
    [Serializable]
    public class circulardoublelist<T> : IEnumerable<T>, ICollection<T> where T : ICloneable<T>
    {
        public Node<T>? head = null;
        public int Count
        {
            get;
            private set;
        }
        public bool IsReadOnly
        {
            get;
            set;
        }

        public circulardoublelist()
        {
            head = null;

        }
        public delegate bool comparatoR(T e1, Person e2);
        public int FindIndex(comparatoR match, Person e)
        {
            for (int i = 0; i < Count; i++)
            {
                if (match(this[i], e)) return i + 1;
            }
            return -1;
        }
        public circulardoublelist(int Count)
        {
            head = null;
            Count = 0;
            for (int i = 0; i < Count; ++i)
            {
                Add(default(T));
            }
        }
        public circulardoublelist(IEnumerable<T> collection)
        {
            foreach (T element in collection)
            {
                Add(element.Clone());
            }
        }

        public void Clear()
        {
            if (head != null)
            {
                Count = 0;
                head = null;
            }
        }
        public circulardoublelist<T> Copy()
        {
            var list = new circulardoublelist<T>();
            var curHead = head;
            list.head = (Node<T>)curHead.Clone();
            list.head.Next = list.head;
            list.head.Prev = list.head;
            list.Count = 1;
            for (var i = 0; i < Count - 1; i++)
            {
                ++list.Count;
                curHead = curHead.Next;
                var curList = (Node<T>)curHead.Clone();
                curList.Next = list.head;
                curList.Prev = list.head.Prev;
                list.head.Prev.Next = curList;
                list.head.Prev = curList;
                list.head = curList;
            }
            return list;
        }

        public circulardoublelist<T> ShallowCopy()
        {
            circulardoublelist<T> copy = new circulardoublelist<T>();

            foreach (T tmp in this)
            {
                copy.Add(tmp);
            }
            return copy;
        }

        public void Add(T element)
        {
            if (head == null)
            {
                Count = 1;
                head = new Node<T>();
                head.Next = head;
                head.Prev = head;
            }
            else
            {
                ++Count;
                var newNode = new Node<T>();
                newNode.Next = head;
                newNode.Prev = head.Prev;
                head.Prev.Next = newNode;
                head.Prev = newNode;
                head = newNode;
            }
            head.Data = element;
        }

        public virtual bool Remove(int index)
        {
            if (head == null)
            {
                return false;
            }
            var curNode = head;
            for (int i = 0; i < index; ++i)
            {
                curNode = curNode.Next;
            }
            if (curNode == head)
            {
                head = curNode.Next;
            }
            curNode.Data = default(T);
            curNode.Next.Prev = curNode.Prev;
            curNode.Prev.Next = curNode.Next;
            --Count;
            return true;
        }

        public virtual T? this[int index]
        {
            get
            {
                if (head != null)
                {
                    var curNode = head;
                    for (int i = 0; i < index; ++i)
                    {
                        curNode = curNode.Next;
                    }
                    return curNode.Data;
                }
                return default(T);
            }
            set
            {
                if (head != null)
                {
                    var curNode = head;
                    for (int i = 0; i < index; ++i)
                    {
                        curNode = curNode.Next;
                    }
                    if (curNode != null)
                    {
                        curNode.Data = value;
                    }
                }
            }
        }

        public void CopyTo(T[] arr, int head)
        {
            if (Count + head <= arr.GetLength(0))
            {
                int i = head;
                foreach (T element in this)
                {
                    arr[i] = element.Clone();
                    ++i;
                }
            }
        }
        public bool Remove(T t)
        {
            if (head != null)
            {
                int iterations = 0;
                while (Contains(t))
                {
                    var curNode = head;
                    int i = 0;
                    while (!curNode.Data.Equals(t))
                    {
                        curNode = curNode.Next;
                        ++i;
                    }
                    if (i == 0)
                    {
                        head = head.Next;
                    }
                    curNode.Data = default(T);
                    curNode.Next.Prev = curNode.Prev;
                    curNode.Prev.Next = curNode.Next;
                    --Count;
                    iterations++;
                }
                if (iterations > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Contains(T toFind)
        {
            if (head == null)
            {
                return false;
            }
            foreach (T element in this)
            {
                if (element.Equals(toFind))
                {
                    return true;
                }
            }
            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            if (head != null)
            {
                var curNode = head;
                for (int i = 0; i < Count; ++i)
                {
                    yield return curNode.Data;
                    curNode = curNode.Next;
                }
            }
            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
