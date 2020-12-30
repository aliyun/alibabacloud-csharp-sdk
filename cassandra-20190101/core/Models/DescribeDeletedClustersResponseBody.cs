// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeDeletedClustersResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

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
        public DescribeDeletedClustersResponseBodyClusters Clusters { get; set; }
        public class DescribeDeletedClustersResponseBodyClusters : TeaModel {
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public List<DescribeDeletedClustersResponseBodyClustersCluster> Cluster { get; set; }
            public class DescribeDeletedClustersResponseBodyClustersCluster : TeaModel {
                public string Status { get; set; }
                public int? DataCenterCount { get; set; }
                public string ExpireTime { get; set; }
                public string PayType { get; set; }
                public string ClusterName { get; set; }
                public string MajorVersion { get; set; }
                public string CreatedTime { get; set; }
                public string MinorVersion { get; set; }
                public string ClusterId { get; set; }
            }
        };

    }

}
