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

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeTableStatisticsResponseBodyItems Items { get; set; }
        public class DescribeTableStatisticsResponseBodyItems : TeaModel {
            [NameInMap("TableStatisticRecords")]
            [Validation(Required=false)]
            public List<DescribeTableStatisticsResponseBodyItemsTableStatisticRecords> TableStatisticRecords { get; set; }
            public class DescribeTableStatisticsResponseBodyItemsTableStatisticRecords : TeaModel {
                [NameInMap("ColdDataSize")]
                [Validation(Required=false)]
                public long? ColdDataSize { get; set; }

                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                [NameInMap("HotDataSize")]
                [Validation(Required=false)]
                public long? HotDataSize { get; set; }

                [NameInMap("IndexSize")]
                [Validation(Required=false)]
                public long? IndexSize { get; set; }

                [NameInMap("OtherSize")]
                [Validation(Required=false)]
                public long? OtherSize { get; set; }

                [NameInMap("PartitionCount")]
                [Validation(Required=false)]
                public long? PartitionCount { get; set; }

                [NameInMap("PrimaryKeyIndexSize")]
                [Validation(Required=false)]
                public long? PrimaryKeyIndexSize { get; set; }

                [NameInMap("RowCount")]
                [Validation(Required=false)]
                public long? RowCount { get; set; }

                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                [NameInMap("SpaceRatio")]
                [Validation(Required=false)]
                public double? SpaceRatio { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

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
