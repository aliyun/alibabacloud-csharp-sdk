// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListMmsTasksRequest : TeaModel {
        [NameInMap("sorter")]
        [Validation(Required=false)]
        public ListMmsTasksRequestSorter Sorter { get; set; }
        public class ListMmsTasksRequestSorter : TeaModel {
            /// <summary>
            /// <para>Sorts results by the start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>Sorts results by status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asc</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The destination MaxCompute project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mms_test</para>
        /// </summary>
        [NameInMap("dstDbName")]
        [Validation(Required=false)]
        public string DstDbName { get; set; }

        /// <summary>
        /// <para>The destination MaxCompute table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_table_1</para>
        /// </summary>
        [NameInMap("dstTableName")]
        [Validation(Required=false)]
        public string DstTableName { get; set; }

        /// <summary>
        /// <para>The migration job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("jobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

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
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The partition value. Use this parameter to filter migration tasks that migrated a specific partition value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p1=1/p2=abc</para>
        /// </summary>
        [NameInMap("partition")]
        [Validation(Required=false)]
        public string Partition { get; set; }

        /// <summary>
        /// <para>The source database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_db_1</para>
        /// </summary>
        [NameInMap("srcDbName")]
        [Validation(Required=false)]
        public string SrcDbName { get; set; }

        /// <summary>
        /// <para>The source table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_table_1</para>
        /// </summary>
        [NameInMap("srcTableName")]
        [Validation(Required=false)]
        public string SrcTableName { get; set; }

        /// <summary>
        /// <para>The migration task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATA_DOING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
