// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class GetPriceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The region ID. This parameter is required if the cloud product is deployed in a region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The attributes based on which the price is queried (in JSON format).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///         &quot;LoadBalancerName&quot;: &quot;cc-test&quot;,
        ///         &quot;LoadBalancerSpec&quot;: &quot;slb.s3.small&quot;,
        ///         &quot;InternetChargeType&quot;: &quot;paybybandwidth&quot;,
        ///         &quot;AddressType&quot;: &quot;internet&quot;,
        ///         &quot;PaymentType&quot;: &quot;PayAsYouGo&quot;,
        ///         &quot;Bandwidth&quot;: 6
        ///       }</para>
        /// </summary>
        [NameInMap("resourceAttributes")]
        [Validation(Required=false)]
        public string ResourceAttributesShrink { get; set; }

    }

}
