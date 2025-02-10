// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointServiceResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If no value is returned for <b>NextToken</b>, no next requests are performed.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value can be used in the next request to retrieve a new page of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED28DCAC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListVpcEndpointServiceResourcesResponseBodyResources> Resources { get; set; }
        public class ListVpcEndpointServiceResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic resource allocation is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoAllocatedEnabled")]
            [Validation(Required=false)]
            public bool? AutoAllocatedEnabled { get; set; }

            /// <summary>
            /// <para>The IP address of the service resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.23</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The ID of the region where the service resource is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huhehaote</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The number of endpoints that are associated with the service resource that is smoothly migrated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RelatedDeprecatedEndpointCount")]
            [Validation(Required=false)]
            public long? RelatedDeprecatedEndpointCount { get; set; }

            /// <summary>
            /// <para>The number of endpoints that are associated with the service resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RelatedEndpointCount")]
            [Validation(Required=false)]
            public long? RelatedEndpointCount { get; set; }

            /// <summary>
            /// <para>The service resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-hp32z1wp5peaoox2q****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>Indicates whether IPv6 is enabled for the endpoint service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ResourceSupportIPv6")]
            [Validation(Required=false)]
            public bool? ResourceSupportIPv6 { get; set; }

            /// <summary>
            /// <para>The type of the service resource.</para>
            /// <para>Only <b>slb</b> is returned. This value indicates a Classic Load Balancer (CLB) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>slb</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the service resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-hp3uf6045ljdhd5zr****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) to which the service resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-hp356stwkxg3fn2xe****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The ID of the zone to which the service resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huhehaote-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
