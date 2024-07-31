// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceStatusCountResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The statistics of instances.
        /// </summary>
        [NameInMap("StatusCount")]
        [Validation(Required=false)]
        public GetInstanceStatusCountResponseBodyStatusCount StatusCount { get; set; }
        public class GetInstanceStatusCountResponseBodyStatusCount : TeaModel {
            /// <summary>
            /// The number of instances that failed.
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
            /// The total number of instances returned.
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
            /// The number of instances that are waiting for their scheduling time to arrive.
            /// </summary>
            [NameInMap("WaitTimeCount")]
            [Validation(Required=false)]
            public int? WaitTimeCount { get; set; }

        }

    }

}
