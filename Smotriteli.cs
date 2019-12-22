using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            class Smotriteli : ZooparkR

        {

            string fiosmotr;

            public string FIOSmotr

            {

                get { return fiosmotr; }

                set { fiosmotr = value; }

            }

            string agesmotr;

            public string AgeSmotr

            {

                get { return agesmotr; }

                set { agesmotr = value; }

            }

            string stazhsmotr;

            public string StazhSmotr

            {

                get { return stazhsmotr; }

                set { stazhsmotr = value; }

            }

            public override string StringData

            {

                get { return «Смотритель < Ф.И.О.:» +FIOSmotr + «Возраст:» +AgeSmotr + «Стаж работы:» +StazhSmotr +»>»; }

            }

            public override string getStringData()

            {

                return StringData;

            }

            public Smotriteli()

            : base()

            {

                type = TypeR.Smotriteli;

            }

        }
    }
    }
}
