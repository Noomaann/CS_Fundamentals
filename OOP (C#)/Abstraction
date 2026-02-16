using System;

// ১. Abstract Class: এটি একটি 'ব্লু-প্রিন্ট' বা সাধারণ কাঠামো। 
// সরাসরি এই ক্লাসের অবজেক্ট তৈরি করা যায় না।
public abstract class payment {
    // Properties: এগুলো সব পেমেন্ট মেথডের জন্যই কমন।
    public int amount { get; set; }
    public string TransID { get; set; }
	
    // ২. Abstract Method: এর কোনো বডি ({ }) নেই। 
    // চাইল্ড ক্লাসগুলোকে অবশ্যই এই মেথডগুলো ইমপ্লিমেন্ট (Override) করতে হবে।
    public abstract void Validpayment();
	
    public abstract void Processpayment();
	
    // ৩. Non-abstract Method: এটি সব চাইল্ড ক্লাস সরাসরি ব্যবহার করতে পারবে।
    public void showinfo() {
        Console.WriteLine($"Amount : {amount}");
        Console.WriteLine($"TranseactionID : {TransID}");
    }
}

// ৪. Inheritance: 'payment' ক্লাসকে ইনহেরিট করছে 'cardpayment'।
public class cardpayment : payment {
    // এই ক্লাসের নিজস্ব প্রপার্টি
    public string cardnumber { get; set; }
	
    // 'override' ব্যবহার করে বেস ক্লাসের মেথডকে নিজের মতো করে সাজানো হচ্ছে।
    public override void Validpayment() {
        Console.WriteLine("Validating Card Payment");
    }
	
    public override void Processpayment() {
        Console.WriteLine("Processing Card Payment");
    }
}

// ৫. Inheritance: 'payment' ক্লাসকে ইনহেরিট করছে 'bkashpayment'।
public class bkashpayment : payment {
    // এই ক্লাসের নিজস্ব প্রপার্টি (বিকাশ নম্বরের জন্য)
    public string Mobilenumber { get; set; }
	
    public override void Validpayment() {
        Console.WriteLine("Validating Bkash Payment");
    }
	
    public override void Processpayment() {
        Console.WriteLine("Processing Bkash Payment");
    }
}
					
public class Program
{
    public static void Main()
    {
        // ৬. Polymorphism: বেস ক্লাসের রেফারেন্স (payment a) দিয়ে 
        // চাইল্ড ক্লাসের (cardpayment) অবজেক্ট তৈরি করা।
        payment a = new cardpayment {
            amount = 100,
            TransID = "15490",
            cardnumber = "2001570206073" // অবজেক্ট ইনিশিয়ালাইজার ব্যবহার
        };
        a.Validpayment();
        a.Processpayment();
        a.showinfo(); // কমন মেথড কল করা হচ্ছে
		
        Console.WriteLine("--------------------");

        // ৭. একই ভাবে বিকাশ পেমেন্টের অবজেক্ট তৈরি
        payment b = new bkashpayment {
            amount = 200,
            TransID = "09451",
            Mobilenumber = "01570206073"	
        };
		
        b.Validpayment();
        b.Processpayment();
        b.showinfo();
    }
}
