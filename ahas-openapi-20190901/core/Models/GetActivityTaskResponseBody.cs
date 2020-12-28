// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class GetActivityTaskResponseBody : TeaModel {
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public List<GetActivityTaskResponseBodyHosts> Hosts { get; set; }
        public class GetActivityTaskResponseBodyHosts : TeaModel {
            [NameInMap("HostIp")]
            [Validation(Required=false)]
            public string HostIp { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("ExpId")]
            [Validation(Required=false)]
            public string ExpId { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ActivityName")]
        [Validation(Required=false)]
        public string ActivityName { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("ActivityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        [NameInMap("ExperimentTaskId")]
        [Validation(Required=false)]
        public string ExperimentTaskId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("RunResult")]
        [Validation(Required=false)]
        public string RunResult { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
