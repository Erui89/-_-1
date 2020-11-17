using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Методы_и_средства_программирования_ЛАБА__1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(textbox1.Text);
            Random rnd1 = new Random();
            int number;
            textbox1.Text = " ";
            listbox1.Items.Clear();
            listbox1.Items.Add("Сгенерированный массив:");
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                listbox1.Items.Add(number);
            }
            
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(textbox1.Text);
            Random rnd1 = new Random();
            int number;
            textbox1.Text = " ";
            listbox1.Items.Clear();
            listbox1.Items.Add("Исходный массив");
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                listbox1.Items.Add(number);
            }
            myAL.Sort();
            textbox1.Text = " ";
            listbox2.Items.Clear();
            listbox2.Items.Add("Отсортированный массив");
            foreach (int elem in myAL)
            {
                listbox2.Items.Add(elem);
            }
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog myDialog = new Microsoft.Win32.SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in listbox1.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int N = Convert.ToInt32(textbox1.Text);
            int count = 0;
            int first = 0;
            int summa = 0;
            int u = 0;
            int K = Convert.ToInt32(textbox2.Text);
            int first_K = 0;
            int summa_K = 0;
            int[] array = new int[N];
            Random random = new Random();
            listbox1.SelectionMode = System.Windows.Controls.SelectionMode.Multiple;
            textbox1.Text = " ";
            textbox2.Text = " ";
            listbox1.SelectedIndex = -1;
            listbox1.Items.Clear();
            listbox2.Items.Clear();
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                array[indexArray] = 5 + random.Next(100);
                listbox1.Items.Add(array[indexArray]);
            }
            for (int indexArray = 1; indexArray < N-1; indexArray++)
            {
                if (array[indexArray] > array[indexArray - 1] && array[indexArray] > array[indexArray + 1])
                {
                    count++;
                }
            }
            if (count > 0)
            {
                listbox2.Items.Add("Кол-во элементов:" + count);
            }
            else
            {
                listbox2.Items.Add("Нет элементов, удовлетворяющих условию");
            }
            listbox2.Items.Add("[----------------------------------------------]");

            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                if (array[indexArray] > 25)
                {
                    first = indexArray;
                    u = 1;
                }

                if (u == 1)
                {
                    listbox2.Items.Add("Номер первого элемента, большего 25: " + first);
                    break;
                }
                
                
            }
                listbox2.Items.Add("[----------------------------------------------]");

            
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                if (array[indexArray] > array[1])
                {
                    summa = summa + array[indexArray];
                }
            }
            if (summa > 0)
            {
                listbox2.Items.Add("Сумма:" + summa);
            }
            else
            {
                listbox2.Items.Add("Нет элементов, удовлетворяющих условию");
            }
            listbox2.Items.Add("[----------------------------------------------]");
            u = 0;
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                if (array[indexArray] > K)
                {
                    first_K = indexArray;
                    u = 1;
                }

                if (u == 1)
                {
                    listbox2.Items.Add("Номер первого элемента, большего K: " + first_K);
                    break;
                }
                
            }
            listbox2.Items.Add("[----------------------------------------------]");
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                if (array[indexArray] > array[K])
                {
                    summa_K = summa_K + array[indexArray];
                }
            }
            if (summa_K > 0)
            {
                listbox2.Items.Add("Сумма:" + summa_K);
            }
            else
            {
                listbox2.Items.Add("Нет элементов, удовлетворяющих условию");
            }
            listbox2.Items.Add("[----------------------------------------------]");

        }
    }
}
