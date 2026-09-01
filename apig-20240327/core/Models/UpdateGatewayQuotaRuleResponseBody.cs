// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateGatewayQuotaRuleResponseBody : TeaModel {
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
        /// <para>The response data content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;key\&quot;: \&quot;value\&quot;}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateGatewayQuotaRuleResponseBodyData Data { get; set; }
        public class UpdateGatewayQuotaRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the write request is accepted by the system. A value of false typically indicates a retryable scenario such as an unconfirmed conflict overwrite.</para>
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
            public UpdateGatewayQuotaRuleResponseBodyDataConflictPreview ConflictPreview { get; set; }
            public class UpdateGatewayQuotaRuleResponseBodyDataConflictPreview : TeaModel {
                /// <summary>
                /// <para>The hash of the conflict snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f8f44dc6cf369a017d56b7197eb4fb5ac4bbb6b09a92b9b41999541f50xxxxxx</para>
                /// </summary>
                [NameInMap("conflictHash")]
                [Validation(Required=false)]
                public string ConflictHash { get; set; }

                /// <summary>
                /// <para>The list of conflicting principals (consumers or consumer groups).</para>
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<UpdateGatewayQuotaRuleResponseBodyDataConflictPreviewItems> Items { get; set; }
                public class UpdateGatewayQuotaRuleResponseBodyDataConflictPreviewItems : TeaModel {
                    /// <summary>
                    /// <para>The period type of the existing conflicting rule on the consumer principal. Valid values: day, week, and month, which indicate that the period of the conflicting rule is daily, weekly, or monthly.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>week</para>
                    /// </summary>
                    [NameInMap("conflictPeriodType")]
                    [Validation(Required=false)]
                    public string ConflictPeriodType { get; set; }

                    /// <summary>
                    /// <para>The type of the existing conflicting rule on the consumer principal. Valid values: calendar (the conflicting rule uses a calendar period) and epoch (the conflicting rule uses a custom period).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>calendar</para>
                    /// </summary>
                    [NameInMap("conflictType")]
                    [Validation(Required=false)]
                    public string ConflictType { get; set; }

                    /// <summary>
                    /// <para>The consumer ID. You can use subjectId instead.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cs-d82n1g6m1hkm375xxxxx</para>
                    /// </summary>
                    [NameInMap("consumerId")]
                    [Validation(Required=false)]
                    public string ConsumerId { get; set; }

                    /// <summary>
                    /// <para>The consumer name. You can use subjectName instead.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>consumer-a</para>
                    /// </summary>
                    [NameInMap("consumerName")]
                    [Validation(Required=false)]
                    public string ConsumerName { get; set; }

                    /// <summary>
                    /// <para>The ID of the conflicting principal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cs-xxx</para>
                    /// </summary>
                    [NameInMap("subjectId")]
                    [Validation(Required=false)]
                    public string SubjectId { get; set; }

                    /// <summary>
                    /// <para>The name of the conflicting principal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>consumer-a</para>
                    /// </summary>
                    [NameInMap("subjectName")]
                    [Validation(Required=false)]
                    public string SubjectName { get; set; }

                    /// <summary>
                    /// <para>The type of the conflicting principal. Valid values: consumer and consumer_group.</para>
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
            /// <para>Indicates whether the request is a dry run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("dryRun")]
            [Validation(Required=false)]
            public bool? DryRun { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qr-xxxxxx</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

        /// <summary>
        /// <para>The message content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello, World!</para>
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
