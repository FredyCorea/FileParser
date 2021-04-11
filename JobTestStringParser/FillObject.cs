using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTestStringParser
{
     public class FillObject
     {
          public bool DataFiller(Person p, string fieldName, string value)
          {
               switch (fieldName)
               {
                    case "Name":
                         p.Name = value;
                         return true;
                    case "Age":
                         p.Age = Int32.Parse(value);
                         return true;
                    case "City":
                         p.City = value;
                         return true;
                    case "State":
                         p.State = value;
                         return true;
                    case "Female":
                         p.Female = value;
                         return true;
                    case "Student":
                         p.Student = value;
                         return true;
                    case "Employee":
                         p.Employee = value;
                         return true;
                    default:
                         return true;

               }
          }
     }
}
