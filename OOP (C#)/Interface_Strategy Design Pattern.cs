using System;
using System.Collections.Generic;

// ১. ইন্টারফেস: এটি একটি চুক্তির মতো। যে এই ইন্টারফেস নিবে তাকে এই ৩টি কাজ করতেই হবে।
public interface INotify
{
    void send(); // নোটিফিকেশন পাঠানো
    void log();  // লগ রাখা
    void save(); // ডাটাবেজে সেভ করা
} 

// ২. ইমপ্লিমেন্টেশন: আলাদা আলাদা মাধ্যম যারা ইন্টারফেসের কাজগুলো নিজের মতো করে করবে।
public class EmailNotify : INotify
{
    public string Email { get; set; }
    public void send() { Console.WriteLine("Sending email to " + Email); }
    public void log() { Console.WriteLine("Logging email to " + Email); }
    public void save() { Console.WriteLine("Saving DB to " + Email); }
}

public class SMSNotify : INotify
{
    public string Phone { get; set; }
    public void send() { Console.WriteLine("Sending SMS to " + Phone); }
    public void log() { Console.WriteLine("Logging SMS to " + Phone); }
    public void save() { Console.WriteLine("Saving DB to " + Phone); }
}

public class PushNotify : INotify
{
    public string Token { get; set; }
    public void send() { Console.WriteLine("Sending Push to " + Token); }
    public void log() { Console.WriteLine("Logging Push to " + Token); }
    public void save() { Console.WriteLine("Saving DB to " + Token); }
}

// ৩. কনটেক্সট ক্লাস: এটি একটি ম্যানেজার ক্লাস। সে জানে না সে কী পাঠাচ্ছে, 
// সে শুধু জানে তাকে যা দেওয়া হয়েছে সেটার ৩টি মেথড রান করতে হবে।
public class NotifyContext
{
    public INotify notify { get; set; }
    
    // কন্সট্রাক্টরের মাধ্যমে আমরা নির্দিষ্ট কর্মী (Object) নিয়োগ দিচ্ছি
    public NotifyContext(INotify notify) 
    {
        this.notify = notify;
    }
    
    // এই মেথডটি সব নোটিফিকেশনের জন্য একই সিকোয়েন্স মেইনটেইন করে
    public void process()
    {
        notify.send(); 
        notify.log();
        notify.save();
    }
}

public class Program
{
    public static void Main()
    {
        // কর্মীদের অবজেক্ট তৈরি
        INotify email = new EmailNotify { Email = "Noman@gmail.com" };
        INotify sms = new SMSNotify { Phone = "01570206073" };
        INotify push = new PushNotify { Token = "2345734" };

        // ম্যানেজার বা কনটেক্সটে কর্মীদের এসাইন করা
        NotifyContext emailContext = new NotifyContext(email);
        NotifyContext smsContext = new NotifyContext(sms);
        NotifyContext pushContext = new NotifyContext(push);
        
        // সব কনটেক্সটকে একটি লিস্টে রাখা যাতে লুপ চালানো যায়
        List<NotifyContext> notifyList = new List<NotifyContext> {
            emailContext,
            smsContext,
            pushContext
        };
        
        // লুপ চালিয়ে সবার 'process' মেথড কল করা
        foreach(var context in notifyList)
        {
            context.process();
            Console.WriteLine("-------------------");
        }
    }
}
