// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class ListPidLoopEvaluationsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public long TotalCount { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public List<ListPidLoopEvaluationsResponseData> Data { get; set; }
        public class ListPidLoopEvaluationsResponseData : TeaModel {
            [NameInMap("AfterPidParameters")]
            [Validation(Required=true)]
            public Dictionary<string, object> AfterPidParameters { get; set; }

            [NameInMap("BeforePidParameters")]
            [Validation(Required=true)]
            public Dictionary<string, object> BeforePidParameters { get; set; }

            [NameInMap("PidLoopRemark")]
            [Validation(Required=true)]
            public string PidLoopRemark { get; set; }

            [NameInMap("AssessTime")]
            [Validation(Required=true)]
            public long AssessTime { get; set; }

            [NameInMap("Robust")]
            [Validation(Required=true)]
            public float? Robust { get; set; }

            [NameInMap("ValidOperationRate")]
            [Validation(Required=true)]
            public float? ValidOperationRate { get; set; }

            [NameInMap("OperationRate")]
            [Validation(Required=true)]
            public float? OperationRate { get; set; }

            [NameInMap("PerformMetrics")]
            [Validation(Required=true)]
            public float? PerformMetrics { get; set; }

            [NameInMap("MultipleScore")]
            [Validation(Required=true)]
            public float? MultipleScore { get; set; }

            [NameInMap("Grade")]
            [Validation(Required=true)]
            public string Grade { get; set; }

            [NameInMap("PidLoopName")]
            [Validation(Required=true)]
            public string PidLoopName { get; set; }

            [NameInMap("PidProjectId")]
            [Validation(Required=true)]
            public string PidProjectId { get; set; }

            [NameInMap("PidLoopId")]
            [Validation(Required=true)]
            public string PidLoopId { get; set; }

            [NameInMap("PidLoopParameterId")]
            [Validation(Required=true)]
            public string PidLoopParameterId { get; set; }

        }

    }

}
