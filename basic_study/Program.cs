// Pseudocode:
// 1. Create namespace `basic_study` and class `Program` to avoid top-level/global code conflicts.
// 2. Implement `Student` class:
//    - static uint `numberOfStudents`
//    - public string `name`, `neptunCode`
//    - constructor assigns the two fields and increments `numberOfStudents`
//    - validate non-null arguments to satisfy non-nullable reference checks
// 3. Provide a helper method `cw` that wraps `Console.WriteLine` to replace the undefined `cw` symbol.
// 4. Implement `Main` inside `Program`:
//    - print initial student count
//    - create two `Student` instances, printing the count after each creation
//    - print the list of students with `name` and `neptunCode`
// 5. Ensure no top-level statements remain so `Main` is used as the entry point.

using System;

namespace basic_study
{
    class Student
    {
        public static uint numberOfStudents = 0;
        public string neptunCode;
        public string name;

        public Student(string name, string neptunCode)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.neptunCode = neptunCode ?? throw new ArgumentNullException(nameof(neptunCode));
            numberOfStudents++;
        }
    }

    class Program
    {
        static void cw(string format, params object[] args) => Console.WriteLine(format, args);

        static void Main(string[] args)
        {
            cw("Tanulók száma: {0}", Student.numberOfStudents);

            Student tanulo1 = new Student("Józsi", "Abc123");

            cw("Tanulók száma: {0}", Student.numberOfStudents);

            Student tanulo2 = new Student("Marika", "Bcd987");

            cw("Tanulók száma: {0}", Student.numberOfStudents);

            cw("Tanulók:");
            cw("\t{0}\t{1}", tanulo1.name, tanulo1.neptunCode);
            cw("\t{0}\t{1}", tanulo2.name, tanulo2.neptunCode);
        }
    }
}

namespace vehicle {
    enum szinek  { fehér, fekete, piros, kék, zöld, sárga };
    enum motorTypes { belsőégésű, elektromos, hibrid };
    class vehicle
    {
        protected string gyarto;
        protected szinek szin;
        private int tomeg;
        protected int ferohely;
    }
    class Motorized : vehicle
    {
        private motorTypes motorType;
        private int teljesitmeny;

        public szinek Szin
        {
            get { return szin; }
            set
            {
                this.szin = szin;
            }
        }

       

        public Motorized(string gyarto, szinek szin, int tomeg, int ferohely, motorTypes motorType, int teljesitmeny)
        {
            this.gyarto = gyarto;
            this.szin = szin;
            this.ferohely = ferohely;
            this.motorType = motorType;
            this.teljesitmeny = teljesitmeny;
        }


    }

    class evezos: vehicle
    {
        private int evezokSzama;

    }

    class animal_powered : vehicle
    {
        private int allatSzama;
    }
}