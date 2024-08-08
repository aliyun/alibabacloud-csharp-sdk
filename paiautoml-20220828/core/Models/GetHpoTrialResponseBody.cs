// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiAutoML20220828.Models
{
    public class GetHpoTrialResponseBody : TeaModel {
        /// <summary>
        /// Error code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Extra error information.
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public Dictionary<string, string> Detail { get; set; }

        /// <summary>
        /// Experiment ID.
        /// </summary>
        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        public string ExperimentId { get; set; }

        /// <summary>
        /// Final metric of the trial.
        /// </summary>
        [NameInMap("FinalMetric")]
        [Validation(Required=false)]
        public string FinalMetric { get; set; }

        /// <summary>
        /// Trial create time.
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// Trial last update time.
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// Hyperparameters used to run the trial.
        /// </summary>
        [NameInMap("Hyperparam")]
        [Validation(Required=false)]
        public string Hyperparam { get; set; }

        /// <summary>
        /// trial meta infomation.
        /// </summary>
        [NameInMap("JobMeta")]
        [Validation(Required=false)]
        public string JobMeta { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// metric details uploaded during running.
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// Name of the metric.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// Trial output model.
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// Parameter id, start from 0.
        /// </summary>
        [NameInMap("ParameterId")]
        [Validation(Required=false)]
        public int? ParameterId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Trial status.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// Trail ID.
        /// </summary>
        [NameInMap("TrialId")]
        [Validation(Required=false)]
        public string TrialId { get; set; }

        /// <summary>
        /// User added comments.
        /// </summary>
        [NameInMap("UserComment")]
        [Validation(Required=false)]
        public string UserComment { get; set; }

        /// <summary>
        /// User updated score.
        /// </summary>
        [NameInMap("UserScore")]
        [Validation(Required=false)]
        public int? UserScore { get; set; }

    }

}
