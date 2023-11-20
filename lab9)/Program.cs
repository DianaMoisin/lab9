using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab9_
{

    delegate List<Angajat> ListaAngajati1(List<Angajat> angajati, int minSalary);
    delegate List<Angajat> ListaAngajati2(List<Angajat> angajati);
    delegate Angajat Angajat3(List<Angajat> angajati);
    delegate Angajat Angajat4(List<Angajat> angajati);
    delegate double Salarii(List<Angajat> angajati);
    delegate double CostForDepartment(List<Angajat> angajati);
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Angajat> angajati = new List<Angajat>();

            Angajat angajat1 = new Angajat()
            {
                Nume = "Popa Ion",
                Department = 2,
                Salary = 3200
            };

            angajati.Add(angajat1);

            Angajat angajat2 = new Angajat()
            {
                Nume = "Pop Cosmina",
                Department = 1,
                Salary = 4500
            };

            angajati.Add(angajat2);

            Angajat angajat3 = new Angajat()
            {
                Nume = "Popescu Maria",
                Department = 4,
                Salary = 2500
            };

            angajati.Add(angajat3);


            #region noOfWellPayedEmployees
            // noOfWellPayedEmployees : o lista cu toti angajatii cu salariul mai mare decat valoarea numerica oferita ca parametru
            var min = 3000;

            ListaAngajati1 ang1 = (List<Angajat> angajati, int min) =>
            {

                List<Angajat> list = new List<Angajat>();

                foreach (var item in angajati)
                {
                    if(item.Salary > min)
                    {
                        list.Add(item);
                    }
                }

                return list;
            };

            #endregion

            #region employeesFromMaintenance
            // employeesFromMaintenance: o lista cu toti angajatii din departamentul Maintenance
            ListaAngajati2 ang2 = (List<Angajat> angajati) =>
            {
                List<Angajat> list = new List<Angajat>();

                foreach (var item in angajati)
                {
                    if (item.Department  == (int)Departament.Maintenance)
                    {
                        list.Add(item);
                    }
                }

                return list;
            };

            #endregion

            #region maxSalary
            // maxSalary: angajatii cu cel mai mare salariu la nivel de companie

            Angajat3 ang3 = (List<Angajat> angajati) =>
            {
                Angajat angajat = new Angajat();
                double maxSalary = 0;

                foreach (var item in angajati)
                {
                    if (item.Salary > maxSalary)
                    {
                        maxSalary = item.Salary;
                        angajat = item;
                    }
                }

                return angajat;
            };

            #endregion

            #region maxSalaryForDevelopment
            //maxSalaryForDevelopment: angajatii cu cel mai mare salariu din departamentul Development

            Angajat4 ang4 = (List<Angajat> angajati) =>
            {
                Angajat angajat = new Angajat();
                double maxSalary = 0;

                foreach (var item in angajati)
                {
                    if (item.Department == (int)Departament.Development && item.Salary > maxSalary)
                    {
                        maxSalary = item.Salary;
                        angajat = item;
                    }
                }

                return angajat;
            };
            #endregion

            #region totalCost
            //totalCost: suma tuturor salariilor din companie

            Salarii salarii = (List<Angajat> angajati) =>
            {
                double salarii = 0;

                foreach (var item in angajati)
                {
                    salarii += item.Salary;
                }
                return salarii;
            };
            #endregion

            #region costForDepartment
            //costForDepartment: o suma tuturor salariilor din departamentul Logistics

            CostForDepartment cost = (List<Angajat> angajati) =>
            {
                double salarii = 0;

                foreach (var item in angajati)
                {
                    if (item.Department == (int)Departament.Development)
                    {
                        salarii += item.Salary;
                    }
                }
                return salarii;
            };

            #endregion
        }
    }
}
