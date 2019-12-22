using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            class Animals : Zoopark

        {

            string vid;

            public string Vid

            {

                get { return vid; }

                set { vid = value; }

            }

            string nameanim;

            public string NameAnim

            {

                get { return nameanim; }

                set { nameanim = value; }

            }

            string ageanim;

            public string AgeAnim

            {

                get { return ageanim; }

                set { ageanim = value; }

            }

            string polanim;

            public string PolAnim

            {

                get { return polanim; }

                set { polanim = value; }

            }

            public override string StringData

            {

                get { return «Вид:» +Vid + «Кличка:» +NameAnim + «Возраст:» +AgeAnim + «Пол:» +PolAnim; }

            }

            public override string getStringData()

            {

                return StringData;

            }

            public Animals()

            : base()

            {

                type = Type.Animals;

            }

        }
    }
    }
}
