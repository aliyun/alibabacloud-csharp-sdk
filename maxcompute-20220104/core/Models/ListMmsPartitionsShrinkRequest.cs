// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListMmsPartitionsShrinkRequest : TeaModel {
        [NameInMap("sorter")]
        [Validation(Required=false)]
        public ListMmsPartitionsShrinkRequestSorter Sorter { get; set; }
        public class ListMmsPartitionsShrinkRequestSorter : TeaModel {
            /// <summary>
            /// <para>Sorts by lastDdlTime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("lastDdlTime")]
            [Validation(Required=false)]
            public string LastDdlTime { get; set; }

            /// <summary>
            /// <para>Sorts by number of rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("numRows")]
            [Validation(Required=false)]
            public string NumRows { get; set; }

            /// <summary>
            /// <para>Sorts by data size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asc</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        /// <summary>
        /// <para>The database ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("dbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d1</para>
        /// </summary>
        [NameInMap("dbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The maximum lastDdlTime value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-17 19:44:42</para>
        /// </summary>
        [NameInMap("lastDdlTimeEnd")]
        [Validation(Required=false)]
        public string LastDdlTimeEnd { get; set; }

        /// <summary>
        /// <para>The minimum lastDdlTime value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-17 15:44:42</para>
        /// </summary>
        [NameInMap("lastDdlTimeStart")]
        [Validation(Required=false)]
        public string LastDdlTimeStart { get; set; }

        /// <summary>
        /// <para>The page number to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The migration status.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string StatusShrink { get; set; }

        /// <summary>
        /// <para>The ID of the table that contains the partition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20323</para>
        /// </summary>
        [NameInMap("tableId")]
        [Validation(Required=false)]
        public long? TableId { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t1</para>
        /// </summary>
        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>Filters partitions whose metadata has been updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("updated")]
        [Validation(Required=false)]
        public bool? Updated { get; set; }

        /// <summary>
        /// <para>The partition value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p1=1/p2=abc</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
