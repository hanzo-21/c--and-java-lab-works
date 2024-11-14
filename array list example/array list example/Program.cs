using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace array_list_example
{
    internal class Program
    {
        static void displayCollege(ArrayList name)
        {
            
                Console.WriteLine("\nname of college is ");
            foreach (var element in name)
            {
                Console.Write(element);
            }
            Console.WriteLine();

        }

        static void Main(string[] args)
        {

            /*
            // create array list array list and display it's functions

            
            ArrayList list = new ArrayList();

            list.Add("my name is Aayush");
            list.Add('S');
            list.Add(null);
            list.Add(343);
            list.Add(22.5);
            list.Add(true);
            list.Add(34533);
            list.Add(3322.90905);
            list.Add(false);

            foreach (var elements in list)
            {
                Console.WriteLine(elements);
            }


            // Displaying count of elements of ArrayList (shows how many elemsents does it have)
            Console.WriteLine("Number of elements in list : " + list.Count );
            // Displaying Current capacity of ArrayList (shows many many elements can it store in )
            //in pattern of  1,2,4,8,16......2^n.
            Console.WriteLine("Current capacity of list: " + list.Capacity  );
            */

           
            ArrayList collegeName= new ArrayList();

            // wrire EVEREST COLLEGE in array list

            collegeName.Add('E');
            collegeName.Add('V');
            collegeName.Add('E');
            collegeName.Add('R');
            collegeName.Add('E');
            collegeName.Add('S');
            collegeName.Add('T');
            collegeName.Add(' ');
            collegeName.Add('C');
            collegeName.Add('O');
            collegeName.Add('L');
            collegeName.Add('L');
            collegeName.Add('E');
            collegeName.Add('G');


            // Remove the first element from the ArrayList Using Remove() method 
            collegeName.Remove('E');
            Console.WriteLine("After Remove() method the number of elements: " +collegeName.Count);

            //display the array list after removing 'E'
            displayCollege(collegeName);

            // Remove the element present at index 5 Using RemoveAt() method 
            collegeName.RemoveAt(5);
            Console.WriteLine("\nAfter RemoveAt(5) method the number of elements:" + collegeName.Count);

            //display the array list after removing character at index 5
            displayCollege(collegeName);

            // Remove 3 elements starting from index 1 using RemoveRange() method 
            collegeName.RemoveRange(1, 3);
            Console.WriteLine("\nAfter RemoveRange(1,3) method the number of elements: " + collegeName.Count);

            //display the array list after removing character from index 1 to 3 
            displayCollege(collegeName);

            // Remove the all element present in ArrayList Using Clear() method 
            collegeName.Clear();
            Console.WriteLine("\nAfter Clear() method the number of elements: " + collegeName.Count);

            //display the array list after cleraing all the characters
            displayCollege(collegeName);
            


            Console.ReadKey();  
        }
    }
}