// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoSyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7640819A-FB5B-4E25-A227-97717F62****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details about synchronization tasks.</para>
        /// </summary>
        [NameInMap("SyncTasks")]
        [Validation(Required=false)]
        public List<ListRepoSyncTaskResponseBodySyncTasks> SyncTasks { get; set; }
        public class ListRepoSyncTaskResponseBodySyncTasks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1572839126000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CrossUser")]
            [Validation(Required=false)]
            public bool? CrossUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CustomLink")]
            [Validation(Required=false)]
            public bool? CustomLink { get; set; }

            [NameInMap("ImageFrom")]
            [Validation(Required=false)]
            public ListRepoSyncTaskResponseBodySyncTasksImageFrom ImageFrom { get; set; }
            public class ListRepoSyncTaskResponseBodySyncTasksImageFrom : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>v0.1</para>
                /// </summary>
                [NameInMap("ImageTag")]
                [Validation(Required=false)]
                public string ImageTag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cri-kmsiwlxxdcva****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RepoNamespaceName")]
                [Validation(Required=false)]
                public string RepoNamespaceName { get; set; }

            }

            [NameInMap("ImageTo")]
            [Validation(Required=false)]
            public ListRepoSyncTaskResponseBodySyncTasksImageTo ImageTo { get; set; }
            public class ListRepoSyncTaskResponseBodySyncTasksImageTo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>v0.1</para>
                /// </summary>
                [NameInMap("ImageTag")]
                [Validation(Required=false)]
                public string ImageTag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cri-k77rd2eo9zttneqo</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RepoNamespaceName")]
                [Validation(Required=false)]
                public string RepoNamespaceName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1572839133000</para>
            /// </summary>
            [NameInMap("ModifedTime")]
            [Validation(Required=false)]
            public long? ModifedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15DEEB56-9271-4FDD-AC4D-C3A5CC2C****</para>
            /// </summary>
            [NameInMap("SyncBatchTaskId")]
            [Validation(Required=false)]
            public string SyncBatchTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>crsr-7lph66uloi6h****</para>
            /// </summary>
            [NameInMap("SyncRuleId")]
            [Validation(Required=false)]
            public string SyncRuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rst-4kfd7fk6pohk****</para>
            /// </summary>
            [NameInMap("SyncTaskId")]
            [Validation(Required=false)]
            public string SyncTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SyncTransAccelerate")]
            [Validation(Required=false)]
            public bool? SyncTransAccelerate { get; set; }

            /// <summary>
            /// <para>The error message that is returned if the synchronization task fails.</para>
            /// <remarks>
            /// <para> The system uses this parameter to return an error message if the synchronization task fails.</para>
            /// </remarks>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OSS_POLICY_UNAUTHORIZED: Container Registry is not granted permissions to use Object Storage Service (OSS).</description></item>
            /// <item><description>TAG_CONFLICT: The destination repository contains an image that has the same tag as the source image, and image tag immutability is enabled for the destination repository.</description></item>
            /// <item><description>UNSUPPORTED_FORMAT: The manifest and config formats of the image to be synchronized are not supported.</description></item>
            /// <item><description>INTERNAL_ERROR: The synchronization task failed due to internal issues on the server.</description></item>
            /// <item><description>NETWORK_ERROR: The synchronization task failed due to unstable network connection.</description></item>
            /// <item><description>DATA_LENGTH_EXCEEDED: The manifest or config of the image is oversized.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NETWORK_ERROR</para>
            /// </summary>
            [NameInMap("TaskIssue")]
            [Validation(Required=false)]
            public string TaskIssue { get; set; }

            /// <summary>
            /// <para>The status of the synchronization task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PASSIVE</para>
            /// </summary>
            [NameInMap("TaskTrigger")]
            [Validation(Required=false)]
            public string TaskTrigger { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
