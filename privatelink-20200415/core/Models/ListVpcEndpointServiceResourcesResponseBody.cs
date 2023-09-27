// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointServiceResourcesResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If no value is returned for **NextToken**, no next requests are performed.
        /// *   If a value is returned for **NextToken**, the value can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The service resources.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListVpcEndpointServiceResourcesResponseBodyResources> Resources { get; set; }
        public class ListVpcEndpointServiceResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// Indicates whether automatic resource allocation is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("AutoAllocatedEnabled")]
            [Validation(Required=false)]
            public bool? AutoAllocatedEnabled { get; set; }

            /// <summary>
            /// The IP address of the service resource.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The ID of the region where the service resource is deployed.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The number of endpoints that are associated with the service resource that is smoothly migrated.
            /// </summary>
            [NameInMap("RelatedDeprecatedEndpointCount")]
            [Validation(Required=false)]
            public long? RelatedDeprecatedEndpointCount { get; set; }

            /// <summary>
            /// The number of endpoints that are associated with the service resource.
            /// </summary>
            [NameInMap("RelatedEndpointCount")]
            [Validation(Required=false)]
            public long? RelatedEndpointCount { get; set; }

            /// <summary>
            /// The service resource ID.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// Indicates whether IPv6 is enabled for the endpoint service. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("ResourceSupportIPv6")]
            [Validation(Required=false)]
            public bool? ResourceSupportIPv6 { get; set; }

            /// <summary>
            /// The type of the service resource.
            /// 
            /// Only **slb** is returned. This value indicates a Classic Load Balancer (CLB) instance.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The ID of the vSwitch to which the service resource belongs.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC) to which the service resource belongs.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The ID of the zone to which the service resource belongs.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
