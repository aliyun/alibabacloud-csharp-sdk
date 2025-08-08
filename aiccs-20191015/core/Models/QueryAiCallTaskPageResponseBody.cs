// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiCallTaskPageResponseBody : TeaModel {
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
        public QueryAiCallTaskPageResponseBodyData Data { get; set; }
        public class QueryAiCallTaskPageResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryAiCallTaskPageResponseBodyDataList> List { get; set; }
            public class QueryAiCallTaskPageResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>11213132123123*****</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>72</para>
                /// </summary>
                [NameInMap("CallingCount")]
                [Validation(Required=false)]
                public long? CallingCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>70%</para>
                /// </summary>
                [NameInMap("CompleteRate")]
                [Validation(Required=false)]
                public string CompleteRate { get; set; }

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
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("DayCallCount")]
                [Validation(Required=false)]
                public long? DayCallCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>74.14%</para>
                /// </summary>
                [NameInMap("DayConnectRate")]
                [Validation(Required=false)]
                public string DayConnectRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>400</para>
                /// </summary>
                [NameInMap("DayImportCount")]
                [Validation(Required=false)]
                public long? DayImportCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>61</para>
                /// </summary>
                [NameInMap("FailedCount")]
                [Validation(Required=false)]
                public long? FailedCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>95.89%</para>
                /// </summary>
                [NameInMap("HistoryConnectRate")]
                [Validation(Required=false)]
                public string HistoryConnectRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1748932499000</para>
                /// </summary>
                [NameInMap("RealStartTime")]
                [Validation(Required=false)]
                public long? RealStartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("StartFailedReason")]
                [Validation(Required=false)]
                public string StartFailedReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1748932499000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>36</para>
                /// </summary>
                [NameInMap("SucceedCount")]
                [Validation(Required=false)]
                public long? SucceedCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11121221121*****</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>58</para>
                /// </summary>
                [NameInMap("TotalCallCount")]
                [Validation(Required=false)]
                public long? TotalCallCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>71</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>37</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>74</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>72</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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
        /// <para>B99C5955-5664-573D-97BE-A7CC1AFD8401</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
