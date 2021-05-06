// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeTablePartitionDiagnoseResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("SuggestMaxRecordsPerPartition")]
        [Validation(Required=false)]
        public long? SuggestMaxRecordsPerPartition { get; set; }

        [NameInMap("SuggestMinRecordsPerPartition")]
        [Validation(Required=false)]
        public long? SuggestMinRecordsPerPartition { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeTablePartitionDiagnoseResponseBodyItems> Items { get; set; }
        public class DescribeTablePartitionDiagnoseResponseBodyItems : TeaModel {
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            [NameInMap("PartitionDetail")]
            [Validation(Required=false)]
            public string PartitionDetail { get; set; }

            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            [NameInMap("PartitionNumber")]
            [Validation(Required=false)]
            public int? PartitionNumber { get; set; }

        }

    }

}
