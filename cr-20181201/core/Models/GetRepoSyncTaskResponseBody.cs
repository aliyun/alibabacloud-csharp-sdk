// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoSyncTaskResponseBody : TeaModel {
        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Indicates whether the synchronization task is performed across Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("CrossUser")]
        [Validation(Required=false)]
        public bool? CrossUser { get; set; }

        /// <summary>
        /// The source address of the image.
        /// </summary>
        [NameInMap("ImageFrom")]
        [Validation(Required=false)]
        public GetRepoSyncTaskResponseBodyImageFrom ImageFrom { get; set; }
        public class GetRepoSyncTaskResponseBodyImageFrom : TeaModel {
            /// <summary>
            /// The tag of the image.
            /// </summary>
            [NameInMap("ImageTag")]
            [Validation(Required=false)]
            public string ImageTag { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The name of the image repository.
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// The name of the namespace.
            /// </summary>
            [NameInMap("RepoNamespaceName")]
            [Validation(Required=false)]
            public string RepoNamespaceName { get; set; }

        }

        /// <summary>
        /// The destination address of the image.
        /// </summary>
        [NameInMap("ImageTo")]
        [Validation(Required=false)]
        public GetRepoSyncTaskResponseBodyImageTo ImageTo { get; set; }
        public class GetRepoSyncTaskResponseBodyImageTo : TeaModel {
            /// <summary>
            /// The tag of the image.
            /// </summary>
            [NameInMap("ImageTag")]
            [Validation(Required=false)]
            public string ImageTag { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The name of the image repository.
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// The name of the namespace.
            /// </summary>
            [NameInMap("RepoNamespaceName")]
            [Validation(Required=false)]
            public string RepoNamespaceName { get; set; }

        }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The synchronization tasks for the image layer.
        /// </summary>
        [NameInMap("LayerTasks")]
        [Validation(Required=false)]
        public List<GetRepoSyncTaskResponseBodyLayerTasks> LayerTasks { get; set; }
        public class GetRepoSyncTaskResponseBodyLayerTasks : TeaModel {
            /// <summary>
            /// The digest of the artifact.
            /// </summary>
            [NameInMap("ArtifactDigest")]
            [Validation(Required=false)]
            public string ArtifactDigest { get; set; }

            /// <summary>
            /// The digest of the image layer.
            /// </summary>
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            /// <summary>
            /// The size of synchronized image layers.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The ID of the synchronization task for the image layer.
            /// </summary>
            [NameInMap("SyncLayerTaskId")]
            [Validation(Required=false)]
            public string SyncLayerTaskId { get; set; }

            /// <summary>
            /// The size of the image layer that is synchronized.
            /// </summary>
            [NameInMap("SyncedSize")]
            [Validation(Required=false)]
            public long? SyncedSize { get; set; }

            /// <summary>
            /// The status of the synchronization task. Valid values:
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// The synchronization progress. Valid values:
        /// 
        /// *   `0`: The synchronization starts or failed.
        /// *   `1`: The synchronization is successful.
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the synchronization task in which multiple images are synchronized at a time.
        /// </summary>
        [NameInMap("SyncBatchTaskId")]
        [Validation(Required=false)]
        public string SyncBatchTaskId { get; set; }

        /// <summary>
        /// The ID of the synchronization rule.
        /// </summary>
        [NameInMap("SyncRuleId")]
        [Validation(Required=false)]
        public string SyncRuleId { get; set; }

        /// <summary>
        /// The ID of the synchronization task.
        /// </summary>
        [NameInMap("SyncTaskId")]
        [Validation(Required=false)]
        public string SyncTaskId { get; set; }

        /// <summary>
        /// Indicates whether transfer acceleration is enabled in the synchronization process.
        /// </summary>
        [NameInMap("SyncTransAccelerate")]
        [Validation(Required=false)]
        public bool? SyncTransAccelerate { get; set; }

        /// <summary>
        /// The size of the image layer that is synchronized. Unit: bytes.
        /// </summary>
        [NameInMap("SyncedSize")]
        [Validation(Required=false)]
        public long? SyncedSize { get; set; }

        /// <summary>
        /// The status of the task. Valid values:
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// The policy that is used to trigger the synchronization task.
        /// </summary>
        [NameInMap("TaskTrigger")]
        [Validation(Required=false)]
        public string TaskTrigger { get; set; }

    }

}
