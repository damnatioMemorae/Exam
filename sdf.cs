//--Easy questions 
//--1. Write a for loop to print numbers from 1 to 10

using System;

public
class HelloWorld {
      public
        static void Main(string[] args) {
                for (int i = 1; i <= 10; i++) {
                        Console.WriteLine(i);
                }
        }
}

//--2.Print even numbers from 1 to 20

public class HelloWorld {
      public
        static void Main(string[] args) {
                for (int i = 2; i <= 20; i += 2) {
                        Console.WriteLine(i);
                }
        }
}

//--3.Print numbers from 10 to 1 (reverse)

public class HelloWorld {
      public
        static void Main(string[] args) {
                for (int i = 10; i >= 1; i--) {
                        Console.WriteLine(i);
                }
        }
}

//--4.Print 'Hello World' 5 times

public class HelloWorld {
      public
        static void Main(string[] args) {
                for (int i = 1; i <= 5; i++) {
                        Console.WriteLine("Hello World");
                }
        }
}

//--5.Find the sum of numbers from 1 to 10

public class HelloWorld {
      public
        static void Main(string[] args) {
                int sum = 0;

                for (int i = 1; i <= 10; i++) {
                        sum += i;
                }

                Console.WriteLine("Sum = " + sum);
        }
}

//--6.Use while to print numbers from 1 to 10

public class HelloWorld {
      public
        static void Main(string[] args) {
                int i = 1;

                while (i <= 10) {
                        Console.WriteLine(i);
                        i++;
                }
        }
}

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

//--9.Read numbers until user enters 0

public class HelloWorld {
      public
        static void Main(string[] args) {
                int number;

                do {
                        Console.Write("Enter a number (0 to stop): ");
                        number = int.Parse(Console.ReadLine());

                } while (number != 0);

                Console.WriteLine("Program ended.");
        }
}

//--10.Find first power of 2 greater than 100

public class HelloWorld {
      public
        static void Main(string[] args) {
                int power = 1;

                while (power <= 100) {
                        power *= 2;
                }

                Console.WriteLine("First power of 2 greater than 100: " + power);
        }
}

//--11.Print numbers from 1 to n

public class HelloWorld {
      public
        static void Main(string[] args) {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++) {
                        Console.WriteLine(i);
                }
        }
}

//--12.Print even numbers up to n

public class HelloWorld {
      public
        static void Main(string[] args) {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++) {
                        if (i % 2 == 0) {
                                Console.WriteLine(i);
                        }
                }
        }
}

//--13.Print numbers from n to 1

public class HelloWorld {
      public
        static void Main(string[] args) {
                Console.Write("Enter n: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = n; i <= n; i++) {
                        Console.WriteLine(i);
                }
        }
}

//--14. Find sum from 1 to 100

public class HelloWorld {
      public
        static void Main(string[] args) {
                int sum = 0;

                for (int i = 1; i <= 100; i++) {
                        sum += i;
                }

                Console.WriteLine("Sum from 1 to 100 = " + sum);
        }
}

//--15.Print odd numbers from 1 to 50

public class HelloWorld {
      public
        static void Main(string[] args) {
                for (int i = 1; i <= 50; i += 2) {
                        Console.WriteLine(i);
                }
        }
}

//--Medium questions
//--1. Print day of week using if-else (1–7)

public class HelloWorld {
      public
        static void Main(string[] args) {
                Console.Write("Enter a number (1-7): ");
                int day = int.Parse(Console.ReadLine());

                if (day == 1)
                        Console.WriteLine("Monday");
                else if (day == 2)
                        Console.WriteLine("Tuesday");
                else if (day == 3)
                        Console.WriteLine("Wednesday");
                else if (day == 4)
                        Console.WriteLine("Thursday");
                else if (day == 5)
                        Console.WriteLine("Friday");
                else if (day == 6)
                        Console.WriteLine("Saturday");
                else if (day == 7)
                        Console.WriteLine("Sunday");
                else
                        Console.WriteLine("Invalid input!");
        }
}

//--2.Find smallest n where 1+2+...+n > 100

public class HelloWorld {
      public
        static void Main(string[] args) {
                int sum = 0;
                int n = 0;

                while (sum <= 100) {
                        n++;
                        sum += n;
                }

                Console.WriteLine("Smallest n: " + n);
                Console.WriteLine("Sum: " + sum);
        }
}

