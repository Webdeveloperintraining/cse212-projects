public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Check first if the queue is empty then test if values are being stored by priority in the queue
        // Expected Result: 
        Console.WriteLine("Test 1");
        var test1 = new PriorityQueue();
        test1.Dequeue();
        test1.Enqueue("pizza",0);
        test1.Dequeue();
        test1.Enqueue("soda",1);
        test1.Dequeue();
        test1.Enqueue("ice cream",0);
        test1.Dequeue();
        test1.Enqueue("root beer",1);
        test1.Dequeue();
        // Defect(s) Found: 
        /*Values are stored as strings instead of int */

        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");
        var test2 = new PriorityQueue();


        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}