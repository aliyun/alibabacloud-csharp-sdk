// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeTableStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The queried table statistics.</para>
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
                /// <para>The cold data size. Unit: bytes.</para>
                /// <remarks>
                /// <para> The parameter is returned only for AnalyticDB for MySQL clusters of V3.1.3.4 or later.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ColdDataSize")]
                [Validation(Required=false)]
                public long? ColdDataSize { get; set; }

                /// <summary>
                /// <para>The data size of table records. Unit: bytes.</para>
                /// <remarks>
                /// <para> The data size of table records, excluding the data size of regular index and primary key indexes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>15592</para>
                /// </summary>
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                /// <summary>
                /// <para>The hot data size. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("HotDataSize")]
                [Validation(Required=false)]
                public long? HotDataSize { get; set; }

                /// <summary>
                /// <para>The data size of regular indexes. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3076</para>
                /// </summary>
                [NameInMap("IndexSize")]
                [Validation(Required=false)]
                public long? IndexSize { get; set; }

                /// <summary>
                /// <para>The data size of other data. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("OtherSize")]
                [Validation(Required=false)]
                public long? OtherSize { get; set; }

                /// <summary>
                /// <para>The number of partitions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PartitionCount")]
                [Validation(Required=false)]
                public long? PartitionCount { get; set; }

                /// <summary>
                /// <para>The data size of primary key indexes. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16340</para>
                /// </summary>
                [NameInMap("PrimaryKeyIndexSize")]
                [Validation(Required=false)]
                public long? PrimaryKeyIndexSize { get; set; }

                /// <summary>
                /// <para>The number of rows in the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RowCount")]
                [Validation(Required=false)]
                public long? RowCount { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_schema</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The percentage of the table size. Unit: %.</para>
                /// <remarks>
                /// <para> Formula: Table storage percentage = Total data size of a table/Total data size of the cluster × 100%.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>66.23</para>
                /// </summary>
                [NameInMap("SpaceRatio")]
                [Validation(Required=false)]
                public double? SpaceRatio { get; set; }

                /// <summary>
                /// <para>The name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_table</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The total data size. Unit: bytes.</para>
                /// <remarks>
                /// <para> The following formulas can be used to calculate the total data size: Formula 1: Total data size = Hot data size + Cold data size. Formula 2: Total data size = Data size of table records + Data size of regular indexes + Data size of primary key indexes + Data size of other data.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1577</para>
                /// </summary>
                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public long? TotalSize { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C4433FF-5D3A-4C3E-A19C-6D93B2******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SchemaNames")]
        [Validation(Required=false)]
        public string SchemaNames { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
