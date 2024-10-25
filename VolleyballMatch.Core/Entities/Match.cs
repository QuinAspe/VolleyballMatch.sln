using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolleyballMatch.Core.Entities
{
    public class Match
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Set> Sets { get; set; }
    }
}
