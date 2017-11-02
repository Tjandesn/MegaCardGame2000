using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    public class Character
    {
        int baseDamage = 10;
        int currentHealthPoints = 50;
        int maxHealthPoints = 50;

        public Character(int vBaseDamage, int vCurrentHealthPoints, int vMaxHealthPoints)
        {
            baseDamage = vBaseDamage;
            currentHealthPoints = vCurrentHealthPoints;
            maxHealthPoints = vMaxHealthPoints;
        }
    }
}
