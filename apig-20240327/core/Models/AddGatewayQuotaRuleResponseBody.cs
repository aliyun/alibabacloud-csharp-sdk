// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AddGatewayQuotaRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code or error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200, 404, 500</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;key\&quot;: \&quot;value\&quot;}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public AddGatewayQuotaRuleResponseBodyData Data { get; set; }
        public class AddGatewayQuotaRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the semantics of the write request can be accepted by the system. A value of false typically occurs in retryable scenarios, such as when conflicts are not confirmed for overwriting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("accepted")]
            [Validation(Required=false)]
            public bool? Accepted { get; set; }

            /// <summary>
            /// <para>The conflict preview.</para>
            /// </summary>
            [NameInMap("conflictPreview")]
            [Validation(Required=false)]
            public AddGatewayQuotaRuleResponseBodyDataConflictPreview ConflictPreview { get; set; }
            public class AddGatewayQuotaRuleResponseBodyDataConflictPreview : TeaModel {
                /// <summary>
                /// <para>The hash of the conflicts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f8f44dc6cf369a017d56b7197eb4fb5ac4bbb6b09a92b9b41999541fxxxxxxxx</para>
                /// </summary>
                [NameInMap("conflictHash")]
                [Validation(Required=false)]
                public string ConflictHash { get; set; }

                /// <summary>
                /// <para>The list of conflicting subjects (consumers or consumer groups).</para>
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<AddGatewayQuotaRuleResponseBodyDataConflictPreviewItems> Items { get; set; }
                public class AddGatewayQuotaRuleResponseBodyDataConflictPreviewItems : TeaModel {
                    /// <term><b>Obsolete</b></term>
                    /// 
                    /// <summary>
                    /// <para>The period type of the existing conflicting rule on the subject. This is a legacy field. Use periodType in the actual response instead. This field is not guaranteed to be returned. A value of day, week, or month indicates that the period of the existing conflicting rule is day, week, or month.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>week</para>
                    /// </summary>
                    [NameInMap("conflictPeriodType")]
                    [Validation(Required=false)]
                    [Obsolete]
                    public string ConflictPeriodType { get; set; }

                    /// <summary>
                    /// <para>The type of the existing conflicting rule on the subject. A value of calendar indicates that the existing conflicting rule uses a natural period. A value of epoch indicates that the existing conflicting rule uses a custom period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>calendar</para>
                    /// </summary>
                    [NameInMap("conflictType")]
                    [Validation(Required=false)]
                    public string ConflictType { get; set; }

                    /// <summary>
                    /// <para>The ID of the conflicting consumer. You can use subjectId instead.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cs-xxxxxx</para>
                    /// </summary>
                    [NameInMap("consumerId")]
                    [Validation(Required=false)]
                    public string ConsumerId { get; set; }

                    /// <summary>
                    /// <para>The name of the conflicting consumer. You can use subjectName instead.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>consumer-a</para>
                    /// </summary>
                    [NameInMap("consumerName")]
                    [Validation(Required=false)]
                    public string ConsumerName { get; set; }

                    /// <summary>
                    /// <para>The period type of the existing conflicting rule. Valid values: day, week, and month.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>day</para>
                    /// </summary>
                    [NameInMap("periodType")]
                    [Validation(Required=false)]
                    public string PeriodType { get; set; }

                    /// <summary>
                    /// <para>The ID of the conflicting subject.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cs-xxx</para>
                    /// </summary>
                    [NameInMap("subjectId")]
                    [Validation(Required=false)]
                    public string SubjectId { get; set; }

                    /// <summary>
                    /// <para>The name of the conflicting subject.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>consumer-a</para>
                    /// </summary>
                    [NameInMap("subjectName")]
                    [Validation(Required=false)]
                    public string SubjectName { get; set; }

                    /// <summary>
                    /// <para>The type of the conflicting subject. Valid values: consumer and consumer_group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>consumer</para>
                    /// </summary>
                    [NameInMap("subjectType")]
                    [Validation(Required=false)]
                    public string SubjectType { get; set; }

                }

                /// <summary>
                /// <para>The total number of conflicts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("totalConflictCount")]
                [Validation(Required=false)]
                public int? TotalConflictCount { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether a dry run is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("dryRun")]
            [Validation(Required=false)]
            public bool? DryRun { get; set; }

            /// <summary>
            /// <para>The ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qr-xxxxx</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

        /// <summary>
        /// <para>The message content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
