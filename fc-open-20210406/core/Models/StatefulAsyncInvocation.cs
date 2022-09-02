// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class StatefulAsyncInvocation : TeaModel {
        [NameInMap("alreadyRetriedTimes")]
        [Validation(Required=false)]
        public long? AlreadyRetriedTimes { get; set; }

        [NameInMap("destinationStatus")]
        [Validation(Required=false)]
        public string DestinationStatus { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("events")]
        [Validation(Required=false)]
        public List<StatefulAsyncInvocationEvent> Events { get; set; }

        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("invocationErrorMessage")]
        [Validation(Required=false)]
        public string InvocationErrorMessage { get; set; }

        [NameInMap("invocationId")]
        [Validation(Required=false)]
        public string InvocationId { get; set; }

        [NameInMap("invocationPayload")]
        [Validation(Required=false)]
        public string InvocationPayload { get; set; }

        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("startedTime")]
        [Validation(Required=false)]
        public long? StartedTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
