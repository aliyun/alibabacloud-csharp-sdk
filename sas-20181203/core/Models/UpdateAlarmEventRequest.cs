// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateAlarmEventRequest : TeaModel {
        /// <summary>
        /// The IDs of the alert events.
        /// </summary>
        [NameInMap("AlarmEventIdList")]
        [Validation(Required=false)]
        public List<long?> AlarmEventIdList { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The operation that you want to perform on the alert events. Valid values:
        /// 
        /// *   **manual_handled**: handle the alert events.
        /// *   **ignore**: igore the alert events.
        /// *   **cancel_ignore**: remove the alert events from the whitelist.
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

    }

}
