// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListMmsTablesRequest : TeaModel {
        [NameInMap("sorter")]
        [Validation(Required=false)]
        public ListMmsTablesRequestSorter Sorter { get; set; }
        public class ListMmsTablesRequestSorter : TeaModel {
            /// <summary>
            /// <para>The sort order for lastDdlTime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("lastDdlTime")]
            [Validation(Required=false)]
            public string LastDdlTime { get; set; }

            /// <summary>
            /// <para>The sort order for the number of rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("numRows")]
            [Validation(Required=false)]
            public string NumRows { get; set; }

            /// <summary>
            /// <para>The sort order for the data size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asc</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        /// <summary>
        /// <para>The ID of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>197</para>
        /// </summary>
        [NameInMap("dbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mms_test</para>
        /// </summary>
        [NameInMap("dbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The name of the destination MaxCompute table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("dstName")]
        [Validation(Required=false)]
        public string DstName { get; set; }

        /// <summary>
        /// <para>The name of the destination MaxCompute project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mms_test</para>
        /// </summary>
        [NameInMap("dstProjectName")]
        [Validation(Required=false)]
        public string DstProjectName { get; set; }

        /// <summary>
        /// <para>The name of the destination MaxCompute schema. This parameter is null if the destination MaxCompute project does not have a schema layer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("dstSchemaName")]
        [Validation(Required=false)]
        public string DstSchemaName { get; set; }

        /// <summary>
        /// <para>The partitioned table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasPartitions")]
        [Validation(Required=false)]
        public bool? HasPartitions { get; set; }

        /// <summary>
        /// <para>The end of the time range for lastDdlTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-19 15:44:42</para>
        /// </summary>
        [NameInMap("lastDdlTimeEnd")]
        [Validation(Required=false)]
        public string LastDdlTimeEnd { get; set; }

        /// <summary>
        /// <para>The start of the time range for lastDdlTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-17 15:44:42</para>
        /// </summary>
        [NameInMap("lastDdlTimeStart")]
        [Validation(Required=false)]
        public string LastDdlTimeStart { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only the names of the tables.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("onlyName")]
        [Validation(Required=false)]
        public bool? OnlyName { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The migration status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

        /// <summary>
        /// <para>The table type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MANAGED_TABLE</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
