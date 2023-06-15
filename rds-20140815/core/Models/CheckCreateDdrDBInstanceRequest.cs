// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CheckCreateDdrDBInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the data backup file that is used for the restoration. You can call the [DescribeCrossRegionBackups](~~121733~~) operation to query backup set IDs.
        /// 
        /// >  If you set the **RestoreType** parameter to **0**, you must also specify this parameter.
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// The type of the destination instance. For more information, see [Primary instance types](~~26312~~).
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The storage capacity of the destination instance. Valid values: **5 to 2000**. Unit: GB.
        /// 
        /// The storage capacity increases at increments of 5 GB. For more information, see [Primary instance types](~~26312~~).
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// The database engine that is run on the destination instance. Valid values:
        /// 
        /// *   **MySQL**
        /// *   **SQLServer**
        /// *   **PostgreSQL**
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The version of the database engine that is run on the destination the instance. The value of this parameter varies based on the value of the **Engine** parameter. Valid values:
        /// 
        /// *   MySQL: **5.5, 5.6, 5.7, and 8.0**
        /// *   SQL Server: **2008r2, 08r2\_ent_ha, 2012, 2012\_ent_ha, 2012\_std_ha, 2012\_web, 2014\_std_ha, 2016\_ent_ha, 2016\_std_ha, 2016\_web, 2017\_std_ha, 2017\_ent, 2019\_std_ha, and 2019\_ent**
        /// *   PostgreSQL: **9.4, 10.0, 11.0, 12.0, and 13.0**
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the destination instance. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list of region IDs.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The point in time to which you want to restore data. The point in time that you specify must be earlier than the current time. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// >  If you set the **RestoreType** parameter to **1**, you must also specify this parameter.
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// The restoration method that you want to use. Valid values:
        /// 
        /// *   **0**: restores data from a data backup file. If you select this value, you must also specify the **BackupSetId** parameter.
        /// *   **1**: restores data to a point in time. If you select this value, you must also specify the **RestoreTime**, **SourceRegion** and **SourceDBInstanceName** parameters.
        /// 
        /// Default value: **0**.
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// The ID of the source instance if you want to restore data to a point in time.
        /// 
        /// >  If you set the **RestoreType** parameter to **1**, you must also specify this parameter.
        /// </summary>
        [NameInMap("SourceDBInstanceName")]
        [Validation(Required=false)]
        public string SourceDBInstanceName { get; set; }

        /// <summary>
        /// The region ID of the source instance if you want to restore data to a point in time.
        /// 
        /// >  If you set the **RestoreType** parameter to **1**, you must also specify this parameter.
        /// </summary>
        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

    }

}
