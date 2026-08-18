// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The EPS resource type supported by PrivateLink. The available regions vary based on the service resource type. You can specify a service resource type when querying the regions where PrivateLink is available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>slb</b> (default): the service resource type is Classic Load Balancer (CLB).</para>
        /// </description></item>
        /// <item><description><para><b>alb</b>: the service resource type is Application Load Balancer (ALB).</para>
        /// </description></item>
        /// <item><description><para><b>nlb</b>: the service resource type is Network Load Balancer (NLB).</para>
        /// </description></item>
        /// <item><description><para><b>gwlb</b>: the service resource type is Gateway Load Balancer (GWLB).</para>
        /// </description></item>
        /// <item><description><para><b>ALL</b>: all of the preceding types.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>slb</para>
        /// </summary>
        [NameInMap("ServiceResourceType")]
        [Validation(Required=false)]
        public string ServiceResourceType { get; set; }

    }

}
