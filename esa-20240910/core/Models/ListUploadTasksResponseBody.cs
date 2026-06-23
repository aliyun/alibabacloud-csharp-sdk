// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListUploadTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of file upload tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListUploadTasksResponseBodyTasks> Tasks { get; set; }
        public class ListUploadTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The creation time in ISO 8601 format (for example, 2024-01-01T00:00:00+Z).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-26T01:56:15Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error message returned when the file upload task fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>invalid url</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The error code. Multiple error codes are separated by commas. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>InvalidUrl</b>: The URL format is invalid.</description></item>
            /// <item><description><b>InvalidDomain</b>: The domain name ownership verification failed.</description></item>
            /// <item><description><b>QuotaExcess</b>: The quota limit is exceeded.</description></item>
            /// <item><description><b>OtherErrors</b>: Other errors occurred.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidUrl,InvalidDomain</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Complete</b>: The task is complete.</description></item>
            /// <item><description><b>Refreshing</b>: The task is in progress.</description></item>
            /// <item><description><b>Failed</b>: The task failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Complete</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>file</b>: URL file purge.</description></item>
            /// <item><description><b>preload</b>: resource prefetch.</description></item>
            /// <item><description><b>directory</b>: directory purge.</description></item>
            /// <item><description><b>ignoreparams</b>: purge with parameters ignored.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>file</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The ID of the file upload task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>159253299357****</para>
            /// </summary>
            [NameInMap("UploadId")]
            [Validation(Required=false)]
            public string UploadId { get; set; }

            /// <summary>
            /// <para>The name of the file upload task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>purge_file_task</para>
            /// </summary>
            [NameInMap("UploadTaskName")]
            [Validation(Required=false)]
            public string UploadTaskName { get; set; }

        }

    }

}
