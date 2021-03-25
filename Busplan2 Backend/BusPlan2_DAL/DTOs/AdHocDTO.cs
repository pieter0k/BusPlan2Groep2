﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusPlan2_DAL.DTOs
{
    public class AdHocDTO
    {
        public int AdHocID { get; set; }
        public int BusID { get; set; }
        public int Type { get; set; }
        public int Team { get; set; }
        public string Description { get; set; }
        public DateTime TimeDone { get; set; }

        public AdHocDTO() { }

        public AdHocDTO(int adHocID, int busID, int type, int team, string description, DateTime timeDone)
        {
            AdHocID = adHocID;
            BusID = busID;
            Type = type;
            Team = team;
            Description = description;
            TimeDone = timeDone;
        }
    }
}
