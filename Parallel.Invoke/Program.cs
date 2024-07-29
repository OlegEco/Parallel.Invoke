Parallel.Invoke(
    () => Task1(),
    () => Task2(),
    () => Task3()
    );
Console.WriteLine("All tasks completed.");


static void Task1() => Console.WriteLine($"Task 1 is running on thread {Task.CurrentId}");


static void Task2() => Console.WriteLine($"Task 2 is running on thread {Task.CurrentId}");

static void Task3() => Console.WriteLine($"Task 3 is running on thread {Task.CurrentId}");
