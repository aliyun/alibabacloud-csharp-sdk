// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSuspiciousStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The number of alerts whose Emergency level is Reminder.
        /// </summary>
        [NameInMap("RemindCount")]
        [Validation(Required=false)]
        public int? RemindCount { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of alerts whose Emergency level is Urgent.
        /// </summary>
        [NameInMap("SeriousCount")]
        [Validation(Required=false)]
        public int? SeriousCount { get; set; }

        /// <summary>
        /// The number of alerts whose Emergency level is Suspicious.
        /// </summary>
        [NameInMap("SuspiciousCount")]
        [Validation(Required=false)]
        public int? SuspiciousCount { get; set; }

        /// <summary>
        /// The total number of alerts.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
