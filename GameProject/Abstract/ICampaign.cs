﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
   public interface ICampaign
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
