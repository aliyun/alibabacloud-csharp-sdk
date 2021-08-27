// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeHpcClustersResponseBody : TeaModel {
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

        [NameInMap("HpcClusters")]
        [Validation(Required=false)]
        public DescribeHpcClustersResponseBodyHpcClusters HpcClusters { get; set; }
        public class DescribeHpcClustersResponseBodyHpcClusters : TeaModel {
            [NameInMap("HpcCluster")]
            [Validation(Required=false)]
            public List<DescribeHpcClustersResponseBodyHpcClustersHpcCluster> HpcCluster { get; set; }
            public class DescribeHpcClustersResponseBodyHpcClustersHpcCluster : TeaModel {
                public string HpcClusterId { get; set; }
                public string Name { get; set; }
                public string Description { get; set; }
            }
        };

    }

}
