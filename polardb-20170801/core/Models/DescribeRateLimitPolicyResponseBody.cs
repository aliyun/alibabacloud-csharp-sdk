// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeRateLimitPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of rate limit policy objects.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeRateLimitPolicyResponseBodyItems> Items { get; set; }
        public class DescribeRateLimitPolicyResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-01T17:52:05+08:00</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-19T16:47:25+08:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the gateway instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-xxxxxxxx</para>
            /// </summary>
            [NameInMap("GwClusterId")]
            [Validation(Required=false)]
            public string GwClusterId { get; set; }

            /// <summary>
            /// <para>The ID of the rate limit policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02eccf7c61cf4d05a543075ee907f3**</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RateLimit</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>The maximum requests per minute (RPM).</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RateLimitRpm")]
            [Validation(Required=false)]
            public string RateLimitRpm { get; set; }

            /// <summary>
            /// <para>The maximum tokens per minute (TPM).</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RateLimitTpm")]
            [Validation(Required=false)]
            public string RateLimitTpm { get; set; }

            /// <summary>
            /// <para>The ID of the object within the policy\&quot;s scope, such as a consumer group or a consumer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cg-xxxxxxx</para>
            /// </summary>
            [NameInMap("ScopeRefId")]
            [Validation(Required=false)]
            public string ScopeRefId { get; set; }

            /// <summary>
            /// <para>The scope of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ConsumerGroup</b>: The policy applies to a consumer group.</para>
            /// </description></item>
            /// <item><description><para><b>Consumer</b>: The policy applies to a specific consumer.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ConsumerGroup</para>
            /// </summary>
            [NameInMap("ScopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }

            /// <summary>
            /// <para>The status of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enabled</b>: The policy is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Disabled</b>: The policy is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The returned page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CED079B7-A408-41A1-BFF1-EC608E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of matching entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
