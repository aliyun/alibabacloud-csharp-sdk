// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeTablePartitionDiagnoseResponseBody : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The information of tables.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeTablePartitionDiagnoseResponseBodyItems> Items { get; set; }
        public class DescribeTablePartitionDiagnoseResponseBodyItems : TeaModel {
            /// <summary>
            /// Details of the inappropriate partitions.
            /// </summary>
            [NameInMap("PartitionDetail")]
            [Validation(Required=false)]
            public string PartitionDetail { get; set; }

            /// <summary>
            /// The number of partitions.
            /// </summary>
            [NameInMap("PartitionNumber")]
            [Validation(Required=false)]
            public int? PartitionNumber { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// The table name.
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The recommended maximum number of rows in each list partition.
        /// </summary>
        [NameInMap("SuggestMaxRecordsPerPartition")]
        [Validation(Required=false)]
        public long? SuggestMaxRecordsPerPartition { get; set; }

        /// <summary>
        /// The recommended minimum number of rows in each list partition.
        /// </summary>
        [NameInMap("SuggestMinRecordsPerPartition")]
        [Validation(Required=false)]
        public long? SuggestMinRecordsPerPartition { get; set; }

        /// <summary>
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
