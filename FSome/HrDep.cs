using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressWpfApp5
{
    internal class HrDep : Papa
    {
        //static List<string[]> koatuAll;
        //static List<string[]> sprArr;
        //static Dictionary<string, List<string[]>> sprDict = new Dictionary<string, List<string[]>>();
        public static void MainHrDep()
        {
            info = "";
            //var x = "";
            //string myKey = "partner";
            string outText = "№ п/п;\"№ Відділення ТОВ \"\"ЕПС\"\"\";Область;Район в обл.;Індекс;Тип населеного пункту;Населений пункт;Район в місті;Тип вулиці;Адреса;Номер будинку;Дата признчення керівника;модель РРО;Заводський № РРО;2;koatu1;koatu2\n";
            var data = GetSummuryOtborData();
            var sizeLine = data[0].Count;

            int count = 0;
            foreach (var u in data)
            {
                try
                {

                    count++;
                    string outLine = "";

                    outLine = String.Format("{0}", count) + ";"
                            + u[0] + ";"
                            + u[1] + ";"
                            + u[2] + ";"
                            + u[3] + ";"
                            + u[4] + ";"
                            + u[5] + ";"
                            + u[6] + ";"
                            + u[7] + ";"
                            + u[8] + ";"
                            + u[9] + ";"
                            + "" + ";"
                            + "" + ";"
                            + "" + ";"
                            + u[10] + ";"
                            + u[11] + ";";

                    string sity = u[5];
                    string districtSity = u[6];
                    string koatuOld = u[11];

                    //string koatuNew = MkKoatuNew(outLine, koatuOld, sity, districtSity);
                    string koatuNew = Koatu2.MkKoatuNew(sity, districtSity, koatuOld);
                    outLine += koatuNew;
                    outText += outLine + "\n";

                    //info += u[0] + "\n";
                    SayCyan($"{u[0]} {koatuNew}");

                }
                catch { }
            }
            string ofName = Path.Combine(dataOutPath, "hr_new_deps.csv");
            TextToFile(ofName, outText);
            //OpenNote(ofName);

        }

        internal static List<List<string>> GetSummuryOtborData()
        {
            #region
            List<List<string>> outList = new List<List<string>>();
            using (var context = new MyDataContext())
            {
                var department = context.departments;
                var terminal = context.terminals;
                var otbor = context.otbors;
                var w = department.ToList();

                var lingVar = from dep in department
                              join otb in otbor on dep.DepartmentDep equals otb.DepOtbor
                              where otb.DepOtbor == dep.DepartmentDep
                              select
                              new
                              {
                                  dep = dep.DepartmentDep,
                                  region = dep.RegionDep,
                                  disrictRegion = dep.DistrictRegionDep,
                                  potIndex = dep.PostIndexDep,
                                  cityType = dep.CityTypeDep,
                                  city = dep.CityDep,
                                  districtCity = dep.DistrictCityDep,
                                  streetType = dep.StreetTypeDep,
                                  street = dep.StreetDep,
                                  hous = dep.HousDep,
                                  adres = dep.AddressDep,
                                  koatu = dep.KoatuDep,
                                  partner = dep.PartnerDep
                              };

                foreach (var line in lingVar)
                {

                    List<string> lineList = new List<string>();
                    lineList.Add(line.dep);
                    lineList.Add(line.region);
                    lineList.Add(line.disrictRegion);
                    lineList.Add(line.potIndex);
                    lineList.Add(line.cityType);
                    lineList.Add(line.city);
                    lineList.Add(line.districtCity);
                    lineList.Add(line.streetType);
                    lineList.Add(line.street);
                    lineList.Add(line.hous);
                    lineList.Add(line.adres);
                    lineList.Add(line.koatu);
                    lineList.Add(line.partner);

                    outList.Add(lineList);
                }

            }
            return outList;
            #endregion
        }

    }
}
