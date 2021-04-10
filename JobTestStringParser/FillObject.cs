using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTestStringParser
{
     public class FillObject
     {
          public bool DataFiller(Person p, string fieldName, string value, ref List<Person> personList )
          {
               switch (fieldName)
               {
                    case "Name":
                         p.Name = value;
                         return true;
                    case "Age":
                         p.age = Int32.Parse(value);
                         return true;
                     case "City":
                         p.city = value;
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
                         personList.Add(p);
                         return true;

               }
          }
     }
}
