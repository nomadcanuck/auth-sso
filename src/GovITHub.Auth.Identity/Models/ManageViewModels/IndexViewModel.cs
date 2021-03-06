﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace GovITHub.Auth.Identity.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }

        public IList<UserLoginInfo> Logins { get; set; }

        public IEnumerable<string> PhoneNumbers { get; set; }

        public IEnumerable<string> Emails { get; set; }
        public bool TwoFactor { get; set; }

        public bool BrowserRemembered { get; set; }
    }
}
