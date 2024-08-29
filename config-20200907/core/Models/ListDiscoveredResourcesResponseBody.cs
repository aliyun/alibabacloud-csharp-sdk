// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListDiscoveredResourcesResponseBody : TeaModel {
        /// <summary>
        /// The information about the resources.
        /// </summary>
        [NameInMap("DiscoveredResourceProfiles")]
        [Validation(Required=false)]
        public ListDiscoveredResourcesResponseBodyDiscoveredResourceProfiles DiscoveredResourceProfiles { get; set; }
        public class ListDiscoveredResourcesResponseBodyDiscoveredResourceProfiles : TeaModel {
            /// <summary>
            /// The details of the resources.
            /// </summary>
            [NameInMap("DiscoveredResourceProfileList")]
            [Validation(Required=false)]
            public List<ListDiscoveredResourcesResponseBodyDiscoveredResourceProfilesDiscoveredResourceProfileList> DiscoveredResourceProfileList { get; set; }
            public class ListDiscoveredResourcesResponseBodyDiscoveredResourceProfilesDiscoveredResourceProfileList : TeaModel {
                /// <summary>
                /// The ID of the Alibaba Cloud account to which the resource belongs.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// The zone ID.
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
                /// The timestamp when the resource was created. Unit: milliseconds.
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
                /// The status of the resource. The value of this parameter varies based on the resource type and may be empty. Examples:
                /// 
                /// *   If the ResourceType parameter is set to ACS::ECS::Instance, the resource is an Elastic Compute Service (ECS) instance that has a specific state. In this case, the valid values of this parameter are Running and Stopped.
                /// *   If the ResourceType parameter is ACS::OSS::Bucket, the resource is an Object Storage Service (OSS) bucket that is not in a specific state. In this case, this parameter is left empty.
                /// </summary>
                [NameInMap("ResourceStatus")]
                [Validation(Required=false)]
                public string ResourceStatus { get; set; }

                /// <summary>
                /// The type of the resource.
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
                /// The version of the resource change.
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
            /// A pagination token. It can be used in the next request to retrieve a new page of results.
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
