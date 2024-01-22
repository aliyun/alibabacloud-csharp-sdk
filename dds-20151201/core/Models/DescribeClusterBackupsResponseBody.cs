// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeClusterBackupsResponseBody : TeaModel {
        /// <summary>
        /// The cluster backup sets. A cluster backup file contains the backup sets of each node.
        /// </summary>
        [NameInMap("ClusterBackups")]
        [Validation(Required=false)]
        public List<DescribeClusterBackupsResponseBodyClusterBackups> ClusterBackups { get; set; }
        public class DescribeClusterBackupsResponseBodyClusterBackups : TeaModel {
            /// <summary>
            /// The collection of the backup sets of each child node in a cluster backup set.
            /// </summary>
            [NameInMap("Backups")]
            [Validation(Required=false)]
            public List<DescribeClusterBackupsResponseBodyClusterBackupsBackups> Backups { get; set; }
            public class DescribeClusterBackupsResponseBodyClusterBackupsBackups : TeaModel {
                /// <summary>
                /// The URL that is used to download the backup set over the Internet. If the backup set cannot be downloaded, an empty string is returned.
                /// </summary>
                [NameInMap("BackupDownloadURL")]
                [Validation(Required=false)]
                public string BackupDownloadURL { get; set; }

                /// <summary>
                /// The end of the backup time range. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// The ID of the backup set.
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                /// <summary>
                /// The URL that is used to download the backup set over an internal network. If the backup set cannot be downloaded, null is returned.
                /// </summary>
                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

                /// <summary>
                /// The backup name.
                /// </summary>
                [NameInMap("BackupName")]
                [Validation(Required=false)]
                public string BackupName { get; set; }

                /// <summary>
                /// The size of the backup file. Unit: bytes.
                /// </summary>
                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public string BackupSize { get; set; }

                /// <summary>
                /// The beginning of the backup time range. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// The status of the backup task. Valid values:
                /// 
                /// *   **Success**: The backup task is successful.
                /// *   **Failed**: The backup task failed.
                /// </summary>
                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                /// <summary>
                /// The name of the shard.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// Indicates whether the backup set is available. Valid values:
                /// 
                /// *   **0**: unavailable
                /// *   **1**: available
                /// </summary>
                [NameInMap("IsAvail")]
                [Validation(Required=false)]
                public string IsAvail { get; set; }

            }

            /// <summary>
            /// The end of the time range within which the cluster backup is performed.
            /// </summary>
            [NameInMap("ClusterBackupEndTime")]
            [Validation(Required=false)]
            public string ClusterBackupEndTime { get; set; }

            /// <summary>
            /// The ID of the cluster backup set.
            /// </summary>
            [NameInMap("ClusterBackupId")]
            [Validation(Required=false)]
            public string ClusterBackupId { get; set; }

            /// <summary>
            /// The cluster backup mode.
            /// </summary>
            [NameInMap("ClusterBackupMode")]
            [Validation(Required=false)]
            public string ClusterBackupMode { get; set; }

            /// <summary>
            /// The size of the cluster backup set. Unit: bytes.
            /// </summary>
            [NameInMap("ClusterBackupSize")]
            [Validation(Required=false)]
            public string ClusterBackupSize { get; set; }

            /// <summary>
            /// The beginning of the time range within which the cluster backup is performed.
            /// </summary>
            [NameInMap("ClusterBackupStartTime")]
            [Validation(Required=false)]
            public string ClusterBackupStartTime { get; set; }

            /// <summary>
            /// The status of the cluster backup set.
            /// </summary>
            [NameInMap("ClusterBackupStatus")]
            [Validation(Required=false)]
            public string ClusterBackupStatus { get; set; }

            /// <summary>
            /// The additional information in JSON format.
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public DescribeClusterBackupsResponseBodyClusterBackupsExtraInfo ExtraInfo { get; set; }
            public class DescribeClusterBackupsResponseBodyClusterBackupsExtraInfo : TeaModel {
                /// <summary>
                /// Indicates whether the cluster backups are from the historical backup sets. If the value of this parameter is **1**, the cluster backups are migrated from the historical backup sets.
                /// </summary>
                [NameInMap("RegistryFromHistory")]
                [Validation(Required=false)]
                public string RegistryFromHistory { get; set; }

            }

            /// <summary>
            /// Indicates whether the cluster backup sets take effect. Valid values:
            /// 
            /// *   **1**: The cluster backup sets take effect.
            /// *   **0**: The backup sets of child nodes are incomplete or fail.
            /// </summary>
            [NameInMap("IsAvail")]
            [Validation(Required=false)]
            public int? IsAvail { get; set; }

            /// <summary>
            /// The progress of the backup task. Unit: %. The progress is returned only for running backup tasks.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

        }

        /// <summary>
        /// The maximum number of entries returned.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The page number of the page returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
