using System;

class Program {
    static void Main() {
        string[] subjects = new string[3];
        double[] grades = new double[3];

        for (int i = 0; i < 3; i++) {
            Console.Write($"Enter subject {i + 1}: ");
            subjects[i] = Console.ReadLine();

            Console.Write("Enter grade (0 - 100): ");
            grades[i] = double.Parse(Console.ReadLine());
        }

        double total = 0;
        for (int i = 0; i < 3; i++) {
            total += grades[i];
        }

        double gpa = total / 3;
        Console.WriteLine($"\nYour GPA is: {gpa:F2}");
    }
}
