// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyTrafficControlRequest : TeaModel {
        /// <summary>
        /// The default throttling value for each API.
        /// </summary>
        [NameInMap("ApiDefault")]
        [Validation(Required=false)]
        public int? ApiDefault { get; set; }

        /// <summary>
        /// The default throttling value for each app.
        /// </summary>
        [NameInMap("AppDefault")]
        [Validation(Required=false)]
        public int? AppDefault { get; set; }

        /// <summary>
        /// The description of the throttling policy.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The security token included in the WebSocket request header. The system uses this token to authenticate the request.
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The ID of the throttling policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TrafficControlId")]
        [Validation(Required=false)]
        public string TrafficControlId { get; set; }

        /// <summary>
        /// The throttling policy name. The name must be 4 to 50 characters in length and can contain letters, digits, and underscores (_). It cannot start with an underscore.
        /// </summary>
        [NameInMap("TrafficControlName")]
        [Validation(Required=false)]
        public string TrafficControlName { get; set; }

        /// <summary>
        /// The unit to be used in the throttling policy. Valid values:
        /// 
        /// *   **SECOND**
        /// *   **MINUTE**
        /// *   **HOUR**
        /// *   **DAY**
        /// </summary>
        [NameInMap("TrafficControlUnit")]
        [Validation(Required=false)]
        public string TrafficControlUnit { get; set; }

        /// <summary>
        /// The default throttling value for each user.
        /// </summary>
        [NameInMap("UserDefault")]
        [Validation(Required=false)]
        public int? UserDefault { get; set; }

    }

}
