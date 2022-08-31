using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class ListaGen<T>
    {
        public void delete(int x)
        {
           
        }

        public void insertToFront(object x)
        {
            
        }

        private class Nod
        {
            private T data;
            private Nod next;

          


        public Nod Next
            {
                get { return next; }
                set { next = value; }
            }

        public T Data
            {
                get { return data; }
                set { data = value; }

            }


            private Nod start;
            private Nod end;
            private T t;

            public Nod(T t)
            {
                this.t = t;
            }

            public void ListaGen()
            {
                start = null; end = null;
                
            }

            public void insertToFront(T t)
            {
                Nod n = new Nod(t);
                n.Next = start;
                start = n;
                if (end == null) end = n;
            }

            public void insertToEnd(T t)
            {
                Nod n = new Nod(t);
                if (start == null) start = n;
                if (end != null) end.Next = n;
                end = n;
            }

            public void delete(T t)
            {
                Nod current = start;
                while (current != null && current.Data.Equals(t))
                {
                    start = start.Next;
                    current = start;
                }
                if (current == null) return;
                while (current.Next != null)
                {
                    if (current.Next.Data.Equals(t))
                    {
                        if (end == current.Next)
                        {
                            end = current;
                            end.Next = null;
                        }
                        else
                        {
                            Nod delNod = current.Next;
                            current.Next = current.Next.Next;
                            delNod.Next = null;
                        }
                    }
                    else current = current.Next;
                }
            }
            public IEnumerator<T> GetEnumerator()
            {
                Nod current = start;
                while (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }

        }


    }


}
