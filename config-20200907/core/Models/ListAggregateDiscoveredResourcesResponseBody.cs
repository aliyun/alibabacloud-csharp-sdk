// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateDiscoveredResourcesResponseBody : TeaModel {
        /// <summary>
        /// The queried resources.
        /// </summary>
        [NameInMap("DiscoveredResourceProfiles")]
        [Validation(Required=false)]
        public ListAggregateDiscoveredResourcesResponseBodyDiscoveredResourceProfiles DiscoveredResourceProfiles { get; set; }
        public class ListAggregateDiscoveredResourcesResponseBodyDiscoveredResourceProfiles : TeaModel {
            /// <summary>
            /// The queried resource.
            /// </summary>
            [NameInMap("DiscoveredResourceProfileList")]
            [Validation(Required=false)]
            public List<ListAggregateDiscoveredResourcesResponseBodyDiscoveredResourceProfilesDiscoveredResourceProfileList> DiscoveredResourceProfileList { get; set; }
            public class ListAggregateDiscoveredResourcesResponseBodyDiscoveredResourceProfilesDiscoveredResourceProfileList : TeaModel {
                /// <summary>
                /// The ID of the Alibaba Cloud account to which the resource belongs. We recommend that you use the ResourceOwnerId parameter.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// The ID of the zone in which the resource resides.
                /// </summary>
                [NameInMap("AvailabilityZone")]
                [Validation(Required=false)]
                public string AvailabilityZone { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The time when the resource was created. Unit: milliseconds.
                /// </summary>
                [NameInMap("ResourceCreationTime")]
                [Validation(Required=false)]
                public long? ResourceCreationTime { get; set; }

                /// <summary>
                /// The status of the resource. Valid values:
                /// 
                /// *   0: The resource is deleted.
                /// *   1: The resource is retained.
                /// </summary>
                [NameInMap("ResourceDeleted")]
                [Validation(Required=false)]
                public int? ResourceDeleted { get; set; }

                /// <summary>
                /// The resource ID.
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// The resource name.
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the resource belongs.
                /// </summary>
                [NameInMap("ResourceOwnerId")]
                [Validation(Required=false)]
                public long? ResourceOwnerId { get; set; }

                /// <summary>
                /// The status of the resource. The value of this parameter varies with the resource type and may be empty. Examples:
                /// 
                /// *   If the value of the ResourceType parameter is ACS::ECS::Instance, the resource is an Elastic Compute Service (ECS) instance that is in a specific state. In this case, the valid values of this parameter are Running and Stopped.
                /// *   If the value of the ResourceType parameter is ACS::OSS::Bucket, the resource is an Object Storage Service (OSS) bucket that is not in a specific state. In this case, this parameter is empty.
                /// </summary>
                [NameInMap("ResourceStatus")]
                [Validation(Required=false)]
                public string ResourceStatus { get; set; }

                /// <summary>
                /// The resource type.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The tags of the resource.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// The build version of the resource.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

            /// <summary>
            /// The maximum number of entries returned on each page.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// The token that was used to initiate the next request.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The total number of resources.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
