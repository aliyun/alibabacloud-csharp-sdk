// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeTableStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>am-****************</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>4428120064</para>
                /// </summary>
                [NameInMap("ColdDataSize")]
                [Validation(Required=false)]
                public long? ColdDataSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>15592</para>
                /// </summary>
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("HotDataSize")]
                [Validation(Required=false)]
                public long? HotDataSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3076</para>
                /// </summary>
                [NameInMap("IndexSize")]
                [Validation(Required=false)]
                public long? IndexSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("OtherSize")]
                [Validation(Required=false)]
                public long? OtherSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PartitionCount")]
                [Validation(Required=false)]
                public long? PartitionCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>16340</para>
                /// </summary>
                [NameInMap("PrimaryKeyIndexSize")]
                [Validation(Required=false)]
                public long? PrimaryKeyIndexSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RowCount")]
                [Validation(Required=false)]
                public long? RowCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_schema</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>66.23</para>
                /// </summary>
                [NameInMap("SpaceRatio")]
                [Validation(Required=false)]
                public double? SpaceRatio { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_table</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1577</para>
                /// </summary>
                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public long? TotalSize { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4C4433FF-5D3A-4C3E-A19C-6D93B2******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[\&quot;adb_platform\&quot;, \&quot;adb_ai\&quot;, \&quot;adb_data\&quot;]</para>
        /// </summary>
        [NameInMap("SchemaNames")]
        [Validation(Required=false)]
        public string SchemaNames { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>693</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
