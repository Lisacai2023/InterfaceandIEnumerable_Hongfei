using System.Xml.Resolvers;

namespace InterfaceandIEnumerable_Hongfei
{
    internal class Program
    {
        //static List<Student> studentList = new List<Student>();
        static ClassRoster prog124 = new ClassRoster();
        static ClassRoster prog122 = new ClassRoster();

        //Hongfei
        //InterfaceandIEnumerable_Practice
        //Week7
        static void Main(string[] args)
        {
            InterfaceExample();
            Preload();


            //foreach (Student student in studentList)
            //{
            //    Console.WriteLine(student);
            //}

            foreach( Student student in prog124)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("----------------------------");
            foreach (Student student in prog122)
            {
                Console.WriteLine(student);
            }





        }//main

        public static void Preload()
        {
            prog124.AddStudent(new Student("Tina", "Lee", 90, 90));
            prog124.AddStudent(new Student("Sam", "Zheng", 100, 100));
            prog124.AddStudent(new Student("Ella", "Chris", 80, 90));

            prog122.AddStudent(new Student("Anna", "Zhang", 100, 100));
            prog122.AddStudent(new Student("Emma", "Wang", 100, 90));

        }

        public static void InterfaceExample()
        {
            Door door = new Door();
            Bottle bottle = new Bottle();
            Chest chest = new Chest();

            List<IOpen> openableItems = new List<IOpen>();
            openableItems.Add(door);
            openableItems.Add(bottle);
            openableItems.Add(chest);

            foreach (var openableItem in openableItems)
            {
                openableItem.Open();
            }

        }





    }//Program 


}//namespace
