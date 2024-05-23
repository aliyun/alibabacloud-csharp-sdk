// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceConfigRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The name of the configuration item that you want to modify. Valid values:
        /// 
        /// *   **pgbouncer**. This configuration item is supported for ApsaraDB RDS for PostgreSQL instances.
        /// *   **clear_errorlog**. This configuration item is supported for ApsaraDB RDS for SQL Server instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        /// <summary>
        /// The value of the configuration item that you want to modify. Valid values:
        /// 
        /// *   If you set ConfigName to pgbouncer, the valid values are **true** and **false**.
        /// *   If you set ConfigName to clear_errorlog, set the value to **1**. The value 1 indicates that error logs are cleaned up.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The resource group ID. You can call the DescribeDBInstanceAttribute to obtain the resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
