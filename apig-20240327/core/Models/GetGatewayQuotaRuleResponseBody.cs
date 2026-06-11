// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetGatewayQuotaRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;ruleId&quot;:1001}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGatewayQuotaRuleResponseBodyData Data { get; set; }
        public class GetGatewayQuotaRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1745846400000</para>
            /// </summary>
            [NameInMap("baseTimestamp")]
            [Validation(Required=false)]
            public long? BaseTimestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("consumerCount")]
            [Validation(Required=false)]
            public long? ConsumerCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>day</para>
            /// </summary>
            [NameInMap("periodType")]
            [Validation(Required=false)]
            public string PeriodType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>token</para>
            /// </summary>
            [NameInMap("quotaDimension")]
            [Validation(Required=false)]
            public string QuotaDimension { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("quotaLimit")]
            [Validation(Required=false)]
            public long? QuotaLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qr-d8j7fpmm1hks65xxxxxx</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>daily-token-limit</para>
            /// </summary>
            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("ruleStatus")]
            [Validation(Required=false)]
            public string RuleStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GMT+8</para>
            /// </summary>
            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>calendar</para>
            /// </summary>
            [NameInMap("windowAlignment")]
            [Validation(Required=false)]
            public string WindowAlignment { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
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
