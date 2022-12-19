// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeStrategyExecDetailResponseBody : TeaModel {
        /// <summary>
        /// The time when the baseline check ends.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The number of check items that failed to pass the baseline check. This type of check item is considered risk items.
        /// </summary>
        [NameInMap("FailCount")]
        [Validation(Required=false)]
        public int? FailCount { get; set; }

        /// <summary>
        /// An array consisting of the servers on which risk items were detected.
        /// </summary>
        [NameInMap("FailedEcsList")]
        [Validation(Required=false)]
        public List<DescribeStrategyExecDetailResponseBodyFailedEcsList> FailedEcsList { get; set; }
        public class DescribeStrategyExecDetailResponseBodyFailedEcsList : TeaModel {
            /// <summary>
            /// The IP address of the server on which the baseline check was performed.
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The failure cause for the check item.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

        }

        /// <summary>
        /// The number of tasks that are **running** based on the baseline check policy.
        /// </summary>
        [NameInMap("InProcessCount")]
        [Validation(Required=false)]
        public int? InProcessCount { get; set; }

        /// <summary>
        /// The execution progress of the baseline check policy.
        /// </summary>
        [NameInMap("Percent")]
        [Validation(Required=false)]
        public string Percent { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The type of the baseline check. Valid values:
        /// 
        /// *   **Schedule**: automatic check that periodically runs
        /// *   **Manual**: intermediate check that is manually performed
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The time when the baseline check starts.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The number of check items that **passed** the baseline check.
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

    }

}
