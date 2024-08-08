// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiAutoML20220828.Models
{
    public class ListHpoTrialsResponseBody : TeaModel {
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
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries qualified.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Trial array.
        /// </summary>
        [NameInMap("Trials")]
        [Validation(Required=false)]
        public List<ListHpoTrialsResponseBodyTrials> Trials { get; set; }
        public class ListHpoTrialsResponseBodyTrials : TeaModel {
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            [NameInMap("FinalMetric")]
            [Validation(Required=false)]
            public string FinalMetric { get; set; }

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            [NameInMap("Hyperparam")]
            [Validation(Required=false)]
            public string Hyperparam { get; set; }

            [NameInMap("JobMeta")]
            [Validation(Required=false)]
            public string JobMeta { get; set; }

            [NameInMap("Metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("ParameterId")]
            [Validation(Required=false)]
            public int? ParameterId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TrialId")]
            [Validation(Required=false)]
            public string TrialId { get; set; }

            [NameInMap("UserComment")]
            [Validation(Required=false)]
            public string UserComment { get; set; }

            [NameInMap("UserScore")]
            [Validation(Required=false)]
            public int? UserScore { get; set; }

        }

    }

}
