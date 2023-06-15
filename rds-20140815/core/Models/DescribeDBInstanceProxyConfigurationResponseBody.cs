// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceProxyConfigurationResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the mechanism that is used to mitigate brute-force attacks is enabled:
        /// 
        /// *   **Enable**
        /// *   **Disable**
        /// 
        /// The return value is a JSON string. Examples:
        /// 
        /// {"status":"Disable", "check_interval_seconds": 60,
        /// 
        /// "max_failed_login_attempts": 60, "blocking_seconds": 600}
        /// 
        /// Description:
        /// 
        /// *   Each client allows {max_failed_login_attempts} logon attempts that fail due to incorrect passwords within {check_interval_seconds} seconds. If one more such attempt is conducted, the client must wait for {blocking_seconds} seconds before you can try again.
        /// 
        /// *   Valid values:
        /// 
        ///     *   check_interval_seconds: **30 to 600**. Unit: seconds.
        ///     *   max_failed_login_attempts: **10 to 5000**. Unit: times.
        ///     *   blocking_seconds: **30 to 3600**. Unit: seconds.
        /// </summary>
        [NameInMap("AttacksProtectionConfiguration")]
        [Validation(Required=false)]
        public string AttacksProtectionConfiguration { get; set; }

        /// <summary>
        /// Indicates whether the short-lived connection optimization feature is enabled.
        /// 
        /// *   **Enable**
        /// *   **Disable**
        /// 
        /// The return value is a JSON string. Example:
        /// 
        /// {"status":"Disable"}.
        /// </summary>
        [NameInMap("PersistentConnectionsConfiguration")]
        [Validation(Required=false)]
        public string PersistentConnectionsConfiguration { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the transparent switchover feature is enabled.
        /// 
        /// *   **Enable**
        /// *   **Disable**
        /// 
        /// The return value is a JSON string. Example:
        /// 
        /// {"status":"Enable"}.
        /// </summary>
        [NameInMap("TransparentSwitchConfiguration")]
        [Validation(Required=false)]
        public string TransparentSwitchConfiguration { get; set; }

    }

}
