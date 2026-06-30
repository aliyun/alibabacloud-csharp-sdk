// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetGlobalAcceleratorResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the Alibaba Cloud Global Accelerator (GA).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1odcab8tmno0hdq****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The ID of the linked peripheral resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v2_public_cn-x0r****gr1i</para>
        /// </summary>
        [NameInMap("AssociatedResourceId")]
        [Validation(Required=false)]
        public string AssociatedResourceId { get; set; }

        /// <summary>
        /// <para>The Region ID where the linked instance is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("AssociatedResourceRegionId")]
        [Validation(Required=false)]
        public string AssociatedResourceRegionId { get; set; }

        /// <summary>
        /// <para>The resource type of the linked peripheral resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WAF</para>
        /// </summary>
        [NameInMap("AssociatedResourceType")]
        [Validation(Required=false)]
        public string AssociatedResourceType { get; set; }

        /// <summary>
        /// <para>The Region ID where the Alibaba Cloud Global Accelerator (GA) instance is located. The only valid value is cn-hangzhou.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
