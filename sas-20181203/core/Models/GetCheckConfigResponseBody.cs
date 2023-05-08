// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckConfigResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of days in a week on which an automatic check is performed.
        /// </summary>
        [NameInMap("CycleDays")]
        [Validation(Required=false)]
        public List<int?> CycleDays { get; set; }

        /// <summary>
        /// The end time of the check. The value indicates a point in time. The time period that is specified by the start time and end time must be one of the following time periods:
        /// 
        /// *   **00:00 to 06:00:** The StartTime parameter is set to 0 and the EndTime parameter is set to 6.
        /// *   **06:00 to 12:00**: The StartTime parameter is set to 6 and the EndTime parameter is set to 12.
        /// *   **12:00 to 18:00**: The StartTime parameter is set to 12 and the EndTime parameter is set to 18.
        /// *   **18:00 to 24:00:** The StartTime parameter is set to 18 and the EndTime parameter is set to 24.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the information about the check items.
        /// </summary>
        [NameInMap("Standards")]
        [Validation(Required=false)]
        public List<GetCheckConfigResponseBodyStandards> Standards { get; set; }
        public class GetCheckConfigResponseBodyStandards : TeaModel {
            /// <summary>
            /// The ID of the check item.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the check item.
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// The status of the check item. Valid values:
            /// 
            /// *   **ON**: enabled
            /// *   **OFF**: disabled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The type of the check item. Valid values:
            /// 
            /// *   **RISK**: cloud service configuration management
            /// *   **IDENTITY_PERMISSION**: identity and permission management
            /// *   **COMPLIANCE**: compliance
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The start time of the check. The value indicates a point in time.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

    }

}
