// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListUploadTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The file upload tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListUploadTasksResponseBodyTasks> Tasks { get; set; }
        public class ListUploadTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-26T01:56:15Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error message returned when the file upload task failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>invalid url</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The error code. Multiple error codes are separated by commas (,).</para>
            /// <list type="bullet">
            /// <item><description><b>InvalidUrl</b>: The URL format is incorrect.</description></item>
            /// <item><description><b>InvalidDomain</b>: The domain ownership fails to be verified.</description></item>
            /// <item><description><b>QuotaExcess</b>: The quota limit has been reached.</description></item>
            /// <item><description><b>OtherErrors</b>: Other errors.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidUrl,InvalidDomain</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The task status.</para>
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
            /// <item><description><b>file</b>: purges the cache by file URL.</description></item>
            /// <item><description><b>preload</b>: prefetches files.</description></item>
            /// <item><description><b>directory</b>: purges the cache by directory.</description></item>
            /// <item><description><b>ignoreparams</b>: purges the cache by URL with specified parameters ignored.</description></item>
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
