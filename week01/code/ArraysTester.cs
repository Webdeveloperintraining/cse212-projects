using System.Linq.Expressions;

public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    private static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

    // STEP 1 Create an empty list to store the number of multiples
        List<double> myList = new List<double>();
    // STEP 2 Implement a FOR loop that to get the multiples of the input.
        for (int i = 1; i <= length;  i++)
        {
    // STEP 3 Multiply the starting number with the loop index
            double calculation = i*number;
    // STEP 4 Store the result in our list
            myList.Add(calculation);
        }
    // STEP 5 return list and turn it into an array
        return myList.ToArray();
        //return new double[0]; // replace this return statement with your own
    }
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    private static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

    // STEP 1 Create a new list to store sorted list
        List<int> newList = new List<int>();

    // STEP 2 Identify first index to append to new list
        int newindex = data.Count - amount;

    //STEP 3 Create a For loop to add each element from the "data" list to the "newList" list
        for (int i = 0; i < data.Count; i++)
            {
    // STEP 4 Append new index value if it's less than "data" list length
            if (newindex + i < data.Count){
                newList.Add(data[newindex+i]);
            }
    // STEP 5 If the new index value is greater than "data" list length, 
    // I wrapped  round the index number back to 0.
            else{
                newList.Add(data[i - amount % data.Count]);
            }
        }
    // STEP 6 Print Results
        foreach(var element in newList)
        {
            Console.Write(element);
        }

    // Chat GPT helped me on this step below, I didn't know how to modify the numbers list
    for (int i = 0; i < data.Count; i++)
        {
            data[i] = newList[i];
        }
    }
}


            // if (i == 0) working
            // {
            //     newList.Add(data[newindex]);
            // }
            // else{
            //     newList.Add(data[i-1]);
            // }
            



    //     for (int i = 0; i < data.Count; i++)
    //     {
    //         if (i <= amount % data.Count)
    //         {
    //             newList.Add(data[i-amount]);
    //         }
    //         else{
    //             newList.Add(data[i]);
    //         }
    //     }

    //     foreach(var element in newList)
    //     {
    //         Console.Write(element);
    //     }

    // }

        // for (int i = amount % data.Count; i < 0; i++)
        // {
        //     Console.Write(data[i]);
        // }

        // int spacesMoved = amount % data.Count;
        // List<int> slice = data.GetRange(0, spacesMoved);

        // newList.AddRange(slice);
        // newList.AddRange(slice2);
        // foreach (int number in newList)
        // {
        //     Console.Write(number);
        // }


    
        //REVERSE LIST
        // for (int i = data.Count - 1; i >=0; i--)
        // {
        //     Console.Write(data[i]);
        // }

                // for (int i = 0; i < data.Count; i++)
        // {
        //     int spacesMoved = amount % data.Count;
            
        //     //int newIndex = data.Count - amount;
        //     if (amount > data.Count){
        //         newList.Add(i-spacesMoved);
        //     }


        // }

        // int spacesMoved = amount % data.Count;
        // List<int> x = data.GetRange(0,spacesMoved);

        // foreach(var element in x)
        // {
        //     Console.Write(element);
        // }


    // STEP 2 FOR Loop to g though each element from the "data" list
        // foreach(int i in data)
        // {
        //      Console.WriteLine(i);
        // }
        //for (int i=0; i < data.Count; i++)
        //{
            //newList.Add(spacesMoved); 
            //int newIndex = spacesMoved + i;
            //newList.Add(newIndex); 
            // if (newIndex > data.Count){

            // }

            //List<int> x = data.GetRange(newIndex, 3);

            // if (i == 0)
            // {
            //     newList.Add(data[newStartingIndex]);
                
            // }
            // else
            // {   
            //     //i--;
            //     //Console.WriteLine( amount % i );
            //     newList.Add(data[i-1]); 
            //     //i++;          
            // }    
            
        //}

        // foreach(var element in newList)
        // {
        //     Console.Write(element);
        // }

    //}

