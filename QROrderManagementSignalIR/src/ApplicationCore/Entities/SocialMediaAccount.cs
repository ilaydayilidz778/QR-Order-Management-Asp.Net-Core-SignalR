using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class SocialMediaAccount : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Link { get; set; } = null!;
        public string Icon { get; set; } = null!;
    }
}
