// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClustersResponseBody : TeaModel {
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

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClustersResponseBodyItems Items { get; set; }
        public class DescribeDBClustersResponseBodyItems : TeaModel {
            [NameInMap("DBCluster")]
            [Validation(Required=false)]
            public List<DescribeDBClustersResponseBodyItemsDBCluster> DBCluster { get; set; }
            public class DescribeDBClustersResponseBodyItemsDBCluster : TeaModel {
                public string DtsJobId { get; set; }
                public long? DBNodeCount { get; set; }
                public string Expired { get; set; }
                public string CreateTime { get; set; }
                public string PayType { get; set; }
                public string DiskType { get; set; }
                public DescribeDBClustersResponseBodyItemsDBClusterTags Tags { get; set; }
                public class DescribeDBClustersResponseBodyItemsDBClusterTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBClustersResponseBodyItemsDBClusterTagsTag> Tag { get; set; }
                    public class DescribeDBClustersResponseBodyItemsDBClusterTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string Mode { get; set; }
                public string Port { get; set; }
                public string LockMode { get; set; }
                public string StorageResource { get; set; }
                public string ExecutorCount { get; set; }
                public string DBClusterId { get; set; }
                public string ConnectionString { get; set; }
                public string RdsInstanceId { get; set; }
                public string DBClusterType { get; set; }
                public string CommodityCode { get; set; }
                public string ExpireTime { get; set; }
                public long? DBNodeStorage { get; set; }
                public string DBNodeClass { get; set; }
                public string LockReason { get; set; }
                public string VPCId { get; set; }
                public string RegionId { get; set; }
                public string ComputeResource { get; set; }
                public int? ElasticIOResource { get; set; }
                public string VSwitchId { get; set; }
                public string DBVersion { get; set; }
                public string VPCCloudInstanceId { get; set; }
                public string DBClusterStatus { get; set; }
                public string ResourceGroupId { get; set; }
                public string DBClusterNetworkType { get; set; }
                public string DBClusterDescription { get; set; }
                public string ZoneId { get; set; }
                public string Category { get; set; }
                public string Engine { get; set; }
            }
        };

    }

}
