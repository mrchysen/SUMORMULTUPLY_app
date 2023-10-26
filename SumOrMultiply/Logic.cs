
using SumOrMultiply.Logic.Generators;

namespace SumOrMultiply.Logic
{
    /// <summary>
    /// Типы игры.
    /// </summary>
    public enum TypeOfGame
    {
        Addition,
        Multiplication
    }

    /// <summary>
    /// Вспомогательные функции для приложения
    /// </summary>
    public static class Operation
    {
        public static bool IsNumeral(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (!(a[0] <= '9' && a[0] >= '0'))
                {
                    return false;
                }
            }
            return true;
        }

    }
    
    namespace Generators
    {
        /// <summary>
        /// Генератор чисел.
        /// </summary>
        public class GeneratorNumbers
        {
            // Поля \\
            /// <summary>
            /// Сложность.
            /// </summary>
            protected int Difficult;
            protected Random Rnd;

            // Конструкторы \\
            public GeneratorNumbers(int difficult = 10)
            {
                Difficult = difficult;
                Rnd = new Random();
            }

            // Методы \\
            /// <summary>
            /// Сгенерировать число.
            /// </summary>
            /// <returns></returns>
            public virtual int GenerateNumber()
            {
                int number = Rnd.Next(Difficult);

                return number;
            }
        }

        /// <summary>
        /// Генератор чисел для умножения
        /// </summary>
        public class GeneratorForMultiplication : GeneratorNumbers 
        {
            public GeneratorForMultiplication(int difficult) : base(difficult) { }

            public override int GenerateNumber()
            { 
                if(Difficult == 1)
                {
                    return Rnd.Next(1, Difficult+2);
                }
                return Rnd.Next(Difficult - (int)Math.Round(Math.Sqrt(Difficult + 1)) + 1, Difficult+2);
            }
            
        }

        public class GeneratorForAddition : GeneratorNumbers
        {
            public GeneratorForAddition(int difficult) : base(difficult) { }

            public override int GenerateNumber()
            {
                return Rnd.Next(Difficult + (int)Math.Sqrt(10 * Difficult), 10 * Difficult + 1);
            }
        }
    }

    namespace Equations
    {
        /// <summary>
        /// Базовый абстрактный класс - Уравнение
        /// </summary>
        public abstract class Equation
        {
            // Поля \\
            /// <summary>
            /// Вид уравнения. Пример "х1*x2".
            /// </summary>
            protected string Pattern;
            /// <summary>
            /// Количество переменных в уравнении.
            /// </summary>
            protected int Numbers = 0;
            /// <summary>
            /// Генератор чисел.
            /// </summary>
            protected GeneratorNumbers Generator;
            /// <summary>
            /// Лист с числами x1 = list[0] итд.
            /// </summary>
            protected List<int> NumbersList;

            // Свойства \\
            /// <summary>
            /// Возвращает кол-во чисел в уравнении.
            /// </summary>
            public int NumbersInEquation => Numbers;
            /// <summary>
            /// Возвращает посчитанное значения уравнения.
            /// </summary>
            public int Result => SolveEquation();
            /// <summary>
            /// Возвращает паттерн, с подставленными числами в уравнение.
            /// </summary>
            public abstract string EquationWithNumbers
            {
                get;
            }

            // Конструкторы \\
            public Equation(GeneratorNumbers? generatorNumbers, string pattern)
            {
                Pattern = pattern;
                Numbers = NumbersInPattern();
                if(generatorNumbers == null)
                    Generator = new GeneratorNumbers(5);
                else
                    Generator = generatorNumbers;
            }

            // Методы \\
            /// <summary>
            /// Сгенерировать числа.
            /// 
            /// </summary>
            public abstract void RegenerateNumbers();
            /// <summary>
            /// Решение уравнения.
            /// </summary>
            /// <returns></returns>
            protected abstract int SolveEquation();

            /// <summary>
            ///  Количество переменных в уравнении.
            /// </summary>
            /// <returns></returns>
            protected abstract int NumbersInPattern();
        }
        /// <summary>
       /// Класс уравнение со сложением
       /// </summary>
        public class BinaryAddition : Equation
        {
            // Конструкторы \\
            public BinaryAddition(GeneratorNumbers generator) : base(generator, "x1+x2")
            {
                NumbersList = new List<int>() { 0, 0 };
                RegenerateNumbers();
            }
            // Методы \\
            public override void RegenerateNumbers()
            {
                NumbersList[0] = Generator.GenerateNumber();
                NumbersList[1] = Generator.GenerateNumber();
            }
            public override string EquationWithNumbers => $"{NumbersList[0]}+{NumbersList[1]}";
            protected override int SolveEquation() => NumbersList[0] + NumbersList[1];
            protected override int NumbersInPattern() => 2;

        }
        /// <summary>
        /// Класс уравнение с умножением двух чисел.
        /// </summary>
        public class BinaryMultiply : Equation
        {

            // Свойства \\
            protected override int NumbersInPattern() => 2;
            public override string EquationWithNumbers => $"{NumbersList[0]}*{NumbersList[1]}";
            protected override int SolveEquation() => NumbersList[0] * NumbersList[1];

            // Конструктор \\
            public BinaryMultiply(GeneratorNumbers generatorNumbers) : base(generatorNumbers, "n1*n2")
            {
                NumbersList = new List<int>() { 0, 0 };
                RegenerateNumbers();
            }

            // Методы \\
            public override void RegenerateNumbers()
            {
                NumbersList[0] = Generator.GenerateNumber();
                NumbersList[1] = Generator.GenerateNumber();
            }
        }
    }

    namespace Profiles
    {
        /// <summary>
        /// Класс - профиль
        /// </summary>
        public class Profile : IComparable<Profile>
        {
            // Поля \\
            public string Name { get; set; }
            public int Points { get; set; }

            // Конструкторы \\
            public Profile(string name)
            {
                Name = name;
            }
            public Profile(string name, int points)
            {
                Name = name;
                Points = points;
            }
            /// <summary>
            /// Считывание из файла.
            /// </summary>
            /// <param name="sr"></param>
            public Profile(StreamReader sr)
            {
                string line = sr.ReadLine();
                var lines = line.Split();

                Name = lines[0];
                Points = int.Parse(lines[1]);
            }

            // Методы \\
            /// <summary>
            /// Запись в txt файл
            /// </summary>
            /// <param name="sw"></param>
            public virtual void WriteToFile(StreamWriter sw)
            {
                sw.WriteLine(ToString());
            }
            public override string ToString() => $"{Name} {Points}";
            public int CompareTo(Profile? profile) => Points.CompareTo(profile.Points);
        }

        /// <summary>
        /// Класс хранитель профилей
        /// </summary>
        public class ProfileHandler
        {
            // Поля \\
            protected List<Profile> profiles = new List<Profile>();
            
            // Свойства \\
            public int Length => profiles.Count;
            public Profile this[int index] => profiles[index];

            // Методы \\
            /// <summary>
            /// Добавление элемента
            /// </summary>
            /// <param name="profile"></param>
            public void Add(Profile profile) => profiles.Add(profile);

            /// <summary>
            /// Запись содержимого в файл
            /// </summary>
            /// <param name="path"></param>
            public void WriteToFile(string path)
            {
                using(StreamWriter sw = new StreamWriter(path)) 
                {
                    for (int i = 0; i < Length; i++)
                    {
                        profiles[i].WriteToFile(sw);
                    }
                }
                
            }
            /// <summary>
            /// Считывание из файла
            /// </summary>
            /// <param name="path"></param>
            public void ReadFromFile(string path)
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string? line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            var lines = line.Split();
                            profiles.Add(new Profile(lines[0], int.Parse(lines[1])));
                        }
                    }
                }
            }
            /// <summary>
            /// Сортировать профили по очкам
            /// </summary>
            public void Sort()
            {
                profiles.Sort();
                profiles.Reverse();
            }
            /// <summary>
            /// Выбрать профили по паттерну названия
            /// </summary>
            /// <param name="pattern"></param>
            /// <returns></returns>
            public List<Profile> SearchFor(string pattern) => profiles.Where(p => p.Name.Contains(pattern)).ToList<Profile>();
        }
    }

}
