using System;

namespace PZ_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool g;
            Student stud1 = new Student("Student", new offset());
            stud1.GO();
            
            stud1.Knowledge = new Diffoffset();
            stud1.GO();
           
            stud1.Knowledge = new exam();
            stud1.GO();

            Console.ReadLine();
        }
        public interface IStrategy
        {
            void Algorithm();
        }

        public class ConcreteStrategy1 : IStrategy
        {
            public void Algorithm()
            { }
        }

        public class ConcreteStrategy2 : IStrategy
        {
            public void Algorithm()
            { }
        }

        public class Context
        {
            public IStrategy ContextStrategy { get; set; }

            public Context(IStrategy _strategy)
            {
                ContextStrategy = _strategy;
            }

            public void ExecuteAlgorithm()
            {
                ContextStrategy.Algorithm();
            }
        }
      
        interface IKnowledge
        {
            
            void GO()
            {
            
            }    
        }
        
        class offset : IKnowledge
        {
            bool ok = true;
            public void GO()
            {
                Console.WriteLine("Сдача зачета ");
                int gard = new Random().Next(2, 5);
                Console.WriteLine("Зачет {0}", gard);
               

               if (gard == 2)
                {
                    Console.WriteLine("ЗАчет не cдан");
                    ok = false;
                }
            }
        }

        class Diffoffset : IKnowledge
        {
            bool ok = true;
            public void GO()
            {
                int gard = new Random().Next(2, 5);
                Console.WriteLine("Сдача Диф.зачета ");
                Console.WriteLine("Диф.зачета {0}", gard);
                if (gard == 2)
                {
                    Console.WriteLine("Диф.зачета не cдан");
                    ok = false;
                }
            }
        }
        class exam : IKnowledge
        {
            bool ok = true;
            public void GO()
            {
                int gard = new Random().Next(2, 5);
                Console.WriteLine("Сдача экзамена ");
                Console.WriteLine("Экзамена {0}", gard);
                if (gard == 2)
                {
                    Console.WriteLine("Экзамена не cдан");
                    ok = false;
                }
            }
        }
        class Student
        {
            protected int garden;
              protected string name;

            public Student(string Name, IKnowledge task)
            {
        
                name = Name;
                Knowledge = task;
            }
            public IKnowledge Knowledge { private get; set; }
            public void GO()
            {
                Knowledge.GO();
            }
        }
    }
}
