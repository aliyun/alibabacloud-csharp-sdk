// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class StatefulAsyncInvocation : TeaModel {
        /// <summary>
        /// alreadyRetriedTimes
        /// </summary>
        [NameInMap("alreadyRetriedTimes")]
        [Validation(Required=false)]
        public long? AlreadyRetriedTimes { get; set; }

        /// <summary>
        /// destinationStatus
        /// </summary>
        [NameInMap("destinationStatus")]
        [Validation(Required=false)]
        public string DestinationStatus { get; set; }

        /// <summary>
        /// endTime
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// functionName
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// invocationErrorMessage
        /// </summary>
        [NameInMap("invocationErrorMessage")]
        [Validation(Required=false)]
        public string InvocationErrorMessage { get; set; }

        /// <summary>
        /// invocationId
        /// </summary>
        [NameInMap("invocationId")]
        [Validation(Required=false)]
        public string InvocationId { get; set; }

        /// <summary>
        /// invocationPayload
        /// </summary>
        [NameInMap("invocationPayload")]
        [Validation(Required=false)]
        public string InvocationPayload { get; set; }

        /// <summary>
        /// qualifier
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// serviceName
        /// </summary>
        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// startedTime
        /// </summary>
        [NameInMap("startedTime")]
        [Validation(Required=false)]
        public long? StartedTime { get; set; }

        /// <summary>
        /// status
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
