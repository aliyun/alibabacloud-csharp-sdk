// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetMmsTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The migration task object.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMmsTaskResponseBodyData Data { get; set; }
        public class GetMmsTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-25 04:21:01</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The source database ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("dbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// <para>The destination MaxCompute project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mms_target</para>
            /// </summary>
            [NameInMap("dstDbName")]
            [Validation(Required=false)]
            public string DstDbName { get; set; }

            /// <summary>
            /// <para>The destination MaxCompute schema.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("dstSchemaName")]
            [Validation(Required=false)]
            public string DstSchemaName { get; set; }

            /// <summary>
            /// <para>The destination MaxCompute table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table_1</para>
            /// </summary>
            [NameInMap("dstTableName")]
            [Validation(Required=false)]
            public string DstTableName { get; set; }

            /// <summary>
            /// <para>The end time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-25 07:21:01</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The migration task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7680</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The migration job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>87</para>
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            /// <summary>
            /// <para>The migration job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_odps_spark</para>
            /// </summary>
            [NameInMap("jobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The number of times the task has been retried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("retriedTimes")]
            [Validation(Required=false)]
            public int? RetriedTimes { get; set; }

            /// <summary>
            /// <para>Indicates if the task is running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("running")]
            [Validation(Required=false)]
            public bool? Running { get; set; }

            /// <summary>
            /// <para>The data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000015</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }

            /// <summary>
            /// <para>The data source name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("sourceName")]
            [Validation(Required=false)]
            public string SourceName { get; set; }

            /// <summary>
            /// <para>The source database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mms_test</para>
            /// </summary>
            [NameInMap("srcDbName")]
            [Validation(Required=false)]
            public string SrcDbName { get; set; }

            /// <summary>
            /// <para>The name of the source schema. This refers to the schema in a Layer 3 namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("srcSchemaName")]
            [Validation(Required=false)]
            public string SrcSchemaName { get; set; }

            /// <summary>
            /// <para>The source table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table_1</para>
            /// </summary>
            [NameInMap("srcTableName")]
            [Validation(Required=false)]
            public string SrcTableName { get; set; }

            /// <summary>
            /// <para>The start time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-25 06:21:01</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The migration task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DATA_DOING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Indicates if the task is stopped.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("stopped")]
            [Validation(Required=false)]
            public bool? Stopped { get; set; }

            /// <summary>
            /// <para>The source table ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2323</para>
            /// </summary>
            [NameInMap("tableId")]
            [Validation(Required=false)]
            public long? TableId { get; set; }

            /// <summary>
            /// <para>The task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BIGQUERY</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>73207140-0FD5-588A-B11A-3CE093924196</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
