// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeRateLimitPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the gateway instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-xxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <para>The page number to return. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b>. The default value is <b>30</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the target resource, which can be a consumer group or a consumer, depending on the <c>ScopeType</c> value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg-xxxxxxxx</para>
        /// </summary>
        [NameInMap("ScopeRefId")]
        [Validation(Required=false)]
        public string ScopeRefId { get; set; }

        /// <summary>
        /// <para>The scope of the rate limit policy. Valid values:</para>
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

    }

}
