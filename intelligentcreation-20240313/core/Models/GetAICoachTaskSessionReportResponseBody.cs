// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class GetAICoachTaskSessionReportResponseBody : TeaModel {
        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("evaluationRating")]
        [Validation(Required=false)]
        public string EvaluationRating { get; set; }

        [NameInMap("evaluationResult")]
        [Validation(Required=false)]
        public string EvaluationResult { get; set; }

        [NameInMap("extendCustomNameMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtendCustomNameMap { get; set; }

        [NameInMap("feedback")]
        [Validation(Required=false)]
        public bool? Feedback { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("scriptName")]
        [Validation(Required=false)]
        public string ScriptName { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
