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
        /// 
        /// This parameter is required.
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProxyConfigurationKey")]
        [Validation(Required=false)]
        public string ProxyConfigurationKey { get; set; }

        /// <summary>
        /// The features and status of the database proxy:
        /// 
        /// *   **TransparentSwitch**: transparent switchover. Valid values:
        /// 
        ///     *   **Enable**: The feature is enabled. This is the default value.
        ///     *   **Disable**: The feature is disabled.
        /// 
        /// *   **PersistentConnections**: short-lived connection optimization. Valid values:
        /// 
        ///     *   **Enable**: The feature is enabled.
        ///     *   **Disable**: The feature is disabled. This is the default value.
        /// 
        /// *   **AttacksProtection**: brute-force attack protection. Valid values:
        /// 
        ///     *   **Enable**: The feature is enabled.
        ///     *   **Disable**: The feature is disabled. This is the default value.
        /// 
        /// Format: {"Feature 1":"Status 1","Feature 2":"Status 2"...}
        /// 
        /// This parameter is required.
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
