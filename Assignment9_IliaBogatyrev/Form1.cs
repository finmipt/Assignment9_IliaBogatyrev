namespace Assignment9_IliaBogatyrev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text;

            // Use a dictionary to count the frequency of each character in the string
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (c == ' ' || c == '\t')
                {
                    
                }
                else if (charFrequency.ContainsKey(c))
                {
                    charFrequency[c]++;
                }
                else
                {
                    charFrequency[c] = 1;
                }
            }

            // Find the character with the highest frequency
            char mostFrequentChar = '\0';
            int highestFrequency = 0;

            foreach (char c in charFrequency.Keys)
            {
                if (charFrequency[c] > highestFrequency)
                {
                    mostFrequentChar = c;
                    highestFrequency = charFrequency[c];
                }
            }

            // Display the result in the label
            label1.Text = "The most frequent character is '" + mostFrequentChar + "', which appears " + highestFrequency + " times.";
        }
    }
}