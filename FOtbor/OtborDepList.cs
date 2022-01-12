using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ExpressWpfApp5
{
    class OtborDepList : Papa
    {
        public static void MainOtborDepList(string choise)
        {
            List<string[]> arr = new List<string[]>();
            string[] choiseSplit = choise.Split(' ');
            if (choise.IndexOf(' ') < 0)
            {
                outLine = $"{choise}1;{choise}";
                arr.Add(outLine.Split(';'));
                Say(outLine);
                goto LabelMe;
            }

            string nos = choiseSplit[0].Substring(0, 4);
            foreach (string depdep in choiseSplit)
            {
                string myDep = depdep;
                if (depdep.Length < 7)
                {
                    myDep = nos + depdep;
                }
                string term = myDep + "1";
                outLine = term + ";" + myDep;
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
