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

          List<Person> personList = new List<Person>();
          //string gender = "Female";
          //string strText = "";

          private void buttonParse_Click(object sender, EventArgs e)
          {
               //List<Person> personList = new List<Person>();

               Process.start(ref personList);

               bindingSource1.DataSource = personList;
               dataGridView1.DataSource = bindingSource1;
               dataGridView1.Refresh();

               buttonExtract.Enabled = true;
          }



          private void buttonExtract_Click(object sender, EventArgs e)
          {
               ////Exptect format
               ////John Doe[20, Male]
               ////        City: Ashtabula
               ////        State : OH
               ////        Student : Yes
               ////        Employee : No

               ////
               //richTextBox1.Text = "";

               ////Iterate the list to extract and format information
               //foreach (var item in personList)
               //{
               //     //These lines for illustration purpose, the Console will
               //     //not appear in this windows form
               //     //unless if I attache the executable
               //     gender = item.Female == "Y" ? "Female" : "Male";
               //     Console.WriteLine(item.Name + " [" + item.Age + "," + gender + "]" + "\n");
               //     Console.WriteLine("City: ".PadLeft(15));
               //     strText = strText + "\n";
               //     strText = strText + (item.Name + " [" + item.Age + "," + gender + "]" + "\n");
               //     strText = strText + "          City    : ";
               //     strText = strText + " " + item.City + "\n";
               //     strText = strText + "          State   : ";
               //     if (item.State != null)
               //     {
               //          strText = strText + " " + (item.State).Trim() + "\n";
               //     }
               //     else
               //     {
               //          item.State = "N/A";
               //          strText = strText + " " + (item.State).Trim() + "\n";
               //          //strText = strText + " " + "          ";
               //     }
               //     strText = strText + "          Employee: ";
               //     strText = strText + " " + (item.Student).Trim() + "\n";
               //     strText = strText + "          Student : ";
               //     strText = strText + " " + item.Student + "\n";
               //}

               //strText = ExtractData.GetList(personList);
               //richTextBox1.Text = strText;
               richTextBox1.Text = ExtractData.GetList(personList);
          }
     }
}
