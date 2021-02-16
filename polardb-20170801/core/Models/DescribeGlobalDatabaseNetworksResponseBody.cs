// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeGlobalDatabaseNetworksResponseBody : TeaModel {
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
        public List<DescribeGlobalDatabaseNetworksResponseBodyItems> Items { get; set; }
        public class DescribeGlobalDatabaseNetworksResponseBodyItems : TeaModel {
            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }

            [NameInMap("GDNId")]
            [Validation(Required=false)]
            public string GDNId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("GDNStatus")]
            [Validation(Required=false)]
            public string GDNStatus { get; set; }

            [NameInMap("DBClusters")]
            [Validation(Required=false)]
            public List<DescribeGlobalDatabaseNetworksResponseBodyItemsDBClusters> DBClusters { get; set; }
            public class DescribeGlobalDatabaseNetworksResponseBodyItemsDBClusters : TeaModel {
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            [NameInMap("GDNDescription")]
            [Validation(Required=false)]
            public string GDNDescription { get; set; }

        }

    }

}
