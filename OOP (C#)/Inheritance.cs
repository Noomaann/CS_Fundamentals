using System;

// ১. Base Class বা Parent Class (মূল ক্লাস)
public class Student
{
    // Private fields: এগুলো শুধু এই ক্লাসের ভেতরেই অ্যাক্সেসযোগ্য
    private string name;
    private int age;
    
    // ২. Base Class Constructor: নাম এবং বয়স সেট করার জন্য
    public Student(string name, int age){
        this.name = name;
        this.age = age;
    }
    
    // ৩. Common Method: যা সব স্টুডেন্টের জন্য প্রযোজ্য
    public void showinfo(){
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age : " + age);
    }
}    

// ৪. Derived Class (Child Class): Student ক্লাসকে ইনহেরিট করছে ':' চিহ্নের মাধ্যমে
public class JIPCStudent : Student {
    
    // ৫. Constructor with 'base' keyword: 
    // চাইল্ড ক্লাসের কনস্ট্রাক্টর প্যারামিটারগুলো নিয়ে 'base' কিওয়ার্ডের মাধ্যমে মেইন ক্লাসে পাঠিয়ে দিচ্ছে।
    public JIPCStudent(string name, int age) : base(name, age) { }

    // ৬. Specialized Method: এটি শুধু JIPCStudent-এর নিজস্ব কাজ
    public void GiveQuiz(){
        Console.WriteLine("Give Quiz");
    }
}

// ৭. আরেকটি Derived Class: একই Student ক্লাস থেকে তৈরি (Hierarchical Inheritance)
public class CPStudent : Student {
    
    // ৮. base(name, age) ব্যবহার করে প্যারেন্ট ক্লাসের কনস্ট্রাক্টরকে কল করা হচ্ছে
    public CPStudent(string name, int age) : base(name, age) { }
    
    // ৯. Specialized Method: এটি শুধু CPStudent-এর নিজস্ব কাজ
    public void GiveContest(){
        Console.WriteLine("Give Contest");
    }
}
    
public class Program
{
    public static void Main(){
        // ১০. JIPCStudent-এর অবজেক্ট তৈরি
        JIPCStudent jipcs = new JIPCStudent("Noman", 26);
        // showinfo() মেথডটি Student ক্লাসের, কিন্তু ইনহেরিটেন্সের কারণে jipcs এটি ব্যবহার করতে পারছে
        jipcs.showinfo(); 
        jipcs.GiveQuiz(); // নিজস্ব মেথড কল

        Console.WriteLine("-------------------");

        // ১১. CPStudent-এর অবজেক্ট তৈরি
        CPStudent cps = new CPStudent("Abdul", 24);
        cps.showinfo(); // প্যারেন্ট ক্লাসের মেথড ব্যবহার করছে
        cps.GiveContest(); // নিজস্ব মেথড কল
    }
}
