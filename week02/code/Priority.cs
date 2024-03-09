public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        //Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following value and priority: A (2), B (5), C (1), D (3)
        // Expected Result: B, D, A, C
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 1);
        priorityQueue.Enqueue("D", 3);

        for (int i = 0; i < 4; i++)
        {
            var result = priorityQueue.Dequeue();
            Console.WriteLine($"{result}");
        }

        // Defect(s) Found: 
        // Insert inside de Dequeue method the called to removeAt

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with the following value and priority: A (1), B (1), C (4), D (3)
        // Expected Result: C, D, A, B
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 1);
        priorityQueue.Enqueue("C", 4);
        priorityQueue.Enqueue("D", 3);

        for (int i = 0; i < 4; i++)
        {
            var result = priorityQueue.Dequeue();
            Console.WriteLine($"{result}");
        }
        // Defect(s) Found: 
        // Removed the condition Equals or getter than, to getter than in validation to change the highPriority

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
        // Test 3
        // Scenario: Create a queue with the following value and priority: k (1), S (1), T (4), N (3), H (4), A(4)
        // Expected Result: T, H, A, N, K, S
        Console.WriteLine("Test 3");
        priorityQueue.Enqueue("K", 1);
        priorityQueue.Enqueue("S", 1);
        priorityQueue.Enqueue("T", 4);
        priorityQueue.Enqueue("N", 3);
        priorityQueue.Enqueue("H", 4);
        priorityQueue.Enqueue("A", 4);

        for (int i = 0; i < 6; i++)
        {
            var result = priorityQueue.Dequeue();
            Console.WriteLine($"{result}");
        }

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
        // Test 3
        // Scenario: Try dequeue a empty queue
        // Expected Result: should return a message error
        Console.WriteLine("Test 4");
        var message = priorityQueue.Dequeue();
        Console.WriteLine($"{message}");
    }
}