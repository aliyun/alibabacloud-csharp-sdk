// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClusterSuspEventStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of alerts by risk level.
        /// </summary>
        [NameInMap("SuspStatistics")]
        [Validation(Required=false)]
        public GetClusterSuspEventStatisticsResponseBodySuspStatistics SuspStatistics { get; set; }
        public class GetClusterSuspEventStatisticsResponseBodySuspStatistics : TeaModel {
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

    }

}
