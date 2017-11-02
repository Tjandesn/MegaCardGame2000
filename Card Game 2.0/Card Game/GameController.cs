using System;
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


namespace Card_Game
{
    public class GameController
    {
        NonPlayerCharacter enemy { get; set; }
        PlayerCharacter player { get; set; }

        public GameController(NonPlayerCharacter vEnemy, PlayerCharacter vPlayer)
        {
            enemy = vEnemy;
            player = vPlayer;
        }

        public void ChooseClass(/*Design shows string parameter of 'ChoosingClass' here. Cannot find this parameter in design anywhere else.*/)
        {
            PlayerCharacter player = new PlayerCharacter("vCharacterName", 10, 50, 50);
        }

        public void startBattle()
        {
            //Have no idea what this function is supposed to do. No Parameters, No return values. No notes in design.
        }

        public void initiateGame()
        {
            //This is supposed to access a database (inaccessible) and return the NPC character. However the function in the design has no return value.

            NonPlayerCharacter enemy = new NonPlayerCharacter("Harpie", 10, 50, 50);
        }

        public void attack()
        {
            player.NormalAttack();
            enemy.damageGiven(damageAmount);
        }

        public void specialAttack()
        {
            player.getSpecialAttackDmg(damageAmount);

            if (damageAmount < 0)
            {
                player.damageGiven(damageAmount);
            }
            else
            {
                enemy.damageGiven(damageAmount);
            }
        }

        public string getWinner()
        {
            //Not exactly sure how you were wanting to call this function
            //or how you were wanting to return the string..
        }

        public void displayWinner(winnerName)
        {
            //Again, not exactly sure how you were looking to get winnerName
            //or how you were wanting to display it.
        }
    }
}
