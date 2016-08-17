using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] numbersArray = new int[10];
        string a, b;
        int x, z;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void addToArray_Click(object sender, RoutedEventArgs e)
        {
            if (z < 10)
            {
                a = numbersToSort.Text;
                if (int.TryParse(a, out x))
                {
                    sortOutput.Text = a;
                    numbersArray[z] = x;
                }
                else
                {
                    sortOutput.Text = "Please enter a number";
                }

                b = Convert.ToString(x);
                sortOutput.Text = b;
                z++;
            }
            else
            {
                sortOutput.Text = "They array is now full, time to sort!";
                // sorting should set z back to 0 so that once some numbers are sorted the array can be used again
            }

           
            
        }

        private void bubbleSort_Click(object sender, RoutedEventArgs e)
        {


            for (int i = 0; i < numbersArray.Length - 1; i++) //go through the array
            {
                for (int v = 0; v < numbersArray.Length - 1; v++) //bubble sort works by comparing two numbers and swapping the smaller number to the left - it essentially drags the largest number to the right
                {
                    if (numbersArray[v] > numbersArray[v + 1]) //if the number on the left is smaller than the right 
                    {
                        int temp = numbersArray[v + 1];
                        numbersArray[v + 1] = numbersArray[v];
                        numbersArray[v] = temp;
                    }
                }

            }

            string a = Convert.ToString(numbersArray[0]);
            string b = Convert.ToString(numbersArray[1]);
            string c = Convert.ToString(numbersArray[2]);
            string d = Convert.ToString(numbersArray[3]);
            string l = Convert.ToString(numbersArray[4]);
            string f = Convert.ToString(numbersArray[5]);
            string g = Convert.ToString(numbersArray[6]);
            string h = Convert.ToString(numbersArray[7]);
            string k = Convert.ToString(numbersArray[8]);
            string j = Convert.ToString(numbersArray[9]);
            sortOutput.Text = a + " " + b + " " + c + " " + d + " " + l + " " + f + " " + g + " " + h + " " + k + " " + j;
            z = 0;

        }

        private void insertionSort_Click(object sender, RoutedEventArgs e)
        {

            //insertion sort works by taking two numbers and comparing them, taking the lowest to the left
            for (int p = 1; p < numbersArray.Length; p++ ) //starts at 1 because you take the second number in the array first and compare it to the first
            {
                int v = p;
                while (v > 0)
                {
                    if (numbersArray[v] < numbersArray[v - 1])
                    {
                        int temp = numbersArray[v];
                        numbersArray[v] = numbersArray[v - 1];
                        numbersArray[v - 1] = temp;
                    }
                    v--;
                }
            }
            for (int b = 0; b > 9; b++)
            {

            }

            System.Text.StringBuilder text = new System.Text.StringBuilder();
            for (int b = 0; b > 9; b++)
            {
                string a = Convert.ToString(numbersArray[b]);
                text.AppendLine(a.ToString());
            }
            sortOutput.Text = text.ToString();
            /*
            string a = Convert.ToString(numbersArray[0]);
            string b = Convert.ToString(numbersArray[1]);
            string c = Convert.ToString(numbersArray[2]);
            string d = Convert.ToString(numbersArray[3]);
            string l = Convert.ToString(numbersArray[4]);
            string f = Convert.ToString(numbersArray[5]);
            string g = Convert.ToString(numbersArray[6]);
            string h = Convert.ToString(numbersArray[7]);
            string k = Convert.ToString(numbersArray[8]);
            string j = Convert.ToString(numbersArray[9]);
            sortOutput.Text = a + " " + b + " " + c + " " + d + " " + l + " " + f + " " + g + " " + h + " " + k + " " + j;
            z = 0;
            */
        }

        private void quickSort_Click(object sender, RoutedEventArgs e) //divide & conquer algorithm
        {


            int left = 0;
            int right = (numbersArray.Length - 1);

            for (int i = 0; i < numbersArray.Length; i++)
            {
                for (int x = i + 1; x < numbersArray.Length; x++)
                {
                    if (numbersArray[i] == numbersArray[x])
                    {
                        sortOutput.Text = "Sorry you entered a duplicate, this sort cannot be performed. Please enter different numbers to sort.";
                        z = 0;
                        return;
                    }
                }
            }


            quickSortRecursion(numbersArray, left, right);


            string a = Convert.ToString(numbersArray[0]);
            string b = Convert.ToString(numbersArray[1]);
            string c = Convert.ToString(numbersArray[2]);
            string d = Convert.ToString(numbersArray[3]);
            string l = Convert.ToString(numbersArray[4]);
            string f = Convert.ToString(numbersArray[5]);
            string g = Convert.ToString(numbersArray[6]);
            string h = Convert.ToString(numbersArray[7]);
            string k = Convert.ToString(numbersArray[8]);
            string j = Convert.ToString(numbersArray[9]);
            sortOutput.Text = a + " " + b + " " + c + " " + d + " " + l + " " + f + " " + g + " " + h + " " + k + " " + j;
            z = 0;
        }


        static public void quickSortRecursion(int[] numbers, int left, int right)
        {

            int i = left;
            int j = right;
            int temp;
            int pivot = numbers[(left + right) / 2];

            //making a partition

            while (i <= j)
            {
                while (numbers[i] < pivot)
                {
                    i++;
                }
                while (numbers[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                    i++;
                    j--;
                }
            }

            //this part is the part that sorts
            if (left < j)
                quickSortRecursion(numbers, left, j);
            if (i < right)
                quickSortRecursion(numbers, i, right);
        }



        private void mergeSort_Click_1(object sender, RoutedEventArgs e) //divide & conquer algorithm
        {

            int left = 0;
            int right = numbersArray.Length - 1;

            mergeSortRecursion(numbersArray, left, right);
            
            string a = Convert.ToString(numbersArray[0]);
            string b = Convert.ToString(numbersArray[1]);
            string c = Convert.ToString(numbersArray[2]);
            string d = Convert.ToString(numbersArray[3]);
            string l = Convert.ToString(numbersArray[4]);
            string f = Convert.ToString(numbersArray[5]);
            string g = Convert.ToString(numbersArray[6]);
            string h = Convert.ToString(numbersArray[7]);
            string k = Convert.ToString(numbersArray[8]);
            string j = Convert.ToString(numbersArray[9]);
            sortOutput.Text = a + " " + b + " " + c + " " + d + " " + l + " " + f + " " + g + " " + h + " " + k + " " + j;
            z = 0;
        }


        //merge sort splits the array into the smallest possible pieces then will merge one array with another at once e.g.
        // [3, 9, 5, 1, 6, 8, 3, 12, 10, 11] -> [3, 9, 5, 1, 6] [8, 3, 12, 10, 11] -> [3, 9] [5, 1, 6] [8, 3] [12, 10, 11] -> [3] [9] [5] [1, 6] [8] [3] [12] [10, 11] -> [3] [9] [5] [1] [6] [8] [3] [12] [10] [11]
        //-> [3, 9] [5] [1, 6] [3, 8] [12] [10, 11] -> [3, 5, 9] [1, 6] [3, 8] [10, 11, 12] -> [1, 3, 5, 6, 9] [3, 8, 10, 11, 12] -> [1, 3, 3, 5, 6, 8, 9, 10, 11, 12]

       static public void mergeMethod(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[20];

            int temp_position = left;//temp position itterates through the temporary array that we're adding the sorted numbers into 
            int left_end = mid - 1; // this is the end of the left side array
            int numberofelements = right - left + 1; 

            while ((left <= left_end) && (mid <= right))// which left is smaller or equal to left end and mid is smaller or equal than right there are elements in the arrays that haven't been itterated through and need sorting
            {
                if (numbers[left] <= numbers[mid]) //this compares two arrays so that they can be merged
                {
                    temp[temp_position] = numbers[left]; //if mid is larger than left, put the left number into the temp array
                    left++; //increment left so it now looks to the next number in the sub array
                    temp_position++; //increment the temp array so the next position can be filled
                }
                else
                {
                    temp[temp_position] = numbers[mid]; //if the previous statement is false the number in the right array is smaller 
                    mid++;
                    temp_position++;
                }

            }
            // once one of the arrays are sorted the previous while loop will break
           // at this point only one of the arrays need sorting so one of the below while loops will execute depending on which still has numbers in
            while (left <= left_end) 
            {
                temp[temp_position] = numbers[left];
                left++;
                temp_position++;
            }

            while (mid <= right)
            {
                temp[temp_position] = numbers[mid];
                mid++;
                temp_position++;
            }
           
            for (int i = 0; i < numberofelements; i++)
            {
                numbers[right] = temp[right]; // this places the numbers from the temp array into actual array - 
                right--;
            }
        }
        

        static public void mergeSortRecursion(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2; //find a mid point to split the array at, all elements after this position will belong to one half of the array, everything on the other side belongs to the other half
                mergeSortRecursion(numbers, left, mid); //split into sub array - when it recurses (calls itself) the value or right will be different, will will equal mid which is halved it will do this until right is smaller or equal to left
                mergeSortRecursion(numbers, (mid + 1), right); //split into sub array - it recurses the same as above but this time the value of right will be just 1 due to the rescursion that has already occured 
                mergeMethod(numbers, left, (mid + 1 ), right); //merge - this will be called multiple times to merge the multiple split arrays
 
            }
        }

   
        private void autoAdd_Click(object sender, RoutedEventArgs e)
        { 
            Random randNum = new Random();
            for(int i = 0; i < numbersArray.Length; i++)
            {
                
                int randomNum = randNum.Next(0, 100);
                if (numbersArray.Contains(randomNum))
                {
                    randomNum = randNum.Next(0, 100);
                }
                numbersArray[i] = randomNum;
            }

            string a = Convert.ToString(numbersArray[0]);
            string b = Convert.ToString(numbersArray[1]);
            string c = Convert.ToString(numbersArray[2]);
            string d = Convert.ToString(numbersArray[3]);
            string l = Convert.ToString(numbersArray[4]);
            string f = Convert.ToString(numbersArray[5]);
            string g = Convert.ToString(numbersArray[6]);
            string h = Convert.ToString(numbersArray[7]);
            string k = Convert.ToString(numbersArray[8]);
            string j = Convert.ToString(numbersArray[9]);
            sortOutput.Text = a + " " + b + " " + c + " " + d + " " + l + " " + f + " " + g + " " + h + " " + k + " " + j;
            
        }

        private void numbersToSort_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void sortOutput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
