# Eligibility-for-Engineering-Admission
## Aim:
To write a C# program to check whether the student is eligibile for the engineering admission

## Algorithm:
### Step1: 
Create new class

### Step2: 
Initiate the variables for maths, physics and chemistry and get the value from the user.

### Step3:
Get the maths, chemistry and physics marks from the user using ReadLine().

### Step4:
Calculate the sum of all three subjects and check whether the sum is greater than and equal to 180

### Step5:
Calculate the sum of physics and maths and check the condition

### Step6:
Check for the given criteria for eligibility using if-else statements.

### Step7:
Display whether the person is eligible for admission or not based on the given criteria.

## Program:
```
using System;

namespace exp1
{
    class Eligibility
    {
        static void Main(string[] args)
        {
            string n;
            int m, p, c;
            Console.Write("Enter your name:");
            n = Console.ReadLine();
            Console.Write("Enter Maths Marks:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Physics Marks:");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Chemistry Marks:");
            c = Convert.ToInt32(Console.ReadLine());
            int Sum = m + p + c;
            int tot = m + p;
            if (m >= 65 && p >= 55 && c >= 50)
            {
                if (Sum >= 180 || tot >= 140)
                {
                    Console.WriteLine(n + " is eligible for admission to an engineering course.");
                }
                else
                {
                    Console.WriteLine(n + " is not eligible for admission to an engineering course due to insufficient marks.");
                }
            }
            else
            {
                Console.WriteLine(n + " is not eligible for admission to an engineering course due to insufficient marks.");
            }
            Console.Read();
        }
    }
}
```
## Output:

![image](https://github.com/sanjay5656/Eligibility-for-Engineering-Admission/assets/115128955/38ac103f-ca70-4c75-8b3f-d377255b935f)


## Result:
Thus the above C# program to check the eligibility of engineering admission is successfully executed.

