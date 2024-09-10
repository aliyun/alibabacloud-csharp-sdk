// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class UpdateHotelAlarmRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Alarms")]
        [Validation(Required=false)]
        public List<UpdateHotelAlarmRequestAlarms> Alarms { get; set; }
        public class UpdateHotelAlarmRequestAlarms : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("AlarmId")]
            [Validation(Required=false)]
            public long? AlarmId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("DeviceOpenId")]
            [Validation(Required=false)]
            public string DeviceOpenId { get; set; }

            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("UserOpenId")]
            [Validation(Required=false)]
            public string UserOpenId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("ScheduleInfo")]
        [Validation(Required=false)]
        public UpdateHotelAlarmRequestScheduleInfo ScheduleInfo { get; set; }
        public class UpdateHotelAlarmRequestScheduleInfo : TeaModel {
            [NameInMap("Once")]
            [Validation(Required=false)]
            public UpdateHotelAlarmRequestScheduleInfoOnce Once { get; set; }
            public class UpdateHotelAlarmRequestScheduleInfoOnce : TeaModel {
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
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Weekly")]
            [Validation(Required=false)]
            public UpdateHotelAlarmRequestScheduleInfoWeekly Weekly { get; set; }
            public class UpdateHotelAlarmRequestScheduleInfoWeekly : TeaModel {
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
