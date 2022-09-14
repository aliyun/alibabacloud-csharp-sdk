// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20170714.Models
{
    public class ListClustersResponseBody : TeaModel {
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public ListClustersResponseBodyClusters Clusters { get; set; }
        public class ListClustersResponseBodyClusters : TeaModel {
            [NameInMap("ClusterInfoSimple")]
            [Validation(Required=false)]
            public List<ListClustersResponseBodyClustersClusterInfoSimple> ClusterInfoSimple { get; set; }
            public class ListClustersResponseBodyClustersClusterInfoSimple : TeaModel {
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                [NameInMap("Computes")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersClusterInfoSimpleComputes Computes { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoSimpleComputes : TeaModel {
                    [NameInMap("ExceptionCount")]
                    [Validation(Required=false)]
                    public int? ExceptionCount { get; set; }

                    [NameInMap("NormalCount")]
                    [Validation(Required=false)]
                    public int? NormalCount { get; set; }

                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public int? Total { get; set; }

                }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("ImageOwnerAlias")]
                [Validation(Required=false)]
                public string ImageOwnerAlias { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("LoginNodes")]
                [Validation(Required=false)]
                public string LoginNodes { get; set; }

                [NameInMap("Managers")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersClusterInfoSimpleManagers Managers { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoSimpleManagers : TeaModel {
                    [NameInMap("ExceptionCount")]
                    [Validation(Required=false)]
                    public int? ExceptionCount { get; set; }

                    [NameInMap("NormalCount")]
                    [Validation(Required=false)]
                    public int? NormalCount { get; set; }

                    [NameInMap("Total")]
                    [Validation(Required=false)]
                    public int? Total { get; set; }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TotalResources")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersClusterInfoSimpleTotalResources TotalResources { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoSimpleTotalResources : TeaModel {
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    [NameInMap("Gpu")]
                    [Validation(Required=false)]
                    public int? Gpu { get; set; }

                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                }

                [NameInMap("UsedResources")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersClusterInfoSimpleUsedResources UsedResources { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoSimpleUsedResources : TeaModel {
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    [NameInMap("Gpu")]
                    [Validation(Required=false)]
                    public int? Gpu { get; set; }

                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
