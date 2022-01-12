using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ExpressWpfApp5
{
    class OtborTermList : Papa
    {
        
        public static void MainOtborTermList(string choise)
        {
            string outLine = "";
            List<string[]> arr = new List<string[]>();
            string[] choiseSplit = choise.Split(' ');
            if (choise.IndexOf(" ") < 0)
            {
                outLine += choise + ";" + choise.Substring(0, 7) + "\n";
                arr.Add(outLine.Split(';'));
                Say(outLine);
                goto LabelMe;
            }

            string nos = choiseSplit[0].Substring(0, 4);
            foreach (var term in choiseSplit)
            {
                string myTerm = term;
                if (term.Length < 8)
                {
                    myTerm = nos + term;
                }
                string dep = myTerm.Substring(0, 7);
                outLine = myTerm + ";" + dep;
                arr.Add(outLine.Split(';'));

                Say(outLine);

            }




        LabelMe:


            //TextToFile(Path.Combine(dataInPath, "otbor.csv"), outText);

            DbOtborMet.AddManyOtbor(arr);
            //SayGreen(outText);
        }

    }
}
