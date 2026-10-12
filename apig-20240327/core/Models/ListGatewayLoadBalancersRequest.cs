// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayLoadBalancersRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return all instances in the selectable list mode. This parameter affects pagination and filtering behavior.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The load balancer instance ID. Specify this parameter to query details of a specific load balancer in the selectable list mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-xxxx</para>
        /// </summary>
        [NameInMap("loadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The network type used to filter results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>The mode switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Returns the list of load balancers that are already associated with the gateway by reading database relationships.</description></item>
        /// <item><description>false (default): Returns the selectable list by calling SLB or NLB OpenAPI to filter bindable instances.</description></item>
        /// </list>
        /// <para>Use related=true to retrieve the list of associated load balancers. The default mode (related=false) calls SLB or NLB OpenAPI to filter bindable instances, which may return a 500 error in common scenarios due to backend data issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("related")]
        [Validation(Required=false)]
        public bool? Related { get; set; }

        /// <summary>
        /// <para>The load balancer type used to filter results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NLB</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The VPC ID used to filter instances within the specified VPC in the selectable list mode. This parameter is required when type is set to NLB and related is not set to true. Otherwise, the API returns a 500 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxxx</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
