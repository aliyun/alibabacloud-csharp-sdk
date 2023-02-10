// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageFixTaskResponseBody : TeaModel {
        [NameInMap("BuildTasks")]
        [Validation(Required=false)]
        public List<DescribeImageFixTaskResponseBodyBuildTasks> BuildTasks { get; set; }
        public class DescribeImageFixTaskResponseBodyBuildTasks : TeaModel {
            [NameInMap("BuildTaskId")]
            [Validation(Required=false)]
            public string BuildTaskId { get; set; }

            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("FixTime")]
            [Validation(Required=false)]
            public string FixTime { get; set; }

            [NameInMap("NewTag")]
            [Validation(Required=false)]
            public string NewTag { get; set; }

            [NameInMap("NewUuid")]
            [Validation(Required=false)]
            public string NewUuid { get; set; }

            [NameInMap("OldTag")]
            [Validation(Required=false)]
            public string OldTag { get; set; }

            [NameInMap("OldUuid")]
            [Validation(Required=false)]
            public string OldUuid { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageFixTaskResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageFixTaskResponseBodyPageInfo : TeaModel {
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
