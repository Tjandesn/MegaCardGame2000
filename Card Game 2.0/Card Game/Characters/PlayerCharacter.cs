using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    public class PlayerCharacter : Character
    {
        string characterName { get; set; }
        
        public PlayerCharacter(string vCharacterName, int vBaseDamage, int vCurrentHealthPoints, int vMaxHealthPoints): base(vBaseDamage, vCurrentHealthPoints, vMaxHealthPoints)
        {
            characterName = vCharacterName;
        }

        public int NormalAttack()
        {

            return 10;
        }

        public int getSpecialAttackDmg()
        {

            return 10;
        }

        public int damageGiven(damageAmount)
        {
            //The design shows that this function is to take the damage amount,
            //subtract it from the enemies HP and return the remaining HP for 
            //the enemy character.
            return damageAmount;
        }
}
