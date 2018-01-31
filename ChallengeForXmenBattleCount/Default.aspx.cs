using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "John", "suzy", "Ethan" };
            int[] battles = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";

            int highestNumberOfBattles = battles.Max();
            int lowestNumberOfBattles = battles.Min();

            for (int i = 0; i < battles.Length; i++)
            {
                if (battles[i] == highestNumberOfBattles)
                {
                    result += string.Format("Most battles belong to: {0} (Value: {1})<br />", names[i], battles[i]);
                }
                if (battles[i] == lowestNumberOfBattles)
                {
                    result += string.Format("Least battles belong to: {0} (Value: {1})<br />", names[i], battles[i]); 
                }
            }

            resultLabel.Text = result;



        }
    }
}