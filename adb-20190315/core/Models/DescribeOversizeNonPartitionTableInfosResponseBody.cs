// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeOversizeNonPartitionTableInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-8vb46cpn2aaxxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The queried detection items and detection results.</para>
        /// </summary>
        [NameInMap("DetectionItems")]
        [Validation(Required=false)]
        public List<DescribeOversizeNonPartitionTableInfosResponseBodyDetectionItems> DetectionItems { get; set; }
        public class DescribeOversizeNonPartitionTableInfosResponseBodyDetectionItems : TeaModel {
            /// <summary>
            /// <para>The information about the detection result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Multiple oversized non-partitioned tables are detected.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The name of the detection item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Oversized non-partitioned tables</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The severity level of the detection result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL</description></item>
            /// <item><description>WARNING</description></item>
            /// <item><description>CRITICAL</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WARNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F67B5AC5-6CDE-5187-9E25-B1EEE9AC4D91</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried oversized non-partitioned tables.</para>
        /// </summary>
        [NameInMap("Tables")]
        [Validation(Required=false)]
        public List<DescribeOversizeNonPartitionTableInfosResponseBodyTables> Tables { get; set; }
        public class DescribeOversizeNonPartitionTableInfosResponseBodyTables : TeaModel {
            /// <summary>
            /// <para>The data size of table records. Unit: bytes.</para>
            /// <remarks>
            /// <para> The data size of table records does not include the data size of regular and primary key indexes.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>21474836480</para>
            /// </summary>
            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public long? DataSize { get; set; }

            /// <summary>
            /// <para>The data size of regular indexes. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1073741824</para>
            /// </summary>
            [NameInMap("IndexSize")]
            [Validation(Required=false)]
            public long? IndexSize { get; set; }

            /// <summary>
            /// <para>The size of hot data. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24696061952</para>
            /// </summary>
            [NameInMap("LocalDataSize")]
            [Validation(Required=false)]
            public long? LocalDataSize { get; set; }

            /// <summary>
            /// <para>The data size of the primary key index. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2147483648</para>
            /// </summary>
            [NameInMap("PrimaryKeySize")]
            [Validation(Required=false)]
            public long? PrimaryKeySize { get; set; }

            /// <summary>
            /// <para>The size of cold data. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RemoteDataSize")]
            [Validation(Required=false)]
            public long? RemoteDataSize { get; set; }

            /// <summary>
            /// <para>The number of rows in the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3294</para>
            /// </summary>
            [NameInMap("RowCount")]
            [Validation(Required=false)]
            public long? RowCount { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adb_demo</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The storage percentage of the table. Unit: %.</para>
            /// <remarks>
            /// <para> Formula: Table storage percentage = Total data size of a table/Total data size of the cluster × 100%.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("SpaceRatio")]
            [Validation(Required=false)]
            public double? SpaceRatio { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
