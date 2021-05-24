using Labo07.Context;
using Labo07.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Labo07
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new UcaContext())
            {
                db.Students.RemoveRange(db.Students);//Limpiando la tabla

                //lista estudiante
                var std = new List<Student>()
                {
                    new Student()
                    {
                       Carnet = "00019618",
                       Career = "Ing. Informatica",
                       Name = "Walter",
                       LastName = "Morales"
                    },
                    new Student()
                    {
                       Carnet = "00209020",
                       Career = "Ing. Informatica",
                       Name = "Daniel",
                       LastName = "Solis"
                    },
                    new Student()
                    {
                       Carnet = "00176620",
                       Career = "Ing. Informatica",
                       Name = "Roberto",
                       LastName = "Alvarado"
                    },
                    new Student()
                    {
                       Carnet = "00090220",
                       Career = "Ing. Informatica",
                       Name = "Lourdes",
                       LastName = "Jimenez"
                    },
                    new Student()
                    {
                       Carnet = "00145620",
                       Career = "Ing. Informatica",
                       Name = "Raul",
                       LastName = "Gallardo"
                    }
                };
                std.ForEach(st => db.Add(st));//agregando a la base de datos en su respectiva tabla
                db.SaveChanges();//Guardando los cambios

                var savedStudent = db.Students//haciendo consulta + tabla para consultar
                    .OrderBy(st => st.Name)//ordenando por el nombre
                    .ToList();//convirtiendo a lista

                savedStudent.ForEach(st => Console.WriteLine(st.FullName));
            }
        }
    }
}
