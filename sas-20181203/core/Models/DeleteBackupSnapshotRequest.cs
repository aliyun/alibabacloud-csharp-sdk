// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteBackupSnapshotRequest : TeaModel {
        /// <summary>
        /// The regions for backup.
        /// </summary>
        [NameInMap("BackupRegionIdList")]
        [Validation(Required=false)]
        public List<string> BackupRegionIdList { get; set; }

        /// <summary>
        /// The backup snapshots.
        /// </summary>
        [NameInMap("BackupSnapshotList")]
        [Validation(Required=false)]
        public List<DeleteBackupSnapshotRequestBackupSnapshotList> BackupSnapshotList { get; set; }
        public class DeleteBackupSnapshotRequestBackupSnapshotList : TeaModel {
            /// <summary>
            /// The ID of the Cloud Backup client.
            /// 
            /// >  You can call the [DescribeSnapshots](~~DescribeSnapshots~~) operation to query the ID.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// The ID of the server.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The region in which Security Center is deployed. Valid values:
            /// 
            /// *   **cn-hangzhou**: China (Hangzhou).
            /// *   **ap-southeast-1**: Singapore.
            /// *   **cn-beijing**: China (Beijing).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the snapshot that you want to delete.
            /// 
            /// >  You can call the [DescribeSnapshots](~~DescribeSnapshots~~) operation to query the ID.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// The type of the data source. Valid values:
            /// 
            /// *   **ECS_FILE**: Elastic Compute Service (ECS) files.
            /// *   **OSS**: Object Storage Service (OSS) buckets.
            /// *   **NAS**: Apsara File Storage NAS (NAS) file systems.
            /// *   **OTS_TABLE**: Tablestore instances.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// The ID of the backup vault that is used in the restoration task.
            /// 
            /// >  You can call the [DescribeSnapshots](~~DescribeSnapshots~~) operation to query the ID.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("VaultId")]
            [Validation(Required=false)]
            public string VaultId { get; set; }

        }

        /// <summary>
        /// Specifies whether to retain the latest snapshot. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("RetainLatestSnapshot")]
        [Validation(Required=false)]
        public bool? RetainLatestSnapshot { get; set; }

    }

}
