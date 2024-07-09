using System.ComponentModel.Design;
using System.Reflection;
using System.Security;
using static OOP_Session_1_Assignment.Program;

namespace OOP_Session_1_Assignment
{
    class Program
    {
        public enum DaysOfWeek
        {
            Saturday,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,


        }
        public enum Seasons

        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        [Flags]
        public enum Permissions
        {
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }
        class Stuff
        {
            public string Name;
            public Permissions Permission;
        }
        public enum Colors
        {
            Red,
            Green,
            Blue
        }
      
        static void Main()
        {
            #region Problem 1
            //foreach (DaysOfWeek Desired_day in Enum.GetValues(typeof(DaysOfWeek)))
            //{
            //    Console.WriteLine(Desired_day);
            //}
            #endregion
            #region Problem 2
            //Console.Write("Hello,Please Enter The Season Name:=");
            //string name = Console.ReadLine();
            //if (Enum.TryParse(name, true, out Seasons season))
            //{
            //    switch (season)
            //    {
            //        case Seasons.Spring:
            //            Console.WriteLine("spring starts from march to may");
            //            break;
            //        case Seasons.Summer:
            //            Console.WriteLine("summer starts from june to august");
            //            break;
            //            case Seasons.Winter:
            //            Console.WriteLine("winter starts from December to February");
            //            break;
            //        case Seasons.Autumn:
            //            Console.WriteLine("autumn starts from September to November ");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Season Name Entered");
            //            break;

            //    }

            //}
            //else
            //    Console.WriteLine("Invalid Season Name Entered");
            #endregion
            #region Problem 3
            //Stuff stuff = new Stuff();
            //stuff.Name = "Mahmoud";
            //stuff.Permission = Permissions.Read;
            //Console.WriteLine(stuff.Permission);
            //stuff.Permission = (Permissions)3;//we added write permission
            //Console.WriteLine(stuff.Permission);
            //read,write
            //stuff.Permission = stuff.Permission ^ Permissions.Execute;//another way of addition
            //Console.WriteLine(stuff.Permission);
            //read,write,execution
            //stuff.Permission = stuff.Permission ^ Permissions.Execute;//we deleted the execute permission
            //Console.WriteLine(stuff.Permission);
            //read,write
            //stuff.Permission = stuff.Permission | Permissions.Execute;*/// here first the clr will check if permission execute is 
            //is existed or not, in this case its not existed so it will add it and if it was here,it will do nothing to it then
            //read,write,execute
            //Console.WriteLine(stuff.Permission);
            // stuff.Permission = stuff.Permission | Permissions.Execute;*///here execute is already exist so it will do nothing to it
            //Console.WriteLine(stuff.Permission);
            //read,write,execute
            //if we wanna delete for example write permission then we do as following:-
            //stuff.Permission = stuff.Permission ^ Permissions.Write;
            //Console.WriteLine(stuff.Permission);
            //here we gonna check if execute permission is existed or not
            //if ((stuff.Permission & Permissions.Execute) == Permissions.Execute)
            //{
            //    Console.WriteLine("execute Is Existed");
            //}
            //else
            //{
            //    {
            //        stuff.Permission = stuff.Permission ^ Permissions.Execute;
            //    }
            #endregion
            #region Problem 4
            //Console.Write("Hello,Please Enter The Desired color name(From red,green,blue) :");
            //string name = Console.ReadLine();
            //if (Enum.TryParse(name, true, out Colors color))
            //{
            //    switch (color)
            //    {
            //        case Colors.Red:
            //            Console.WriteLine($"{color} Is From The Primary Colours");
            //            break;
            //        case Colors.Green:
            //            Console.WriteLine($"{color} Is From The Primary Colours");
            //            break;
            //        case Colors.Blue:
            //            Console.WriteLine($"{color} Is From The Primary Colours");
            //            break;
            //    }
            //}
            //else
            //    Console.WriteLine("The Entered Colour Is Not From The Primary Colours");
            #endregion
            #region Problem 5
           //couldnt understand or solve the problem
            #endregion
        }
    }
    }
