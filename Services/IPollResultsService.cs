using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollBall.Services
{
    public interface IPollResultsService
    {
        public void AddVote(SelectedGame game);
        public SortedDictionary<SelectedGame, int> GetVoteResult();
    }
}
