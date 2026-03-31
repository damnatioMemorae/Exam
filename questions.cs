//--Easy questions 

//--7.Print multiples of 5 up to 100 using while

public class HelloWorld {
      public
        static void Main(string[] args) {
                int i = 5;

                while (i <= 100) {
                        Console.WriteLine(i);
                        i += 5;
                }
        }
}

//--8.Find sum of digits (n = 1234)

public class HelloWorld {
      public
        static void Main(string[] args) {
                int n = 1234;
                int sum = 0;

                while (n > 0) {
                        int digit = n % 10;
                        sum += digit;
                        n /= 10;
                }

                Console.WriteLine("Sum of digits = " + sum);
        }
}


//--Medium questions

//--7.Check if number is prime

public class HelloWorld {
      public
        static void Main(string[] args) {
                Console.Write("Enter a number: ");
                int n = int.Parse(Console.ReadLine());

                bool isPrime = true;

                if (n <= 1)
                        isPrime = false;
                else {
                        for (int i = 2; i < n; i++) {
                                if (n % i == 0) {
                                        isPrime = false;
                                        break;
                                }
                        }
                }

                if (isPrime)
                        Console.WriteLine("Prime number");
                else
                        Console.WriteLine("Not a prime number");
        }
}

//--9.Reverse a number(12345 → 54321)

public class HelloWorld {
      public
        static void Main(string[] args) {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                int reversed = 0;

                while (number != 0) {
                        int digit = number % 10;
                        reversed = reversed * 10 + digit;
                        number /= 10;
                }

                Console.WriteLine("Reversed number: " + reversed);
        }
}

//--Hard questions

//--9.Check if string is palindrome

public class HelloWorld {
      public
        static void Main(string[] args) {
                string text = "madam";
                string reversed = "";

                for (int i = text.Length - 1; i >= 0; i--) {
                        reversed += text[i];
                }

                if (text == reversed) {
                        Console.WriteLine("Palindrome");
                } else {
                        Console.WriteLine("Not Palindrome");
                }
        }
}