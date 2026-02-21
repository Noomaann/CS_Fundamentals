using System;

// ১. Base Class (Parent) - নামের প্রথম অক্ষর বড় হাতের
public class Course
{
    public string title;
    public string desc;
    
    public void showinfo()
    {
        Console.WriteLine($"Title : {title}");
    }
    
    public virtual void quiz()
    {
        Console.WriteLine("Parent Class: Score Quiz (Basic)");
    }
}

// ২. Child Class - এখানে 'Course' বড় হাতের হবে
public class JIPCcourse : Course
{
    public override void quiz()
    {
        base.quiz(); 

        int s = 10;
        int e = 70;
        Console.WriteLine($"Child Class: Score JIPC Quiz, start : {s}, end : {e}");
    }
}

class program
{
    public static void Main()
    {
        // ৩. অবজেক্টের নাম ক্লাসের নামের সাথে হুবহু এক না রাখাই ভালো (যেমন: 'jipc' ব্যবহার করো)
        JIPCcourse jipc = new JIPCcourse();
        
        jipc.title = "Noman's Course";
        jipc.showinfo();
        jipc.quiz();
        
        Console.WriteLine("-------------------------");

        Course parentObj = new Course();
        parentObj.title = "General Course";
        parentObj.quiz();
    }
}
