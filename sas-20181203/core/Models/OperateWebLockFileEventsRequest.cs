// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateWebLockFileEventsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to handle all alert events that are generated for web tamper proofing. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DealAll")]
        [Validation(Required=false)]
        public int? DealAll { get; set; }

        /// <summary>
        /// The IDs of alert events.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EventIds")]
        [Validation(Required=false)]
        public List<long?> EventIds { get; set; }

        /// <summary>
        /// The operation that you want to perform on the alert events. Valid values:
        /// 
        /// *   **mark_mis_info**: marks the alert events as false positives
        /// *   **rm_mark_mis_info**: cancels marking the alerts events as false positives
        /// *   **offline_handled**: marks the alert events as handled offline
        /// *   **whitelist**: adds the alert events to the whitelist
        /// *   **rm_whitelist**: cancels adding the alert events to the whitelist
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

    }

}
