﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models.ViewModels
{
    public class StudentMembershipViewModel
    {
        public Student Student { get; set; }
        public ICollection<CommunityMembershipViewModel> Memberships { get; set; }

    }
}
