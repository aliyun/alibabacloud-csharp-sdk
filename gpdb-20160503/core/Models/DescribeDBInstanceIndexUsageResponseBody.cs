// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceIndexUsageResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceIndexUsageResponseBodyItems> Items { get; set; }
        public class DescribeDBInstanceIndexUsageResponseBodyItems : TeaModel {
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            [NameInMap("IndexDef")]
            [Validation(Required=false)]
            public string IndexDef { get; set; }

            [NameInMap("IndexName")]
            [Validation(Required=false)]
            public string IndexName { get; set; }

            [NameInMap("IndexScanTimes")]
            [Validation(Required=false)]
            public int? IndexScanTimes { get; set; }

            [NameInMap("IndexSize")]
            [Validation(Required=false)]
            public string IndexSize { get; set; }

            [NameInMap("IsPartitionTable")]
            [Validation(Required=false)]
            public bool? IsPartitionTable { get; set; }

            [NameInMap("ParentTableName")]
            [Validation(Required=false)]
            public string ParentTableName { get; set; }

            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            [NameInMap("TimeLastUpdated")]
            [Validation(Required=false)]
            public string TimeLastUpdated { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
