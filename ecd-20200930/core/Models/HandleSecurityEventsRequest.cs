// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class HandleSecurityEventsRequest : TeaModel {
        /// <summary>
        /// The operation to handle multiple alerts of the same type at a time.
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// The return value from the operation to handle multiple alerts of the same type at a time.\
        /// This parameter is required only if you set the OperationCode parameter to `kill_and_quara` or `block_ip`. This parameter is not required if you set the OperationCode parameter to other values.
        /// </summary>
        [NameInMap("OperationParams")]
        [Validation(Required=false)]
        public string OperationParams { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The alerts.
        /// </summary>
        [NameInMap("SecurityEvent")]
        [Validation(Required=false)]
        public List<HandleSecurityEventsRequestSecurityEvent> SecurityEvent { get; set; }
        public class HandleSecurityEventsRequestSecurityEvent : TeaModel {
            /// <summary>
            /// The ID of the cloud desktop.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The ID of the alert.
            /// </summary>
            [NameInMap("SecurityEventId")]
            [Validation(Required=false)]
            public string SecurityEventId { get; set; }

        }

    }

}
