// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListJobsResponseBody : TeaModel {
        [NameInMap("jobs")]
        [Validation(Required=false)]
        public List<ListJobsResponseBodyJobs> Jobs { get; set; }
        public class ListJobsResponseBodyJobs : TeaModel {
            [NameInMap("config")]
            [Validation(Required=false)]
            public ListJobsResponseBodyJobsConfig Config { get; set; }
            public class ListJobsResponseBodyJobsConfig : TeaModel {
                [NameInMap("moduleVersion")]
                [Validation(Required=false)]
                public string ModuleVersion { get; set; }

                [NameInMap("resourcesChanged")]
                [Validation(Required=false)]
                public string ResourcesChanged { get; set; }

            }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("statusDetail")]
            [Validation(Required=false)]
            public Dictionary<string, JobsStatusDetailValue> StatusDetail { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
