// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceClusterListResponseBody : TeaModel {
        [NameInMap("InstanceClusters")]
        [Validation(Required=false)]
        public DescribeInstanceClusterListResponseBodyInstanceClusters InstanceClusters { get; set; }
        public class DescribeInstanceClusterListResponseBodyInstanceClusters : TeaModel {
            [NameInMap("InstanceCluster")]
            [Validation(Required=false)]
            public List<DescribeInstanceClusterListResponseBodyInstanceClustersInstanceCluster> InstanceCluster { get; set; }
            public class DescribeInstanceClusterListResponseBodyInstanceClustersInstanceCluster : TeaModel {
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("InstanceClusterId")]
                [Validation(Required=false)]
                public string InstanceClusterId { get; set; }

                [NameInMap("InstanceClusterName")]
                [Validation(Required=false)]
                public string InstanceClusterName { get; set; }

                [NameInMap("InstanceClusterStatus")]
                [Validation(Required=false)]
                public string InstanceClusterStatus { get; set; }

                [NameInMap("InstanceClusterType")]
                [Validation(Required=false)]
                public string InstanceClusterType { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

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
