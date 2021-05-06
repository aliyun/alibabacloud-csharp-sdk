// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeTableStatisticsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeTableStatisticsResponseBodyItems Items { get; set; }
        public class DescribeTableStatisticsResponseBodyItems : TeaModel {
            [NameInMap("TableStatisticRecords")]
            [Validation(Required=false)]
            public List<DescribeTableStatisticsResponseBodyItemsTableStatisticRecords> TableStatisticRecords { get; set; }
            public class DescribeTableStatisticsResponseBodyItemsTableStatisticRecords : TeaModel {
                public string SchemaName { get; set; }
                public string TableName { get; set; }
                public long? RowCount { get; set; }
                public long? DataSize { get; set; }
                public long? IndexSize { get; set; }
                public long? PrimaryKeyIndexSize { get; set; }
                public long? PartitionCount { get; set; }
                public long? ColdDataSize { get; set; }
            }
        };

    }

}
