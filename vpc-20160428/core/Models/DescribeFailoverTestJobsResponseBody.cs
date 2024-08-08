// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeFailoverTestJobsResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The list of failover tests.
        /// </summary>
        [NameInMap("FailoverTestJobList")]
        [Validation(Required=false)]
        public List<DescribeFailoverTestJobsResponseBodyFailoverTestJobList> FailoverTestJobList { get; set; }
        public class DescribeFailoverTestJobsResponseBodyFailoverTestJobList : TeaModel {
            /// <summary>
            /// The description of the failover test.
            /// 
            /// The description must be 0 to 256 characters in length and cannot start with \\*\\*http:// **or** https://\\*\\*.
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
            /// The IDs of the failover test resources.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public List<string> ResourceId { get; set; }

            /// <summary>
            /// The type of the failover test resource. Only **PHYSICALCONNECTION** is returned.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

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

            [NameInMap("StopTime")]
            [Validation(Required=false)]
            public string StopTime { get; set; }

        }

        /// <summary>
        /// The number of entries per page. Valid values: **1 to 100**. Default value: 20.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
