// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SetGtmMonitorStatusRequest : TeaModel {
        /// <summary>
        /// The language used by the user.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The health check ID.
        /// </summary>
        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

        /// <summary>
        /// Specifies whether health check is enabled for the address pool. Valid values:
        /// 
        /// *   **OPEN**: Enabled
        /// *   **CLOSE**: Disabled
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
