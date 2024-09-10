// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class CreateHotelAlarmRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("MusicType")]
        [Validation(Required=false)]
        public string MusicType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Rooms")]
        [Validation(Required=false)]
        public List<string> Rooms { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScheduleInfo")]
        [Validation(Required=false)]
        public CreateHotelAlarmRequestScheduleInfo ScheduleInfo { get; set; }
        public class CreateHotelAlarmRequestScheduleInfo : TeaModel {
            [NameInMap("Once")]
            [Validation(Required=false)]
            public CreateHotelAlarmRequestScheduleInfoOnce Once { get; set; }
            public class CreateHotelAlarmRequestScheduleInfoOnce : TeaModel {
                [NameInMap("Day")]
                [Validation(Required=false)]
                public int? Day { get; set; }

                [NameInMap("Hour")]
                [Validation(Required=false)]
                public int? Hour { get; set; }

                [NameInMap("Minute")]
                [Validation(Required=false)]
                public int? Minute { get; set; }

                [NameInMap("Month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                [NameInMap("Year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// ONCE, WEEKLY
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Weekly")]
            [Validation(Required=false)]
            public CreateHotelAlarmRequestScheduleInfoWeekly Weekly { get; set; }
            public class CreateHotelAlarmRequestScheduleInfoWeekly : TeaModel {
                [NameInMap("DaysOfWeek")]
                [Validation(Required=false)]
                public List<int?> DaysOfWeek { get; set; }

                [NameInMap("Hour")]
                [Validation(Required=false)]
                public int? Hour { get; set; }

                [NameInMap("Minute")]
                [Validation(Required=false)]
                public int? Minute { get; set; }

            }

        }

    }

}
