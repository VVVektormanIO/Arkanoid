using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LAST_TRY_lb4
{
    public partial class Form1 : Form
    {
        private IBinaryFunction binaryFunction;
        private BinaryFunctionContainer functionContainer;

        public Form1()
        {
            InitializeComponent();

            button1.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;
            button4.Click += Button_Click;
            button5.Click += Button_Click;
            button6.Click += Button_Click;
            button7.Click += CalculateAllFunctions_Click;

            functionContainer = new BinaryFunctionContainer();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            bool x, y;

            if (!bool.TryParse(textBox1.Text, out x) || !bool.TryParse(textBox2.Text, out y))
            {
                MessageBox.Show("Введіть коректні значення для X та Y.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sender == button1)
                binaryFunction = new Conjunction(x, y);
            else if (sender == button2)
                binaryFunction = new Equivalence(x, y);
            else if (sender == button3)
                binaryFunction = new ExclusiveOr(x, y);
            else if (sender == button4)
                binaryFunction = new ShefferStroke(x, y);
            else if (sender == button5)
                binaryFunction = new Implication(x, y);
            else if (sender == button6)
                binaryFunction = new Disjunktion(x, y);

            bool result = binaryFunction.compute();
            textBox3.Text = result.ToString();
        }

        private void CalculateAllFunctions_Click(object sender, EventArgs e)
        {
            bool x, y;

            if (!bool.TryParse(textBox1.Text, out x) || !bool.TryParse(textBox2.Text, out y))
            {
                MessageBox.Show("Введіть коректні значення для X та Y.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            functionContainer.ClearFunctions();

            // Додавання функцій до контейнера
            functionContainer.AddFunction(new Conjunction(x, y));
            functionContainer.AddFunction(new Equivalence(x, y));
            functionContainer.AddFunction(new ExclusiveOr(x, y));
            functionContainer.AddFunction(new ShefferStroke(x, y));
            functionContainer.AddFunction(new Implication(x, y));
            functionContainer.AddFunction(new Disjunktion(x, y));

            List<string> results = functionContainer.CalculateAll(x, y);
            textBox4.Lines = results.ToArray();
        }
    }
}
