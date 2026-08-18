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
        /// <para>Set CrossRegion to true and use it together with CrossRegionSide in the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description><para><b>As a service consumer</b>: You need to create a cross-region endpoint to connect to an endpoint service in another region. To query the zones in the current region that support cross-region endpoints, set CrossRegion to true and CrossRegionSide to Endpoint.</para>
        /// </description></item>
        /// <item><description><para><b>As a service provider</b>: You need to share your endpoint service across regions with service consumers in other regions. To query the zones in the current region that support cross-region sharing, set CrossRegion to true and CrossRegionSide to EndpointService.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CrossRegion")]
        [Validation(Required=false)]
        public bool? CrossRegion { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the active zone support for the initiator side or the service side in a cross-region connection. Valid values:</para>
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
        /// <para>The ID of the region where the zones reside. You can call the <a href="https://help.aliyun.com/document_detail/120468.html">DescribeRegions</a> operation to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The zone availability of PrivateLink in a region depends on the backend EPS resource type. You can specify the EPS resource type when querying the list of zones supported by PrivateLink. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>slb</b> (default): the EPS resource type is Classic Load Balancer (CLB).</description></item>
        /// <item><description><b>alb</b>: the EPS resource type is Application Load Balancer (ALB).</description></item>
        /// <item><description><b>nlb</b>: the EPS resource type is Network Load Balancer (NLB).</description></item>
        /// <item><description><b>gwlb</b>: the EPS resource type is Gateway Load Balancer (GWLB).</description></item>
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
