// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoSyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

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
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7640819A-FB5B-4E25-A227-97717F62****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of synchronization tasks.</para>
        /// </summary>
        [NameInMap("SyncTasks")]
        [Validation(Required=false)]
        public List<ListRepoSyncTaskResponseBodySyncTasks> SyncTasks { get; set; }
        public class ListRepoSyncTaskResponseBodySyncTasks : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1572839126000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the image is synchronized across accounts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: The image is synchronized across accounts.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: The image is synchronized within the same account.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>false</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CrossUser")]
            [Validation(Required=false)]
            public bool? CrossUser { get; set; }

            /// <summary>
            /// <para>Indicates whether a custom synchronization link is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CustomLink")]
            [Validation(Required=false)]
            public bool? CustomLink { get; set; }

            /// <summary>
            /// <para>The source image.</para>
            /// </summary>
            [NameInMap("ImageFrom")]
            [Validation(Required=false)]
            public ListRepoSyncTaskResponseBodySyncTasksImageFrom ImageFrom { get; set; }
            public class ListRepoSyncTaskResponseBodySyncTasksImageFrom : TeaModel {
                /// <summary>
                /// <para>The image tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v0.1</para>
                /// </summary>
                [NameInMap("ImageTag")]
                [Validation(Required=false)]
                public string ImageTag { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cri-kmsiwlxxdcva****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The repository name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// <para>The repository namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RepoNamespaceName")]
                [Validation(Required=false)]
                public string RepoNamespaceName { get; set; }

            }

            /// <summary>
            /// <para>The destination image.</para>
            /// </summary>
            [NameInMap("ImageTo")]
            [Validation(Required=false)]
            public ListRepoSyncTaskResponseBodySyncTasksImageTo ImageTo { get; set; }
            public class ListRepoSyncTaskResponseBodySyncTasksImageTo : TeaModel {
                /// <summary>
                /// <para>The image tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v0.1</para>
                /// </summary>
                [NameInMap("ImageTag")]
                [Validation(Required=false)]
                public string ImageTag { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cri-k77rd2eo9zttneqo</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The repository name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// <para>The repository namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RepoNamespaceName")]
                [Validation(Required=false)]
                public string RepoNamespaceName { get; set; }

            }

            /// <summary>
            /// <para>The custom synchronization link ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stl-b3fpik5nq6oy7***</para>
            /// </summary>
            [NameInMap("LinkId")]
            [Validation(Required=false)]
            public string LinkId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1572839133000</para>
            /// </summary>
            [NameInMap("ModifedTime")]
            [Validation(Required=false)]
            [Obsolete]
            public long? ModifedTime { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1572839133000</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <para>The execution priority of the synchronization task. Synchronization tasks are executed in descending order of priority. Tasks with the same priority are executed in random order.</para>
            /// <para>Valid values: 1 to 5.</para>
            /// <para>Default value: 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The batch synchronization task ID for images, which corresponds to the SyncRecordId (synchronization task record ID) in the request parameters.</para>
            /// <remarks>
            /// <para>When an image matches multiple synchronization rules and generates multiple synchronization tasks, these tasks share the same SyncBatchTaskId.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>9d8ac4f6-8138-4c15-a2e3-60624ad3****</para>
            /// </summary>
            [NameInMap("SyncBatchTaskId")]
            [Validation(Required=false)]
            public string SyncBatchTaskId { get; set; }

            /// <summary>
            /// <para>The synchronization rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crsr-7lph66uloi6h****</para>
            /// </summary>
            [NameInMap("SyncRuleId")]
            [Validation(Required=false)]
            public string SyncRuleId { get; set; }

            /// <summary>
            /// <para>The synchronization task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rst-4kfd7fk6pohk****</para>
            /// </summary>
            [NameInMap("SyncTaskId")]
            [Validation(Required=false)]
            public string SyncTaskId { get; set; }

            /// <summary>
            /// <para>The synchronization transfer acceleration status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SyncTransAccelerate")]
            [Validation(Required=false)]
            public bool? SyncTransAccelerate { get; set; }

            /// <summary>
            /// <para>The task failure information.</para>
            /// <remarks>
            /// <para>When a synchronization task fails, this field returns information about the failure.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>NETWORK_ERROR</para>
            /// </summary>
            [NameInMap("TaskIssue")]
            [Validation(Required=false)]
            public string TaskIssue { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ERROR</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>The trigger policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PASSIVE</c>: Synchronization is automatically triggered.</para>
            /// </description></item>
            /// <item><description><para><c>INITIATIVE</c>: Synchronization is manually triggered.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>PASSIVE</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>PASSIVE</para>
            /// </summary>
            [NameInMap("TaskTrigger")]
            [Validation(Required=false)]
            public string TaskTrigger { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
