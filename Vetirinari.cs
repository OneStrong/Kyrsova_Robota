using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            class Veterinari : ZooparkR

        {

            string fioveter;

            public string FIOVeter

            {

                get { return fioveter; }

                set { fioveter = value; }

            }

            string ageveter;

            public string AgeVeter

            {

                get { return ageveter; }

                set { ageveter = value; }

            }

            string stazhveter;

            public string StazhVeter

            {

                get { return stazhveter; }

                set { stazhveter = value; }

            }

            public override string StringData

            {

                get { return «Ветеринар < Ф.И.О.:» +FIOVeter + «Возраст:» +AgeVeter + «Стаж работы:» +StazhVeter + «>»; }

            }

            public override string getStringData()

            {

                return StringData;

            }

            public Veterinari()

            : base()

            {

                type = TypeR.Veterinari;

            }

        }
    }
    }
}
