using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HshlomResturant
{
    public class FileRead
    {
        public string p1 = @"C:\Users\UPDATE\Desktop\פרויקט\מסעדת השלום\HshlomResturant\ManegersPasswors.txt";
        public string p2 = @"C:\Users\UPDATE\Desktop\פרויקט\מסעדת השלום\HshlomResturant\EmployeesList.txt";
        public string p3 = @"C:\Users\UPDATE\Desktop\פרויקט\מסעדת השלום\HshlomResturant\EmployeesHours.txt";
        public List<string> lines;


        
        public void Managers_Read(out List<string> mlist)
        {
            
            mlist = new List<string>();
            mlist = File.ReadAllLines(p1).ToList();
          
        }
        public void Employee_read(out List<string> elist)   /// method to access to the file text
        {
            elist = new List<string>();
            elist = File.ReadAllLines(p2).ToList();
        }
        public void Ehours(out List<string> hlist)
        {
            hlist = new List<string>();
            hlist = File.ReadAllLines(p3).ToList();

        }
    }
}
