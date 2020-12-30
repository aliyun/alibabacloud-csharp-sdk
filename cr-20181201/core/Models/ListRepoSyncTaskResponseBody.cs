// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoSyncTaskResponseBody : TeaModel {
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("SyncTasks")]
        [Validation(Required=false)]
        public List<ListRepoSyncTaskResponseBodySyncTasks> SyncTasks { get; set; }
        public class ListRepoSyncTaskResponseBodySyncTasks : TeaModel {
            [NameInMap("ModifedTime")]
            [Validation(Required=false)]
            public long? ModifedTime { get; set; }

            [NameInMap("SyncRuleId")]
            [Validation(Required=false)]
            public string SyncRuleId { get; set; }

            [NameInMap("SyncTaskId")]
            [Validation(Required=false)]
            public string SyncTaskId { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("SyncBatchTaskId")]
            [Validation(Required=false)]
            public string SyncBatchTaskId { get; set; }

            [NameInMap("TaskTrigger")]
            [Validation(Required=false)]
            public string TaskTrigger { get; set; }

            [NameInMap("ImageTo")]
            [Validation(Required=false)]
            public ListRepoSyncTaskResponseBodySyncTasksImageTo ImageTo { get; set; }
            public class ListRepoSyncTaskResponseBodySyncTasksImageTo : TeaModel {
                [NameInMap("RepoNamespaceName")]
                [Validation(Required=false)]
                public string RepoNamespaceName { get; set; }
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }
                [NameInMap("ImageTag")]
                [Validation(Required=false)]
                public string ImageTag { get; set; }
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }
            };

            [NameInMap("ImageFrom")]
            [Validation(Required=false)]
            public ListRepoSyncTaskResponseBodySyncTasksImageFrom ImageFrom { get; set; }
            public class ListRepoSyncTaskResponseBodySyncTasksImageFrom : TeaModel {
                [NameInMap("RepoNamespaceName")]
                [Validation(Required=false)]
                public string RepoNamespaceName { get; set; }
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }
                [NameInMap("ImageTag")]
                [Validation(Required=false)]
                public string ImageTag { get; set; }
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }
            };

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
