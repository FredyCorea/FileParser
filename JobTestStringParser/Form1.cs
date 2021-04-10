using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobTestStringParser
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          public string fileContent = string.Empty;

          private void buttonParse_Click(object sender, EventArgs e)
          {

               Person person = new Person();
               List<Person> personList = new List<Person>();
               string fieldNme;
               string content;
               string contentClean;
               string flagValue;
               string fieldNmeRaw;
               int flagValueStart;
               int flagValueEnd;

               string path = @"c:\A1\people.txt";

               FillObject fo = new FillObject();

               dataGridView1.DataSource = personList;

               StreamReader reader = File.OpenText(path);

               string line;
               while ((line = reader.ReadLine()) != null)
               {

                    string[] items = line.Split('\t');
                    //int myInteger = int.Parse(items[1]);   // Here's your integer.

                    // Now let's find the path.
                    //string path = null;
                    foreach (string item in items)
                    {
                         int start = item.IndexOf("(") + 1;
                         int end = item.IndexOf(")", start);

                         fieldNme = item.Substring(start, end - start);

                         fieldNmeRaw = "(" + fieldNme + ")";

                         //content = line.Remove(fieldNme);
                         content = item.ToString();
                         contentClean = content.Replace(fieldNmeRaw, "");

                         if (fieldNme == "Flags")
                         {
                              for (int i = 0; i < 2; i++)
                              {
                                   flagValueStart = i;
                                   flagValueEnd = i + 1;

                                   flagValue = contentClean.Substring(0, 1);
                                   if (flagValueStart == 0)
                                   {
                                        fo.DataFiller(person, "Female", contentClean, ref personList);
                                   }
                                   else if (flagValueStart == 1)
                                   {
                                        fo.DataFiller(person, "Student", contentClean, ref personList);
                                   }
                                   else
                                   {
                                        fo.DataFiller(person, "Employee", contentClean, ref personList);
                                   }
                              }

                         }
                         else
                         {
                              fo.DataFiller(person, fieldNme, contentClean, ref personList);
                         }
                         string a = "temp";
                    }


               }
          }

     }


}
