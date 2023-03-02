// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceStatusStatisticResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request. You can use the ID to search for logs and troubleshoot issues based on the logs.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The numbers of instances in different states.
        /// </summary>
        [NameInMap("StatusCount")]
        [Validation(Required=false)]
        public GetInstanceStatusStatisticResponseBodyStatusCount StatusCount { get; set; }
        public class GetInstanceStatusStatisticResponseBodyStatusCount : TeaModel {
            /// <summary>
            /// The number of instances that failed to run.
            /// </summary>
            [NameInMap("FailureCount")]
            [Validation(Required=false)]
            public int? FailureCount { get; set; }

            /// <summary>
            /// The number of instances that are not run.
            /// </summary>
            [NameInMap("NotRunCount")]
            [Validation(Required=false)]
            public int? NotRunCount { get; set; }

            /// <summary>
            /// The number of instances that are running.
            /// </summary>
            [NameInMap("RunningCount")]
            [Validation(Required=false)]
            public int? RunningCount { get; set; }

            /// <summary>
            /// The number of instances that are successfully run.
            /// </summary>
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            /// <summary>
            /// The total number of instances.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// The number of instances that are waiting for resources.
            /// </summary>
            [NameInMap("WaitResCount")]
            [Validation(Required=false)]
            public int? WaitResCount { get; set; }

            /// <summary>
            /// The number of instances that are waiting to run.
            /// </summary>
            [NameInMap("WaitTimeCount")]
            [Validation(Required=false)]
            public int? WaitTimeCount { get; set; }

        }

    }

}
