// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections;
using System.Collections.Generic;

public class Persoana {
    private string nume;
    private string prenume;
    private int varsta;
    
    public Persoana(string nume, string prenume, int varsta)
   {
      this.nume = nume;
      this.prenume = prenume;
      this.varsta = varsta;
   }
   
   public override string ToString()
    {
        return string.Format("Nume:{0}, Prenume:{1}, Varsta:{2}", this.nume, this.prenume, this.varsta);
    }
}


public class Student : Persoana {
    private double medie_generala;
    private string nume_facultate;
    
    
    public Student(string nume, string prenume, int varsta, double medie_generala, string nume_facultate) : base(nume, prenume, varsta)
   {
      this.medie_generala = medie_generala;
      this.nume_facultate = nume_facultate;
   }
    
  public void schimbaMedia(double medie_generala)
  {                 
    Console.WriteLine("Media generala inainte de schimbare: "+this.medie_generala);
    this.medie_generala = medie_generala;
    Console.WriteLine("Media generala dupa de schimbare: "+this.medie_generala);
  }
  
  public override string ToString()
    {
        return base.ToString() + string.Format(", Media generala:{0}, Facultatea:{1}\n", this.medie_generala, this.nume_facultate);
    }
}

public class ProbaLigaAC
{
    public static void Main(string[] args)
    {
        List<Student> catalog = new List<Student>();
        
        Student st1 = new Student("Basnic", "Ioan", 23, 82.41, "Facultate AC");
        
        Student st2 = new Student("Gigi", "Nicolae", 21, 1.41, "Facultatea de dublaj");
        
        catalog.Add(st1);
        catalog.Add(st2);
        
        foreach(Student student in catalog) {
            Console.WriteLine(student.ToString());
        }
        
        st2.schimbaMedia(10);
        
        foreach(Student student in catalog) {
            Console.WriteLine(student.ToString());
        }
    }
}
