// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListClustersResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<ListClustersResponseBodyClusters> Clusters { get; set; }
        public class ListClustersResponseBodyClusters : TeaModel {
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("UsedResources")]
            [Validation(Required=false)]
            public ListClustersResponseBodyClustersUsedResources UsedResources { get; set; }
            public class ListClustersResponseBodyClustersUsedResources : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }
                [NameInMap("Gpu")]
                [Validation(Required=false)]
                public int? Gpu { get; set; }
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }
            };

            [NameInMap("ComputeSpotStrategy")]
            [Validation(Required=false)]
            public string ComputeSpotStrategy { get; set; }

            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("EhpcVersion")]
            [Validation(Required=false)]
            public string EhpcVersion { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("BaseOsTag")]
            [Validation(Required=false)]
            public string BaseOsTag { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("ComputeSpotPriceLimit")]
            [Validation(Required=false)]
            public float? ComputeSpotPriceLimit { get; set; }

            [NameInMap("SchedulerType")]
            [Validation(Required=false)]
            public string SchedulerType { get; set; }

            [NameInMap("NodeSuffix")]
            [Validation(Required=false)]
            public string NodeSuffix { get; set; }

            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            [NameInMap("ImageOwnerAlias")]
            [Validation(Required=false)]
            public string ImageOwnerAlias { get; set; }

            [NameInMap("OsTag")]
            [Validation(Required=false)]
            public string OsTag { get; set; }

            [NameInMap("NodePrefix")]
            [Validation(Required=false)]
            public string NodePrefix { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("Managers")]
            [Validation(Required=false)]
            public ListClustersResponseBodyClustersManagers Managers { get; set; }
            public class ListClustersResponseBodyClustersManagers : TeaModel {
                [NameInMap("ExceptionCount")]
                [Validation(Required=false)]
                public int? ExceptionCount { get; set; }
                [NameInMap("NormalCount")]
                [Validation(Required=false)]
                public int? NormalCount { get; set; }
                [NameInMap("OperatingCount")]
                [Validation(Required=false)]
                public int? OperatingCount { get; set; }
                [NameInMap("StoppedCount")]
                [Validation(Required=false)]
                public int? StoppedCount { get; set; }
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }
            };

            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("TotalResources")]
            [Validation(Required=false)]
            public ListClustersResponseBodyClustersTotalResources TotalResources { get; set; }
            public class ListClustersResponseBodyClustersTotalResources : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }
                [NameInMap("Gpu")]
                [Validation(Required=false)]
                public int? Gpu { get; set; }
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }
            };

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("Computes")]
            [Validation(Required=false)]
            public ListClustersResponseBodyClustersComputes Computes { get; set; }
            public class ListClustersResponseBodyClustersComputes : TeaModel {
                [NameInMap("ExceptionCount")]
                [Validation(Required=false)]
                public int? ExceptionCount { get; set; }
                [NameInMap("NormalCount")]
                [Validation(Required=false)]
                public int? NormalCount { get; set; }
                [NameInMap("OperatingCount")]
                [Validation(Required=false)]
                public int? OperatingCount { get; set; }
                [NameInMap("StoppedCount")]
                [Validation(Required=false)]
                public int? StoppedCount { get; set; }
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }
            };

            [NameInMap("LoginNodes")]
            [Validation(Required=false)]
            public string LoginNodes { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

        }

    }

}
