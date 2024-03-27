// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20231009.Models
{
    public class DescribeWorkflowInstanceResponseBody : TeaModel {
        [NameInMap("emrClusterId")]
        [Validation(Required=false)]
        public string EmrClusterId { get; set; }

        [NameInMap("endDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("isComplementData")]
        [Validation(Required=false)]
        public bool? IsComplementData { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("runTimes")]
        [Validation(Required=false)]
        public int? RunTimes { get; set; }

        [NameInMap("scheduleTime")]
        [Validation(Required=false)]
        public string ScheduleTime { get; set; }

        [NameInMap("startDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        [NameInMap("workflowId")]
        [Validation(Required=false)]
        public long? WorkflowId { get; set; }

        [NameInMap("workflowVersion")]
        [Validation(Required=false)]
        public int? WorkflowVersion { get; set; }

    }

}
