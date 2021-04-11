using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JobTestStringParser
{
     public class Person
     {
          public string Name { get; set; }
          public int Age { get; set; }
          public string City { get; set; }
          public string State { get; set; }
          
          [DisplayName("Is Female")]
          public string Female { get; set; }

          [DisplayName("Is Student")]
          public string Student { get; set; }

          [DisplayName("Is Employee")]
          public string Employee { get; set; }

     }
}
