using System.Windows.Forms;
using Task_5_2;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            
            int[] numbers = { 24, 64, 57, 89, 40, 95 };

       
            Sorter sorter = new Sorter(numbers);

       
            sorter.SortDescending();

            listBox1.Items.Clear(); 
            foreach (int num in sorter.GetSortedArray())
            {
                listBox1.Items.Add(num); 
            }
        }
    }
}
