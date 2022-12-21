using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Clinic
{
    internal class Doctors
    {
        public string name = "";
        public virtual string Treat() { return ""; }
                
    }

    class Surgeon : Doctors
    {
        public override string Treat() 
        {
            return "Treat Surgeon";
        }
    }
    class Therapist : Doctors
    {
        public override string Treat()
        {
            return "Treat Therapist";
        }
    }
    class Dentist : Doctors
    {
        public override string Treat() 
        {
            return "Treat Dentist";
        }
    }


    class Patient : TreatmentPlan
    {
        public string Name { get; set; }
        public string Firstname { get; set; }
        Doctors doctors;
       
        public Patient(string name, string firstname, int plan)
        {
            this.Name = name;
            this.Firstname = firstname;
            this.doctors = Plan(plan);
        }

        public void Print()
        {
            Console.WriteLine(Name + " " + Firstname + " " + doctors.Treat());
        }
        
    }
    class TreatmentPlan
    {

        public Doctors Plan(int a)
        { 

            switch (a)
            {
                case 1:
                    var surgeon = new Surgeon();
                    return surgeon;
                case 2:
                    var therapist = new Therapist();
                    return therapist;
                default:
                    var dentist = new Dentist();
                    return dentist;
                   
            }
                                   
        }       
       
    }
}
