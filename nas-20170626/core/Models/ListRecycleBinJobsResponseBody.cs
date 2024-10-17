// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListRecycleBinJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the jobs of the recycle bin.</para>
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<ListRecycleBinJobsResponseBodyJobs> Jobs { get; set; }
        public class ListRecycleBinJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// <para>The time when the job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error code returned.</para>
            /// <para>A valid value is returned only if you set the Status parameter to Fail or PartialSuccess.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidFileId.NotFound</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// <para>A valid value is returned only if you set the Status parameter to Fail or PartialSuccess.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The Target File or Directory does not exist.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The ID of the file or directory in the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04***08</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The name of the file or directory that is associated with the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test001</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8C****C54</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The progress of the job.</para>
            /// <para>Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The status of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running: The job is running.</description></item>
            /// <item><description>Defragmenting: The job is defragmenting data.</description></item>
            /// <item><description>PartialSuccess: The job is partially completed.</description></item>
            /// <item><description>Success: The job is completed.</description></item>
            /// <item><description>Fail: The job failed.</description></item>
            /// <item><description>Cancelled: The job is canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Fail</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Restore: a file restoration job</description></item>
            /// <item><description>Delete: a file deletion job</description></item>
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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of jobs returned per page.</para>
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
        /// <para>The total number of jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
