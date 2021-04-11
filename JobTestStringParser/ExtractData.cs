using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTestStringParser
{
     public static class ExtractData
     {
          public  static string GetList(List<Person> personList)
          {

               //Exptect format
               //John Doe[20, Male]
               //        City: Ashtabula
               //        State : OH
               //        Student : Yes
               //        Employee : No

               //

               string gender = "Female";
               string strText = "";

               //Iterate the list to extract and format information
               foreach (var item in personList)
               {
                    //These lines for illustration purpose, the Console will
                    //not appear in this windows form
                    //unless if I attache the executable
                    gender = item.Female == "Y" ? "Female" : "Male";
                    Console.WriteLine(item.Name + " [" + item.Age + "," + gender + "]" + "\n");
                    Console.WriteLine("City: ".PadLeft(15));

                    strText = strText + "\n";
                    strText = strText + (item.Name + " [" + item.Age + "," + gender + "]" + "\n");

                    strText = strText + "          City    : ";
                    strText = strText + " " + item.City + "\n";

                    strText = strText + "          State   : ";
                    if (item.State != null)
                    {
                         strText = strText + " " + (item.State).Trim() + "\n";
                    }
                    else
                    {
                         item.State = "N/A";
                         strText = strText + " " + (item.State).Trim() + "\n";
                         //strText = strText + " " + "          ";
                    }

                    strText = strText + "          Employee: ";
                    strText = strText + " " + (item.Student).Trim() + "\n";

                    strText = strText + "          Student : ";
                    strText = strText + " " + item.Student + "\n";

               }

               return strText;
          }
     }
}
