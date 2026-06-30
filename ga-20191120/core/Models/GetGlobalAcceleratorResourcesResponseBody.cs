// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetGlobalAcceleratorResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>List of linked instances.</para>
        /// </summary>
        [NameInMap("AssociatedResources")]
        [Validation(Required=false)]
        public List<GetGlobalAcceleratorResourcesResponseBodyAssociatedResources> AssociatedResources { get; set; }
        public class GetGlobalAcceleratorResourcesResponseBodyAssociatedResources : TeaModel {
            /// <summary>
            /// <para>Instance ID of Alibaba Cloud Global Accelerator (GA).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp1odcab8tmno0hdq****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// <para>Association pattern:  </para>
            /// <list type="bullet">
            /// <item><description><b>Managed</b>: Managed mode, where GA restricts user operations based on management policies.  </description></item>
            /// <item><description><b>Associated</b> (default): Loose coupling association, where GA does not restrict user operations; WAF uses loose coupling.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Associated</para>
            /// </summary>
            [NameInMap("AssociatedMode")]
            [Validation(Required=false)]
            public string AssociatedMode { get; set; }

            /// <summary>
            /// <para>ID of the linked instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf_v2_public_cn-x0r****gr1i</para>
            /// </summary>
            [NameInMap("AssociatedResourceId")]
            [Validation(Required=false)]
            public string AssociatedResourceId { get; set; }

            /// <summary>
            /// <para>Region ID of the linked instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("AssociatedResourceRegionId")]
            [Validation(Required=false)]
            public string AssociatedResourceRegionId { get; set; }

            /// <summary>
            /// <para>Resource type of the linked instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WAF</para>
            /// </summary>
            [NameInMap("AssociatedResourceType")]
            [Validation(Required=false)]
            public string AssociatedResourceType { get; set; }

            /// <summary>
            /// <para>Status of the association between the Alibaba Cloud Global Accelerator (GA) instance and other cloud product resources.  </para>
            /// <list type="bullet">
            /// <item><description><para><b>active</b>: The resource is active.  </para>
            /// </description></item>
            /// <item><description><para><b>binding</b>: The resource is being attached.  </para>
            /// </description></item>
            /// <item><description><para><b>unBinding</b>: The resource is being detached.  </para>
            /// </description></item>
            /// <item><description><para><b>wafRelease</b>: The WAF instance has been released.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE77A7F3-3B74-41C0-A5BC-CAFD188C28B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
