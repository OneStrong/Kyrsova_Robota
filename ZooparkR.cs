using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
public abstract class ZooparkR

        {

            protected TypeR type;

            private static ZooparkR head;

            private ZooparkR next;

            private void add()

            {

                if (head == null)

                    head = this;

                else

                {

                    ZooparkR tail = head;

                    while (tail.next != null)

                        tail = tail.next;

                    tail.next = this;

                }

            }

            public ZooparkR Next

            {

                get { return next; }

                private set { next = value; }

            }

            public ZooparkR()

            {

                next = null;

                add();

            }

            public static ZooparkR Head

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

            public TypeR Type

            {

                get { return type; }

            }
        }
    }
}
