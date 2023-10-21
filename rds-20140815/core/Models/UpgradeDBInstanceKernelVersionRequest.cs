// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class UpgradeDBInstanceKernelVersionRequest : TeaModel {
        /// <summary>
        /// The ID of the instance. You can call the [DescribeDBInstances](~~610396~~) operation to query the ID of the instance.
        /// 
        /// > *   If your instance runs PostgreSQL, you must make sure that the instance uses **cloud disks**. If the instance is equipped with local disks, you must call the [RestartDBInstance](~~26230~~) operation to restart the instance. The system automatically updates the instance to the latest minor engine version during the restart.
        /// > *   If your instance runs SQL Server, you must make sure that the instance runs SQL Server 2019.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The update time. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// > This parameter takes effect only when you set **UpgradeTime** to **SpecifyTime**.
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// The minor engine version to which you want to update the instance. Format:
        /// 
        /// *   **PostgreSQL**: `rds_postgres_<Major engine version>00_<Minor engine version>`. Example: `rds_postgres_1200_20200830`.
        /// 
        /// *   **MySQL**: `<RDS edition and MySQL version>_<Minor engine version>`. Examples: `rds_20200229`, `xcluster_20200229`, and `xcluster80_20200229`. The following RDS editions and MySQL versions are supported:
        /// 
        ///     *   **rds**: The instance runs RDS Basic Edition or RDS High-availability Edition.
        ///     *   **xcluster**: The instance runs MySQL 5.7 on RDS Enterprise Edition.
        ///     *   **xcluster80**: The instance runs MySQL 8.0 on RDS Enterprise Edition.
        /// 
        /// *   **SQLServer**: `<Minor engine version>`. Example: `15.0.4073.23`.
        /// 
        /// If you do not specify this parameter, the instance is updated to the latest minor engine version.
        /// 
        /// > For more information about minor engine versions, see [Release notes of minor AliPG versions](~~126002~~), [Release notes of minor AliSQL versions](~~96060~~), and [Release notes of minor engine versions of ApsaraDB RDS for SQL Server](~~213577~~).
        /// </summary>
        [NameInMap("TargetMinorVersion")]
        [Validation(Required=false)]
        public string TargetMinorVersion { get; set; }

        /// <summary>
        /// The time when the update takes effect. Valid values:
        /// 
        /// *   **Immediate** (default): The update takes effect immediately.
        /// *   **MaintainTime**: The update takes effect during the maintenance window that you specify. For more information about how to change the maintenance window, see [ModifyDBInstanceMaintainTime](~~26249~~).
        /// *   **SpecifyTime**: The update takes effect at the point in time you specify.
        /// </summary>
        [NameInMap("UpgradeTime")]
        [Validation(Required=false)]
        public string UpgradeTime { get; set; }

    }

}
