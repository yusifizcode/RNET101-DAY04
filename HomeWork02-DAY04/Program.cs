int[] arr = { 1, 2, 34, 67, 76, 12, 54 };


// Task 1
Array.ForEach(arr, i => Console.WriteLine(i));

// Task 2
Console.WriteLine("Bir eded daxil edin: ");

// Way One

//string numStr = Console.ReadLine();
//if (arr.ToString().Contains(numStr))
//    Console.WriteLine(true);
//else
//    Console.WriteLine(false);

int num = Convert.ToInt32(Console.ReadLine());
bool isExist = Array.Exists(arr, i => i == num);
Console.WriteLine(isExist);