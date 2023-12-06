// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMetaListRequest : TeaModel {
        /// <summary>
        /// The ID of the backup set from which you want to restore data. You can call the DescribeBackups operation to query the backup set ID.
        /// 
        /// >  This parameter must be specified when the **RestoreType** parameter is set to **BackupSetID**.
        /// </summary>
        [NameInMap("BackupSetID")]
        [Validation(Required=false)]
        public int? BackupSetID { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the generated token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The name of the database to query. The system implements exact match based on the value of this parameter and returns the name of the matched database and the names of all tables contained in the database.
        /// 
        /// > If you leave this parameter empty, the system returns all databases that are created on the instance.
        /// </summary>
        [NameInMap("GetDbName")]
        [Validation(Required=false)]
        public string GetDbName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. Valid values: any non-zero positive integer.**** Default value: **1**.
        /// 
        /// > This parameter only takes effect when you specify the **PageSize** parameter.
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **1**.
        /// 
        /// > This parameter only takes effect when you specify the **PageIndex** parameter.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the database to query. The system implements fuzzy match based on the value of this parameter and returns only the name of the matched database.
        /// 
        /// > For example, if you set the value to `test`, the system returns `testdb1` and `testdb2`. Then, you can specify the **GetDbName** parameter to query tables in the required database.
        /// </summary>
        [NameInMap("Pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

        /// <summary>
        /// The resource group ID.
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

        /// <summary>
        /// The point in time to which you want to restore data. The specified point in time must be earlier than the current time. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC. You can call the DescribeBackups operation to query the restorable time range.
        /// 
        /// >  This parameter must be specified when the **RestoreType** parameter is set to **RestoreTime**.
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// The method that is used to restore data. Valid values:
        /// 
        /// *   **BackupSetID**: Data is restored from a backup set. If you use this value, you must also specify the **BackupSetID** parameter.
        /// *   **RestoreTime**: Data is restored to a specific point in time. If you use this value, you must also specify the **RestoreTime** parameter.
        /// 
        /// Default value: **BackupSetID**.
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

    }

}
