// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListExecutionPlanInstancesResponseBody : TeaModel {
        [NameInMap("ExecutionPlanInstances")]
        [Validation(Required=false)]
        public ListExecutionPlanInstancesResponseBodyExecutionPlanInstances ExecutionPlanInstances { get; set; }
        public class ListExecutionPlanInstancesResponseBodyExecutionPlanInstances : TeaModel {
            [NameInMap("ExecutionPlanInstance")]
            [Validation(Required=false)]
            public List<ListExecutionPlanInstancesResponseBodyExecutionPlanInstancesExecutionPlanInstance> ExecutionPlanInstance { get; set; }
            public class ListExecutionPlanInstancesResponseBodyExecutionPlanInstancesExecutionPlanInstance : TeaModel {
                public string Status { get; set; }
                public bool? LogEnable { get; set; }
                public long? StartTime { get; set; }
                public string LogPath { get; set; }
                public string ExecutionPlanId { get; set; }
                public string ClusterType { get; set; }
                public int? RunTime { get; set; }
                public string ClusterName { get; set; }
                public string WorkflowApp { get; set; }
                public string Id { get; set; }
                public string ClusterId { get; set; }
                public string ExecutionPlanName { get; set; }
            }
        };

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

    }

}
