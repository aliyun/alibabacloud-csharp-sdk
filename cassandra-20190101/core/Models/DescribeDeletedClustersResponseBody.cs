// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeDeletedClustersResponseBody : TeaModel {
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public DescribeDeletedClustersResponseBodyClusters Clusters { get; set; }
        public class DescribeDeletedClustersResponseBodyClusters : TeaModel {
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public List<DescribeDeletedClustersResponseBodyClustersCluster> Cluster { get; set; }
            public class DescribeDeletedClustersResponseBodyClustersCluster : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("DataCenterCount")]
                [Validation(Required=false)]
                public int? DataCenterCount { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("MajorVersion")]
                [Validation(Required=false)]
                public string MajorVersion { get; set; }

                [NameInMap("MinorVersion")]
                [Validation(Required=false)]
                public string MinorVersion { get; set; }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
        public long? TotalCount { get; set; }

    }

}
