// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveSnapshotJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of jobs.</para>
        /// </summary>
        [NameInMap("JobList")]
        [Validation(Required=false)]
        public List<ListLiveSnapshotJobsResponseBodyJobList> JobList { get; set; }
        public class ListLiveSnapshotJobsResponseBodyJobList : TeaModel {
            /// <summary>
            /// <para>The time when the template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20T02:48:58Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>a046-263c-3560-978a-fb287782</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The name of the job.</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The output information.</para>
            /// </summary>
            [NameInMap("SnapshotOutput")]
            [Validation(Required=false)]
            public ListLiveSnapshotJobsResponseBodyJobListSnapshotOutput SnapshotOutput { get; set; }
            public class ListLiveSnapshotJobsResponseBodyJobListSnapshotOutput : TeaModel {
                /// <summary>
                /// <para>The bucket of the output endpoint. If the storage type is set to oss, the OSS bucket is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testbucket</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>The output endpoint. If the storage type is set to oss, the Object Storage Service (OSS) domain name is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The storage type. The value can only be oss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

            }

            /// <summary>
            /// <para>The state of the job.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>init: The job is not started.</description></item>
            /// <item><description>paused: The job is paused.</description></item>
            /// <item><description>started: The job is in progress.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>started</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>a046-263c-3560-978a-fb287666</b></b></para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The interval between two adjacent snapshots. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TimeInterval")]
            [Validation(Required=false)]
            public int? TimeInterval { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The sorting order of the jobs by creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
