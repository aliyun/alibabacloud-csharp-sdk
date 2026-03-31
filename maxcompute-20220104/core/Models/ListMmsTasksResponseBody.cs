// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListMmsTasksResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListMmsTasksResponseBodyData Data { get; set; }
        public class ListMmsTasksResponseBodyData : TeaModel {
            [NameInMap("objectList")]
            [Validation(Required=false)]
            public List<ListMmsTasksResponseBodyDataObjectList> ObjectList { get; set; }
            public class ListMmsTasksResponseBodyDataObjectList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-10-25 04:21:01</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>196</para>
                /// </summary>
                [NameInMap("dbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mms_test</para>
                /// </summary>
                [NameInMap("dstDbName")]
                [Validation(Required=false)]
                public string DstDbName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("dstSchemaName")]
                [Validation(Required=false)]
                public string DstSchemaName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>table_1</para>
                /// </summary>
                [NameInMap("dstTableName")]
                [Validation(Required=false)]
                public string DstTableName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-10-25 07:21:01</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2323</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>87</para>
                /// </summary>
                [NameInMap("jobId")]
                [Validation(Required=false)]
                public long? JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_odps_spark</para>
                /// </summary>
                [NameInMap("jobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("retriedTimes")]
                [Validation(Required=false)]
                public int? RetriedTimes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("running")]
                [Validation(Required=false)]
                public bool? Running { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000028</para>
                /// </summary>
                [NameInMap("sourceId")]
                [Validation(Required=false)]
                public long? SourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("sourceName")]
                [Validation(Required=false)]
                public string SourceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>db_1</para>
                /// </summary>
                [NameInMap("srcDbName")]
                [Validation(Required=false)]
                public string SrcDbName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("srcSchemaName")]
                [Validation(Required=false)]
                public string SrcSchemaName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>table_1</para>
                /// </summary>
                [NameInMap("srcTableName")]
                [Validation(Required=false)]
                public string SrcTableName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-10-25 06:21:01</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DATA_DOING</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("stopped")]
                [Validation(Required=false)]
                public bool? Stopped { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("tableId")]
                [Validation(Required=false)]
                public long? TableId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BIGQUERY</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>373A5CB2-8570-53BE-A98F-729B11D7A8B0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
