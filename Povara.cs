using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            class Povara : ZooparkR

        {

            string fiopovar;

            public string FIOPovar

            {

                get { return fiopovar; }

                set { fiopovar = value; }

            }

            string agepovar;

            public string AgePovar

            {

                get { return agepovar; }

                set { agepovar = value; }

            }

            string stazhpovar;

            public string StazhPovar

            {

                get { return stazhpovar; }

                set { stazhpovar = value; }

            }

            public override string StringData

            {

                get { return «Повар < Ф.И.О.:» +FIOPovar + «Возраст:» +AgePovar + «Стаж работы:» +StazhPovar + «>»; }

            }

            public override string getStringData()

            {

                return StringData;

            }

            public Povara()

            : base()

            {

                type = TypeR.Povara;

            }

        }
    }
    }
}
