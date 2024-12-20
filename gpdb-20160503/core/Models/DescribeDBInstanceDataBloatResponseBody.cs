// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceDataBloatResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried data bloat.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceDataBloatResponseBodyItems> Items { get; set; }
        public class DescribeDBInstanceDataBloatResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The coefficient of data bloat. It is calculated by using the following formula:</para>
            /// <para>Bloat coefficient = Number of dead rows/Number of active rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.03</para>
            /// </summary>
            [NameInMap("BloatCeoff")]
            [Validation(Required=false)]
            public string BloatCeoff { get; set; }

            /// <summary>
            /// <para>The bloat size of the table. It indicates the amount of space that can be released.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2MB</para>
            /// </summary>
            [NameInMap("BloatSize")]
            [Validation(Required=false)]
            public string BloatSize { get; set; }

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
            /// <para>The expected size of the table.</para>
            /// <para>It indicates the size of the table that has no data bloat.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1MB</para>
            /// </summary>
            [NameInMap("ExpectTableSize")]
            [Validation(Required=false)]
            public string ExpectTableSize { get; set; }

            /// <summary>
            /// <para>The actual size of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2MB</para>
            /// </summary>
            [NameInMap("RealTableSize")]
            [Validation(Required=false)]
            public string RealTableSize { get; set; }

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
            /// <para>The sequence number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>The storage type of the table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Heap Table</b></description></item>
            /// <item><description><b>Append-Only Heap Table</b></description></item>
            /// <item><description><b>Append-Only Columnar Table</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Heap Table</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>This parameter is not returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("SuggestedAction")]
            [Validation(Required=false)]
            public string SuggestedAction { get; set; }

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
            /// <para>The time when the table was last deleted, inserted, or updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-08T20:00:00Z</para>
            /// </summary>
            [NameInMap("TimeLastUpdated")]
            [Validation(Required=false)]
            public string TimeLastUpdated { get; set; }

            /// <summary>
            /// <para>The time when the table was last vacuumed. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-08T16:00:00Z</para>
            /// </summary>
            [NameInMap("TimeLastVacuumed")]
            [Validation(Required=false)]
            public string TimeLastVacuumed { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
