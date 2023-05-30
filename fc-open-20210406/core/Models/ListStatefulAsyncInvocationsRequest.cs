// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListStatefulAsyncInvocationsRequest : TeaModel {
        /// <summary>
        /// You can search for API operations, call and debug API operations online, and dynamically generate executable sample code for SDKs.
        /// </summary>
        [NameInMap("includePayload")]
        [Validation(Required=false)]
        public bool? IncludePayload { get; set; }

        /// <summary>
        /// Alibaba Cloud provides SDKs for multiple programming languages to help you integrate Alibaba Cloud services by using APIs. We recommend that you use an SDK to call API operations. This frees you from manual signature verification.
        /// </summary>
        [NameInMap("invocationIdPrefix")]
        [Validation(Required=false)]
        public string InvocationIdPrefix { get; set; }

        /// <summary>
        /// The list of events that trigger the asynchronous task.
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The ID of the instance that is used to run the asynchronous task.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The number of retries after the asynchronous task fails.
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// StatefulAsyncInvocation: asynchronous task. Asynchronous tasks allow you to manage the states on the basis of common asynchronous invocations, which is more suitable for task scenarios.
        /// </summary>
        [NameInMap("sortOrderByTime")]
        [Validation(Required=false)]
        public string SortOrderByTime { get; set; }

        /// <summary>
        /// The structure of the asynchronous task.
        /// </summary>
        [NameInMap("startedTimeBegin")]
        [Validation(Required=false)]
        public long? StartedTimeBegin { get; set; }

        /// <summary>
        /// The latest version of Function Compute API.
        /// </summary>
        [NameInMap("startedTimeEnd")]
        [Validation(Required=false)]
        public long? StartedTimeEnd { get; set; }

        /// <summary>
        /// The request ID of the asynchronous task.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
