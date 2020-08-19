using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Types
{
    public class Draw
    {
        public string ProductID { get; set; }
        public int DrawNumber { get; set; }
        public string DrawDisplayName { get; set; }
        public string DrawDate { get; set; }
        public string DrawLogoUrl { get; set; }
        public DrawType DrawType { get; set; }
        public double Div1Amount { get; set; }
        public bool IsDiv1Estimated { get; set; }
        public bool IsDiv1Unknown { get; set; }
        public string DrawCloseDateTimeUTC { get; set; }
        public string DrawEndSellDateTimeUTC { get; set; }
        public double DrawCountDownTimerSeconds { get; set; }
    }
}