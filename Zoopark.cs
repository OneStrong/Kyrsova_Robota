using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoopark
{
    class Program
    {
        static void Main(string[] args)
        { }
            public abstract class Zoopark

        {

            protected Type type;

            private static Zoopark head;

            private Zoopark next;

            private void add()

            {

                if (head == null)

                    head = this;

                else

                {

                    Zoopark tail = head;

                    while (tail.next != null)

                        tail = tail.next;

                    tail.next = this;

                }

            }

            public Zoopark Next

            {

                get { return next; }

                private set { next = value; }

            }

            public Zoopark()

            {

                next = null;

                add();

            }

            public static Zoopark Head

            {

                get { return head; }

            }

            public abstract string getStringData();

            public override string ToString()

            {

                return StringData;

            }

            public abstract string StringData

            {

                get;

            }

            public Type Type

            {

                get { return type; }

            }
        }
    }
}
