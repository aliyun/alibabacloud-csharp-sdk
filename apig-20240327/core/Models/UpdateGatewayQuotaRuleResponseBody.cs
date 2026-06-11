// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateGatewayQuotaRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200, 404, 500</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;key\&quot;: \&quot;value\&quot;}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateGatewayQuotaRuleResponseBodyData Data { get; set; }
        public class UpdateGatewayQuotaRuleResponseBodyData : TeaModel {
            [NameInMap("accepted")]
            [Validation(Required=false)]
            public bool? Accepted { get; set; }

            [NameInMap("conflictPreview")]
            [Validation(Required=false)]
            public UpdateGatewayQuotaRuleResponseBodyDataConflictPreview ConflictPreview { get; set; }
            public class UpdateGatewayQuotaRuleResponseBodyDataConflictPreview : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>f8f44dc6cf369a017d56b7197eb4fb5ac4bbb6b09a92b9b41999541f50xxxxxx</para>
                /// </summary>
                [NameInMap("conflictHash")]
                [Validation(Required=false)]
                public string ConflictHash { get; set; }

                [NameInMap("items")]
                [Validation(Required=false)]
                public List<UpdateGatewayQuotaRuleResponseBodyDataConflictPreviewItems> Items { get; set; }
                public class UpdateGatewayQuotaRuleResponseBodyDataConflictPreviewItems : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cs-d82n1g6m1hkm375xxxxx</para>
                    /// </summary>
                    [NameInMap("consumerId")]
                    [Validation(Required=false)]
                    public string ConsumerId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>consumer-a</para>
                    /// </summary>
                    [NameInMap("consumerName")]
                    [Validation(Required=false)]
                    public string ConsumerName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("totalConflictCount")]
                [Validation(Required=false)]
                public int? TotalConflictCount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("dryRun")]
            [Validation(Required=false)]
            public bool? DryRun { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qr-xxxxxx</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>你好，世界！</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
