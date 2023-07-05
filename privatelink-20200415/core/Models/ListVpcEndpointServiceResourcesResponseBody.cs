// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointServiceResourcesResponseBody : TeaModel {
        /// <summary>
        /// The vSwitch to which the service resource belongs.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The type of the service resource.
        /// 
        /// The value is set to **slb**, which indicates Classic Load Balancer (CLB).
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **ListVpcEndpointServiceResources**.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of service resources.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListVpcEndpointServiceResourcesResponseBodyResources> Resources { get; set; }
        public class ListVpcEndpointServiceResourcesResponseBodyResources : TeaModel {
            [NameInMap("AutoAllocatedEnabled")]
            [Validation(Required=false)]
            public bool? AutoAllocatedEnabled { get; set; }

            /// <summary>
            /// The ID of the endpoint service.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RelatedDeprecatedEndpointCount")]
            [Validation(Required=false)]
            public long? RelatedDeprecatedEndpointCount { get; set; }

            [NameInMap("RelatedEndpointCount")]
            [Validation(Required=false)]
            public long? RelatedEndpointCount { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceSupportIPv6")]
            [Validation(Required=false)]
            public bool? ResourceSupportIPv6 { get; set; }

            /// <summary>
            /// The number of replaced connections to the endpoint associated with the endpoint service in smooth migration scenarios.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// Indicates whether automatic resource allocation is allowed. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The ID of the region where the service resource is deployed.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The ID of the zone where the service resource is deployed.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
