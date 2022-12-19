// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecurityCheckScheduleConfigResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The configurations of custom check tasks.
        /// </summary>
        [NameInMap("RiskCheckJobConfig")]
        [Validation(Required=false)]
        public DescribeSecurityCheckScheduleConfigResponseBodyRiskCheckJobConfig RiskCheckJobConfig { get; set; }
        public class DescribeSecurityCheckScheduleConfigResponseBodyRiskCheckJobConfig : TeaModel {
            /// <summary>
            /// The day of the week when the check tasks are performed. Multiple days can be specified. Multiple days are separated by commas (,).
            /// 
            /// *   **1**: Monday
            /// *   **2**: Tuesday
            /// *   **3**: Wednesday
            /// *   **4**: Thursday
            /// *   **5**: Friday
            /// *   **6**: Saturday
            /// *   **7**: Sunday
            /// </summary>
            [NameInMap("DaysOfWeek")]
            [Validation(Required=false)]
            public string DaysOfWeek { get; set; }

            /// <summary>
            /// The time range during which check tasks end. Valid values:
            /// 
            /// *   **6**: 00:00 to 06:00
            /// *   **12**: 06:00 to 12:00
            /// *   **18**: 12:00 to 18:00
            /// *   **24**: 18:00 to 24:00
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            /// <summary>
            /// The time range during which check tasks start. Valid values:
            /// 
            /// *   **0**: 00:00 to 06:00
            /// *   **6**: 06:00 to 12:00
            /// *   **12**: 12:00 to 18:00
            /// *   **18**: 18:00 to 24:00
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

        }

    }

}
