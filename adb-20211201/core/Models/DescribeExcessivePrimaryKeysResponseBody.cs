// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeExcessivePrimaryKeysResponseBody : TeaModel {
        /// <summary>
        /// The queried information about the request denial.
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// The cluster ID.
        /// 
        /// >  You can call the [DescribeDBClusters](https://help.aliyun.com/document_detail/129857.html) operation to query the IDs of all AnalyticDB for MySQL clusters within a region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The queried detection items and detection results.
        /// </summary>
        [NameInMap("DetectionItems")]
        [Validation(Required=false)]
        public List<DescribeExcessivePrimaryKeysResponseBodyDetectionItems> DetectionItems { get; set; }
        public class DescribeExcessivePrimaryKeysResponseBodyDetectionItems : TeaModel {
            /// <summary>
            /// The detection result.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The name of the detection item.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The severity level of the detection result.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values:
        /// 
        /// *   **30** (default)
        /// *   **50**
        /// *   **100**
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The queried tables that have excessive primary key fields.
        /// </summary>
        [NameInMap("Tables")]
        [Validation(Required=false)]
        public List<DescribeExcessivePrimaryKeysResponseBodyTables> Tables { get; set; }
        public class DescribeExcessivePrimaryKeysResponseBodyTables : TeaModel {
            /// <summary>
            /// The total number of columns.
            /// </summary>
            [NameInMap("ColumnCount")]
            [Validation(Required=false)]
            public int? ColumnCount { get; set; }

            /// <summary>
            /// The queried primary key fields.
            /// </summary>
            [NameInMap("PrimaryKeyColumns")]
            [Validation(Required=false)]
            public string PrimaryKeyColumns { get; set; }

            /// <summary>
            /// The number of primary key fields.
            /// </summary>
            [NameInMap("PrimaryKeyCount")]
            [Validation(Required=false)]
            public int? PrimaryKeyCount { get; set; }

            /// <summary>
            /// The data size of primary key indexes. Unit: bytes.
            /// </summary>
            [NameInMap("PrimaryKeyIndexSize")]
            [Validation(Required=false)]
            public long? PrimaryKeyIndexSize { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// The percentage of the table size. Unit: %.
            /// 
            /// >  Formula: Table storage percentage = Total data size of a table/Total data size of the cluster × 100%.
            /// </summary>
            [NameInMap("SpaceRatio")]
            [Validation(Required=false)]
            public double? SpaceRatio { get; set; }

            /// <summary>
            /// The name of the table
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// The cold data size. Unit: bytes.
            /// 
            /// >  Formula: Cold data size = Data size of table records + Data size of regular indexes + Data size of primary key indexes + Data size of other data.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
