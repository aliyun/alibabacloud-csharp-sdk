// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoSyncTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CrossUser")]
        [Validation(Required=false)]
        public bool? CrossUser { get; set; }

        [NameInMap("ImageFrom")]
        [Validation(Required=false)]
        public GetRepoSyncTaskResponseBodyImageFrom ImageFrom { get; set; }
        public class GetRepoSyncTaskResponseBodyImageFrom : TeaModel {
            [NameInMap("ImageTag")]
            [Validation(Required=false)]
            public string ImageTag { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }
            [NameInMap("RepoNamespaceName")]
            [Validation(Required=false)]
            public string RepoNamespaceName { get; set; }
        };

        [NameInMap("ImageTo")]
        [Validation(Required=false)]
        public GetRepoSyncTaskResponseBodyImageTo ImageTo { get; set; }
        public class GetRepoSyncTaskResponseBodyImageTo : TeaModel {
            [NameInMap("ImageTag")]
            [Validation(Required=false)]
            public string ImageTag { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }
            [NameInMap("RepoNamespaceName")]
            [Validation(Required=false)]
            public string RepoNamespaceName { get; set; }
        };

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("LayerTasks")]
        [Validation(Required=false)]
        public List<GetRepoSyncTaskResponseBodyLayerTasks> LayerTasks { get; set; }
        public class GetRepoSyncTaskResponseBodyLayerTasks : TeaModel {
            [NameInMap("ArtifactDigest")]
            [Validation(Required=false)]
            public string ArtifactDigest { get; set; }

            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("SyncLayerTaskId")]
            [Validation(Required=false)]
            public string SyncLayerTaskId { get; set; }

            [NameInMap("SyncedSize")]
            [Validation(Required=false)]
            public long? SyncedSize { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        [NameInMap("Progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SyncBatchTaskId")]
        [Validation(Required=false)]
        public string SyncBatchTaskId { get; set; }

        [NameInMap("SyncRuleId")]
        [Validation(Required=false)]
        public string SyncRuleId { get; set; }

        [NameInMap("SyncTaskId")]
        [Validation(Required=false)]
        public string SyncTaskId { get; set; }

        [NameInMap("SyncTransAccelerate")]
        [Validation(Required=false)]
        public bool? SyncTransAccelerate { get; set; }

        [NameInMap("SyncedSize")]
        [Validation(Required=false)]
        public long? SyncedSize { get; set; }

        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        [NameInMap("TaskTrigger")]
        [Validation(Required=false)]
        public string TaskTrigger { get; set; }

    }

}
