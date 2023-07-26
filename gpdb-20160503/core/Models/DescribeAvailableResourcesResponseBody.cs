// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeAvailableResourcesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details of the available resources.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<DescribeAvailableResourcesResponseBodyResources> Resources { get; set; }
        public class DescribeAvailableResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// The available engine version and specifications.
            /// </summary>
            [NameInMap("SupportedEngines")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourcesResponseBodyResourcesSupportedEngines> SupportedEngines { get; set; }
            public class DescribeAvailableResourcesResponseBodyResourcesSupportedEngines : TeaModel {
                /// <summary>
                /// The instance resource type. Valid values:
                /// 
                /// *   **ecs**: elastic storage mode
                /// *   **serverless**: Serverless mode
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// The available engine version.
                /// </summary>
                [NameInMap("SupportedEngineVersion")]
                [Validation(Required=false)]
                public string SupportedEngineVersion { get; set; }

                /// <summary>
                /// The available specifications.
                /// </summary>
                [NameInMap("SupportedInstanceClasses")]
                [Validation(Required=false)]
                public List<DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClasses> SupportedInstanceClasses { get; set; }
                public class DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClasses : TeaModel {
                    /// <summary>
                    /// The instance edition. Valid values:
                    /// 
                    /// *   **HighAvailability**: High-availability Edition
                    /// *   **Basic**: Basic Edition
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// The description of compute node specifications.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The specifications of each compute node.
                    /// </summary>
                    [NameInMap("DisplayClass")]
                    [Validation(Required=false)]
                    public string DisplayClass { get; set; }

                    /// <summary>
                    /// The specifications of each compute node.
                    /// </summary>
                    [NameInMap("InstanceClass")]
                    [Validation(Required=false)]
                    public string InstanceClass { get; set; }

                    /// <summary>
                    /// Details about the compute nodes.
                    /// </summary>
                    [NameInMap("NodeCount")]
                    [Validation(Required=false)]
                    public DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClassesNodeCount NodeCount { get; set; }
                    public class DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClassesNodeCount : TeaModel {
                        /// <summary>
                        /// The maximum number of compute nodes.
                        /// </summary>
                        [NameInMap("MaxCount")]
                        [Validation(Required=false)]
                        public string MaxCount { get; set; }

                        /// <summary>
                        /// The minimum number of compute nodes.
                        /// </summary>
                        [NameInMap("MinCount")]
                        [Validation(Required=false)]
                        public string MinCount { get; set; }

                        /// <summary>
                        /// The step size for adding compute nodes.
                        /// 
                        /// For example, if the value of this parameter is 4, compute nodes must be added by multiples of 4.
                        /// </summary>
                        [NameInMap("Step")]
                        [Validation(Required=false)]
                        public string Step { get; set; }

                    }

                    /// <summary>
                    /// Details about the storage capacity of compute nodes.
                    /// </summary>
                    [NameInMap("StorageSize")]
                    [Validation(Required=false)]
                    public DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClassesStorageSize StorageSize { get; set; }
                    public class DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClassesStorageSize : TeaModel {
                        /// <summary>
                        /// The maximum storage capacity of each compute node.
                        /// </summary>
                        [NameInMap("MaxCount")]
                        [Validation(Required=false)]
                        public string MaxCount { get; set; }

                        /// <summary>
                        /// The minimum storage capacity of each compute node.
                        /// </summary>
                        [NameInMap("MinCount")]
                        [Validation(Required=false)]
                        public string MinCount { get; set; }

                        /// <summary>
                        /// The step size for adding storage capacity for compute nodes.
                        /// </summary>
                        [NameInMap("Step")]
                        [Validation(Required=false)]
                        public string Step { get; set; }

                    }

                    /// <summary>
                    /// The storage type. Valid values:
                    /// 
                    /// *   **cloud_essd**: enhanced SSD (ESSD)
                    /// *   **cloud_efficiency**: ultra disk
                    /// *   **oss**: Object Storage Service (OSS)
                    /// </summary>
                    [NameInMap("StorageType")]
                    [Validation(Required=false)]
                    public string StorageType { get; set; }

                }

            }

            /// <summary>
            /// The ID of the zone.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
