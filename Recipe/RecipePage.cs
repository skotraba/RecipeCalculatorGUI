using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe
{
    public partial class RecipePage : Form
    {
        public RecipePage()
        {
            InitializeComponent();
        }

        private void goToIngredientPage(object sender, EventArgs e)
        {

            Program.tempRec.setRecName(recipeN.Text);

            IngredientPage c = new IngredientPage();
            this.Hide();
            c.ShowDialog();
            this.Close();


        }

        private void showRecipes(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine;
            for (int i = 0; i < Program.RecipeList.Count(); i++)
            {
                displayR.Text = Program.RecipeList[i].getRecName() + " " + newLine;
                for (int j = 0; j < Program.RecipeList[i].GetIngredients().Count(); j++)
                {
                    
                    displayR.Text += Program.RecipeList[i].GetIngredients()[j].getName() + "  " + newLine
                        + Program.RecipeList[i].GetIngredients()[j].getWeight() + " " + newLine
                        + Program.RecipeList[i].GetIngredients()[j].getCalorie() + " " + newLine + newLine;

                }
            }
            
        }

        private void clearRecipes(object sender, EventArgs e)
        {
           
            displayR.Text = "";
        }
    }
}
