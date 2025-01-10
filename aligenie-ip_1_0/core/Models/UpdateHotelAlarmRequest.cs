// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class UpdateHotelAlarmRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Alarms")]
        [Validation(Required=false)]
        public List<UpdateHotelAlarmRequestAlarms> Alarms { get; set; }
        public class UpdateHotelAlarmRequestAlarms : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("AlarmId")]
            [Validation(Required=false)]
            public long? AlarmId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pvk***VTA==</para>
            /// </summary>
            [NameInMap("DeviceOpenId")]
            [Validation(Required=false)]
            public string DeviceOpenId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mgw/***dHQd</para>
            /// </summary>
            [NameInMap("UserOpenId")]
            [Validation(Required=false)]
            public string UserOpenId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a7a381a668bc485980bed3876a75e013</para>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Day")]
                [Validation(Required=false)]
                public int? Day { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Hour")]
                [Validation(Required=false)]
                public int? Hour { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>ONCE</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Hour")]
                [Validation(Required=false)]
                public int? Hour { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Minute")]
                [Validation(Required=false)]
                public int? Minute { get; set; }

            }

        }

    }

}
