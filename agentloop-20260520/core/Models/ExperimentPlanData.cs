// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ExperimentPlanData : TeaModel {
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("experimentCount")]
        [Validation(Required=false)]
        public int? ExperimentCount { get; set; }

        [NameInMap("experimentType")]
        [Validation(Required=false)]
        public string ExperimentType { get; set; }

        [NameInMap("planId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        [NameInMap("planName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        [NameInMap("querySql")]
        [Validation(Required=false)]
        public string QuerySql { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
