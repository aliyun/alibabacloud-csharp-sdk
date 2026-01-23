// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetQualityWatchTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("WatchTaskInfo")]
        [Validation(Required=false)]
        public GetQualityWatchTaskResponseBodyWatchTaskInfo WatchTaskInfo { get; set; }
        public class GetQualityWatchTaskResponseBodyWatchTaskInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-30</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yyyy-MM-dd</para>
            /// </summary>
            [NameInMap("BizDateFormat")]
            [Validation(Required=false)]
            public string BizDateFormat { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-30 20:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("QualityOwner")]
            [Validation(Required=false)]
            public string QualityOwner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("QualityOwnerName")]
            [Validation(Required=false)]
            public string QualityOwnerName { get; set; }

            [NameInMap("RuleCountInfo")]
            [Validation(Required=false)]
            public GetQualityWatchTaskResponseBodyWatchTaskInfoRuleCountInfo RuleCountInfo { get; set; }
            public class GetQualityWatchTaskResponseBodyWatchTaskInfoRuleCountInfo : TeaModel {
                [NameInMap("StrongRuleCount")]
                [Validation(Required=false)]
                public GetQualityWatchTaskResponseBodyWatchTaskInfoRuleCountInfoStrongRuleCount StrongRuleCount { get; set; }
                public class GetQualityWatchTaskResponseBodyWatchTaskInfoRuleCountInfoStrongRuleCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ErrorRuleCount")]
                    [Validation(Required=false)]
                    public long? ErrorRuleCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("FinishedRuleCount")]
                    [Validation(Required=false)]
                    public long? FinishedRuleCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SuccessRuleCount")]
                    [Validation(Required=false)]
                    public long? SuccessRuleCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TotalRuleCount")]
                    [Validation(Required=false)]
                    public long? TotalRuleCount { get; set; }

                }

                [NameInMap("ValidateRuleCount")]
                [Validation(Required=false)]
                public GetQualityWatchTaskResponseBodyWatchTaskInfoRuleCountInfoValidateRuleCount ValidateRuleCount { get; set; }
                public class GetQualityWatchTaskResponseBodyWatchTaskInfoRuleCountInfoValidateRuleCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ErrorRuleCount")]
                    [Validation(Required=false)]
                    public long? ErrorRuleCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("FinishedRuleCount")]
                    [Validation(Required=false)]
                    public long? FinishedRuleCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SuccessRuleCount")]
                    [Validation(Required=false)]
                    public long? SuccessRuleCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TotalRuleCount")]
                    [Validation(Required=false)]
                    public long? TotalRuleCount { get; set; }

                }

                [NameInMap("WeakRuleCount")]
                [Validation(Required=false)]
                public GetQualityWatchTaskResponseBodyWatchTaskInfoRuleCountInfoWeakRuleCount WeakRuleCount { get; set; }
                public class GetQualityWatchTaskResponseBodyWatchTaskInfoRuleCountInfoWeakRuleCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ErrorRuleCount")]
                    [Validation(Required=false)]
                    public long? ErrorRuleCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("FinishedRuleCount")]
                    [Validation(Required=false)]
                    public long? FinishedRuleCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SuccessRuleCount")]
                    [Validation(Required=false)]
                    public long? SuccessRuleCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TotalRuleCount")]
                    [Validation(Required=false)]
                    public long? TotalRuleCount { get; set; }

                }

            }

            [NameInMap("RuleIdList")]
            [Validation(Required=false)]
            public List<long?> RuleIdList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-30 08:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WatchId")]
            [Validation(Required=false)]
            public long? WatchId { get; set; }

        }

    }

}
