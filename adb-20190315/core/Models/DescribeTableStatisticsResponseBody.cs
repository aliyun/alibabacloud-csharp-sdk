// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeTableStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// Details about table statistics.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeTableStatisticsResponseBodyItems Items { get; set; }
        public class DescribeTableStatisticsResponseBodyItems : TeaModel {
            [NameInMap("TableStatisticRecords")]
            [Validation(Required=false)]
            public List<DescribeTableStatisticsResponseBodyItemsTableStatisticRecords> TableStatisticRecords { get; set; }
            public class DescribeTableStatisticsResponseBodyItemsTableStatisticRecords : TeaModel {
                /// <summary>
                /// The total amount of cold data. Unit: byte.
                /// 
                /// >  The parameter is returned only when the engine version of the cluster is 3.1.3.4 or later.
                /// </summary>
                [NameInMap("ColdDataSize")]
                [Validation(Required=false)]
                public long? ColdDataSize { get; set; }

                /// <summary>
                /// The amount of data in the table. Unit: byte.
                /// </summary>
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                [NameInMap("HotDataSize")]
                [Validation(Required=false)]
                public long? HotDataSize { get; set; }

                /// <summary>
                /// The amount of data in indexes. Unit: byte.
                /// </summary>
                [NameInMap("IndexSize")]
                [Validation(Required=false)]
                public long? IndexSize { get; set; }

                [NameInMap("OtherSize")]
                [Validation(Required=false)]
                public long? OtherSize { get; set; }

                /// <summary>
                /// The number of partitions.
                /// </summary>
                [NameInMap("PartitionCount")]
                [Validation(Required=false)]
                public long? PartitionCount { get; set; }

                /// <summary>
                /// The amount of data in primary key indexes. Unit: byte.
                /// </summary>
                [NameInMap("PrimaryKeyIndexSize")]
                [Validation(Required=false)]
                public long? PrimaryKeyIndexSize { get; set; }

                /// <summary>
                /// The number of rows in the table.
                /// </summary>
                [NameInMap("RowCount")]
                [Validation(Required=false)]
                public long? RowCount { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                [NameInMap("SpaceRatio")]
                [Validation(Required=false)]
                public double? SpaceRatio { get; set; }

                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public long? TotalSize { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
