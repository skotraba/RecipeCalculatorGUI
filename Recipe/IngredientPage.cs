using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Recipe
{
    public partial class IngredientPage : Form
    {
        public IngredientPage()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addIngredient(object sender, EventArgs e)
        {
           
            string tempName = textBox1.Text;
            float tempWeight = float.Parse(textBox2.Text);
            float tempCalories = float.Parse(textBox3.Text);

            //Ingredient temp = new Ingredient(tempName, tempWeight, tempCalories);
            //List<Ingredient> list = new List<Ingredient>();

            Program.tempRec.addToRecipe(new Ingredient(tempName, tempWeight, tempCalories));

            for (int i = 0; i < Program.tempRec.GetIngredients().Count(); i++)
            {
                string newLine = Environment.NewLine;
                textBox4.Text += Program.tempRec.GetIngredients()[i].getName() + "  " + newLine
                    + Program.tempRec.GetIngredients()[i].getWeight() + "  Grams" + newLine
                    + Program.tempRec.GetIngredients()[i].getCalorie() + "  Calories" + newLine + newLine;
                    
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


        }

        private void calculateCalories(object sender, EventArgs e)
        {
            float total = 0;
            for (int i = 0; i < Program.tempRec.GetIngredients().Count(); i ++)
            {
                total += Program.tempRec.GetIngredients()[i].getCalorie();
                textBox4.Text = total.ToString() + " Total Calories";

            }
        }

        private void goToRecipePage(object sender, EventArgs e)
        {

            RecipePage c = new RecipePage();
                this.Hide();
                c.ShowDialog();
                this.Close();
            
        }

        private void clearIngredients(object sender, EventArgs e)
        {
            
            Program.tempRec.GetIngredients().Clear();
            textBox4.Text = "";
        }

        private void addRecipe(object sender, EventArgs e)
        {
            Program.RecipeList.Add(Program.tempRec);
            Program.tempRec.clearRecipe();
        }

        private void cleartxt_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void CalculateServing_Click(object sender, EventArgs e)
        {
            
            
            float totalC = 0;
            for (int i = 0; i < Program.tempRec.GetIngredients().Count(); i++)
            {
                totalC += Program.tempRec.GetIngredients()[i].getCalorie();

                float total = totalC / float.Parse(test.Text);
                textBox4.Text = total + " Calories per " +  " serving";
            }
            

        }

        private void view_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.tempRec.GetIngredients().Count(); i++)
            {
                string newLine = Environment.NewLine;
                textBox4.Text += Program.tempRec.GetIngredients()[i].getName() + "  " + newLine
                    + Program.tempRec.GetIngredients()[i].getWeight() + "  Grams" + newLine
                    + Program.tempRec.GetIngredients()[i].getCalorie() + "  Calories" + newLine + newLine;

            }
        }
    }
}
