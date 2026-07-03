// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListConsumerQuotaRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;totalSize&quot;:100}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListConsumerQuotaRulesResponseBodyData Data { get; set; }
        public class ListConsumerQuotaRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;ruleId&quot;:&quot;rule-001&quot;}]</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListConsumerQuotaRulesResponseBodyDataItems> Items { get; set; }
            public class ListConsumerQuotaRulesResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The ID of the gateway to which the rule belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-123456</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The name of the gateway to which the rule belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prod-gateway</para>
                /// </summary>
                [NameInMap("gatewayName")]
                [Validation(Required=false)]
                public string GatewayName { get; set; }

                /// <summary>
                /// <para>The period multiplier, which specifies the number of periods after which the quota is reset. This parameter is returned only when the rule uses a custom cycle. Minimum value: 1. Maximum value: 60.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("periodMultiplier")]
                [Validation(Required=false)]
                public string PeriodMultiplier { get; set; }

                /// <summary>
                /// <para>The period type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>week</para>
                /// </summary>
                [NameInMap("periodType")]
                [Validation(Required=false)]
                public string PeriodType { get; set; }

                /// <summary>
                /// <para>The quota dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>token</para>
                /// </summary>
                [NameInMap("quotaDimension")]
                [Validation(Required=false)]
                public string QuotaDimension { get; set; }

                /// <summary>
                /// <para>The quota limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("quotaLimit")]
                [Validation(Required=false)]
                public long? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qr-d8j7fpmm1hksxxxxxx</para>
                /// </summary>
                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>daily-token-limit</para>
                /// </summary>
                [NameInMap("ruleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("ruleStatus")]
                [Validation(Required=false)]
                public string RuleStatus { get; set; }

                /// <summary>
                /// <para>The time zone corresponding to the natural cycle, in UTC+x format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UTC+8</para>
                /// </summary>
                [NameInMap("timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

                /// <summary>
                /// <para>The cycle type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>calendar: Natural cycle.</description></item>
                /// <item><description>epoch: Custom cycle.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>calendar</para>
                /// </summary>
                [NameInMap("windowAlignment")]
                [Validation(Required=false)]
                public string WindowAlignment { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The current page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of configured quota rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
