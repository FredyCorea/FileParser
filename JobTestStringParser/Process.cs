using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTestStringParser
{
     public static class Process
     {
          public static void start(ref List<Person> personList)
          {

               Person person = new Person(); ;
               //List<Person> personList = new List<Person>();

               string fieldNme;
               string content;
               string contentClean;
               string flagValue;
               string fieldNmeRaw;
               int flagValueStart;

               string path = @"c:\A1\people.txt";
               FillObject fo = new FillObject();

               StreamReader reader = File.OpenText(path);
               string line;
               while ((line = reader.ReadLine()) != null)
               {
                    string[] items = line.Split('\t');

                    foreach (string item in items)
                    {
                         if (item == "")
                         {
                              personList.Add(person);
                              person = new Person();
                              break;
                         }

                         int start = item.IndexOf("(") + 1;
                         int end = item.IndexOf(")", start);

                         fieldNme = item.Substring(start, end - start);

                         fieldNmeRaw = "(" + fieldNme + ")";

                         content = item.ToString();
                         contentClean = content.Replace(fieldNmeRaw, "");

                         if (fieldNme == "City")
                         {
                              //When fieldName = City, the contentClean = "Ashtabula, OH"
                              //Extract and eliminate the State from the City value
                              int stateStart = contentClean.IndexOf(",");
                              if (stateStart > 0){
                                   string state = contentClean.Substring(stateStart, 4);   //", OH"

                                   //Clean city from "Ashtabula, OH" to "Ashtabula" 
                                   contentClean = contentClean.Replace(state, "");

                                   //Clean the state from ", OH" to "OH"
                                   state = state.Replace(",", "");

                                   fo.DataFiller(person, "City", contentClean);
                                   fo.DataFiller(person, "State", state);
                                   break;
                              }
                              
                         }

                         //Process the Flags feil which have 3 values withouh any separation
                         //The order of each value to the corresponding field is assumed based on the instructions
                         if (fieldNme == "Flags" && fieldNme != "Name" && fieldNme != "City" && fieldNme != "Age")
                         {
                              for (int i = 0; i <= 2; i++)
                              {
                                   flagValueStart = i;
                                   flagValue = contentClean.Substring(i, 1);
                                   if (flagValueStart == 0)         //First value mapped to the Female properpery
                                   {
                                        fo.DataFiller(person, "Female", flagValue);
                                   }
                                   else if (flagValueStart == 1)    //Second value mapped to the Student properpery
                                   {
                                        fo.DataFiller(person, "Student", flagValue);
                                   }
                                   else
                                   {
                                        fo.DataFiller(person, "Employee", flagValue); //Third value mapped to the Employee properpery
                                   }
                              }
                         }
                         else
                         {
                              fo.DataFiller(person, fieldNme, contentClean);
                         }
                    }

                    string a = "temp";

               }
               personList.Add(person);

               string b = "temp";
          }
     }
}
