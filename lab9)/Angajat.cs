using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab9_
{
    public class Angajat
    {
        public Guid Id { get; set; }

        public string Nume { get; set; }

        public double Salary { get; set; }

        public int Department { get; set; }
        public Angajat()
        {

        }
        public Angajat(Angajat angajat)
        {
            Id = angajat.Id;
            Nume = angajat.Nume;
            Salary = angajat.Salary;
            Department = angajat.Department;
        }

        public string ToString(Angajat angajat)
        {
            var departmentName = "";
            
            if(angajat.Department == (int)Departament.Development)
            {
                departmentName = Convert.ToString(Departament.Development);
            }

            if (angajat.Department == (int)Departament.HumanResources)
            {
                departmentName = Convert.ToString(Departament.HumanResources);
            }

            if (angajat.Department == (int)Departament.Logistics)
            {
                departmentName = Convert.ToString(Departament.Logistics);
            }

            if (angajat.Department == (int)Departament.Maintenance)
            {
                departmentName = Convert.ToString(Departament.Maintenance);
            }

            if (angajat.Department == (int)Departament.Testing)
            {
                departmentName = Convert.ToString(Departament.Testing);
            }

            return angajat.Id + " " + angajat.Nume + ", departament: " + departmentName + ", salariu: " + angajat.Salary;

        }

    }
}