// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClustersResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClustersResponseBodyItems Items { get; set; }
        public class DescribeDBClustersResponseBodyItems : TeaModel {
            [NameInMap("DBCluster")]
            [Validation(Required=false)]
            public List<DescribeDBClustersResponseBodyItemsDBCluster> DBCluster { get; set; }
            public class DescribeDBClustersResponseBodyItemsDBCluster : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

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

                [NameInMap("DBNodeNumber")]
                [Validation(Required=false)]
                public int? DBNodeNumber { get; set; }

                [NameInMap("DBNodes")]
                [Validation(Required=false)]
                public DescribeDBClustersResponseBodyItemsDBClusterDBNodes DBNodes { get; set; }
                public class DescribeDBClustersResponseBodyItemsDBClusterDBNodes : TeaModel {
                    [NameInMap("DBNode")]
                    [Validation(Required=false)]
                    public List<DescribeDBClustersResponseBodyItemsDBClusterDBNodesDBNode> DBNode { get; set; }
                    public class DescribeDBClustersResponseBodyItemsDBClusterDBNodesDBNode : TeaModel {
                        [NameInMap("DBNodeClass")]
                        [Validation(Required=false)]
                        public string DBNodeClass { get; set; }

                        [NameInMap("DBNodeId")]
                        [Validation(Required=false)]
                        public string DBNodeId { get; set; }

                        [NameInMap("DBNodeRole")]
                        [Validation(Required=false)]
                        public string DBNodeRole { get; set; }

                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                [NameInMap("DBType")]
                [Validation(Required=false)]
                public string DBType { get; set; }

                [NameInMap("DBVersion")]
                [Validation(Required=false)]
                public string DBVersion { get; set; }

                [NameInMap("DeletionLock")]
                [Validation(Required=false)]
                public int? DeletionLock { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("Expired")]
                [Validation(Required=false)]
                public string Expired { get; set; }

                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("ServerlessType")]
                [Validation(Required=false)]
                public string ServerlessType { get; set; }

                [NameInMap("StoragePayType")]
                [Validation(Required=false)]
                public string StoragePayType { get; set; }

                [NameInMap("StorageSpace")]
                [Validation(Required=false)]
                public long? StorageSpace { get; set; }

                [NameInMap("StorageUsed")]
                [Validation(Required=false)]
                public long? StorageUsed { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
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

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
