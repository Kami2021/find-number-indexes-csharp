

# 🔍 Find Number Indexes (C#)

This C# console application allows users to enter a list of numbers and then find **all indexes** of a specific target number in that list.  
It validates user input, prevents errors, and displays results in a clear and user-friendly way.

---

## 🧠 What the Program Does

1. The user enters numbers one by one.  
2. The program stores these numbers in a list.  
3. When the user types `done`, it stops taking inputs.  
4. The user then enters a **target number**.  
5. The program checks where (at which indexes) that target number appears in the list.  
6. All found indexes are displayed. If none are found, the program shows a friendly message.

---

## 💻 Example Output

```

Enter numbers one by one (type 'done' to finish):
10
20
30
20
40
done
Enter the target number to find: 20
The target number 20 was found at the following index(es):
1, 3

```
```

Enter numbers one by one (type 'done' to finish):
1
two
Invalid input! Please enter a valid integer.
3
done
Enter the target number to find: 7
The target number 7 was not found in the list.

````

---

## 🧩 Full Source Code

```csharp
using System;
using System.Collections.Generic;

class Program
{
    // This method finds all indexes where the target number appears
    static List<int> FindTargetIndexes(int[] nums, int target)
    {
        List<int> indexes = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
                indexes.Add(i); // Add each matching index to the list
        }

        return indexes; // Return all matching indexes
    }

    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter numbers one by one (type 'done' to finish):");

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "done")
                break;

            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input! Please enter a valid integer.");
                Console.ResetColor();
            }
        }

        if (numbers.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("No numbers were entered. Exiting program.");
            Console.ResetColor();
            return;
        }

        Console.Write("Enter the target number to find: ");
        string targetInput = Console.ReadLine();

        if (!int.TryParse(targetInput, out int target))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid target number! Exiting program.");
            Console.ResetColor();
            return;
        }

        List<int> resultIndexes = FindTargetIndexes(numbers.ToArray(), target);

        if (resultIndexes.Count > 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The target number {target} was found at the following index(es):");
            Console.ResetColor();
            Console.WriteLine(string.Join(", ", resultIndexes));
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The target number {target} was not found in the list.");
            Console.ResetColor();
        }
    }
}
````

---

## ⚙️ How the Code Works (Step-by-Step)

### 1. Importing Namespaces

```csharp
using System;
using System.Collections.Generic;
```

These allow the program to use basic C# features (`Console`, `List`, etc.).

---

### 2. The `FindTargetIndexes` Method

This function:

* Takes two parameters — an array of numbers (`nums`) and a `target` number.
* Loops through the array using `for (int i = 0; i < nums.Length; i++)`.
* Checks if each number equals the target (`if (nums[i] == target)`).
* If yes, it adds that index (`i`) to a list called `indexes`.
* Finally, it returns the list of all found indexes.

---

### 3. Taking User Input

Inside the `Main()` method:

* The user enters numbers one by one.
* Each input is checked using `int.TryParse()` to ensure it’s a valid integer.
* Invalid inputs trigger a red warning message.
* Typing “done” stops the input process.

---

### 4. Input Validation and Error Handling

The program prevents crashes by checking:

* Whether input is numeric.
* Whether the list is empty.
* Whether the target input is valid.

These checks keep the program reliable and user-friendly.

---

### 5. Displaying Results

Once the user enters the target number:

* The program calls `FindTargetIndexes()` to search for matches.
* If any indexes are found, they are displayed in green.
* If none are found, a yellow warning message appears.

---

## ✅ Why This Solution Works (Justification)

1. **Input Validation**

   * Uses `int.TryParse()` to safely convert user input to integers.
   * Prevents crashes from invalid input.

2. **Efficient Logic**

   * Uses a single loop to find all occurrences of the target.

3. **Separation of Logic**

   * The searching logic is placed in a separate method (`FindTargetIndexes`).
   * This improves readability and makes the program modular.

4. **Good User Experience**

   * Uses console colors to highlight errors and results.
   * Provides friendly messages and clear instructions.

5. **Handles Multiple Occurrences**

   * Finds **all** positions of the target number, not just the first one.
   * Makes the program more complete and realistic for real-world use.

---

## 🧰 Technologies Used

* **C# (.NET 6 or later)**
* **Console Application**

---


## 🧩 Example Use Case

This program can be used as a foundation for:

* Search utilities
* Number analysis tools
* Teaching basic C# logic and input handling

---

