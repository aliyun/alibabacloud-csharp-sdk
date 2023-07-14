// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListAlertEventsRequest : TeaModel {
        /// <summary>
        /// The name of the alert.
        /// </summary>
        [NameInMap("AlertName")]
        [Validation(Required=false)]
        public string AlertName { get; set; }

        /// <summary>
        /// The end time of the alert events that you want to query. Specify the time in the YYYY-MM-DD HH:mm:ss format.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The list of matching conditions.
        /// </summary>
        [NameInMap("MatchingConditions")]
        [Validation(Required=false)]
        public string MatchingConditions { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// The start time of the alert events that you want to query. Specify the time in the YYYY-MM-DD HH:mm:ss format.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The status of the alert events. Valid values:
        /// 
        /// *   Active
        /// *   Silenced
        /// *   Resolved
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
