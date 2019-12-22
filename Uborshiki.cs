using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            class Uborshiki : ZooparkR

        {

            string fioubor;

            public string FIOUbor

            {

                get { return fioubor; }

                set { fioubor = value; }

            }

            string ageubor;

            public string AgeUbor

            {

                get { return ageubor; }

                set { ageubor = value; }

            }

            string stazhubor;

            public string StazhUbor

            {

                get { return stazhubor; }

                set { stazhubor = value; }

            }

            public override string StringData

            {

                get { return «Уборщик < Ф.И.О.:» +FIOUbor + «Возраст:» +AgeUbor + «Стаж работы:» +StazhUbor + «>»; }

            }

            public override string getStringData()

            {

                return StringData;

            }

            public Uborshiki()

            : base()

            {

                type = TypeR.Uborshiki;

            }

        }
    }
    }
}
