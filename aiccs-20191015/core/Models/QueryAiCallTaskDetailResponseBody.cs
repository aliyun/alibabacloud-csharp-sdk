// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiCallTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denial details. This field is returned only when RAM authentication fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAiCallTaskDetailResponseBodyData Data { get; set; }
        public class QueryAiCallTaskDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the published agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1180**************</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The agent name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestAgent</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SampleValue</para>
            /// </summary>
            [NameInMap("ApplicationCode")]
            [Validation(Required=false)]
            public string ApplicationCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SampleValue</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The list of callable days.</para>
            /// </summary>
            [NameInMap("CallDays")]
            [Validation(Required=false)]
            public List<string> CallDays { get; set; }

            /// <summary>
            /// <para>The expiration date of outbound call details (specific deadline).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-30 20:00:20</para>
            /// </summary>
            [NameInMap("CallExpireDate")]
            [Validation(Required=false)]
            public string CallExpireDate { get; set; }

            /// <summary>
            /// <para>The expiration duration of outbound call details, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("CallExpireMinutes")]
            [Validation(Required=false)]
            public long? CallExpireMinutes { get; set; }

            /// <summary>
            /// <para>The outbound call validity type. Valid values:</para>
            /// <para>0: Permanently valid.
            /// 1: Valid for a period of time after import.
            /// 2: Valid until a specified time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CallExpireType")]
            [Validation(Required=false)]
            public long? CallExpireType { get; set; }

            /// <summary>
            /// <para>The allowed call time periods.</para>
            /// </summary>
            [NameInMap("CallTimes")]
            [Validation(Required=false)]
            public List<QueryAiCallTaskDetailResponseBodyDataCallTimes> CallTimes { get; set; }
            public class QueryAiCallTaskDetailResponseBodyDataCallTimes : TeaModel {
                /// <summary>
                /// <para>The end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>09:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The callable time periods for the current outbound call instance.</para>
            /// </summary>
            [NameInMap("CallableTimes")]
            [Validation(Required=false)]
            public List<QueryAiCallTaskDetailResponseBodyDataCallableTimes> CallableTimes { get; set; }
            public class QueryAiCallTaskDetailResponseBodyDataCallableTimes : TeaModel {
                /// <summary>
                /// <para>The end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The caller number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>05370124****</para>
            /// </summary>
            [NameInMap("CallerNumber")]
            [Validation(Required=false)]
            public string CallerNumber { get; set; }

            /// <summary>
            /// <para>The task concurrency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ConcurrentCount")]
            [Validation(Required=false)]
            public long? ConcurrentCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SampleValue</para>
            /// </summary>
            [NameInMap("LineEncoding")]
            [Validation(Required=false)]
            public string LineEncoding { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SampleValue</para>
            /// </summary>
            [NameInMap("LinePhoneNum")]
            [Validation(Required=false)]
            public string LinePhoneNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("PhoneType")]
            [Validation(Required=false)]
            public long? PhoneType { get; set; }

            /// <summary>
            /// <para>The actual start time of the task. This value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1748932499000</para>
            /// </summary>
            [NameInMap("RealStartTime")]
            [Validation(Required=false)]
            public long? RealStartTime { get; set; }

            /// <summary>
            /// <para>The number of retry attempts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public long? RetryCount { get; set; }

            /// <summary>
            /// <para>Indicates whether call retry is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RetryEnable")]
            [Validation(Required=false)]
            public bool? RetryEnable { get; set; }

            /// <summary>
            /// <para>The retry interval. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RetryInterval")]
            [Validation(Required=false)]
            public long? RetryInterval { get; set; }

            /// <summary>
            /// <para>The list of reasons that allow retry on failure.</para>
            /// </summary>
            [NameInMap("RetryReasons")]
            [Validation(Required=false)]
            public List<string> RetryReasons { get; set; }

            /// <summary>
            /// <para>The scheduled start time of the task. This value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1748932499000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The start type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>IMMEDIATE: Start immediately.</para>
            /// </description></item>
            /// <item><description><para>SCHEDULE: Start at a scheduled time.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IMMEDIATE</para>
            /// </summary>
            [NameInMap("StartType")]
            [Validation(Required=false)]
            public string StartType { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1187**************</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestTask</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

        /// <summary>
        /// <para>The error message. This parameter is not returned for successful calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid parameter</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23822ECB-8CAA-5C52-9C9E-807FD82A5A7F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
