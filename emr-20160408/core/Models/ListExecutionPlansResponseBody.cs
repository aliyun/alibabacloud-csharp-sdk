// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListExecutionPlansResponseBody : TeaModel {
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

        [NameInMap("ExecutionPlans")]
        [Validation(Required=false)]
        public ListExecutionPlansResponseBodyExecutionPlans ExecutionPlans { get; set; }
        public class ListExecutionPlansResponseBodyExecutionPlans : TeaModel {
            [NameInMap("ExecutionPlanInfo")]
            [Validation(Required=false)]
            public List<ListExecutionPlansResponseBodyExecutionPlansExecutionPlanInfo> ExecutionPlanInfo { get; set; }
            public class ListExecutionPlansResponseBodyExecutionPlansExecutionPlanInfo : TeaModel {
                public string Status { get; set; }
                public long? StartTime { get; set; }
                public int? TimeInterval { get; set; }
                public string Stragety { get; set; }
                public bool? CreateClusterOnDemand { get; set; }
                public string Name { get; set; }
                public string TimeUnit { get; set; }
                public string Id { get; set; }
            }
        };

    }

}
