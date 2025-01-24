// List<int> arr = new List<int>();
// int tormoz;
// tormoz = int.Parse(Console.ReadLine());
// int sum = 0;
// for (int i=0;i<tormoz;i++)
// {
//     arr.Add(Convert.ToInt32(Console.ReadLine()));
//     sum +=tormoz;
// }
// System.Console.WriteLine(sum);
//////////////////TASK 1///////////////////////////////

// List<int> arr = new List<int>();
// int tormoz;
// tormoz = int.Parse(Console.ReadLine());
// for (int i=0;i<tormoz;i++)
// {
//     arr.Add(Convert.ToInt32(Console.ReadLine()));

// }
// System.Console.WriteLine("Roi kn: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int cnt = 0;
// for (int i=0;i<arr.Count;i++)
// {
//     if (arr[i] == num){
//         cnt++;
//     }
//     else{
//         cnt = 0;
//     }
// }
// for (int i=0;i<arr.Count;i++){
//     if (cnt>0){
//         System.Console.WriteLine("Xastay");
//     break;
//     }
//     else {
//         System.Console.WriteLine("Nestay");
//     }
//     break;
// }

//////////////////////TASK 2///////////////////////////////


// List<int> numbers = new List<int>();
// List<int> squares = new List<int>();

// Console.Write("Chand raqam: ");
// int count = int.Parse(Console.ReadLine());

// Console.Write("Roi kn: ");
// for (int i = 0; i < count; i++)
// {
//     numbers.Add(Convert.ToInt32(Console.ReadLine()));
// }

// for (int i = 0; i < numbers.Count; i++)
// {
//     squares.Add(numbers[i] * numbers[i]);
// }

// Console.WriteLine("Squares:");
// for (int i = 0; i < squares.Count; i++)
// {
//     Console.Write(squares[i] + " ");
// }

///////////////////////TASK 3////////////////////////

//////////////////////MEDIUM/////////////////////////////

// List<int> arr = new List<int>();

// Console.Write("Chand raqam: ");
// int tormoz = int.Parse(Console.ReadLine());

// Console.WriteLine("Roi kn: ");
// for (int i = 0; i < tormoz; i++)
// {
//     arr.Add(Convert.ToInt32(Console.ReadLine()));
// }

// for (int i = 0; i < arr.Count; i++)
// {
//     if (arr[i] % 2 == 0)
//     {
//         arr.RemoveAt(i);
//         i--;
//     }
// }

// Console.WriteLine("Removes: ");
// for (int i = 0; i < arr.Count; i++)
// {
//     Console.WriteLine(arr[i]);
// }

//////////////////////TASK 1////////////////////////////

// List<int> list1 = new List<int>();
// List<int> list2 = new List<int>();

// Console.Write("Darozi list 1: ");
// int tormoz = int.Parse(Console.ReadLine());
// Console.WriteLine("Raqamow: ");
// for (int i = 0; i < tormoz; i++)
// {
//     list1.Add(int.Parse(Console.ReadLine()));
// }

// Console.Write("Darozi list 2: ");
// int tormoz = int.Parse(Console.ReadLine());
// Console.WriteLine("Raqamow:");
// for (int i = 0; i < tormoz; i++)
// {
//     list2.Add(int.Parse(Console.ReadLine()));
// }

// List<int> merge = new List<int>();
// foreach (int num in list1)
// {
//     if (!merge.Contains(num)) merge.Add(num);
// }
// foreach (int num in list2)
// {
//     if (!merge.Contains(num)) merge.Add(num);
// }

// Console.WriteLine("Listi: ");
// foreach (int num in merge)
// {
//     Console.Write(num + " ");
// }

///////////////////////TASK 2/////////////////////////

// List<int> arr = new List<int>();

// Console.Write("Chand raqam: ");
// int tormoz = int.Parse(Console.ReadLine());

// Console.WriteLine("Roi kn:");
// for (int i = 0; i < tormoz; i++)
// {
//     arr.Add(Convert.ToInt32(Console.ReadLine()));
// }

// int max = arr[0];
// int min = arr[0];

// for (int i = 1; i < arr.Count; i++)
// {
//     if (arr[i] > max)
//     {
//         max = arr[i];
//     }
//     if (arr[i] < min)
//     {
//         min = arr[i];
//     }
// }

// Console.WriteLine("Kalontarin: " + max);
// Console.WriteLine("Xurdtarin: " + min);

///////////////////TASK 3////////////////////////////



