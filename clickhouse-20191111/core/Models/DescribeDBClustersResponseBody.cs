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
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public string AliUid { get; set; }

                [NameInMap("Bid")]
                [Validation(Required=false)]
                public string Bid { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                [NameInMap("ControlVersion")]
                [Validation(Required=false)]
                public string ControlVersion { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DBClusterDescription")]
                [Validation(Required=false)]
                public string DBClusterDescription { get; set; }

                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                [NameInMap("DBClusterNetworkType")]
                [Validation(Required=false)]
                public string DBClusterNetworkType { get; set; }

                [NameInMap("DBClusterStatus")]
                [Validation(Required=false)]
                public string DBClusterStatus { get; set; }

                [NameInMap("DBNodeClass")]
                [Validation(Required=false)]
                public string DBNodeClass { get; set; }

                [NameInMap("DBNodeCount")]
                [Validation(Required=false)]
                public long? DBNodeCount { get; set; }

                [NameInMap("DBNodeStorage")]
                [Validation(Required=false)]
                public long? DBNodeStorage { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("ExtStorageSize")]
                [Validation(Required=false)]
                public int? ExtStorageSize { get; set; }

                [NameInMap("ExtStorageType")]
                [Validation(Required=false)]
                public string ExtStorageType { get; set; }

                [NameInMap("IsExpired")]
                [Validation(Required=false)]
                public string IsExpired { get; set; }

                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("ScaleOutStatus")]
                [Validation(Required=false)]
                public DescribeDBClustersResponseBodyDBClustersDBClusterScaleOutStatus ScaleOutStatus { get; set; }
                public class DescribeDBClustersResponseBodyDBClustersDBClusterScaleOutStatus : TeaModel {
                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public string Ratio { get; set; }

                }

                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
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

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VpcCloudInstanceId")]
                [Validation(Required=false)]
                public string VpcCloudInstanceId { get; set; }

                /// <summary>
                /// VPC ID。
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

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
