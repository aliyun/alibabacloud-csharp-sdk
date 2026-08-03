// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ListLifecycleRetrieveJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of data retrieval task information.</para>
        /// </summary>
        [NameInMap("LifecycleRetrieveJobs")]
        [Validation(Required=false)]
        public List<ListLifecycleRetrieveJobsResponseBodyLifecycleRetrieveJobs> LifecycleRetrieveJobs { get; set; }
        public class ListLifecycleRetrieveJobsResponseBodyLifecycleRetrieveJobs : TeaModel {
            /// <summary>
            /// <para>The time when the task was created.</para>
            /// <para>The time follows the ISO 8601 standard in the format of <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-30T10:08:08Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The total number of files read by the data retrieval task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DiscoveredFileCount")]
            [Validation(Required=false)]
            public long? DiscoveredFileCount { get; set; }

            /// <summary>
            /// <para>The file system ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31a8e4****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The data retrieval task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lrj-nfstest-ia-160****853-hshvw</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The execution paths of the data retrieval task.</para>
            /// </summary>
            [NameInMap("Paths")]
            [Validation(Required=false)]
            public List<string> Paths { get; set; }

            /// <summary>
            /// <para>The number of files successfully retrieved by the data retrieval task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("RetrievedFileCount")]
            [Validation(Required=false)]
            public long? RetrievedFileCount { get; set; }

            /// <summary>
            /// <para>The status of the data retrieval task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>active: running.</description></item>
            /// <item><description>canceled: canceled.</description></item>
            /// <item><description>completed: completed.</description></item>
            /// <item><description>failed: failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The storage class. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>InfrequentAccess: IA storage class.</description></item>
            /// <item><description>Archive: Archive storage class.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InfrequentAccess</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The time when the task was last updated.</para>
            /// <para>The time follows the ISO 8601 standard in the format of <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-30T11:08:08Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The page number of the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of data retrieval tasks on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC7C825C-5F65-4B56-BEF6-98C56C7C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of data retrieval tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
