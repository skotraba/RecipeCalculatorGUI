using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Recipe
{
    static class Program
    {

        public static List<Recipe> RecipeList = new List<Recipe>();

        public static Recipe tempRec = new Recipe();

 

        // <summary>
        // The main entry point for the application.
        // </summary>
        [STAThread]
        static void Main()
        {

            


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IngredientPage());
        }
    }
}
