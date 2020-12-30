// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListJobsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public ListJobsResponseBodyJobs Jobs { get; set; }
        public class ListJobsResponseBodyJobs : TeaModel {
            [NameInMap("JobInfo")]
            [Validation(Required=false)]
            public List<ListJobsResponseBodyJobsJobInfo> JobInfo { get; set; }
            public class ListJobsResponseBodyJobsJobInfo : TeaModel {
                public string Type { get; set; }
                public string FailAct { get; set; }
                public int? RetryInterval { get; set; }
                public string Name { get; set; }
                public string Id { get; set; }
                public string RunParameter { get; set; }
                public int? MaxRetry { get; set; }
            }
        };

    }

}
