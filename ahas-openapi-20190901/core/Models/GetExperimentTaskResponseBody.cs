// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class GetExperimentTaskResponseBody : TeaModel {
        [NameInMap("Activities")]
        [Validation(Required=false)]
        public List<GetExperimentTaskResponseBodyActivities> Activities { get; set; }
        public class GetExperimentTaskResponseBodyActivities : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("CheckState")]
            [Validation(Required=false)]
            public string CheckState { get; set; }

            [NameInMap("RunResult")]
            [Validation(Required=false)]
            public string RunResult { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("ActivityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            [NameInMap("ActivityName")]
            [Validation(Required=false)]
            public string ActivityName { get; set; }

            [NameInMap("ExperimentTaskId")]
            [Validation(Required=false)]
            public string ExperimentTaskId { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ExperimentName")]
        [Validation(Required=false)]
        public string ExperimentName { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        public string ExperimentId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

    }

}
