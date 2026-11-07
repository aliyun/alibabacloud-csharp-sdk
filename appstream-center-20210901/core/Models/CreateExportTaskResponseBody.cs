// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateExportTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the newly created export task. When the task is created, Status is INIT, Progress is 0, and the download URL and error message are empty.</para>
        /// </summary>
        [NameInMap("ExportTaskModel")]
        [Validation(Required=false)]
        public CreateExportTaskResponseBodyExportTaskModel ExportTaskModel { get; set; }
        public class CreateExportTaskResponseBodyExportTaskModel : TeaModel {
            /// <summary>
            /// <para>The time when the task was created. The time is in the yyyy-MM-dd HH:mm:ss format, accurate to seconds. The returned string does not include the time zone offset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-27 19:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The download URL of the exported file. When the task is created by calling this operation, the file is not generated and this field is empty. The null in the example represents a JSON null value, not the string &quot;null&quot;. You can subsequently call DescribeExportTasks to query the latest download URL of the completed task and use it within the validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The error message when the task execution fails. When the task is created by calling this operation, this field is empty. The null in the example represents a JSON null value, not the string &quot;null&quot;. When you query the task status and it is FAILED, you can use this field to identify the cause of the failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The progress of the export task. The value is a percentage ranging from 0 to 100. When the task is created by calling this operation, 0 is returned. The value is updated based on the execution phase and reaches 100 when the task is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public float? Progress { get; set; }

            /// <summary>
            /// <para>The status of the task. When the task is created by calling this operation, INIT (initialized and waiting for execution) is returned. You can subsequently call DescribeExportTasks to query RUNNING (executing), FINISHED (completed), or FAILED (failed). Do not treat INIT as export completion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INIT</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the newly created export task. The value is a 32-character UUID string without hyphens. You can use this value as the TaskId parameter to query the task in DescribeExportTasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8119078c29e948dba2e0a9917995332a</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The type of the export task. The value is the same as the TaskType in the request. For the meaning of each type, see the TaskType request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WUYING_SERVER_LIST</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate call records and troubleshoot issues. The example value is partially desensitized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D30C5D6-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
