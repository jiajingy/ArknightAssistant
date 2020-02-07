using System;
using System.Collections.Generic;
using System.Text;

namespace Arknight.Models
{
    public class RecruitmentTags
    {
        public List<string> Tags = new List<string>();
        public RecruitmentTags()
        {
            Tags.Add("Top Operator");
            Tags.Add("Senior Operator");
            Tags.Add("Crowd-Control");
            Tags.Add("Summon");
            Tags.Add("Nuker");
            Tags.Add("Specialist");
            Tags.Add("Fast Redeploy");
            Tags.Add("Shift");
            Tags.Add("Debuff");
            Tags.Add("Support");

            Tags.Add("Defense");
            Tags.Add("Defender");
            Tags.Add("Slow");
            Tags.Add("DPS");
            Tags.Add("Vanguard");
            Tags.Add("Medic");
            Tags.Add("Ranged");
            Tags.Add("DP-Recovery");
            Tags.Add("Healing");
            Tags.Add("Supporter");
            Tags.Add("AoE");
            Tags.Add("Shift");
            Tags.Add("Melee");
            Tags.Add("Survival");
            Tags.Add("Sniper");


            Tags.Sort();

        }


    }
}
