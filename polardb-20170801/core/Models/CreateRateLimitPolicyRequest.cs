// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateRateLimitPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The gateway instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-xxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <para>The maximum number of requests per minute.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RateLimitRpm")]
        [Validation(Required=false)]
        public string RateLimitRpm { get; set; }

        /// <summary>
        /// <para>The maximum number of tokens per minute.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RateLimitTpm")]
        [Validation(Required=false)]
        public string RateLimitTpm { get; set; }

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
        /// <para>The ID of the throttling dimension (ConsumerGroup ID or Consumer ID).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg-xxxxxxx</para>
        /// </summary>
        [NameInMap("ScopeRefId")]
        [Validation(Required=false)]
        public string ScopeRefId { get; set; }

        /// <summary>
        /// <para>The throttling dimension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ConsumerGroup</b>: user group</para>
        /// </description></item>
        /// <item><description><para><b>Consumer</b>: user</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ConsumerGroup</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
