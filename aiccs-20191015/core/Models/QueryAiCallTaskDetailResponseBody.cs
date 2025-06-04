// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiCallTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Access Denied</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAiCallTaskDetailResponseBodyData Data { get; set; }
        public class QueryAiCallTaskDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            [NameInMap("CallDays")]
            [Validation(Required=false)]
            public List<string> CallDays { get; set; }

            [NameInMap("CallTimes")]
            [Validation(Required=false)]
            public List<QueryAiCallTaskDetailResponseBodyDataCallTimes> CallTimes { get; set; }
            public class QueryAiCallTaskDetailResponseBodyDataCallTimes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>09:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>05370124****</para>
            /// </summary>
            [NameInMap("CallerNumber")]
            [Validation(Required=false)]
            public string CallerNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ConcurrentCount")]
            [Validation(Required=false)]
            public long? ConcurrentCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1748932499000</para>
            /// </summary>
            [NameInMap("RealStartTime")]
            [Validation(Required=false)]
            public long? RealStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public long? RetryCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RetryEnable")]
            [Validation(Required=false)]
            public bool? RetryEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RetryInterval")]
            [Validation(Required=false)]
            public long? RetryInterval { get; set; }

            [NameInMap("RetryReasons")]
            [Validation(Required=false)]
            public List<string> RetryReasons { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1748932499000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IMMEDIATE</para>
            /// </summary>
            [NameInMap("StartType")]
            [Validation(Required=false)]
            public string StartType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11121232222****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23822ECB-8CAA-5C52-9C9E-807FD82A5A7F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
