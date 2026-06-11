// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetGatewayQuotaRuleSubjectUsageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;usedAmount&quot;:500}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGatewayQuotaRuleSubjectUsageResponseBodyData Data { get; set; }
        public class GetGatewayQuotaRuleSubjectUsageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("cachedAmount")]
            [Validation(Required=false)]
            public long? CachedAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;totalSize&quot;:100}</para>
            /// </summary>
            [NameInMap("details")]
            [Validation(Required=false)]
            public GetGatewayQuotaRuleSubjectUsageResponseBodyDataDetails Details { get; set; }
            public class GetGatewayQuotaRuleSubjectUsageResponseBodyDataDetails : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>[{&quot;model&quot;:&quot;qwen-plus&quot;,\&quot;usedAmount\&quot;:210}]</para>
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<GetGatewayQuotaRuleSubjectUsageResponseBodyDataDetailsItems> Items { get; set; }
                public class GetGatewayQuotaRuleSubjectUsageResponseBodyDataDetailsItems : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("cachedAmount")]
                    [Validation(Required=false)]
                    public long? CachedAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("inputAmount")]
                    [Validation(Required=false)]
                    public long? InputAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>qwen-plus</para>
                    /// </summary>
                    [NameInMap("model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("outputAmount")]
                    [Validation(Required=false)]
                    public long? OutputAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-06-05 13:16:31</para>
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>210</para>
                    /// </summary>
                    [NameInMap("usedAmount")]
                    [Validation(Required=false)]
                    public long? UsedAmount { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("pageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("totalSize")]
                [Validation(Required=false)]
                public int? TotalSize { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("inputAmount")]
            [Validation(Required=false)]
            public long? InputAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("outputAmount")]
            [Validation(Required=false)]
            public long? OutputAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("overLimit")]
            [Validation(Required=false)]
            public bool? OverLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("totalQuota")]
            [Validation(Required=false)]
            public long? TotalQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("usedAmount")]
            [Validation(Required=false)]
            public long? UsedAmount { get; set; }

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
