// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddImageEventOperationRequest : TeaModel {
        /// <summary>
        /// The rule conditions. The value is in the JSON format. Valid values of keys:
        /// 
        /// *   **condition**: the matching condition.
        /// *   **type**: the matching type.
        /// *   **value**: the matching value.
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// The keyword of the alert item.
        /// </summary>
        [NameInMap("EventKey")]
        [Validation(Required=false)]
        public string EventKey { get; set; }

        /// <summary>
        /// The name of the alert item.
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// The alert type.
        /// 
        /// *   Set the value to **sensitiveFile**.
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The operation code.
        /// 
        /// *   Set the value to **whitelist** to add the alert item to the whitelist.
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// The application scope of the rule. The value is in the JSON format. Valid values of keys:
        /// 
        /// *   **type**
        /// *   **value**
        /// </summary>
        [NameInMap("Scenarios")]
        [Validation(Required=false)]
        public string Scenarios { get; set; }

    }

}
