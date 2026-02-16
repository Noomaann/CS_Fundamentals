using System;

// ১. ইন্টারফেসের নাম সাধারণত 'I' দিয়ে শুরু করা ভালো (যেমন: IPayment)
public interface IPayment 
{
    // ইন্টারফেসে মেথডের বডি থাকে না এবং 'public' লেখার দরকার নেই (ডিফল্টভাবে পাবলিক)
    void PaymentPro(); 
    void PaymentDetails(); 
}

// ২. ইন্টারফেস ইমপ্লিমেন্ট করার সময় ক্লাসের নামের পাশে ব্র্যাকেট () হয় না
public class CardPayment : IPayment 
{
    // ভুল: ইন্টারফেসের মেথড ইমপ্লিমেন্ট করতে 'override' কি-ওয়ার্ড লাগে না
    // শুধু 'public void' লিখলেই হয়
    public void PaymentPro() 
    {
        Console.WriteLine("Payment by Credit Card");
    }
    
    // ভুল: ইন্টারফেসে ছিল 'PaymentDetails', তাই এখানেও নাম একই হতে হবে (showinfo হবে না)
    public void PaymentDetails() 
    {
        Console.WriteLine("Credit Card payment info");
    }
}

public class BkashPayment : IPayment 
{
    public void PaymentPro() 
    {
        Console.WriteLine("Payment by Bkash");
    }
    
    public void PaymentDetails() 
    {
        Console.WriteLine("Bkash payment info");
    }
}
					
public class Program
{
    public static void Main()
    {
        // ৩. ইন্টারফেস টাইপের ভেরিয়েবলে চাইল্ড ক্লাসের অবজেক্ট রাখা (Polymorphism)
        IPayment a = new CardPayment();
        a.PaymentPro();
        a.PaymentDetails(); // ইন্টারফেসের মেথড কল করছি
        
        Console.WriteLine("---");
        
        IPayment b = new BkashPayment();
        b.PaymentPro();
        b.PaymentDetails();
    } // ৪. সেকেন্ড ব্র্যাকেট ঠিকমতো ক্লোজ করতে হবে
}
