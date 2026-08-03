// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListRecycleBinJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of task information in the recycle bin.</para>
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<ListRecycleBinJobsResponseBodyJobs> Jobs { get; set; }
        public class ListRecycleBinJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// <para>The time when the task was created. The time follows the ISO 8601 standard in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// <para>This value is valid only when Status is Fail or PartialSuccess.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidFileId.NotFound</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// <para>This value is valid only when JobStatus is Fail or PartialSuccess.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The Target File or Directory does not exist.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The FileId of the file or directory associated with the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04***08</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The name of the file or directory associated with the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test001</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8C****C54</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The execution progress of the task.</para>
            /// <para>Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running: The task is running.</description></item>
            /// <item><description>Defragmenting: Data is being defragmented.</description></item>
            /// <item><description>PartialSuccess: The task partially succeeded.</description></item>
            /// <item><description>Success: The task succeeded.</description></item>
            /// <item><description>Fail: The task failed.</description></item>
            /// <item><description>Cancelled: The task is canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Fail</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Restore: A file restoration task.</description></item>
            /// <item><description>Delete: A file deletion task.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Restore</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of tasks per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E15E394-38A6-457A-A62A-D9797C9A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of tasks in the recycle bin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
