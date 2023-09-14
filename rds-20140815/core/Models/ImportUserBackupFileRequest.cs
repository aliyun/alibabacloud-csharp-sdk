// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ImportUserBackupFileRequest : TeaModel {
        /// <summary>
        /// A JSON array that consists of the information about the full backup file stored as an object in an OSS bucket. Example: `{"Bucket":"test", "Object":"test/test_db_employees.xb","Location":"ap-southeast-1"}`
        /// 
        /// The JSON array contains the following fields:
        /// 
        /// *   **Bucket**: The name of the OSS bucket in which the full backup file is stored as an object. You can call the [GetBucket](~~31965~~) operation to query the name of the bucket.
        /// *   **Object**: The path of the full backup file that is stored as an object in the OSS bucket. You can call the [GetObject](~~31980~~) operation to query the path of the object.
        /// *   **Location**: The ID of the region in which the OSS bucket is located. You can call the [GetBucketLocation](~~31967~~) operation to query the region of the bucket.
        /// </summary>
        [NameInMap("BackupFile")]
        [Validation(Required=false)]
        public string BackupFile { get; set; }

        /// <summary>
        /// The region ID of the OSS bucket where the full backup file of the self-managed MySQL database is located. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("BucketRegion")]
        [Validation(Required=false)]
        public string BucketRegion { get; set; }

        /// <summary>
        /// The description of the full backup file.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The version of the database engine that is run on the self-managed MySQL database and ApsaraDB RDS for MySQL instance. Set the value to **5.7**.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
        /// 
        /// > 
        /// 
        /// *   The value of this parameter is the ID of the region in which you want to create the instance.
        /// 
        /// *   The value of this parameter must be consistent with the value of **BucketRegion**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group. You can call the [DescribeDBInstanceAttribute](~~610394~~) operation to obtain the ID of the resource group.
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
        /// The amount of storage that is required to restore the data of the full backup file. Unit: GB.
        /// 
        /// > 
        /// 
        /// *   The default value of this parameter is 5 times the size of the full backup file.
        /// 
        /// *   The minimum value of this parameter is 20.
        /// </summary>
        [NameInMap("RestoreSize")]
        [Validation(Required=false)]
        public int? RestoreSize { get; set; }

        /// <summary>
        /// The retention period of the full backup file. Unit: days. Valid values: any **non-zero** positive integer.
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

        /// <summary>
        /// The ID of the zone. You can call the [DescribeRegions](~~26243~~) operation to query the ID of the zone.
        /// 
        /// > 
        /// 
        /// *   If you specify this parameter, the system creates a snapshot in single-digit seconds, which greatly reduces the time that is required to import the full backup file.
        /// 
        /// *   When you call the [CreateDBInstance](~~26228~~) operation to create an instance by using the full backup file, the instance is created in the zone that you specify for this parameter.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
