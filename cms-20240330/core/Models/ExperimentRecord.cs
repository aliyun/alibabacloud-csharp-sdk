// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ExperimentRecord : TeaModel {
        [NameInMap("completedAt")]
        [Validation(Required=false)]
        public long? CompletedAt { get; set; }

        [NameInMap("completedTasks")]
        [Validation(Required=false)]
        public int? CompletedTasks { get; set; }

        [NameInMap("dataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        [NameInMap("datasetProject")]
        [Validation(Required=false)]
        public string DatasetProject { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("evaluators")]
        [Validation(Required=false)]
        public List<Evaluator> Evaluators { get; set; }

        [NameInMap("executedAt")]
        [Validation(Required=false)]
        public long? ExecutedAt { get; set; }

        [NameInMap("experimentConfig")]
        [Validation(Required=false)]
        public ExperimentConfig ExperimentConfig { get; set; }

        [NameInMap("experimentName")]
        [Validation(Required=false)]
        public string ExperimentName { get; set; }

        [NameInMap("failedTasks")]
        [Validation(Required=false)]
        public int? FailedTasks { get; set; }

        [NameInMap("input")]
        [Validation(Required=false)]
        public Dictionary<string, object> Input { get; set; }

        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("planId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        [NameInMap("planName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        [NameInMap("progress")]
        [Validation(Required=false)]
        public float? Progress { get; set; }

        [NameInMap("recordId")]
        [Validation(Required=false)]
        public string RecordId { get; set; }

        [NameInMap("selectedItemIds")]
        [Validation(Required=false)]
        public List<string> SelectedItemIds { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("totalTasks")]
        [Validation(Required=false)]
        public int? TotalTasks { get; set; }

    }

}
