// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CheckCreateDdrDBInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the backup set that is used for the restoration. You can call the DescribeCrossRegionBackups operation to query the backup set ID.
        /// 
        /// >  This parameter must be specified when the **RestoreType** parameter is set to **0**.
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// The instance type of the destination instance. For more information, see [Primary ApsaraDB RDS instance types](https://help.aliyun.com/document_detail/26312.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The storage capacity of the destination instance. Valid values: **5 to 2000**. Unit: GB. You can increase the storage capacity in increments of 5 GB. For more information, see [Primary instance types](https://help.aliyun.com/document_detail/26312.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// The database engine of the destination instance. Valid values:
        /// 
        /// *   **MySQL**
        /// *   **SQLServer**
        /// *   **PostgreSQL**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The major engine version of the destination instance. The value of this parameter varies based on the value of **Engine**.
        /// 
        /// *   Valid values when Engine is set to MySQL: **5.5, 5.6, 5.7, and 8.0**
        /// *   Valid values when Engine is set to SQLServer: **2008r2, 08r2_ent_ha, 2012, 2012_ent_ha, 2012_std_ha, 2012_web, 2014_std_ha, 2016_ent_ha, 2016_std_ha, 2016_web, 2017_std_ha, 2017_ent, 2019_std_ha, and 2019_ent**
        /// *   PostgreSQL: **10.0, 11.0, 12.0, 13.0, 14.0, and 15.0**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the destination instance. You can call the DescribeRegions operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID. You can call the DescribeDBInstanceAttribute to query the resource group ID.
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
        /// The point in time to which you want to restore data. The point in time that you specify must be earlier than the current time. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// 
        /// > If you set **RestoreType** to **1**, you must also specify this parameter.
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// The method that is used to restore data. Valid values:
        /// 
        /// *   **0**: restores data from a backup set. If you set this parameter to 0, you must also specify the **BackupSetId** parameter.
        /// *   **1**: restores data to a point in time. If you set this parameter to 1, you must also specify the **RestoreTime**, **SourceRegion**, and **SourceDBInstanceName** parameters.
        /// 
        /// Default value: **0**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// The ID of the source instance if you want to restore data to a point in time.
        /// 
        /// >  This parameter must be specified when the **RestoreType** parameter is set to **1**.
        /// </summary>
        [NameInMap("SourceDBInstanceName")]
        [Validation(Required=false)]
        public string SourceDBInstanceName { get; set; }

        /// <summary>
        /// The region ID of the source instance if you want to restore data to a point in time.
        /// 
        /// > If you set **RestoreType** to **1**, you must also specify this parameter.
        /// </summary>
        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

    }

}
