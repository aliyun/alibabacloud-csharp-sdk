// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCrossRegionBackupsResponseBody : TeaModel {
        /// <summary>
        /// The end of the time range to query.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The cross-region data backup files.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeCrossRegionBackupsResponseBodyItems Items { get; set; }
        public class DescribeCrossRegionBackupsResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeCrossRegionBackupsResponseBodyItemsItem> Item { get; set; }
            public class DescribeCrossRegionBackupsResponseBodyItemsItem : TeaModel {
                /// <summary>
                /// The time when the cross-region data backup file was generated.
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// The method that is used to generate the cross-region data backup file. Valid values:
                /// 
                /// *   **L**: logical backup
                /// *   **P**: physical backup
                /// </summary>
                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                /// <summary>
                /// The level at which the cross-region data backup file is generated.
                /// 
                /// *   **0**: instance-level backup
                /// *   **1**: database-level backup
                /// </summary>
                [NameInMap("BackupSetScale")]
                [Validation(Required=false)]
                public int? BackupSetScale { get; set; }

                /// <summary>
                /// The status of the cross-region data backup. Valid values:
                /// 
                /// *   **0**: The cross-region data backup is successful.
                /// *   **1**: The cross-region data backup failed.
                /// </summary>
                [NameInMap("BackupSetStatus")]
                [Validation(Required=false)]
                public int? BackupSetStatus { get; set; }

                /// <summary>
                /// The time when the cross-region data backup started.
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// The type of the cross-region data backup. Valid values:
                /// 
                /// *   **F**: full data backup
                /// *   **I**: incremental data backup
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                /// <summary>
                /// The RDS edition of the instance. Valid values:
                /// 
                /// *   **Basic**: RDS Basic Edition.
                /// *   **HighAvailability**: RDS High-availability Edition.
                /// *   **Finance**: RDS Enterprise Edition. This edition is available only for the China site (aliyun.com).
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The point in time that is indicated by the data in the cross-region data backup file.
                /// </summary>
                [NameInMap("ConsistentTime")]
                [Validation(Required=false)]
                public string ConsistentTime { get; set; }

                /// <summary>
                /// The external URL from which you can download the cross-region data backup file.
                /// </summary>
                [NameInMap("CrossBackupDownloadLink")]
                [Validation(Required=false)]
                public string CrossBackupDownloadLink { get; set; }

                /// <summary>
                /// The ID of the cross-region data backup file.
                /// </summary>
                [NameInMap("CrossBackupId")]
                [Validation(Required=false)]
                public int? CrossBackupId { get; set; }

                /// <summary>
                /// The ID of the region in which the cross-region backup files of the instance are stored.
                /// </summary>
                [NameInMap("CrossBackupRegion")]
                [Validation(Required=false)]
                public string CrossBackupRegion { get; set; }

                /// <summary>
                /// The name of the compressed package that contains the cross-region data backup file.
                /// </summary>
                [NameInMap("CrossBackupSetFile")]
                [Validation(Required=false)]
                public string CrossBackupSetFile { get; set; }

                /// <summary>
                /// The location where the cross-region data backup file is stored.
                /// </summary>
                [NameInMap("CrossBackupSetLocation")]
                [Validation(Required=false)]
                public string CrossBackupSetLocation { get; set; }

                /// <summary>
                /// The size of the cross-region data backup file. Unit: bytes.
                /// </summary>
                [NameInMap("CrossBackupSetSize")]
                [Validation(Required=false)]
                public long? CrossBackupSetSize { get; set; }

                /// <summary>
                /// The storage type. Valid values:
                /// 
                /// *   **local_ssd**: local SSDs. This is the recommended storage type.
                /// *   **cloud_ssd**: standard SSD.
                /// *   **cloud_essd**: enhanced SSD (ESSD).
                /// </summary>
                [NameInMap("DBInstanceStorageType")]
                [Validation(Required=false)]
                public string DBInstanceStorageType { get; set; }

                /// <summary>
                /// The database engine of the instance.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The database engine version.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The instance ID. This parameter is used to determine whether the instance that generates the cross-region data backup file is a primary or secondary instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public int? InstanceId { get; set; }

                /// <summary>
                /// The regions to which the cross-region data backup file can be restored.
                /// </summary>
                [NameInMap("RestoreRegions")]
                [Validation(Required=false)]
                public DescribeCrossRegionBackupsResponseBodyItemsItemRestoreRegions RestoreRegions { get; set; }
                public class DescribeCrossRegionBackupsResponseBodyItemsItemRestoreRegions : TeaModel {
                    [NameInMap("RestoreRegion")]
                    [Validation(Required=false)]
                    public List<string> RestoreRegion { get; set; }

                }

            }

        }

        /// <summary>
        /// The page number. Pages start from page 1.
        /// 
        /// Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of cross-region data backup files on the current page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The total number of entries that are returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
