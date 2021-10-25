// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListClustersResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public ListClustersResponseBodyClusters Clusters { get; set; }
        public class ListClustersResponseBodyClusters : TeaModel {
            [NameInMap("ClusterInfoSimple")]
            [Validation(Required=false)]
            public List<ListClustersResponseBodyClustersClusterInfoSimple> ClusterInfoSimple { get; set; }
            public class ListClustersResponseBodyClustersClusterInfoSimple : TeaModel {
                public string VpcId { get; set; }
                public string Status { get; set; }
                public string CreateTime { get; set; }
                public bool? IsComputeEss { get; set; }
                public string ComputeSpotStrategy { get; set; }
                public string AccountType { get; set; }
                public int? Count { get; set; }
                public string EhpcVersion { get; set; }
                public string Description { get; set; }
                public string BaseOsTag { get; set; }
                public string Name { get; set; }
                public string ImageId { get; set; }
                public float? ComputeSpotPriceLimit { get; set; }
                public string SchedulerType { get; set; }
                public string DeployMode { get; set; }
                public string NodeSuffix { get; set; }
                public string ImageOwnerAlias { get; set; }
                public string OsTag { get; set; }
                public string NodePrefix { get; set; }
                public string InstanceType { get; set; }
                public string RegionId { get; set; }
                public string InstanceChargeType { get; set; }
                public string VSwitchId { get; set; }
                public string ZoneId { get; set; }
                public string LoginNodes { get; set; }
                public string Id { get; set; }
                public string Location { get; set; }
                public string ClientVersion { get; set; }
                public ListClustersResponseBodyClustersClusterInfoSimpleManagers Managers { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoSimpleManagers : TeaModel {
                    [NameInMap("OperatingCount")]
                    [Validation(Required=false)]
                    public int? OperatingCount { get; set; }

                    [NameInMap("ExceptionCount")]
                    [Validation(Required=false)]
                    public int? ExceptionCount { get; set; }

                    [NameInMap("StoppedCount")]
                    [Validation(Required=false)]
                    public int? StoppedCount { get; set; }

                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public int? Total { get; set; }

                    [NameInMap("NormalCount")]
                    [Validation(Required=false)]
                    public int? NormalCount { get; set; }

                }
                public ListClustersResponseBodyClustersClusterInfoSimpleComputes Computes { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoSimpleComputes : TeaModel {
                    [NameInMap("OperatingCount")]
                    [Validation(Required=false)]
                    public int? OperatingCount { get; set; }

                    [NameInMap("ExceptionCount")]
                    [Validation(Required=false)]
                    public int? ExceptionCount { get; set; }

                    [NameInMap("StoppedCount")]
                    [Validation(Required=false)]
                    public int? StoppedCount { get; set; }

                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public int? Total { get; set; }

                    [NameInMap("NormalCount")]
                    [Validation(Required=false)]
                    public int? NormalCount { get; set; }

                }
                public ListClustersResponseBodyClustersClusterInfoSimpleTotalResources TotalResources { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoSimpleTotalResources : TeaModel {
                    [NameInMap("Gpu")]
                    [Validation(Required=false)]
                    public int? Gpu { get; set; }

                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                }
                public ListClustersResponseBodyClustersClusterInfoSimpleUsedResources UsedResources { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoSimpleUsedResources : TeaModel {
                    [NameInMap("Gpu")]
                    [Validation(Required=false)]
                    public int? Gpu { get; set; }

                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                }
            }
        };

    }

}
