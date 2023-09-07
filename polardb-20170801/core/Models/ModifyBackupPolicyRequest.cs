// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// The backup frequency. Default value: Normal. Valid values:
        /// 
        /// *   **Normal**: standard backup. The system backs up data once a day.
        /// *   **2/24H**: enhanced backup. The system backs up data every 2 hours.
        /// *   **3/24H**: enhanced backup. The system backs up data every 3 hours.
        /// *   **4/24H**: enhanced backup. The system backs up data every 4 hours.
        /// 
        /// >- If you enable enhanced backup, all backups are retained for 24 hours. For backup files that are created earlier than the previous 24 hours, the system permanently retains only the first backup that is created after 00:00 every day and deletes the rest.
        /// >- If you enable enhanced backup, **PreferredBackupPeriod** is automatically set to all days in a week (from Monday to Sunday).
        /// >- This parameter is invalid if the region where your PolarDB for MySQL cluster is deployed supports the cross-region backup feature. For information about the regions that support the cross-region backup feature, see [Overview](~~72672~~).
        /// </summary>
        [NameInMap("BackupFrequency")]
        [Validation(Required=false)]
        public string BackupFrequency { get; set; }

        /// <summary>
        /// Specifies whether to retain backups when you delete a cluster. Valid values:
        /// 
        /// *   **ALL**: permanently retains all backups.
        /// *   **LATEST**: permanently retains only the last backup.
        /// *   **NONE**: does not retain backups.
        /// 
        /// > The default value is NONE.
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public string BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// 
        /// > You can call the [DescribeDBClusters](~~98094~~) operation to query information about all clusters that are deployed in a specified region, such as the cluster ID.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The frequency of level-1 backups. Default value: Normal. Valid values:
        /// 
        /// *   **Normal**: standard backup. The system backs up data once a day.
        /// *   **2/24H**: enhanced backup. The system backs up data every 2 hours.
        /// *   **3/24H**: enhanced backup. The system backs up data every 3 hours.
        /// *   **4/24H**: enhanced backup. The system backs up data every 4 hours.
        /// 
        /// >- This parameter is invalid for PolarDB for Oracle clusters or PolarDB for PostgreSQL clusters.
        /// >- This parameter is invalid if the region where your PolarDB for MySQL cluster is deployed does not support the cross-region backup feature. For information about the regions that support the cross-region backup feature, see [Overview](~~72672~~).
        /// </summary>
        [NameInMap("DataLevel1BackupFrequency")]
        [Validation(Required=false)]
        public string DataLevel1BackupFrequency { get; set; }

        /// <summary>
        /// The backup cycle of level-1 backups. Valid values:
        /// 
        /// *   **Monday**
        /// *   **Tuesday**
        /// *   **Wednesday**
        /// *   **Thursday**
        /// *   **Friday**
        /// *   **Saturday**
        /// *   **Sunday**
        /// 
        /// >- You need to specify at least two values. Separate multiple values with commas (,).
        /// >- This parameter is invalid for PolarDB for Oracle clusters or PolarDB for PostgreSQL clusters.
        /// >- This parameter is invalid if the region where your PolarDB for MySQL cluster is deployed does not support the cross-region backup feature. For information about the regions that support the cross-region backup feature, see [Overview](~~72672~~).
        /// </summary>
        [NameInMap("DataLevel1BackupPeriod")]
        [Validation(Required=false)]
        public string DataLevel1BackupPeriod { get; set; }

        /// <summary>
        /// The retention period of level-1 backups. Valid values: 3 to 14. Unit: days.
        /// </summary>
        [NameInMap("DataLevel1BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string DataLevel1BackupRetentionPeriod { get; set; }

        /// <summary>
        /// The time period during which automatic backup for level-1 backup is performed. The time period is in the `hh:mmZ-hh:mmZ` format and is displayed in UTC. The start time and end time are on the hour and have an interval of 1 hour. Example: `14:00Z-15:00Z`.
        /// >- This parameter is invalid for PolarDB for Oracle clusters or PolarDB for PostgreSQL clusters.
        /// >- This parameter is invalid if the region where your PolarDB for MySQL cluster is deployed does not support the cross-region backup feature. For information about the regions that support the cross-region backup feature, see [Overview](~~72672~~).
        /// </summary>
        [NameInMap("DataLevel1BackupTime")]
        [Validation(Required=false)]
        public string DataLevel1BackupTime { get; set; }

        /// <summary>
        /// The region where the cross-region level-2 backup is stored. For information about regions that support the cross-region backup feature, see [Overview](~~72672~~).
        /// </summary>
        [NameInMap("DataLevel2BackupAnotherRegionRegion")]
        [Validation(Required=false)]
        public string DataLevel2BackupAnotherRegionRegion { get; set; }

        /// <summary>
        /// The retention period of cross-region level-2 backups. Valid values:
        /// 
        /// *   **0**: The cross-region level-2 backup feature is disabled.
        /// *   **30 to 7300**: Cross-region level-2 backups are retained for 30 to 7,300 days.
        /// *   **1**: Cross-region level-2 backups are permanently retained.
        /// 
        /// > The default value is **0**. By default, the cross-region level-2 backup feature is disabled when you create a cluster.
        /// </summary>
        [NameInMap("DataLevel2BackupAnotherRegionRetentionPeriod")]
        [Validation(Required=false)]
        public string DataLevel2BackupAnotherRegionRetentionPeriod { get; set; }

        /// <summary>
        /// The backup cycle of level-2 backups. Valid values:
        /// 
        /// *   **Monday**
        /// *   **Tuesday**
        /// *   **Wednesday**
        /// *   **Thursday**
        /// *   **Friday**
        /// *   **Saturday**
        /// *   **Sunday**
        /// 
        /// >- You need to specify at least two values. Separate multiple values with commas (,).
        /// >- This parameter is invalid for PolarDB for Oracle clusters or PolarDB for PostgreSQL clusters.
        /// >- This parameter is invalid if the region where your PolarDB for MySQL cluster is deployed does not support the cross-region backup feature. For information about the regions that support the cross-region backup feature, see [Overview](~~72672~~).
        /// </summary>
        [NameInMap("DataLevel2BackupPeriod")]
        [Validation(Required=false)]
        public string DataLevel2BackupPeriod { get; set; }

        /// <summary>
        /// The retention period of level-2 backups. Valid values:
        /// 
        /// *   **0**: The level-2 backup feature is disabled.
        /// *   **30 to 7300**: Cross-region level-2 backups are retained for 30 to 7,300 days.
        /// *   **1**: Cross-region level-2 backups are permanently retained.
        /// 
        /// > The default value is **0**. By default, the level-2 backup feature is disabled when you create a cluster.
        /// </summary>
        [NameInMap("DataLevel2BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string DataLevel2BackupRetentionPeriod { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The backup cycle. Valid values:
        /// 
        /// *   **Monday**
        /// *   **Tuesday**
        /// *   **Wednesday**
        /// *   **Thursday**
        /// *   **Friday**
        /// *   **Saturday**
        /// *   **Sunday**
        /// 
        /// >- You need to specify at least two values. Separate multiple values with commas (,).
        /// >- This parameter is invalid if the region where your PolarDB for MySQL cluster is deployed supports the cross-region backup feature. For information about the regions that support the cross-region backup feature, see [Overview](~~72672~~).
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// The time period during which automatic backup for level-1 backup is performed. The format is `hh:mmZ-hh:mmZ` format. The time is displayed in UTC. The start time and end time are on the hour and with an interval of one hour. Example: `14:00Z-15:00Z`.
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
