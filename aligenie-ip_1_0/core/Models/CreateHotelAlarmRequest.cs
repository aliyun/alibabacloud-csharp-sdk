// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class CreateHotelAlarmRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cf2446fc9d144c85aaee4f9ae20a96e7</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DOU_YIN</para>
        /// </summary>
        [NameInMap("MusicType")]
        [Validation(Required=false)]
        public string MusicType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rooms")]
        [Validation(Required=false)]
        public List<string> Rooms { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ScheduleInfo")]
        [Validation(Required=false)]
        public CreateHotelAlarmRequestScheduleInfo ScheduleInfo { get; set; }
        public class CreateHotelAlarmRequestScheduleInfo : TeaModel {
            [NameInMap("Once")]
            [Validation(Required=false)]
            public CreateHotelAlarmRequestScheduleInfoOnce Once { get; set; }
            public class CreateHotelAlarmRequestScheduleInfoOnce : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Day")]
                [Validation(Required=false)]
                public int? Day { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>19</para>
                /// </summary>
                [NameInMap("Hour")]
                [Validation(Required=false)]
                public int? Hour { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Minute")]
                [Validation(Required=false)]
                public int? Minute { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("Month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022</para>
                /// </summary>
                [NameInMap("Year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// <para>ONCE, WEEKLY</para>
            /// <para>This parameter is required.</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Hour")]
                [Validation(Required=false)]
                public int? Hour { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Minute")]
                [Validation(Required=false)]
                public int? Minute { get; set; }

            }

        }

    }

}
