// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetStreamTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The basic information and running information of the real-time task instance. The fileId can be used to subsequently query operation records and historical running instances.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetStreamTaskResponseBodyData Data { get; set; }
        public class GetStreamTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time corresponding to the latest read position. The format is yyyy-MM-dd HH:mm:ss. If no consumption metrics are available, the value is null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-15 13:45:52</para>
            /// </summary>
            [NameInMap("ConsumeLocationDate")]
            [Validation(Required=false)]
            public string ConsumeLocationDate { get; set; }

            /// <summary>
            /// <para>The database engine version of the compute DPI engine used to run the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.15.3</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The ID of the task file. This corresponds to the FileId request parameter in ListStreamOpsRecords and ListStreamInstanceRecords. It is not a nodeId or a template file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7333610201479808</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The name of the node to which the real-time task belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rt_mysql_doris</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the node. The ID starts with n_ and identifies a development node. It is different from the task file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n_8442437168737681408</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The ID of the user who last operated the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30001011</para>
            /// </summary>
            [NameInMap("OperatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }

            /// <summary>
            /// <para>The display name of the user who last operated the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alice</para>
            /// </summary>
            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            /// <summary>
            /// <para>The ID of the Dataphin project to which the task belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7299592831043008</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The project mode. Valid values: BASIC for the basic mode, and DEV_PROD for the development-production isolation mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BASIC</para>
            /// </summary>
            [NameInMap("ProjectMode")]
            [Validation(Required=false)]
            public string ProjectMode { get; set; }

            /// <summary>
            /// <para>The name of the Dataphin project to which the task belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>flink_k8s</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The display information of the resource queue used by the task, including the queue name and ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dedicated for real-time development (1052061)</para>
            /// </summary>
            [NameInMap("ResourceQueue")]
            [Validation(Required=false)]
            public string ResourceQueue { get; set; }

            /// <summary>
            /// <para>The running status of the task. The original TaskStatusEnum enumeration name is returned. Common real-time statuses include: STREAMING_STARTING (starting), STREAMING_RUNNING (running), STREAMING_PAUSING (pausing), STREAMING_PAUSED (paused), STREAMING_RESUMING (resuming), STREAMING_STOPPING (stopping), STREAMING_STOPPED (stopped), STREAMING_INIT (initial status), STREAMING_FAILED (running exception), STREAMING_START_FAILED (start exception), STREAMING_RESUME_FAILED (resume exception), and STREAMING_FINISHED (completed). Other known statuses also return the original enumeration name. If the status cannot be identified, UNKNOWN is returned. If the original status is empty, null is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STREAMING_RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Instance ID of the real-time task instance. Instance ID starts with t_ and corresponds to the TaskId request parameter in GetStreamTask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t_8442437168737681408_20261014_8442447717177229312</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The type of the task, such as REAL_TIME_PIPELINE (real-time integration), FLINK_SQL (SQL task), FLINK_TEMPLATE_SQL (template task), and FLINK_DATASTREAM (DataStream task).</para>
            /// 
            /// <b>Example:</b>
            /// <para>REAL_TIME_PIPELINE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backend response exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
