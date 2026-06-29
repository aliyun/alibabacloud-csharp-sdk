// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetQualityWatchTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backend exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The details of the monitoring node task object.</para>
        /// </summary>
        [NameInMap("WatchTaskInfo")]
        [Validation(Required=false)]
        public GetQualityWatchTaskResponseBodyWatchTaskInfo WatchTaskInfo { get; set; }
        public class GetQualityWatchTaskResponseBodyWatchTaskInfo : TeaModel {
            /// <summary>
            /// <para>The business date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            /// <summary>
            /// <para>The business date format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yyyy-MM-dd</para>
            /// </summary>
            [NameInMap("BizDateFormat")]
            [Validation(Required=false)]
            public string BizDateFormat { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The end time. Time format: yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 20:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The quality watchtask ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The user ID of the last modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The user ID of the quality owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("QualityOwner")]
            [Validation(Required=false)]
            public string QualityOwner { get; set; }

            /// <summary>
            /// <para>The name of the quality owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("QualityOwnerName")]
            [Validation(Required=false)]
            public string QualityOwnerName { get; set; }

            /// <summary>
            /// <para>The quality rule count information.</para>
            /// </summary>
            [NameInMap("RuleCountInfo")]
            [Validation(Required=false)]
            public GetQualityWatchTaskResponseBodyWatchTaskInfoRuleCountInfo RuleCountInfo { get; set; }
            public class GetQualityWatchTaskResponseBodyWatchTaskInfoRuleCountInfo : TeaModel {
                /// <summary>
                /// <para>The strong rule count.</para>
                /// </summary>
                [NameInMap("StrongRuleCount")]
                [Validation(Required=false)]
                public GetQualityWatchTaskResponseBodyWatchTaskInfoRuleCountInfoStrongRuleCount StrongRuleCount { get; set; }
                public class GetQualityWatchTaskResponseBodyWatchTaskInfoRuleCountInfoStrongRuleCount : TeaModel {
                    /// <summary>
                    /// <para>The number of rules that failed to execute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ErrorRuleCount")]
                    [Validation(Required=false)]
                    public long? ErrorRuleCount { get; set; }

                    /// <summary>
                    /// <para>The number of rules that have been executed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("FinishedRuleCount")]
                    [Validation(Required=false)]
                    public long? FinishedRuleCount { get; set; }

                    /// <summary>
                    /// <para>The number of rules that were executed successfully.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SuccessRuleCount")]
                    [Validation(Required=false)]
                    public long? SuccessRuleCount { get; set; }

                    /// <summary>
                    /// <para>The total number of rules.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TotalRuleCount")]
                    [Validation(Required=false)]
                    public long? TotalRuleCount { get; set; }

                }

                /// <summary>
                /// <para>The validation rule count.</para>
                /// </summary>
                [NameInMap("ValidateRuleCount")]
                [Validation(Required=false)]
                public GetQualityWatchTaskResponseBodyWatchTaskInfoRuleCountInfoValidateRuleCount ValidateRuleCount { get; set; }
                public class GetQualityWatchTaskResponseBodyWatchTaskInfoRuleCountInfoValidateRuleCount : TeaModel {
                    /// <summary>
                    /// <para>The number of rules that failed to execute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ErrorRuleCount")]
                    [Validation(Required=false)]
                    public long? ErrorRuleCount { get; set; }

                    /// <summary>
                    /// <para>The number of rules that have been executed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("FinishedRuleCount")]
                    [Validation(Required=false)]
                    public long? FinishedRuleCount { get; set; }

                    /// <summary>
                    /// <para>The number of rules that were executed successfully.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SuccessRuleCount")]
                    [Validation(Required=false)]
                    public long? SuccessRuleCount { get; set; }

                    /// <summary>
                    /// <para>The total number of rules.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TotalRuleCount")]
                    [Validation(Required=false)]
                    public long? TotalRuleCount { get; set; }

                }

                /// <summary>
                /// <para>The weak rule count.</para>
                /// </summary>
                [NameInMap("WeakRuleCount")]
                [Validation(Required=false)]
                public GetQualityWatchTaskResponseBodyWatchTaskInfoRuleCountInfoWeakRuleCount WeakRuleCount { get; set; }
                public class GetQualityWatchTaskResponseBodyWatchTaskInfoRuleCountInfoWeakRuleCount : TeaModel {
                    /// <summary>
                    /// <para>The number of rules that failed to execute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ErrorRuleCount")]
                    [Validation(Required=false)]
                    public long? ErrorRuleCount { get; set; }

                    /// <summary>
                    /// <para>The number of rules that have been executed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("FinishedRuleCount")]
                    [Validation(Required=false)]
                    public long? FinishedRuleCount { get; set; }

                    /// <summary>
                    /// <para>The number of rules that were executed successfully.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SuccessRuleCount")]
                    [Validation(Required=false)]
                    public long? SuccessRuleCount { get; set; }

                    /// <summary>
                    /// <para>The total number of rules.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TotalRuleCount")]
                    [Validation(Required=false)]
                    public long? TotalRuleCount { get; set; }

                }

            }

            /// <summary>
            /// <para>The list of quality rule IDs.</para>
            /// </summary>
            [NameInMap("RuleIdList")]
            [Validation(Required=false)]
            public List<long?> RuleIdList { get; set; }

            /// <summary>
            /// <para>The start time. Time format: yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 08:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOT_RUN: not executed.</description></item>
            /// <item><description>WAITING: waiting.</description></item>
            /// <item><description>RUNNING: executing.</description></item>
            /// <item><description>SUCCESS: executed successfully.</description></item>
            /// <item><description>FAILED: execution failed.</description></item>
            /// <item><description>CANCEL: canceled.</description></item>
            /// <item><description>TIMEOUT: timed out.</description></item>
            /// <item><description>OFFLINE: offline.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The monitored object ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WatchId")]
            [Validation(Required=false)]
            public long? WatchId { get; set; }

        }

    }

}
