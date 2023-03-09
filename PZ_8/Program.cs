using System;

namespace PZ_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Student stud1 = new Student("Student", new offset());
            int ball1 = rnd.Next(50, 100);
            int ball2 = rnd.Next(50, 100);
            int ball3 = rnd.Next(2,5);
            stud1.GO(ball1);
            stud1.Knowledge = new Diffoffset();
            stud1.GO(ball2);
            if (ball3 < 70 && ball2 < 70)
            {
                Console.WriteLine("Не допущен ");
            }
            else
            {

                stud1.Knowledge = new exam();
                stud1.GO(ball3); 
        }
            Console.ReadLine();
        }
        interface IKnowledge
        {
            void GO(int ball);
           
        }
        
        class offset : IKnowledge
        {
           
            public void GO(int g)
            {
                if (g < 70)
                {
                    Console.WriteLine("Зачет не cдан"+ g);

                }
                else
                {
                    Console.WriteLine("Сдан зачета "+g);
                }             
            }
        }

        class Diffoffset : IKnowledge
        {
           
            public void GO(int g)
            {
                if (g < 70)
                {
                    Console.WriteLine("Диф.зачета не cдан"+ g);
                }
                
                else
                {
                    Console.WriteLine("Сдан Диф.зачета "+g);
                }
                return;
            }
        }
        class exam : IKnowledge
        {
           
            public void GO(int g)
            {
                if (g != 2)
                {
                    Console.WriteLine("Сдан экзамена "+ g);

                }
                else
                {
                    Console.WriteLine("Экзамена не cдан"+g);
                
                }
            }
        }
        class Student
        {
      
            private string _name;
            public string Name1
            {
                get { return _name; }
                set { _name = value; }
            }
            public Student(string Name, IKnowledge task)
            {
                Name1 = Name;
                Knowledge = task;
            }
            public IKnowledge Knowledge { private get; set; }
            public void GO(int ball)
            {
               
                Knowledge.GO(ball);
            }
        }
    }
}
