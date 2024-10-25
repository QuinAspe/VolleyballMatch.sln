using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolleyballMatch.Core.Enum;

namespace VolleyballMatch.Core.Entities
{
    public class PointInSetEvent
    {
        public int Id { get; set; }
        public Player? Player { get; set; }
        public VolleyEvent VolleyEvent { get; set; }
    }
}
