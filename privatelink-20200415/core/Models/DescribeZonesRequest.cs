// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether this is a cross-region scenario. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CrossRegion")]
        [Validation(Required=false)]
        public bool? CrossRegion { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the active zones for the initiator side or the service side in a cross-region connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Endpoint</b> (default): endpoint.</description></item>
        /// <item><description><b>EndpointService</b>: endpoint service.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when CrossRegion is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EndpointService</para>
        /// </summary>
        [NameInMap("CrossRegionSide")]
        [Validation(Required=false)]
        public string CrossRegionSide { get; set; }

        /// <summary>
        /// <para>The ID of the region where the zones reside. You can call the <a href="https://help.aliyun.com/document_detail/120468.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The zones supported by PrivateLink in a region depend on the backend service resource type. You can specify the service resource type when querying the zones supported by PrivateLink. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>slb</b> (default): Classic Load Balancer (CLB), the service resource type is classic load balancing.</description></item>
        /// <item><description><b>alb</b>: Application Load Balancer (ALB), the service resource type is application load balancing.</description></item>
        /// <item><description><b>nlb</b>: Network Load Balancer (NLB), the service resource type is network load balancing.</description></item>
        /// <item><description><b>gwlb</b>: Gateway Load Balancer (GWLB), the service resource type is gateway load balancing.</description></item>
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
