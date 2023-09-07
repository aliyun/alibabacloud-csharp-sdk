// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterAvailableResourcesResponseBody : TeaModel {
        /// <summary>
        /// The available zones of the cluster.
        /// </summary>
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<DescribeDBClusterAvailableResourcesResponseBodyAvailableZones> AvailableZones { get; set; }
        public class DescribeDBClusterAvailableResourcesResponseBodyAvailableZones : TeaModel {
            /// <summary>
            /// The region ID of the cluster.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The database engines that the available resources support.
            /// </summary>
            [NameInMap("SupportedEngines")]
            [Validation(Required=false)]
            public List<DescribeDBClusterAvailableResourcesResponseBodyAvailableZonesSupportedEngines> SupportedEngines { get; set; }
            public class DescribeDBClusterAvailableResourcesResponseBodyAvailableZonesSupportedEngines : TeaModel {
                /// <summary>
                /// The available resources.
                /// </summary>
                [NameInMap("AvailableResources")]
                [Validation(Required=false)]
                public List<DescribeDBClusterAvailableResourcesResponseBodyAvailableZonesSupportedEnginesAvailableResources> AvailableResources { get; set; }
                public class DescribeDBClusterAvailableResourcesResponseBodyAvailableZonesSupportedEnginesAvailableResources : TeaModel {
                    /// <summary>
                    /// The edition of the cluster. Valid values:
                    /// 
                    /// *   **Normal**: Cluster Edition.
                    /// *   **Basic**: Single Node Edition.
                    /// *   **ArchiveNormal**: X-Engine.
                    /// *   **NormalMultimaster**: Multi-master Cluster (Database/Table) Edition.
                    /// *   **SENormal**: Standard Edition.
                    /// 
                    /// >- Only PolarDB for MySQL supports Single Node Edition.
                    /// >- Only PolarDB for MySQL 8.0 supports X-Engine Edition and Multi-master Cluster (Database/Table) Edition.
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// The specifications of the node.
                    /// </summary>
                    [NameInMap("DBNodeClass")]
                    [Validation(Required=false)]
                    public string DBNodeClass { get; set; }

                }

                /// <summary>
                /// The version of the database engine.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

            }

            /// <summary>
            /// The zone ID of the cluster.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
