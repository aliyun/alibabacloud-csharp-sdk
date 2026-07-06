// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoSyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Whether the request was successful.</para>
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
        /// <para>A list of sync tasks.</para>
        /// </summary>
        [NameInMap("SyncTasks")]
        [Validation(Required=false)]
        public List<ListRepoSyncTaskResponseBodySyncTasks> SyncTasks { get; set; }
        public class ListRepoSyncTaskResponseBodySyncTasks : TeaModel {
            /// <summary>
            /// <para>The creation time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1572839126000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Whether the image is synchronized across accounts. Valid values:</para>
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
            /// <para>Whether a custom sync link is used.</para>
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
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cri-kmsiwlxxdcva****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
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
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cri-k77rd2eo9zttneqo</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
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
            /// <para>The ID of the custom sync link.</para>
            /// </summary>
            [NameInMap("LinkId")]
            [Validation(Required=false)]
            public string LinkId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>This parameter is deprecated due to a typo. Use <c>ModifiedTime</c> instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1572839133000</para>
            /// </summary>
            [NameInMap("ModifedTime")]
            [Validation(Required=false)]
            [Obsolete]
            public long? ModifedTime { get; set; }

            /// <summary>
            /// <para>The modification time of the task.</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <para>The ID of the batch sync task. This ID is the same as the sync record ID (<c>SyncRecordId</c>).</para>
            /// <remarks>
            /// <para>If an image matches multiple sync rules, multiple sync tasks are generated. These tasks share the same <c>SyncBatchTaskId</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>9d8ac4f6-8138-4c15-a2e3-60624ad3****</para>
            /// </summary>
            [NameInMap("SyncBatchTaskId")]
            [Validation(Required=false)]
            public string SyncBatchTaskId { get; set; }

            /// <summary>
            /// <para>The ID of the sync rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crsr-7lph66uloi6h****</para>
            /// </summary>
            [NameInMap("SyncRuleId")]
            [Validation(Required=false)]
            public string SyncRuleId { get; set; }

            /// <summary>
            /// <para>The ID of the sync task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rst-4kfd7fk6pohk****</para>
            /// </summary>
            [NameInMap("SyncTaskId")]
            [Validation(Required=false)]
            public string SyncTaskId { get; set; }

            /// <summary>
            /// <para>Whether transfer acceleration is enabled for the sync task.</para>
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
            /// <para>If the sync task fails, this field returns details about the failure.</para>
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
            /// <item><description><para><c>PASSIVE</c>: The sync task is automatically triggered.</para>
            /// </description></item>
            /// <item><description><para><c>INITIATIVE</c>: The sync task is manually triggered.</para>
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
