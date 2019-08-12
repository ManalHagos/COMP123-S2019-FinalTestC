using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 student name
 student id
 description : this is the identity class
 */

namespace COMP123_S2019_FinalTestC.Objects
{
    public class CharacterPortfolio
    {//identity
        public Identity Identity { get; set; }
        
        //characterstic
        public string Strength { get; set; }
        public string Dextertiy { get; set; }
        public string Endurance { get; set; }
        public string Intellect {get; set;}
        public string Eduaction { get; set; }
        public string SocialStanding { get; set; }
        //skill list
        List<Skill> Skills;
        //COSTRUCTOR
        CharacterPortfolio()
        {
            this.Skills = new List<Skill>();
            this.Identity = new Identity();
        }

    }
}
