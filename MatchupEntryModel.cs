using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    public class MatchupEntryModel
    {    /// <summary>
        /// represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// represents the score for this particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// represent the matchup that this came from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
        

    }
}
