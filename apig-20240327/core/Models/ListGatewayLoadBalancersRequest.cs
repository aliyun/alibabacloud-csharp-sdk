// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayLoadBalancersRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return all instances in the optional list mode. This parameter affects the pagination and filtering strategies.</para>
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
        /// <para>Specifies whether to return the list of load balancers associated with the gateway. If set to true, the associated load balancers are returned based on database relationships. We recommend setting this parameter to true to retrieve the associated load balancers. If set to false or left empty, the optional list mode is used to call the SLB or NLB API and filter bindable instances. In the default mode where related is false, calling the SLB or NLB API may return a 500 error due to backend data issues in common scenarios.</para>
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
