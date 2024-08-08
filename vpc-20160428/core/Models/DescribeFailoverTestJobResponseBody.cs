// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeFailoverTestJobResponseBody : TeaModel {
        /// <summary>
        /// The failover test.
        /// </summary>
        [NameInMap("FailoverTestJobModel")]
        [Validation(Required=false)]
        public DescribeFailoverTestJobResponseBodyFailoverTestJobModel FailoverTestJobModel { get; set; }
        public class DescribeFailoverTestJobResponseBodyFailoverTestJobModel : TeaModel {
            /// <summary>
            /// The description of the failover test.
            /// 
            /// The description must be 0 to 256 characters in length and cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The duration of the failover test. Unit: minutes. Valid values: **1 to 4320**.
            /// </summary>
            [NameInMap("JobDuration")]
            [Validation(Required=false)]
            public string JobDuration { get; set; }

            /// <summary>
            /// The ID of the failover test.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// Indicates whether the failover test is performed immediately. Valid values:
            /// 
            /// *   **StartNow**
            /// *   **StartLater**
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// The name of the failover test.
            /// 
            /// The name must be 0 to 128 characters in length and cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The IDs of failover test resources.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public List<string> ResourceId { get; set; }

            /// <summary>
            /// The type of failover test resource. Only **PHYSICALCONNECTION** is returned.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The start time of the failover test. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The status of the failover test. Valid values:
            /// 
            /// *   **Init**
            /// *   **Starting**
            /// *   **Testing**
            /// *   **Stopping**
            /// *   **Stopped**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The end time of the failover test. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("StopTime")]
            [Validation(Required=false)]
            public string StopTime { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
