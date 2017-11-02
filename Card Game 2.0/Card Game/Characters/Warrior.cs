using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    class Warrior : PlayerCharacter
    {
        public Warrior(string vCharacterName, int vBaseDamage, int vCurrentHealthPoints, int vMaxHealthPoints): base(vCharacterName, vBaseDamage, vCurrentHealthPoints, vMaxHealthPoints)
        {

        }
    }
}
