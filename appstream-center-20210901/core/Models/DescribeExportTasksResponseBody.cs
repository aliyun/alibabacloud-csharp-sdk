// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DescribeExportTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of tasks that meet the query conditions. This value is independent of the number of tasks returned on the current page and can be used with PageSize to calculate the total number of pages. If no tasks meet the conditions, 0 is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of export tasks, sorted in descending order of task creation time, with the most recently created tasks listed first. If no tasks meet the conditions, an empty array is returned.</para>
        /// </summary>
        [NameInMap("ExportTaskModel")]
        [Validation(Required=false)]
        public List<DescribeExportTasksResponseBodyExportTaskModel> ExportTaskModel { get; set; }
        public class DescribeExportTasksResponseBodyExportTaskModel : TeaModel {
            /// <summary>
            /// <para>The task creation time, in yyyy-MM-dd HH:mm:ss format, accurate to seconds. The returned string does not include the time zone offset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-27 19:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The OSS pre-signed download URL of the export file. This field is returned only for tasks whose Status is FINISHED. The default maximum validity period of the signature is 1 hour and does not exceed the 24-hour validity period after the task is created. When the remaining validity period is less than 10 minutes, the server automatically refreshes and returns a new URL. If the task is not completed, the task has expired, or the URL refresh fails, this field is empty. The domain name and path in the example URL are for illustration purposes only. The actual returned value is a complete URL with signature parameters. Use the URL returned by the most recent query for downloading.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.oss-cn-hangzhou.aliyuncs.com/">https://example.oss-cn-hangzhou.aliyuncs.com/</a>...</para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The cause of the task execution failure. This field is returned only when Status is FAILED. The content is the English error description recorded by the server and can be directly displayed to users or used for troubleshooting. In other states, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The export sub type is not supported.</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The export file name, which consists of the task type, task creation time (in yyyyMMddHHmmss format), and the first 8 characters of the task ID, connected by underscores. The file extension is .xlsx. If the file is not generated, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WUYING_SERVER_LIST_20260727190000_8119078c.xlsx</para>
            /// </summary>
            [NameInMap("ExportFileName")]
            [Validation(Required=false)]
            public string ExportFileName { get; set; }

            /// <summary>
            /// <para>The export task progress, in percentage. Valid values: 0 to 100. This value is updated based on the execution stage of the task and is 100 when the task is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public float? Progress { get; set; }

            /// <summary>
            /// <para>The export task status. This operation returns the following values:</para>
            /// <list type="bullet">
            /// <item><description>INIT: The task is created and waiting to be executed. Continue polling.</description></item>
            /// <item><description>RUNNING: The export file is being generated. You can display the progress based on Progress and continue polling.</description></item>
            /// <item><description>FINISHED: The export file is generated. Stop polling and use DownloadUrl to download the file.</description></item>
            /// <item><description>FAILED: The task execution failed. Stop polling and check ErrorMsg.</description></item>
            /// </list>
            /// <para>The server also has an internal EXPIRED state, but this operation does not return tasks in this state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The export task ID, which is a 32-character UUID string without hyphens. You can use this value as the TaskId parameter of this operation to poll the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8119078c29e948dba2e0a9917995332a</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The export task type. For the meaning of each value, see the TaskType request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WUYING_SERVER_LIST</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The actual page number used in this query, which is the echoed value of the PageNumber request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The actual number of tasks per page used in this query, which is the echoed value of the PageSize request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate call records and troubleshoot issues. The example value is partially masked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D4A13D91-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
