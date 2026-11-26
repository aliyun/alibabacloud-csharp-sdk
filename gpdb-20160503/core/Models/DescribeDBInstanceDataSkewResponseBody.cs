// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceDataSkewResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of data skew details.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceDataSkewResponseBodyItems> Items { get; set; }
        public class DescribeDBInstanceDataSkewResponseBodyItems : TeaModel {
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
            /// <para>The distribution key of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ItemId</para>
            /// </summary>
            [NameInMap("DistributeKey")]
            [Validation(Required=false)]
            public string DistributeKey { get; set; }

            /// <summary>
            /// <para>The owner of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adbpguser</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

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
            /// <para>The sequence number. The entries are sorted in descending order of data skew.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tab1</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The total number of rows in the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000</para>
            /// </summary>
            [NameInMap("TableSize")]
            [Validation(Required=false)]
            public string TableSize { get; set; }

            /// <summary>
            /// <para>The data skew percentage of the table. Valid values: 0 to 100. Unit: %. A larger value indicates more severe data skew. A smaller value is more beneficial to the query performance of the database. A value of 0 indicates no data skew.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.23</para>
            /// </summary>
            [NameInMap("TableSkew")]
            [Validation(Required=false)]
            public string TableSkew { get; set; }

            /// <summary>
            /// <para>The time when the table was last updated by a DELETE, INSERT, or UPDATE operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-08T20:00:00Z</para>
            /// </summary>
            [NameInMap("TimeLastUpdated")]
            [Validation(Required=false)]
            public string TimeLastUpdated { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
