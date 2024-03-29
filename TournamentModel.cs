﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
   public class TournamentModel

    {
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; }
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> Round { get; set; } = new List<List<MatchupModel>>();

    }
}
