using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolleyballMatch.Core.Entities
{
    public class Set
    {
        public int Id { get; set; }
        public int BredenePoints { get; set; }
        public int OtherTeamPoints { get; set; }

        public ICollection<PointInSetEvent> Events { get; set; }
    }
}