//--3.Find absolute difference using ternary operator

public class HelloWorld {
      public
        static void Main(string[] args) {
                int a = 10;
                int b = 25;

                int diff = (a > b) ? (a - b) : (b - a);

                Console.WriteLine("Absolute difference: " + diff);
        }
}

//--4.Print numbers 1–5 using do -while

public class HelloWorld {
      public
        static void Main(string[] args) {
                int i = 1;

                do {
                        Console.WriteLine(i);
                        i++;
                } while (i <= 5);
        }
}

//--5.Check if year is leap(365 or 366 days)

public class HelloWorld {
      public
        static void Main(string[] args) {
                Console.Write("Enter a year: ");
                int year = int.Parse(Console.ReadLine());

                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) {
                        Console.WriteLine("Leap year (366 days)");
                } else {
                        Console.WriteLine("Not a leap year (365 days)");
                }
        }
}

//--6.Find smallest of 3 numbers

public class HelloWorld {
      public
        static void Main(string[] args) {
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("Enter third number: ");
                int c = int.Parse(Console.ReadLine());

                int smallest;

                if (a <= b && a <= c)
                        smallest = a;
                else if (b <= a && b <= c)
                        smallest = b;
                else
                        smallest = c;

                Console.WriteLine("Smallest number: " + smallest);
        }
}

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

//--8.Find GCD using Euclidean algorithm

public class HelloWorld {
      public
        static void Main(string[] args) {
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());

                while (b != 0) {
                        int temp = b;
                        b = a % b;
                        a = temp;
                }

                Console.WriteLine("GCD: " + a);
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

//--10.Categorize age

public class HelloWorld {
      public
        static void Main(string[] args) {
                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());

                if (age >= 0 && age <= 12)
                        Console.WriteLine("Child");
                else if (age >= 13 && age <= 19)
                        Console.WriteLine("Teenager");
                else if (age >= 20 && age <= 59)
                        Console.WriteLine("Adult");
                else if (age >= 60)
                        Console.WriteLine("Senior");
                else
                        Console.WriteLine("Invalid age");
        }
}

//--11.Find maximum element in array

public class HelloWorld {
      public
        static void Main(string[] args) {
                int[] numbers = {5, 2, 9, 1, 7};

                int max = numbers[0];

                for (int i = 1; i < numbers.Length; i++) {
                        if (numbers[i] > max) {
                                max = numbers[i];
                        }
                }

                Console.WriteLine("Maximum element: " + max);
        }
}

//--12.Find minimum element in array

public class HelloWorld {
      public
        static void Main(string[] args) {
                int[] numbers = {5, 2, 9, 1, 7};

                int min = numbers[0];

                for (int i = 1; i < numbers.Length; i++) {
                        if (numbers[i] < min) {
                                min = numbers[i];
                        }
                }

                Console.WriteLine("Minimum element: " + min);
        }
}

//--13.Print all elements of array

public class HelloWorld {
      public
        static void Main(string[] args) {
                int[] numbers = {5, 2, 9, 1, 7};

                for (int i = 0; i < numbers.Length; i++) {
                        Console.WriteLine(numbers[i]);
                }
        }
}

//--14.Find sum of array elements

public class HelloWorld {
      public
        static void Main(string[] args) {
                int[] numbers = {5, 2, 9, 1, 7};

                int sum = 0;

                for (int i = 0; i < numbers.Length; i++) {
                        sum += numbers[i];
                }

                Console.WriteLine("Sum: " + sum);
        }
}

//--15.Count even numbers in array

public class HelloWorld {
      public
        static void Main(string[] args) {
                int[] numbers = {5, 2, 9, 1, 7, 4, 6};

                int count = 0;

                for (int i = 0; i < numbers.Length; i++) {
                        if (numbers[i] % 2 == 0) {
                                count++;
                        }
                }

                Console.WriteLine("Even numbers count: " + count);
        }
}

//--Hard questions
//--1. Find diagonal sum of 3x3 matrix

public class HelloWorld {
      public
        static void Main(string[] args) {
                int[, ] matrix = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};

                int primaryDiagonalSum = 0;
                int secondaryDiagonalSum = 0;

