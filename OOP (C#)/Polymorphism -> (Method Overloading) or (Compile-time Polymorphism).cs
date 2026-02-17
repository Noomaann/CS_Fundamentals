using System;

class JIPCcourse{
	
	// ১. নো-প্যারামিটার মেথড: সাধারণ কুইজ
	public void Quiz(){
		Console.WriteLine("Quiz with Practice");
	}
	
	// ২. তিন-প্যারামিটার মেথড: শুরু, শেষ এবং ডিউরেশনসহ কুইজ
	public void Quiz(int st, int et, int du){
		Console.WriteLine("Quiz with Preparation");
	}
	
	// ৩. এক-প্যারামিটার মেথড: শুধু ডিউরেশনসহ কুইজ
	public void Quiz(int du){
		Console.WriteLine("Quiz with time");
	}	
}

class program{
	public static void Main(){
		JIPCcourse jipc = new JIPCcourse();
		
		jipc.Quiz();                    // ১ নং মেথড কল হবে
        jipc.Quiz(10, 11, 60);      // ২ নং মেথড কল হবে
        jipc.Quiz(30);              // ৩ নং মেথড কল হবে
	}
}
