using System;

namespace PZ_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Student stud1 = new Student("Student", new offset());
            int ball1 = rnd.Next(20, 100);
            int ball2 = rnd.Next(20, 100);
            int ball3 = rnd.Next(20, 100);
            stud1.GO(ball1);
            stud1.Knowledge = new Diffoffset();
            stud1.GO(ball2);
            if (ball3 < 50 && ball2 < 30)
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
                if (g <= 50&& g >30)
                {
                    Console.WriteLine("Сдан зачета  на 3| Баллов = " + g);
                    return;
                }
                if (g <= 70&& g >50)
                {
                    Console.WriteLine("Сдан зачета  на 4| Баллов = " + g);
                    return;
                }
                if(g <= 100&& g > 70 )
                {
                    Console.WriteLine("Сдан зачета  на 5|Баллов = " + g);
                    return;
                }
                else
                {
                    Console.WriteLine("Зачет не сдан|Баллов = "+g);

                }             
            }
        }

        class Diffoffset : IKnowledge
        {
           
            public void GO(int g)
            {
                if (g <= 30 && g > 10)
                {
                    Console.WriteLine("Сдан Диф.зачета  на 3| Баллов = " + g);
                    return;
                }
                if (g <= 50 && g > 30)
                {
                    Console.WriteLine("Сдан Диф.зачета  на 4| Баллов = " + g);
                    return;

                }
                if (g <= 100 && g > 50)
                {
                    Console.WriteLine("Сдан Диф.зачета  на 5|Баллов = " + g);
                    return;
                }
                else
                {
                    Console.WriteLine("Диф.Зачет не сдан|Баллов = " + g);
                }
            }
        }
        class exam : IKnowledge
        {
           
            public void GO(int g)
            {
                if (g <= 60 && g > 50 )
                {
                    Console.WriteLine("Сдан Экзамен   на 3| Баллов = " + g);
                    return;
                }
                if (g <= 70 && g > 60 )
                {
                    Console.WriteLine("Сдан Экзамен  на 4| Баллов = " + g);
                    return;
                }
                if (g <= 100 && g >70)
                {
                    Console.WriteLine("Сдан Экзамен  на 5|Баллов = " + g);
                    return;
                }
                else
                {
                    Console.WriteLine("Экзамен не сдан|Баллов = " + g);

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
