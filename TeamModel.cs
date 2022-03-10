using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
   public class TeamModel
    {
        public List<PersonModel> TeamMember { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; }
       
    }
}
