// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiCallTaskPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason for access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The task details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAiCallTaskPageResponseBodyData Data { get; set; }
        public class QueryAiCallTaskPageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The task data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryAiCallTaskPageResponseBodyDataList> List { get; set; }
            public class QueryAiCallTaskPageResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The agent ID.</para>
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
                /// <para>TestAgent.</para>
                /// </summary>
                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Sample value.</para>
                /// </summary>
                [NameInMap("ApplicationCode")]
                [Validation(Required=false)]
                public string ApplicationCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Sample value.</para>
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Sample value.</para>
                /// </summary>
                [NameInMap("CallExpireDate")]
                [Validation(Required=false)]
                public string CallExpireDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>39</para>
                /// </summary>
                [NameInMap("CallExpireMinutes")]
                [Validation(Required=false)]
                public long? CallExpireMinutes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>72</para>
                /// </summary>
                [NameInMap("CallExpireType")]
                [Validation(Required=false)]
                public long? CallExpireType { get; set; }

                /// <summary>
                /// <para>The number of ongoing calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72</para>
                /// </summary>
                [NameInMap("CallingCount")]
                [Validation(Required=false)]
                public long? CallingCount { get; set; }

                /// <summary>
                /// <para>The task completion rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70%</para>
                /// </summary>
                [NameInMap("CompleteRate")]
                [Validation(Required=false)]
                public string CompleteRate { get; set; }

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
                /// <para>The creation time. This value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1748932499000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The number of calls made on the current day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("DayCallCount")]
                [Validation(Required=false)]
                public long? DayCallCount { get; set; }

                /// <summary>
                /// <para>The daily connection rate. Daily connection rate = number of connections on the current day ÷ number of calls on the current day (DayCallCount).</para>
                /// 
                /// <b>Example:</b>
                /// <para>74.14%</para>
                /// </summary>
                [NameInMap("DayConnectRate")]
                [Validation(Required=false)]
                public string DayConnectRate { get; set; }

                /// <summary>
                /// <para>The amount of data imported on the current day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>400</para>
                /// </summary>
                [NameInMap("DayImportCount")]
                [Validation(Required=false)]
                public long? DayImportCount { get; set; }

                /// <summary>
                /// <para>The total number of failed task executions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61</para>
                /// </summary>
                [NameInMap("FailedCount")]
                [Validation(Required=false)]
                public long? FailedCount { get; set; }

                /// <summary>
                /// <para>The historical connection rate. Historical connection rate = historical number of connections ÷ total number of calls (TotalCallCount).</para>
                /// 
                /// <b>Example:</b>
                /// <para>95.89%</para>
                /// </summary>
                [NameInMap("HistoryConnectRate")]
                [Validation(Required=false)]
                public string HistoryConnectRate { get; set; }

                /// <summary>
                /// <para>The actual start time of the task. This value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1748932499000</para>
                /// </summary>
                [NameInMap("RealStartTime")]
                [Validation(Required=false)]
                public long? RealStartTime { get; set; }

                /// <summary>
                /// <para>The reason for startup failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Agent is offline.</para>
                /// </summary>
                [NameInMap("StartFailedReason")]
                [Validation(Required=false)]
                public string StartFailedReason { get; set; }

                /// <summary>
                /// <para>The scheduled start time of the task. This value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1748932499000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <para>The total number of successful task executions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>36</para>
                /// </summary>
                [NameInMap("SucceedCount")]
                [Validation(Required=false)]
                public long? SucceedCount { get; set; }

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
                /// <para>TestTask.</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <para>The total number of calls made by the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>58</para>
                /// </summary>
                [NameInMap("TotalCallCount")]
                [Validation(Required=false)]
                public long? TotalCallCount { get; set; }

                /// <summary>
                /// <para>The total number of task items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>71</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>37</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>74</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>72</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The error message. This parameter is not returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid parameter.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B99C5955-5664-573D-97BE-A7CC1AFD8401</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: successful.</description></item>
        /// <item><description><b>false</b>: failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
