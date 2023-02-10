// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ConfirmVirusEventsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to handle all alert events. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// </summary>
        [NameInMap("OperationAll")]
        [Validation(Required=false)]
        public int? OperationAll { get; set; }

        /// <summary>
        /// The operation that you want to perform on the alert events. Valid values:
        /// 
        /// *   **default**: performs in-depth detection and removal
        /// *   **ignore**: ignores the alert event
        /// *   **advance\_mark\_mis_info**: adds the alert events to the whitelist
        /// *   **manual_handled**: marks the alert events as manually handled
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// The server on which you want to perform the alert events.
        /// </summary>
        [NameInMap("OperationRange")]
        [Validation(Required=false)]
        public string OperationRange { get; set; }

    }

}
