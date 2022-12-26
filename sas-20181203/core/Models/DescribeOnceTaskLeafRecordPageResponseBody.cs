// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeOnceTaskLeafRecordPageResponseBody : TeaModel {
        [NameInMap("OnceTasks")]
        [Validation(Required=false)]
        public List<DescribeOnceTaskLeafRecordPageResponseBodyOnceTasks> OnceTasks { get; set; }
        public class DescribeOnceTaskLeafRecordPageResponseBodyOnceTasks : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Finish")]
            [Validation(Required=false)]
            public int? Finish { get; set; }

            [NameInMap("FinishCount")]
            [Validation(Required=false)]
            public string FinishCount { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

            [NameInMap("RealRunTime")]
            [Validation(Required=false)]
            public long? RealRunTime { get; set; }

            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public string ResultInfo { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusText")]
            [Validation(Required=false)]
            public string StatusText { get; set; }

            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskImageInfo")]
            [Validation(Required=false)]
            public DescribeOnceTaskLeafRecordPageResponseBodyOnceTasksTaskImageInfo TaskImageInfo { get; set; }
            public class DescribeOnceTaskLeafRecordPageResponseBodyOnceTasksTaskImageInfo : TeaModel {
                [NameInMap("Digest")]
                [Validation(Required=false)]
                public string Digest { get; set; }

                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                [NameInMap("Pod")]
                [Validation(Required=false)]
                public string Pod { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RepoId")]
                [Validation(Required=false)]
                public string RepoId { get; set; }

                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                [NameInMap("RepoNamespace")]
                [Validation(Required=false)]
                public string RepoNamespace { get; set; }

                [NameInMap("RepoRegionId")]
                [Validation(Required=false)]
                public string RepoRegionId { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeOnceTaskLeafRecordPageResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeOnceTaskLeafRecordPageResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
