// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSystemLogResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of details of the billing logs for the burstable clean bandwidth.
        /// </summary>
        [NameInMap("SystemLog")]
        [Validation(Required=false)]
        public List<DescribeSystemLogResponseBodySystemLog> SystemLog { get; set; }
        public class DescribeSystemLogResponseBodySystemLog : TeaModel {
            /// <summary>
            /// The IP address of the instance.
            /// </summary>
            [NameInMap("EntityObject")]
            [Validation(Required=false)]
            public string EntityObject { get; set; }

            /// <summary>
            /// The type of the system log. The value is fixed as **20**, which indicates the billing logs for burstable clean bandwidth.
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public int? EntityType { get; set; }

            /// <summary>
            /// The time when the bill was generated. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The time when the bill was last modified. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the bill belongs.
            /// </summary>
            [NameInMap("OpAccount")]
            [Validation(Required=false)]
            public string OpAccount { get; set; }

            /// <summary>
            /// The operation type. The value is fixed as **100**, which indicates the billing logs for the burstable clean bandwidth that you increased.
            /// </summary>
            [NameInMap("OpAction")]
            [Validation(Required=false)]
            public int? OpAction { get; set; }

            /// <summary>
            /// The details of the bill. The value is a string that consists of a JSON struct. The JSON struct contains the following fields:
            /// 
            /// *   **newEntity**: the bill record, which contains the following fields. Data type: object.
            /// 
            ///     *   **billValue**: the usage of the burstable clean bandwidth within a month. Unit: Mbit/s. Data type: integer.
            ///     *   **instanceId**: the ID of the instance. Data type: string.
            ///     *   **ip**: the IP address of the instance. Data type: string.
            ///     *   **maxBw**: the peak service traffic (monthly 95th percentile bandwidth) within a month. Unit: Mbit/s. Data type: string.
            ///     *   **month**: the month in which the bill of the previous calendar month is issued. This value is a UNIX timestamp. Unit: milliseconds. Data type: long.
            ///     *   **overBandwidth**: the peak service traffic minus the clean bandwidth of the instance. Unit: Mbit/s. Data type: integer.
            ///     *   **peakTime**: the time in point of the peak service traffic that is measured for billing. This value is a UNIX timestamp. Unit: seconds. Data type: long.
            ///     *   **startTimestamp**: the beginning of the time range for the peak service traffic range. This value is a UNIX timestamp. Unit: seconds. Data type: long.
            /// </summary>
            [NameInMap("OpDesc")]
            [Validation(Required=false)]
            public string OpDesc { get; set; }

            /// <summary>
            /// The status of the bill. Valid values:
            /// 
            /// *   **0**: to be billed
            /// *   **1**: billed
            /// *   **2**: terminated
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// The total number of billing logs for the burstable clean bandwidth.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
