// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// The backup frequency. Default value: Normal. Valid values:
        /// 
        /// *   **Normal**: standard backup. The system backs up data once a day.
        /// *   **2/24H**: enhanced backup. The system backs up data every 2 hours.
        /// *   **3/24H**: enhanced backup. The system backs up data every 3 hours.
        /// *   **4/24H**: enhanced backup. The system backs up data every 4 hours.
        /// 
        /// > - If enhanced backup is enabled, all backups are retained for 24 hours. Backups are automatically deleted when the retention period ends. However, the system permanently retains the first backup that is created after 00:00 every day.
        /// >-  If enhanced backup is enabled, **PreferredBackupPeriod** is automatically set to all days in a week (from Monday to Sunday).
        /// </summary>
        [NameInMap("BackupFrequency")]
        [Validation(Required=false)]
        public string BackupFrequency { get; set; }

        /// <summary>
        /// Indicates whether backups are retained when you delete a cluster. Valid values:
        /// 
        /// *   **ALL**: permanently retains all backups.
        /// *   **LATEST**: permanently retains only the last backup.
        /// *   **NONE**: does not retain backups.
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public string BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// The backup frequency of level-1 backups. Default value: Normal. Valid values:
        /// 
        /// *   **Normal**: standard backup. The system backs up data once a day.
        /// *   **2/24H**: frequent backup. The system backs up data every 2 hours.
        /// *   **3/24H**: frequent backup. The system backs up data every 3 hours.
        /// *   **4/24H**: frequent backup. The system backs up data every 4 hours.
        /// 
        /// >- This parameter is not supported for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters.
        /// >- This parameter is unavailable if the region where your PolarDB for MySQL cluster is deployed does not support the cross-region backup feature. For information about regions that support the cross-region backup feature, see [Overview](~~72672~~).
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
        /// >- This parameter is not supported for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters.
        /// >- This parameter is unavailable if the region where your PolarDB for MySQL cluster is deployed does not support the cross-region backup feature. For information about regions that support the cross-region backup feature, see [Overview](~~72672~~).
        /// </summary>
        [NameInMap("DataLevel1BackupPeriod")]
        [Validation(Required=false)]
        public string DataLevel1BackupPeriod { get; set; }

        /// <summary>
        /// The retention period of level-1 backups. Valid values: 3 to 14. Unit: day.
        /// </summary>
        [NameInMap("DataLevel1BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string DataLevel1BackupRetentionPeriod { get; set; }

        /// <summary>
        /// The period of time during which automatic backup is performed. The value must be in the `hh:mmZ-hh:mmZ` format. The time must be in UTC. The start time and the end time must be on the hour and must have an interval of 1 hour. Example: `14:00Z-15:00Z`.
        /// 
        /// >- This parameter is not supported for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters.
        /// >- This parameter is unavailable if the region where your PolarDB for MySQL cluster is deployed does not support the cross-region backup feature. For information about regions that support the cross-region backup feature, see [Overview](~~72672~~).
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
        /// > The default value is **0**. By default, the level-2 backup feature is disabled when you create a cluster.
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
        /// >- This parameter is not supported for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters.
        /// >- This parameter is unavailable if the region where your PolarDB for MySQL cluster is deployed does not support the cross-region backup feature. For information about regions that support the cross-region backup feature, see [Overview](~~72672~~).
        /// </summary>
        [NameInMap("DataLevel2BackupPeriod")]
        [Validation(Required=false)]
        public string DataLevel2BackupPeriod { get; set; }

        /// <summary>
        /// The retention period of level-2 backups. Valid values:
        /// 
        /// *   0: The level-2 backup feature is disabled.
        /// *   30 to 7300: Level-2 backups are retained for 30 to 7,300 days.
        /// *   \-1: Level-2 backups are permanently retained.
        /// 
        /// > The default value is **0**. By default, the level-2 backup feature is disabled when you create a cluster.
        /// </summary>
        [NameInMap("DataLevel2BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string DataLevel2BackupRetentionPeriod { get; set; }

        /// <summary>
        /// The backup cycle. Valid values:
        /// 
        /// *   Monday
        /// *   Tuesday
        /// *   Wednesday
        /// *   Thursday
        /// *   Friday
        /// *   Saturday
        /// *   Sunday
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// The time period when automatic backups are performed. The format is `HH:mmZ-HH:mmZ`. The time is displayed in UTC.
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// The time when the next automatic backup will be performed. The format is `YYYY-MM-DDThh:mmZ`. The time is displayed in UTC.
        /// </summary>
        [NameInMap("PreferredNextBackupTime")]
        [Validation(Required=false)]
        public string PreferredNextBackupTime { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
