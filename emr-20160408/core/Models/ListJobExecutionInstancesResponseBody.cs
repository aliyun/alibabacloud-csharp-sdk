// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListJobExecutionInstancesResponseBody : TeaModel {
        [NameInMap("JobInstances")]
        [Validation(Required=false)]
        public ListJobExecutionInstancesResponseBodyJobInstances JobInstances { get; set; }
        public class ListJobExecutionInstancesResponseBodyJobInstances : TeaModel {
            [NameInMap("JobInstance")]
            [Validation(Required=false)]
            public List<ListJobExecutionInstancesResponseBodyJobInstancesJobInstance> JobInstance { get; set; }
            public class ListJobExecutionInstancesResponseBodyJobInstancesJobInstance : TeaModel {
                public string ClusterId { get; set; }
                public string Id { get; set; }
                public string JobId { get; set; }
                public string JobName { get; set; }
                public string JobType { get; set; }
                public string RetryInfo { get; set; }
                public int? RunTime { get; set; }
                public long? StartTime { get; set; }
                public string Status { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
