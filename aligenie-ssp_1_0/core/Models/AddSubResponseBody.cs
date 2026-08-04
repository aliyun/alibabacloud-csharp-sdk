// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class AddSubResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. A value of 200 indicates success.</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Additional information</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B99D27ED-4E12-1414-9FDE-599C57C4B204</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return Result</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddSubResponseBodyResult Result { get; set; }
        public class AddSubResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Album ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>51999575</para>
            /// </summary>
            [NameInMap("AlbumId")]
            [Validation(Required=false)]
            public string AlbumId { get; set; }

            /// <summary>
            /// <para>Daily study quantity</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DailyStudyCnt")]
            [Validation(Required=false)]
            public int? DailyStudyCnt { get; set; }

            /// <summary>
            /// <para>Device ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>5874DBCCA3038FAA1A70A8060F07F26D</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>Subscription record ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>81</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Playback mode</para>
            /// 
            /// <b>Example:</b>
            /// <para>sequence</para>
            /// </summary>
            [NameInMap("PlayMode")]
            [Validation(Required=false)]
            public string PlayMode { get; set; }

            /// <summary>
            /// <para>Schedule information</para>
            /// </summary>
            [NameInMap("ScheduleInfo")]
            [Validation(Required=false)]
            public AddSubResponseBodyResultScheduleInfo ScheduleInfo { get; set; }
            public class AddSubResponseBodyResultScheduleInfo : TeaModel {
                /// <summary>
                /// <para>The epoch for trigger</para>
                /// </summary>
                [NameInMap("DaysOfWeek")]
                [Validation(Required=false)]
                public List<int?> DaysOfWeek { get; set; }

                /// <summary>
                /// <para>The hour of the clock when the trigger occurs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Hour")]
                [Validation(Required=false)]
                public int? Hour { get; set; }

                /// <summary>
                /// <para>The minute of the Time when the trigger occurs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("Minute")]
                [Validation(Required=false)]
                public int? Minute { get; set; }

            }

            /// <summary>
            /// <para>User ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1152893538998276761</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
