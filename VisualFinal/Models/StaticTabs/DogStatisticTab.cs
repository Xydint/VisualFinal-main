﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class DogStatisticTab : StaticTab
    {
        public DogStatisticTab(DbSet<DogStatistic>? dBS = null)
        {
            Header = "DogStatistic";
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("DogId");
            DataColumns.Add("TrackName");
            DataColumns.Add("RaceCount");
            DataColumns.Add("WinCount");
            DataColumns.Add("LongestWinningStreak");
            DataColumns.Add("LongestLosingStreak");
            DataColumns.Add("CurrentWinningStreak");
            DataColumns.Add("CurrentLosingStreak");
            DataColumns.Add("LastRaceDate");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<DogStatistic>? DBS { get; set; }
    }
}
