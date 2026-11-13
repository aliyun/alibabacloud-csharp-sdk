// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayLoadBalancersRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return all instances in the optional list mode. This parameter affects the pagination and filtering policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The exact load balancer instance ID used to query details by ID in the optional list mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-xxxx</para>
        /// </summary>
        [NameInMap("loadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The network type filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>Specifies the mode switch. If set to true, the API returns the list of load balancers associated with the gateway by reading database relationships. If set to false or left empty, the API uses the optional list mode and calls the SLB or NLB POP API to filter bindable instances. We recommend that you set this parameter to true to retrieve the associated load balancers. In the default mode where related is set to false, the API calls the SLB or NLB POP API to filter bindable instances, which may return a 500 error in common scenarios due to backend data issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("related")]
        [Validation(Required=false)]
        public bool? Related { get; set; }

        /// <summary>
        /// <para>The load balancer type filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NLB</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The VPC filter used to filter instances within the specified VPC in the optional list mode. This parameter is required when type is set to NLB and related is not set to true. Otherwise, the API returns a 500 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxxx</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
