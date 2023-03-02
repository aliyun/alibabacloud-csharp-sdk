// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceStatusCountResponseBody : TeaModel {
        /// <summary>
        /// The request ID, which is used to locate the logs and troubleshoot problems.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status statistics of the instance.
        /// </summary>
        [NameInMap("StatusCount")]
        [Validation(Required=false)]
        public GetInstanceStatusCountResponseBodyStatusCount StatusCount { get; set; }
        public class GetInstanceStatusCountResponseBodyStatusCount : TeaModel {
            /// <summary>
            /// The number of failed instances.
            /// </summary>
            [NameInMap("FailureCount")]
            [Validation(Required=false)]
            public int? FailureCount { get; set; }

            /// <summary>
            /// The number of instances that are not running.
            /// </summary>
            [NameInMap("NotRunCount")]
            [Validation(Required=false)]
            public int? NotRunCount { get; set; }

            /// <summary>
            /// The number of running instances.
            /// </summary>
            [NameInMap("RunningCount")]
            [Validation(Required=false)]
            public int? RunningCount { get; set; }

            /// <summary>
            /// The number of successful instances.
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
            /// The number of instances waiting for resources.
            /// </summary>
            [NameInMap("WaitResCount")]
            [Validation(Required=false)]
            public int? WaitResCount { get; set; }

            /// <summary>
            /// The number of instances to be run that meet the conditions.
            /// </summary>
            [NameInMap("WaitTimeCount")]
            [Validation(Required=false)]
            public int? WaitTimeCount { get; set; }

        }

    }

}
