public static class MysteryStack2 {
    private static bool IsFloat(string text) {
        return float.TryParse(text, out _);
    }

    public static float Run(string text) {
        var stack = new Stack<float>();
        foreach (var item in text.Split(' ')) {
            if (item == "+" || item == "-" || item == "*" || item == "/") {
                if (stack.Count < 2)
                    throw new ApplicationException("Invalid Case 1!");

                var op2 = stack.Pop();
                var op1 = stack.Pop();
                float res;
                if (item == "+") {
                    res = op1 + op2;
                }
                else if (item == "-") {
                    res = op1 - op2;
                }
                else if (item == "*") {
                    res = op1 * op2;
                }
                else {
                    if (op2 == 0)
                        throw new ApplicationException("Invalid Case 2!");

                    res = op1 / op2;
                }

                stack.Push(res);
            }
            else if (IsFloat(item)) {
                stack.Push(float.Parse(item));
            }
            else if (item == "") {
            }
            else {
                throw new ApplicationException("Invalid Case 3!");
            }
        }

        if (stack.Count != 1)
            throw new ApplicationException("Invalid Case 4!");

        return stack.Pop();
    }
}

/*
*First function turns text into float when called

* Second funtion will go through each element from a given string and
identifiy if it is an operation sign or a number.

Creates a new empty stack

if there is a number in the string is inserted into a stack

if there is an operation sign in the string it will  proceed to
calculating the last two numbers added to the stack and add it to the stack.

There are error messages if any of this cases are true:
* It will send an error message if there are less than two numbers in a stack
when trying to make a calculation
EXAMPLE: "1+-24"

* Error message if the there is a blank space in the stack or invalid operator
EXAMPLE: "1 2+4^5"

* Error message when trying to divide by 0
EXAMPLE: "10/5"

* Error message if there's more than an element in the stack at the end of the loop
EXAMPLE: 1058/1



// 5 3 7 + *
RESULT:
[5,3,7]
7+3= 10
[5,10]
5*10=50
[50]


// 6 2 + 5 3 - /
[6,2]
6+2=8
[8,5,3]
5-3=2
[8,2]
8/2=4
[4]



*/