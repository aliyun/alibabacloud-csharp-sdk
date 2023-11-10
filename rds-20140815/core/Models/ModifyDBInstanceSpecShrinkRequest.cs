// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceSpecShrinkRequest : TeaModel {
        /// <summary>
        /// Specifies whether to use vouchers to offset fees. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// An invalid parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// The RDS edition of the instance. Valid values:
        /// 
        /// *   Regular RDS instance
        /// 
        ///     *   **Basic**: RDS Basic Edition
        ///     *   **HighAvailability**: RDS High-availability Edition
        ///     *   **AlwaysOn**: RDS Cluster Edition for ApsaraDB RDS for SQL Server
        ///     *   **Cluster**: RDS Cluster Edition for ApsaraDB RDS for MySQL.
        /// 
        /// *   Serverless instance
        /// 
        ///     *   **serverless_basic**: RDS Basic Edition. This edition is available only for serverless instances that run MySQL and PostgreSQL.
        ///     *   **serverless_standard**: RDS High-availability Edition for ApsaraDB RDS for MySQL.
        ///     *   **serverless_ha**: RDS High-availability Edition for ApsaraDB RDS for SQL Server.
        /// 
        ///     **
        /// 
        ///     **Note** If you set the **EngineVersion** parameter to an SQL Server version number, you must also specify this parameter.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The new instance type of the instance. For more information, see [Primary ApsaraDB RDS instance types](~~26312~~). You can also call the [DescribeAvailableClasses](~~610393~~) operation to query the instance types that are supported by an instance.
        /// 
        /// - You must specify at least one of DBInstanceClass and **DBInstanceStorage**.
        /// - You can call the [DescribeDBInstanceAttribute](~~610394~~) operation to query the current instance type of the instance.
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The instance ID. You can call the [DescribeDBInstances](~~610396~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The new storage capacity of the instance. Unit: GB. You can increase the storage capacity in increments of 5 GB. For more information, see [Primary ApsaraDB RDS instance types](~~26312~~). You can call the [DescribeAvailableClasses](~~610393~~) operation to query the storage capacity range that is supported by the new instance type.
        /// 
        /// *   You must specify at least one of the DBInstanceStorage and **DBInstanceClass** parameters.
        /// *   You can call the [DescribeDBInstanceAttribute](~~610394~~) operation to query the current storage capacity of the instance.
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// The storage type of the instance. Valid values:
        /// 
        /// *   **local_ssd**: local SSD.
        /// *   **cloud_ssd**: standard SSD. This storage type is not recommended and is unavailable in some Alibaba Cloud regions.
        /// *   **cloud_essd**: enhanced SSD (ESSD) of performance level 1 (PL1).
        /// *   **cloud_essd2**: ESSDs of PL2.
        /// *   **cloud_essd3**: ESSD of PL3.
        /// 
        /// To change the storage type, take note of the following items:
        /// 
        /// If the instance runs PostgreSQL, you can upgrade the storage type of the instance from standard SSD to ESSD. However, you cannot downgrade the storage type of the instance from ESSD to standard SSD. ESSDs provide the following PLs: PL1, PL2, and PL3. You can upgrade or downgrade the storage type between ESSD of PL1, ESSD of PL2, and ESSD of PL3. For more information, see [Configuration items](~~96750~~).
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// The ID of the dedicated cluster.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// The type of change that you want to perform on the instance. Valid values:
        /// 
        /// *   **Up** (default): upgrades a subscription instance, or upgrades or downgrades a pay-as-you-go instance.
        /// *   **Down**: downgrades a subscription instance.
        /// *   **TempUpgrade**: performs auto scaling on a subscription instance that runs SQL Server. This value is required for auto scaling.
        /// *   **Serverless**: modifies the auto scaling settings of a serverless instance. This value is required if you want to modify the auto scaling settings of a serverless instance.
        /// 
        /// >  If you specify only **DBInstanceStorageType**, you can leave Direction empty. For example, if you want to change only the storage type of the instance from standard SSD to ESSD, you do not need to specify Direction.
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The time when you want the change to take effect. Valid values:
        /// 
        /// *   **Immediate**: This is the default value.
        /// *   **MaintainTime**: The effective time is within the maintenance window. For more information, see [ModifyDBInstanceMaintainTime](~~610402~~).
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// The database engine version of the instance.
        /// 
        /// *   Regular instance
        /// 
        ///     *   Valid values if you set Engine to MySQL: **5.5**, **5.6**, **5.7**, and **8.0**
        ///     *   Valid values if you set Engine to SQLServer: **2008r2**, **08r2\_ent_ha**, **2012**, **2012\_ent_ha**, **2012\_std_ha**, **2012\_web**, **2014\_std_ha**, **2016\_ent_ha**, **2016\_std_ha**, **2016\_web**, **2017\_std_ha**, **2017\_ent**, **2019\_std_ha**, and **2019\_ent**
        ///     *   Valid values if you set Engine to PostgreSQL: **10.0**, **11.0**, **12.0**, **13.0**, **14.0**, and **15.0**
        ///     *   Valid value if you set Engine to MariaDB: **10.3**
        /// 
        /// *   Serverless instance
        /// 
        ///     *   Valid values if you set Engine to MySQL: **5.7** and **8.0**
        ///     *   Valid values if you set Engine to SQLServer: **2016\_std_sl**, **2017\_std_sl**, and **2019\_std_sl**
        ///     *   Valid value if you set Engine to PostgreSQL: **14.0**
        /// 
        ///     **
        /// 
        ///     **Note**ApsaraDB RDS for MariaDB does not support serverless instances.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **Postpaid**: pay-as-you-go.
        /// *   **Prepaid**: subscription.
        /// *   **Serverless**: serverless. This value is not supported for instances that run MariaDB. If you set the value to Serverless, you must specify the scaling range of computing resources, configure the automatic start and stop feature, and configure auto scaling policies for your serverless instance. For more information, see [Overview of serverless ApsaraDB RDS for MySQL instances](~~411291~~), [Overview of serverless ApsaraDB RDS for SQL Server instances](~~604344~~), and [Overview of serverless ApsaraDB RDS for PostgreSQL instances](~~607742~~).
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The ID of the resource group.
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
        /// The serverless instance on which you want to perform the specification change.
        /// </summary>
        [NameInMap("ServerlessConfiguration")]
        [Validation(Required=false)]
        public string ServerlessConfigurationShrink { get; set; }

        /// <summary>
        /// A deprecated parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("SourceBiz")]
        [Validation(Required=false)]
        public string SourceBiz { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// The number of the minor version.
        /// 
        /// This parameter is required only for instances that run PostgreSQL. If the minor engine version does not support changing the instance type, you must specify the minor engine version to update the minor engine version when you change the instance type.
        /// 
        /// Format: `rds_postgres_<Major engine version>00_<Minor engine version>`. Example: `rds_postgres_1200_20200830`.
        /// 
        /// >  For more information about minor engine versions, see [Release notes for AliPG](~~126002~~).
        /// </summary>
        [NameInMap("TargetMinorVersion")]
        [Validation(Required=false)]
        public string TargetMinorVersion { get; set; }

        /// <summary>
        /// The ID of the order.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public long? UsedTime { get; set; }

        /// <summary>
        /// The RDS edition of the instance. Valid values:
        /// 
        /// *   **Basic**: RDS Basic Edition.
        /// *   **HighAvailability**: RDS High-availability Edition.
        /// *   **AlwaysOn**: RDS Cluster Edition for SQL Server.
        /// *   **Finance**: RDS Enterprise Edition. This edition is available only on the China site (aliyun.com).
        /// 
        /// > If you set **EngineVersion** to an SQL Server version number, you must also specify this parameter.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
