using System;
public class Student
{
    // এই ভেরিয়েবলগুলো 'private' করা হয়েছে যাতে ক্লাসের বাইরে থেকে কেউ সরাসরি 
    private string name;  // স্টুডেন্টের নাম রাখার জন্য গোপন ফিল্ড
    private int id;       // স্টুডেন্টের আইডি রাখার জন্য গোপন ফিল্ড
    private string email; // স্টুডেন্টের ইমেইল রাখার জন্য গোপন ফিল্ড

    // --- PUBLIC METHOD (Controlled Access / Setter) ---
    // যেহেতু ফিল্ডগুলো private, তাই বাইরের জগত থেকে তথ্য ইনপুট দেওয়ার জন্য এই মেথডটি একটি 'Gate' হিসেবে কাজ করে।
    public void SetStudentInfo(string name, int id, string email)
    {
 
        // this.name মানে উপরের private string name-কে বোঝাচ্ছে।
        this.name = name;   
        this.id = id;       
        this.email = email; 
        
        // এনক্যাপসুলেশনের সুবিধা হলো, তুমি চাইলে এখানে চেক করতে পারতে:
        // if(id < 0) { Console.WriteLine("ID ভুল!"); }
    }

    // --- PUBLIC METHOD (Output / Getter) ---
    // প্রাইভেট ডেটাগুলোকে সরাসরি অ্যাক্সেস না দিয়ে একটি মেথডের মাধ্যমে সুন্দর করে দেখানোর ব্যবস্থা করা হয়েছে।
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {name}, ID: {id}, Email: {email}");
    }
}	
public class Program
{
	public static void Main()
	{
		Student s1 = new Student();
		s1.SetStudentInfo("Rahim", 103, "ram@example.com");
		s1.ShowInfo();
	}
}