                for (int i = 0; i < 3; i++) {
                        primaryDiagonalSum += matrix[i, i];
                        secondaryDiagonalSum += matrix[i, 2 - i];
                }

                Console.WriteLine("Primary diagonal sum: " + primaryDiagonalSum);
                Console.WriteLine("Secondary diagonal sum: " + secondaryDiagonalSum);
        }
}

//--2.Find Armstrong numbers from 1 to 1000

public class HelloWorld {
      public
        static void Main(string[] args) {
                for (int i = 1; i <= 1000; i++) {
                        int num = i;
                        int sum = 0;

                        while (num > 0) {
                                int digit = num % 10;
                                sum += digit * digit * digit;
                                num /= 10;
                        }

                        if (sum == i) {
                                Console.WriteLine(i);
                        }
                }
        }
}

//--3.Print first 10 Fibonacci numbers

public class HelloWorld {
      public
        static void Main(string[] args) {
                int a = 0, b = 1;

                Console.WriteLine(a);
                Console.WriteLine(b);

                for (int i = 3; i <= 10; i++) {
                        int next = a + b;
                        Console.WriteLine(next);

                        a = b;
                        b = next;
                }
        }
}

//--4.Write Bubble Sort {5,3,8,1,4}

public class HelloWorld {
      public
        static void Main(string[] args) {
                int[] arr = {5, 3, 8, 1, 4};

                for (int i = 0; i < arr.Length - 1; i++) {
                        for (int j = 0; j < arr.Length - i - 1; j++) {
                                if (arr[j] > arr[j + 1]) {
                                        int temp = arr[j];
                                        arr[j] = arr[j + 1];
                                        arr[j + 1] = temp;
                                }
                        }
                }

                foreach (int num in arr) {
                        Console.Write(num + " ");
                }
        }
}

//--5.Find prime numbers from 2 to 30

public class HelloWorld {
      public
        static void Main(string[] args) {
                for (int i = 2; i <= 30; i++) {
                        bool isPrime = true;

                        for (int j = 2; j < i; j++) {
                                if (i % j == 0) {
                                        isPrime = false;
                                        break;
                                }
                        }

                        if (isPrime) {
                                Console.WriteLine(i);
                        }
                }
        }
}

//--6.Reverse an array

public class HelloWorld {
      public
        static void Main(string[] args) {
                int[] arr = {1, 2, 3, 4, 5};

                int start = 0;
                int end = arr.Length - 1;

                while (start < end) {
                        int temp = arr[start];
                        arr[start] = arr[end];
                        arr[end] = temp;

                        start++;
                        end--;
                }

                foreach (int num in arr) {
                        Console.Write(num + " ");
                }
        }
}

//--7.Merge two arrays

public class HelloWorld {
      public
        static void Main(string[] args) {
                int[] arr1 = {1, 2, 3};
                int[] arr2 = {4, 5, 6};

                int[] merged = new int[arr1.Length + arr2.
        for (int i = 0; i < arr1.Length; i++) {
                        merged[i] = arr1[i];
                }

                        
        for (int i = 0; i < arr2.Length; i++) {
                        merged[arr1.Length + i] = arr2[i];
                
        foreach (int num in merged) {
                        Console.Write(num + " ");
                }
        }
}

//--8.Count vowels in a string

public class HelloWorld {
      public
        static void Main(string[] args) {
                string text = "Hello World";
                int count = 0;

                for (int i = 0; i < text.Length; i++) {
                        char ch = char.ToLower(text[i]);

                        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') {
                                count++;
                        }
                }

                Console.WriteLine("Vowel count: " + count);
        }
}

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

//--10.Find most frequent element in array

public class HelloWorld {
      public
        static void Main(string[] args) {
                int[] arr = {1, 3, 2, 3, 4, 3, 2};

                int maxCount = 0;
                int mostFrequent = arr[0];

                for (int i = 0; i < arr.Length; i++) {
                        int count = 0;

                        for (int j = 0; j < arr.Length; j++) {
                                if (arr[i] == arr[j]) {
                                        count++;
                                }
                        }

                        if (count > maxCount) {
                                maxCount = count;
                                mostFrequent = arr[i];
                        }
                }

                Console.WriteLine("Most frequent element: " + mostFrequent);
                Console.WriteLine("Frequency: " + maxCount);
        }
}