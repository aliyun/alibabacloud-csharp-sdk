// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetContextDatabaseSyncJobScheduleResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetContextDatabaseSyncJobScheduleResponseBodyData Data { get; set; }
        public class GetContextDatabaseSyncJobScheduleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reason for the automatic pause.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Three consecutive execution failures</para>
            /// </summary>
            [NameInMap("AutoPauseReason")]
            [Validation(Required=false)]
            public string AutoPauseReason { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is automatically paused.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoPaused")]
            [Validation(Required=false)]
            public bool? AutoPaused { get; set; }

            /// <summary>
            /// <para>The list of daily trigger times for daily-times scheduling in the HH:mm 24-hour format. The number of times ranges from 1 to 6.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;09:00&quot;, &quot;18:00&quot;]</para>
            /// </summary>
            [NameInMap("DailyTimes")]
            [Validation(Required=false)]
            public List<string> DailyTimes { get; set; }

            /// <summary>
            /// <para>The interval in minutes for interval scheduling. The minimum value is 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("IntervalMinutes")]
            [Validation(Required=false)]
            public int? IntervalMinutes { get; set; }

            /// <summary>
            /// <para>The processing policy for missed schedules. Valid values: skip and catch-up.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skip</para>
            /// </summary>
            [NameInMap("MissedPolicy")]
            [Validation(Required=false)]
            public string MissedPolicy { get; set; }

            /// <summary>
            /// <para>The next run time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("NextRunAt")]
            [Validation(Required=false)]
            public string NextRunAt { get; set; }

            /// <summary>
            /// <para>The time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("Timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <para>The scheduling type. Valid values: interval and daily-times.</para>
            /// 
            /// <b>Example:</b>
            /// <para>daily-times</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id-001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
