using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


Title title = new Program_Title();
Title title1 = new GENDER();
Student student1 = new student_1_Name();
Student student2 = new student_2_Name();
Student student3 = new student_3_Name();
Student_Gender student_gender1 = new GENDER_Male();
Student_Boys student_Boys1 = new student_1_Name_Boys();
Student_Boys student_Boys2 = new student_2_Name_Boys();
Student_Boys student_Boys3 = new student_3_Name_Boys();
Student_Boys student_Boys4 = new student_4_Name_Boys();
Student_Boys student_Boys5 = new student_5_Name_Boys();
Student_Boys student_Boys6 = new student_6_Name_Boys();
Student_Boys student_Boys7 = new student_7_Name_Boys();
Student_Boys student_Boys8 = new student_8_Name_Boys();
Student_Boys student_Boys9 = new student_9_Name_Boys();
Student_Boys student_Boys10 = new student_10_Name_Boys();



title.Title_Header();
title1.Title_Header();
student1.Name_of_students(); 
student2.Name_of_students(); 
student3.Name_of_students();
student_gender1.Student_B();
student_Boys1.Name_of_students_Boys();
student_Boys2.Name_of_students_Boys();
student_Boys3.Name_of_students_Boys();
student_Boys4.Name_of_students_Boys();
student_Boys5.Name_of_students_Boys();
student_Boys6.Name_of_students_Boys();
student_Boys7.Name_of_students_Boys();
student_Boys8.Name_of_students_Boys();
student_Boys9.Name_of_students_Boys();
student_Boys10.Name_of_students_Boys();

public class Title
{
    public virtual void Title_Header()
    {
        Console.WriteLine("Title of the program");
    }
}

public class Program_Title : Title
{
    public override void Title_Header()
    {
        Console.WriteLine("                                   ========================================");
        Console.WriteLine("                                   ||     LIST OF COMSCIENCE STUDENTS    ||");
        Console.WriteLine("                                   ========================================");
        Console.WriteLine("\n\n");
    }

}


public class GENDER : Title
{
    public override void Title_Header()
    {
        Console.WriteLine("              ================");
        Console.WriteLine("              ||    GIRLS   ||");
        Console.WriteLine("              ================");
    }
}


public class Student
{
    public virtual void Name_of_students()
    {
        Console.WriteLine("Name of Student");
    }
}

public class student_1_Name : Student
{
    public override void Name_of_students()
    {
        Console.WriteLine("              ===================================================================================");
        Console.WriteLine("              ||     Student #1: " + "Naidine Alexie Z. Villeroz                                    ||");
        Console.WriteLine("              ===================================================================================");
    }
}

public class student_2_Name : Student
{
    public override void Name_of_students()
    {

        Console.WriteLine("              ===================================================================================");
        Console.WriteLine("              ||     Student #2: " + "Shereece Degula                                               ||");
        Console.WriteLine("              ===================================================================================");
    }
}
public class student_3_Name : Student
{
    public override void Name_of_students()
    {
        Console.WriteLine("              ===================================================================================");
        Console.WriteLine("              ||     Student #3: " + "Therese Punzalan                                              ||");
        Console.WriteLine("              ===================================================================================");
        Console.WriteLine("\n\n");
    }
}

public class Student_Gender
{
    public virtual void Student_B()
    {
        Console.WriteLine("Gender");
    }
}
public class GENDER_Male : Student_Gender
{
    public override void Student_B()
    {
        Console.WriteLine("              ================");
        Console.WriteLine("              ||    BOYS    ||");
        Console.WriteLine("              ================");
    }
}

public class Student_Boys
{
    public virtual void Name_of_students_Boys()
    {
        Console.WriteLine("Name of Student");
    }
}

public class student_1_Name_Boys : Student_Boys
{
    public override void Name_of_students_Boys()
    {
        Console.WriteLine("              ===================================================================================");
        Console.WriteLine("              ||     Student #1: " + "Reignan Tamoro                                                ||");
        Console.WriteLine("              ===================================================================================");
    }
}

public class student_2_Name_Boys : Student_Boys
{
    public override void Name_of_students_Boys()
    {

        Console.WriteLine("              ===================================================================================");
        Console.WriteLine("              ||     Student #2: " + "Ernest Del Rosario                                            ||");
        Console.WriteLine("              ===================================================================================");
    }
}
public class student_3_Name_Boys : Student_Boys
{
    public override void Name_of_students_Boys()
    {
        Console.WriteLine("              ===================================================================================");
        Console.WriteLine("              ||     Student #3: " + "John Rey Yano                                                 ||");
        Console.WriteLine("              ===================================================================================");
    }
}
public class student_4_Name_Boys : Student_Boys
{
    public override void Name_of_students_Boys()
    {
        Console.WriteLine("              ===================================================================================");
        Console.WriteLine("              ||     Student #4: " + "Raylie Paguio                                                 ||");
        Console.WriteLine("              ===================================================================================");
    }
}
public class student_5_Name_Boys : Student_Boys
{
    public override void Name_of_students_Boys()
    {
        Console.WriteLine("              ===================================================================================");
        Console.WriteLine("              ||     Student #5: " + "Jan Camacho                                                   ||");
        Console.WriteLine("              ===================================================================================");
    }
}
public class student_6_Name_Boys : Student_Boys
{
    public override void Name_of_students_Boys()
    {
        Console.WriteLine("              ===================================================================================");
        Console.WriteLine("              ||     Student #6: " + "Vince Manila                                                  ||");
        Console.WriteLine("              ===================================================================================");
    }
}
public class student_7_Name_Boys : Student_Boys
{
    public override void Name_of_students_Boys()
    {
        Console.WriteLine("              ===================================================================================");
        Console.WriteLine("              ||     Student #7: " + "Louie Cosio                                                   ||");
        Console.WriteLine("              ===================================================================================");
    }
}
public class student_8_Name_Boys : Student_Boys
{
    public override void Name_of_students_Boys()
    {
        Console.WriteLine("              ===================================================================================");
        Console.WriteLine("              ||     Student #8: " + "JL Timon                                                      ||");
        Console.WriteLine("              ===================================================================================");
    }
}
public class student_9_Name_Boys : Student_Boys
{
    public override void Name_of_students_Boys()
    {
        Console.WriteLine("              ===================================================================================");
        Console.WriteLine("              ||     Student #9: " + "Kenneth Tapang                                                ||");
        Console.WriteLine("              ===================================================================================");
    }
}
public class student_10_Name_Boys : Student_Boys
{
    public override void Name_of_students_Boys()
    {
        Console.WriteLine("              ===================================================================================");
        Console.WriteLine("              ||     Student #10: " + "Adrian Reyes                                                 ||");
        Console.WriteLine("              ===================================================================================");
    }
}