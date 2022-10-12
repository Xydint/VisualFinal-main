﻿using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class TrainerStatistic
    {
        public long TrainerId { get; set; }
        public string TrackName { get; set; } = null!;
        public long WinnerCount { get; set; }
        public long WinnerFavoriteCount { get; set; }
    }
}
