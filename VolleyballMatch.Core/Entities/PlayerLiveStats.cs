using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolleyballMatch.Core.Entities
{
    public class PlayerLiveStats
    {
        public string PlayerName { get; set; }
        public int AttackPointAmount { get; set; }
        public int BlockPointAmount { get; set; }
        public int PointAmount { get; set; }
        public int AceAmount { get; set; }
        public int ReceptionfaultAmount { get; set; }
        public int FaultAmount { get; set; }
        public int SetFaultAmount { get; set; }
        public int BlockOutAmount { get; set; }
    }
}
