
using System;  // Importing the System namespace

public class Exercise10  // Declaration of the Exercise10 class
{  
    public static void Main()  // Entry point of the program
    {  
        int p, c, m;  // Declaration of integer variables p, c, and m for Physics, Chemistry, and Mathematics marks
        Console.Write("\n\n");  // Printing new lines
        Console.Write("Find eligibility for admission :\n");  // Displaying the purpose of the program
        Console.Write("----------------------------------");  // Displaying a separator
        Console.Write("\n\n");

        Console.Write("Eligibility Criteria :\n");  // Displaying eligibility criteria
        Console.Write("Marks in Maths >=65\n");
        Console.Write("and Marks in Phy >=55\n");
        Console.Write("and Marks in Chem>=50\n");
        Console.Write("and Total in all three subject >=180\n");
        Console.Write("or Total in Maths and Physics >=140\n");
        Console.Write("-------------------------------------\n");


        Console.Write("Input the marks obtained in Physics :");  // Prompting user to input Physics marks
        p = Convert.ToInt32(Console.ReadLine());  // Reading the input Physics marks from the user
        Console.Write("Input the marks obtained in Chemistry :");  // Prompting user to input Chemistry marks
        c = Convert.ToInt32(Console.ReadLine());  // Reading the input Chemistry marks from the user
        Console.Write("Input the marks obtained in Mathematics :");  // Prompting user to input Mathematics marks
        m = Convert.ToInt32(Console.ReadLine());  // Reading the input Mathematics marks from the user
        Console.Write("Total marks of Maths, Physics and Chemistry : {0}\n", m + p + c);  // Calculating and displaying the total marks in all three subjects
        Console.Write("Total marks of Maths and Physics : {0}\n", m + p);  // Calculating and displaying the total marks in Maths and Physics


        if (m >= 65)  // Checking if marks in Mathematics are greater than or equal to 65
            if (p >= 55)  // Checking if marks in Physics are greater than or equal to 55
                if (c >= 50)  // Checking if marks in Chemistry are greater than or equal to 50
                    if ((m + p + c) >= 180 || (m + p) >= 140)  // Checking if the total marks fulfill the given criteria for admission
                        Console.Write("The candidate is eligible for admission.\n");  // Printing a message if the candidate is eligible
                    else
                        Console.Write("The candidate is not eligible.\n\n");  // Printing a message if the candidate is not eligible
                else
                    Console.Write("The candidate is not eligible.\n\n");  // Printing a message if the candidate is not eligible
            else
                Console.Write("The candidate is not eligible.\n\n");  // Printing a message if the candidate is not eligible
        else
            Console.Write("The candidate is not eligible.\n\n");  // Printing a message if the candidate is not eligible
    }
}
