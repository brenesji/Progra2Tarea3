using System;

namespace Estudiantes
{
    class Program
    {
        static int option = 0;
        static int i = 0;
        static int size = 4;
        static int men = 0;
        static int women = 0;
        static int menores = 0;
        static int jovenes = 0;
        static int adultos = 0;

        [Flags]
        enum StudentAge
        {
            Menor = 18,
            Joven = 25,
            Adulto = 30,
        };
        struct Student
        {
            public int studentid;
            public string studentname;
            public char sex;
            public int studentageage;
        };

        static Student[] Students;

        static void AddStudents()
        {
            int r = 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < Students.Length)
                {
                    Console.WriteLine("-* Modulo de  Estudiantes UH  *-*");
                    Console.WriteLine("Ingreso de Estudiantes.             ");
                    Console.Write("Digite el Codigo de Estudiante:         ");
                    Students[i].studentid = int.Parse(Console.ReadLine());
                    Console.Write("Digite el Nombre del Estudiante:    ");
                    Students[i].studentname = Console.ReadLine();
                    Console.Write("Digite el sexo del Estudiante:     ");
                    Students[i].sex = char.Parse(Console.ReadLine());

                    if (Students[i].sex == 'M') {
                        men = men + 1;
                    }
                    else {
                        women = women + 1;
                    }
                    Console.WriteLine("Seleccione la edad del Estudiante:");
                    Console.Write(StudentAge.Menor + ":" + (int)StudentAge.Menor + "\n" +
                                  StudentAge.Joven + ":" + (int)StudentAge.Joven + "\n" +
                                  StudentAge.Adulto + ":" + (int)StudentAge.Adulto + "\n");
                    Students[i].studentageage = int.Parse(Console.ReadLine());

                    if (Students[i].studentageage == 18)
                    {
                        menores = menores + 1;
                    }
                    else if (Students[i].studentageage == 25)
                    {
                        jovenes = jovenes + 1;
                    }
                    else
                    {
                        adultos = adultos + 1;
                    }


                    Console.WriteLine("Desea agregar otro Estudiante 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de Estudiantes lleno..");
                    r = 1;
                    Console.ReadKey();
                }
            }
        }

        static void ShowStudents()
        {
            int reg = 0;
            Console.Clear();
            Console.WriteLine("-* Modulo de  Estudiantes UH  *-*");
            Console.WriteLine("====================================");
            Console.WriteLine("       Listado de Estudiantes.      ");
            Console.WriteLine("====================================");
            Console.WriteLine("        Universidad UH           ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Registro\tCodigo\tNombre\tSexo\tEdad");

            for (i = 0; i < Students.Length; i++)
            {
                reg = i + 1;

                Console.Write(reg);
                Console.Write("\t\t" + Students[i].studentid);
                Console.Write("\t{0}", Students[i].studentname);
                Console.Write("\t{0}", Students[i].sex);
                Console.Write("\t{0}", Students[i].studentageage + "\n");

                //Console.Write(reg + "\t" + "\t" + Students[i].studentid + "\t" + Students[i].studentname + "\t" + Students[i].sex + "\t" + Students[i].studentageage);

                //Console.Write(reg  + "\t" + "\t" + Students[i].studentid + "\t" +
                //                  Students[i].studentname + "\t" + Students[i].sex + "\t" +
                //                 Students[i].studentageage);
                //Console.WriteLine("Codigo:   " + "\n" + Students[i].studentid);
                //Console.WriteLine("Nombre:   " + "\n" + Students[i].studentname);
                //Console.WriteLine("Sexo:     " + "\n" + Students[i].sex);
                //Console.WriteLine("Edad:     " + "\n" + Students[i].studentageage);
            }
            Console.WriteLine("====================================");
            Console.WriteLine("Fin del Informe               ");
            Console.ReadKey();
        }

        static void SeekStudents()
        {
            //Buscar por registro
            int ID = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Modulo de  Estudiantes UH  *-*");
                Console.WriteLine("Búsquedad de Estudiantes.           ");
                Console.WriteLine("Digite el Codigo del Estudiante");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < Students.Length; i++)
                {
                    if (ID == Students[i].studentid)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("Codigo:   " + Students[i].studentid);
                        Console.WriteLine("Nombre:   " + Students[i].studentname);
                        Console.WriteLine("Sexo:     " + Students[i].sex);
                        Console.WriteLine("Edad:     " + Students[i].studentageage);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro estudiante 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void ModifyStudents()
        {
            //modificar libro
            int ID = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Modulo de  Estudiantes UH  *-*");
                Console.WriteLine("Modficacion de Estudiantes.           ");
                Console.WriteLine("Digite el Codigo del Estudiante a modificar");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < Students.Length; i++)
                {
                    if (ID == Students[i].studentid)
                    {
                        reg = i + 1;
                        Console.Write("Digite el nombre del Estudiante:    ");
                        Students[i].studentname = Console.ReadLine();
                        Console.Write("Digite el sexo del Estudiante:     ");
                        Students[i].sex = char.Parse(Console.ReadLine());
                        Console.WriteLine("Seleccione la Edad del Estudiante:");
                        Console.Write(StudentAge.Menor + ":" + (int)StudentAge.Menor + "\n" +
                                      StudentAge.Joven + ":" + (int)StudentAge.Joven + "\n" +
                                      StudentAge.Adulto + ":" + (int)StudentAge.Adulto + "\n");
                        Students[i].studentageage = int.Parse(Console.ReadLine());
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea modificar otro Estudiante 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void DeleteStudents()
        {
            //eliminar libro
            int ID = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Modulo de  Estudiantes UH  *-*");
                Console.WriteLine("Borrado de Estudiantes.           ");
                Console.WriteLine("Digite el Codigo del Estudiante a eliminar");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < Students.Length; i++)
                {
                    if (ID == Students[i].studentid)
                    {
                        reg = i + 1;
                        Students[i].studentid = 0;
                        Students[i].sex = '-';
                        Students[i].studentname = "";
                        Students[i].studentageage = 0;
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Estudiante eliminado");
                Console.WriteLine("Desea eliminar otro Estudiante 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void ClasifyStudents() {

            Console.Clear();
      

            Console.WriteLine("============================================");
            Console.WriteLine("    Informe Clasificación estudiantil UH    ");
            Console.WriteLine("============================================");
            Console.WriteLine("Clasificación por edad  ||  Clasificación por Género");

            Console.Write("Menores " + menores + "\t\t" + "||");
            Console.Write("\t\t" + "Hombres " + men + "\n");
            Console.Write("Jovenes " + jovenes + "\t\t" + "||");
            Console.Write("\t\t" + "Mujeres " + women + "\n");
            Console.Write("Adultos " + adultos + "\t\t" + "||" + "\n");

          
            Console.WriteLine("====================================");
            Console.WriteLine("Fin del Informe               ");
            Console.ReadKey();
        }
   

    static void Main()
    {
            Students = new Student[size];
            do
        {
            Console.Clear();
            Console.WriteLine("-* Listado estudiantil UH *-*");
            Console.WriteLine("1. Ingreso de estudiantes.");
            Console.WriteLine("2. Modificación de estudiantes.");
            Console.WriteLine("3. Borrado de estudiantes.");
            Console.WriteLine("4. Búsqueda de estudiantes.");
            Console.WriteLine("5. Listado de estudiantes.");
            Console.WriteLine("6. Informe clasificación de estudiantes.");
            Console.WriteLine("7. Salir.");
            Console.WriteLine("Selecciones una opción");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        AddStudents();
                        break;
                    }
                case 2:
                    {
                            //Modificar la infor
                        ModifyStudents();
                        break;
                    }
                case 3:
                    {
                            //Dejar campos en 0 y vacío
                            DeleteStudents();
                        break;
                    }
                case 4:
                    {
                            SeekStudents();
                            break;
                    }
                case 5:
                    {
                            ShowStudents();
                            break;
                    }
                case 6:
                    {
                            ClasifyStudents();
                        break;
                    }
                case 7:
                    //Salir
                    break;
                default:
                    {
                        Console.WriteLine("Seleccione inválida..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
            }
        } while (option != 7);
    }
}
	}
