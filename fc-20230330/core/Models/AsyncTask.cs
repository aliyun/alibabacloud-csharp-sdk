// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class AsyncTask : TeaModel {
        [NameInMap("alreadyRetriedTimes")]
        [Validation(Required=false)]
        public long? AlreadyRetriedTimes { get; set; }

        [NameInMap("destinationStatus")]
        [Validation(Required=false)]
        public string DestinationStatus { get; set; }

        [NameInMap("durationMs")]
        [Validation(Required=false)]
        public long? DurationMs { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("events")]
        [Validation(Required=false)]
        public List<AsyncTaskEvent> Events { get; set; }

        [NameInMap("functionArn")]
        [Validation(Required=false)]
        public string FunctionArn { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("returnPayload")]
        [Validation(Required=false)]
        public string ReturnPayload { get; set; }

        [NameInMap("startedTime")]
        [Validation(Required=false)]
        public long? StartedTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("taskErrorMessage")]
        [Validation(Required=false)]
        public string TaskErrorMessage { get; set; }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("taskPayload")]
        [Validation(Required=false)]
        public string TaskPayload { get; set; }

    }

}
