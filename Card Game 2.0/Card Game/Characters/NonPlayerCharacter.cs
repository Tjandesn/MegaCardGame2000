using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    public class NonPlayerCharacter : Character
    {
        string enemyType { get; set; }

        public NonPlayerCharacter(string vEnemyType, int vBaseDamage, int vCurrentHealthPoints, int vMaxHealthPoints): base(vBaseDamage, vCurrentHealthPoints, vMaxHealthPoints)
        {
            enemyType = vEnemyType;
        }

        public int getNormalAttackDamage()
        {

            return 10;
        }

        public int damageGiven(damageAmount)
        {
            //The design shows that this function is to take the damage amount,
            //subtract it from the enemies HP and return the remaining HP for 
            //the enemy character.
            return;
        }
    }
}
