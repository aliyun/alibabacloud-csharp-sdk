// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClustersWithBackupsResponseBody : TeaModel {
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClustersWithBackupsResponseBodyItems Items { get; set; }
        public class DescribeDBClustersWithBackupsResponseBodyItems : TeaModel {
            [NameInMap("DBCluster")]
            [Validation(Required=false)]
            public List<DescribeDBClustersWithBackupsResponseBodyItemsDBCluster> DBCluster { get; set; }
            public class DescribeDBClustersWithBackupsResponseBodyItemsDBCluster : TeaModel {
                public string VpcId { get; set; }
                public string DeletedTime { get; set; }
                public string ExpireTime { get; set; }
                public string Expired { get; set; }
                public string CreateTime { get; set; }
                public string PayType { get; set; }
                public string DBNodeClass { get; set; }
                public string DBType { get; set; }
                public string LockMode { get; set; }
                public string RegionId { get; set; }
                public string DBVersion { get; set; }
                public int? DeletionLock { get; set; }
                public string DBClusterId { get; set; }
                public string DBClusterStatus { get; set; }
                public int? IsDeleted { get; set; }
                public string DBClusterNetworkType { get; set; }
                public string DBClusterDescription { get; set; }
                public string ZoneId { get; set; }
                public string Engine { get; set; }
            }
        };

    }

}
