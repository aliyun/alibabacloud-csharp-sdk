// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelAlarmResponseBody : TeaModel {
        [NameInMap("Extentions")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extentions { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43***881</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListHotelAlarmResponseBodyResult> Result { get; set; }
        public class ListHotelAlarmResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5039</para>
            /// </summary>
            [NameInMap("AlarmId")]
            [Validation(Required=false)]
            public long? AlarmId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PvkB****VVTA==</para>
            /// </summary>
            [NameInMap("DeviceOpenId")]
            [Validation(Required=false)]
            public string DeviceOpenId { get; set; }

            [NameInMap("ScheduleInfo")]
            [Validation(Required=false)]
            public ListHotelAlarmResponseBodyResultScheduleInfo ScheduleInfo { get; set; }
            public class ListHotelAlarmResponseBodyResultScheduleInfo : TeaModel {
                [NameInMap("Once")]
                [Validation(Required=false)]
                public ListHotelAlarmResponseBodyResultScheduleInfoOnce Once { get; set; }
                public class ListHotelAlarmResponseBodyResultScheduleInfoOnce : TeaModel {
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
                /// 
                /// <b>Example:</b>
                /// <para>ONCE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Weekly")]
                [Validation(Required=false)]
                public ListHotelAlarmResponseBodyResultScheduleInfoWeekly Weekly { get; set; }
                public class ListHotelAlarmResponseBodyResultScheduleInfoWeekly : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>mgw/k***HQd</para>
            /// </summary>
            [NameInMap("UserOpenId")]
            [Validation(Required=false)]
            public string UserOpenId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
