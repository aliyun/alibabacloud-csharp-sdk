// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClustersResponseBody : TeaModel {
        [NameInMap("DBClusters")]
        [Validation(Required=false)]
        public DescribeDBClustersResponseBodyDBClusters DBClusters { get; set; }
        public class DescribeDBClustersResponseBodyDBClusters : TeaModel {
            [NameInMap("DBCluster")]
            [Validation(Required=false)]
            public List<DescribeDBClustersResponseBodyDBClustersDBCluster> DBCluster { get; set; }
            public class DescribeDBClustersResponseBodyDBClustersDBCluster : TeaModel {
                public string AliUid { get; set; }
                public string Bid { get; set; }
                public string Category { get; set; }
                public string CommodityCode { get; set; }
                public string ConnectionString { get; set; }
                public string ControlVersion { get; set; }
                public string CreateTime { get; set; }
                public string DBClusterDescription { get; set; }
                public string DBClusterId { get; set; }
                public string DBClusterNetworkType { get; set; }
                public string DBClusterStatus { get; set; }
                public string DBNodeClass { get; set; }
                public long? DBNodeCount { get; set; }
                public long? DBNodeStorage { get; set; }
                public string ExpireTime { get; set; }
                public string IsExpired { get; set; }
                public string LockMode { get; set; }
                public string LockReason { get; set; }
                public string PayType { get; set; }
                public int? Port { get; set; }
                public string RegionId { get; set; }
                public DescribeDBClustersResponseBodyDBClustersDBClusterScaleOutStatus ScaleOutStatus { get; set; }
                public class DescribeDBClustersResponseBodyDBClustersDBClusterScaleOutStatus : TeaModel {
                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                }
                public string StorageType { get; set; }
                public DescribeDBClustersResponseBodyDBClustersDBClusterTags Tags { get; set; }
                public class DescribeDBClustersResponseBodyDBClustersDBClusterTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBClustersResponseBodyDBClustersDBClusterTagsTag> Tag { get; set; }
                    public class DescribeDBClustersResponseBodyDBClustersDBClusterTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string VSwitchId { get; set; }
                public string VpcCloudInstanceId { get; set; }
                public string VpcId { get; set; }
                public string ZoneId { get; set; }
            }
        };

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
