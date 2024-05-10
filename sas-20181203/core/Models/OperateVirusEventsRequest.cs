// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateVirusEventsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to handle all alert events. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OperationAll")]
        [Validation(Required=false)]
        public int? OperationAll { get; set; }

        /// <summary>
        /// The operation that you want to perform on the alert events. Valid values:
        /// 
        /// *   **default**: performs in-depth detection and removal
        /// *   **ignore**: ignores the alert event
        /// *   **advance_mark_mis_info**: adds the alert events to the whitelist
        /// *   **manual_handled**: marks the alert events as manually handled
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// The handling scope.
        /// </summary>
        [NameInMap("OperationRange")]
        [Validation(Required=false)]
        public string OperationRange { get; set; }

    }

}
