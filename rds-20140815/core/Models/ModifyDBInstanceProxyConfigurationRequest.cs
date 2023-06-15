// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceProxyConfigurationRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The key of the **configuration item** for the database proxy. Valid values:
        /// 
        /// *   **TransparentSwitch**: transparent switchover
        /// *   **PersistentConnections**: short-lived connection optimization
        /// *   **AttacksProtection**: brute-force attack protection
        /// </summary>
        [NameInMap("ProxyConfigurationKey")]
        [Validation(Required=false)]
        public string ProxyConfigurationKey { get; set; }

        /// <summary>
        /// The value of the **configuration item** for the database proxy. Valid values:
        /// 
        /// *   If you set the ProxyConfigurationKey parameter to **TransparentSwitch**, you can set this parameter to one of the following values:
        /// 
        ///     *   **Enable**. This is the default value.
        ///     *   **Disable**. Example: {"status":"Enable"}.
        /// 
        /// *   If you set the ProxyConfigurationKey parameter to **PersistentConnections**, you can set this parameter to one of the following values:
        /// 
        ///     *   **Enable**.
        ///     *   **Disable**. This is the default value. Example: {"status":"Disable"}.
        /// 
        /// *   If you set the ProxyConfigurationKey parameter to **AttacksProtection**, you can set this parameter to one of the following values:
        /// 
        ///     *   **Enable**.
        ///     *   **Disable**. This is the default value. Example: {"status":"Disable"}.
        /// 
        /// In this case, the return value is a JSON string. Example:
        /// 
        ///     {"status":"Disable", "check_interval_seconds": 60,
        ///                     "max_failed_login_attempts": 60, "blocking_seconds": 600}
        /// 
        /// Description and valid values:
        /// 
        /// *   Each client allows {max_failed_login_attempts} logon attempts upon failure within {check_interval_seconds} seconds. If the number of logon attempts exceeds the limit, the client is disabled for {blocking_seconds} seconds before the client can try again.
        /// *   The following list describes the valid values of each field in the preceding example.
        /// 
        /// check_interval_seconds: **30 to 600**. Unit: seconds. max_failed_login_attempts: **10 to 5000**. Unit: number of times. blocking_seconds: **30 to 3600**. Unit: seconds.
        /// </summary>
        [NameInMap("ProxyConfigurationValue")]
        [Validation(Required=false)]
        public string ProxyConfigurationValue { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
