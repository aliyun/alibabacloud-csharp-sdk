// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeClustersResponseBody : TeaModel {
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
        public DescribeClustersResponseBodyClusters Clusters { get; set; }
        public class DescribeClustersResponseBodyClusters : TeaModel {
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public List<DescribeClustersResponseBodyClustersCluster> Cluster { get; set; }
            public class DescribeClustersResponseBodyClustersCluster : TeaModel {
                public string Status { get; set; }
                public string ExpireTime { get; set; }
                public string PayType { get; set; }
                public DescribeClustersResponseBodyClustersClusterTags Tags { get; set; }
                public class DescribeClustersResponseBodyClustersClusterTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeClustersResponseBodyClustersClusterTagsTag> Tag { get; set; }
                    public class DescribeClustersResponseBodyClustersClusterTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string LockMode { get; set; }
                public int? AutoRenewPeriod { get; set; }
                public string MinorVersion { get; set; }
                public int? DataCenterCount { get; set; }
                public bool? AutoRenewal { get; set; }
                public string ResourceGroupId { get; set; }
                public string ClusterName { get; set; }
                public string MajorVersion { get; set; }
                public string CreatedTime { get; set; }
                public string ClusterId { get; set; }
            }
        };

    }

}
