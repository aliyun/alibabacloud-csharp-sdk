// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClustersWithBackupsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClustersWithBackupsResponseBodyItems Items { get; set; }
        public class DescribeDBClustersWithBackupsResponseBodyItems : TeaModel {
            [NameInMap("DBCluster")]
            [Validation(Required=false)]
            public List<DescribeDBClustersWithBackupsResponseBodyItemsDBCluster> DBCluster { get; set; }
            public class DescribeDBClustersWithBackupsResponseBodyItemsDBCluster : TeaModel {
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

                [NameInMap("DBType")]
                [Validation(Required=false)]
                public string DBType { get; set; }

                [NameInMap("DBVersion")]
                [Validation(Required=false)]
                public string DBVersion { get; set; }

                [NameInMap("DeletedTime")]
                [Validation(Required=false)]
                public string DeletedTime { get; set; }

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

                [NameInMap("IsDeleted")]
                [Validation(Required=false)]
                public int? IsDeleted { get; set; }

                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

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
