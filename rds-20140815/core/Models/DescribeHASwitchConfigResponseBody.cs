// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHASwitchConfigResponseBody : TeaModel {
        /// <summary>
        /// The status of the automatic primary/secondary switchover feature. Valid values:
        /// 
        /// *   **Auto:** The automatic primary/secondary switchover feature is enabled. The system automatically switches your workloads over from the instance to its secondary instance in the event of a fault.
        /// *   **Manual:** The automatic primary/secondary switchover feature is temporarily disabled.
        /// </summary>
        [NameInMap("HAConfig")]
        [Validation(Required=false)]
        public string HAConfig { get; set; }

        /// <summary>
        /// The time when the automatic primary/secondary switchover feature is enabled again. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("ManualHATime")]
        [Validation(Required=false)]
        public string ManualHATime { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
