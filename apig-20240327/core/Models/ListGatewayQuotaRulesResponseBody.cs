// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayQuotaRulesResponseBody : TeaModel {
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
        public ListGatewayQuotaRulesResponseBodyData Data { get; set; }
        public class ListGatewayQuotaRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;ruleId&quot;:&quot;rule-001&quot;}]</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListGatewayQuotaRulesResponseBodyDataItems> Items { get; set; }
            public class ListGatewayQuotaRulesResponseBodyDataItems : TeaModel {
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
                /// <para>qr-xxxxx</para>
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
                /// <para>The time zone for the natural period, in UTC+x format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GMT+8</para>
                /// </summary>
                [NameInMap("timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

                /// <summary>
                /// <para>The reset period type.</para>
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
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records to retrieve at a time. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

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
        /// <para>The pagination token. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>762b1fa4e2434fd3959b1f66481979cf</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
