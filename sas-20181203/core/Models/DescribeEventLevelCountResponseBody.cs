// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEventLevelCountResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The statistics of alerts events by risk level.
        /// </summary>
        [NameInMap("EventLevels")]
        [Validation(Required=false)]
        public DescribeEventLevelCountResponseBodyEventLevels EventLevels { get; set; }
        public class DescribeEventLevelCountResponseBodyEventLevels : TeaModel {
            /// <summary>
            /// The number of alerts whose Emergency level is Reminder.
            /// </summary>
            [NameInMap("Remind")]
            [Validation(Required=false)]
            public int? Remind { get; set; }

            /// <summary>
            /// The number of alerts whose Emergency level is Urgent.
            /// </summary>
            [NameInMap("Serious")]
            [Validation(Required=false)]
            public int? Serious { get; set; }

            /// <summary>
            /// The number of alerts whose Emergency level is Suspicious.
            /// </summary>
            [NameInMap("Suspicious")]
            [Validation(Required=false)]
            public int? Suspicious { get; set; }

        }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
