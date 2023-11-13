// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDefenseRecordsResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of details of the log of an advanced mitigation session.
        /// </summary>
        [NameInMap("DefenseRecords")]
        [Validation(Required=false)]
        public List<DescribeDefenseRecordsResponseBodyDefenseRecords> DefenseRecords { get; set; }
        public class DescribeDefenseRecordsResponseBodyDefenseRecords : TeaModel {
            /// <summary>
            /// The peak attack traffic. Unit: bit/s.
            /// </summary>
            [NameInMap("AttackPeak")]
            [Validation(Required=false)]
            public long? AttackPeak { get; set; }

            /// <summary>
            /// The end time of the advanced mitigation session. This value is a UNIX timestamp. Units: miliseconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The number of attacks.
            /// </summary>
            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public int? EventCount { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The start time of the advanced mitigation session. This value is a UNIX timestamp. Units: miliseconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The status of the advanced mitigation session. Valid values:
            /// 
            /// *   **0**: The advanced mitigation session is being used.
            /// *   **1**: The advanced mitigation session is used.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of advanced mitigation sessions.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
