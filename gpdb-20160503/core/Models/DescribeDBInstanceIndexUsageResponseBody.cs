// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceIndexUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried index usage.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceIndexUsageResponseBodyItems> Items { get; set; }
        public class DescribeDBInstanceIndexUsageResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adbtest</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>The definition of the index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE INDEX idx1 ON schema1.tab1_ptr_2010</para>
            /// </summary>
            [NameInMap("IndexDef")]
            [Validation(Required=false)]
            public string IndexDef { get; set; }

            /// <summary>
            /// <para>The name of the index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idx1</para>
            /// </summary>
            [NameInMap("IndexName")]
            [Validation(Required=false)]
            public string IndexName { get; set; }

            /// <summary>
            /// <para>The number of index scans.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("IndexScanTimes")]
            [Validation(Required=false)]
            public long? IndexScanTimes { get; set; }

            /// <summary>
            /// <para>The size of the index. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("IndexSize")]
            [Validation(Required=false)]
            public string IndexSize { get; set; }

            /// <summary>
            /// <para>Indicates whether the table is a partitioned table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The table is a partitioned table.</description></item>
            /// <item><description><b>false</b>: The table is not a partitioned table.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsPartitionTable")]
            [Validation(Required=false)]
            public bool? IsPartitionTable { get; set; }

            /// <summary>
            /// <para>The name of the parent table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tab1</para>
            /// </summary>
            [NameInMap("ParentTableName")]
            [Validation(Required=false)]
            public string ParentTableName { get; set; }

            /// <summary>
            /// <para>The name of the schema.</para>
            /// 
            /// <b>Example:</b>
            /// <para>schema1</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tab1_ptr_2010</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The time when the table was last deleted, inserted, or updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-08T20:00:00Z</para>
            /// </summary>
            [NameInMap("TimeLastUpdated")]
            [Validation(Required=false)]
            public string TimeLastUpdated { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
