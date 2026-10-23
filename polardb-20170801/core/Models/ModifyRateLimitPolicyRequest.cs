// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyRateLimitPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the gateway instance. You can obtain the ID from the GwClusterId parameter returned by CreateGateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-xxxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the throttling policy to be modified. You can obtain the ID from the PolicyId parameter returned by CreateRateLimitPolicy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02eccf7c61cf4d05a543075ee907f3**</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The limit on the number of requests per minute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RateLimitRpm")]
        [Validation(Required=false)]
        public string RateLimitRpm { get; set; }

        /// <summary>
        /// <para>The limit on the number of tokens per minute.</para>
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

    }

}
