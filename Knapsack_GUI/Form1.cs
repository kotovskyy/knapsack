using ProblemPlecakowy;

namespace Knapsack_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int itemsNum = Int32.Parse(itemsNumTextBox.Text);
            int seed = Int32.Parse(seedTextBox.Text);
            int capacity = Int32.Parse(capacityTextBox.Text);

            Problem problem = new Problem(itemsNum, seed);
            Result result = problem.Solve(capacity);

            string problem_string = problem.ToString();
            string result_string = result.ToString();



        }
    }
}
