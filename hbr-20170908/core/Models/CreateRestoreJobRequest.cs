// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateRestoreJobRequest : TeaModel {
        /// <summary>
        /// The name of the RAM role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// Specifies whether data is backed up within the same Alibaba Cloud account or across Alibaba Cloud accounts. Valid values:
        /// 
        /// *   SELF_ACCOUNT: Data is backed up within the same Alibaba Cloud account.
        /// *   CROSS_ACCOUNT: Data is backed up across Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("CrossAccountType")]
        [Validation(Required=false)]
        public string CrossAccountType { get; set; }

        /// <summary>
        /// The ID of the source Alibaba Cloud account that authorizes the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        /// <summary>
        /// The paths to the files that you do not want to restore. No files in the specified paths are restored. The value must be 1 to 255 characters in length.
        /// </summary>
        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        [NameInMap("FailbackDetail")]
        [Validation(Required=false)]
        public Dictionary<string, object> FailbackDetail { get; set; }

        /// <summary>
        /// The paths to the files that you want to restore. All files in the specified paths are restored. The value must be 1 to 255 characters in length.
        /// </summary>
        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        /// <summary>
        /// Specifies whether to initiate the request by using Container Service for Kubernetes (ACK). Default value: false.
        /// </summary>
        [NameInMap("InitiatedByAck")]
        [Validation(Required=false)]
        public bool? InitiatedByAck { get; set; }

        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// The details about the Tablestore instance.
        /// </summary>
        [NameInMap("OtsDetail")]
        [Validation(Required=false)]
        public OtsTableRestoreDetail OtsDetail { get; set; }

        /// <summary>
        /// The type of the restore destination. Valid values:
        /// 
        /// *   **ECS_FILE**: restores data to Elastic Compute Service (ECS) files.
        /// *   **OSS**: restores data to Object Storage Service (OSS) buckets.
        /// *   **NAS**: restores data to Apsara File Storage NAS file systems.
        /// *   **OTS_TABLE**: restores data to Tablestore instances.
        /// *   **UDM_ECS_ROLLBACK**: restores data to ECS instances.
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// The hash value of the backup snapshot.
        /// </summary>
        [NameInMap("SnapshotHash")]
        [Validation(Required=false)]
        public string SnapshotHash { get; set; }

        /// <summary>
        /// The ID of the backup snapshot.
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   **ECS_FILE**: ECS files
        /// *   **OSS**: OSS buckets
        /// *   **NAS**: NAS file systems
        /// *   **OTS_TABLE**: Tablestore instances
        /// *   **UDM_ECS**: ECS instances
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// This parameter is required only if the **RestoreType** parameter is set to **OSS**. This parameter specifies the name of the OSS bucket to which you want to restore data.
        /// </summary>
        [NameInMap("TargetBucket")]
        [Validation(Required=false)]
        public string TargetBucket { get; set; }

        /// <summary>
        /// The details about the container to which you want to restore data.
        /// </summary>
        [NameInMap("TargetContainer")]
        [Validation(Required=false)]
        public string TargetContainer { get; set; }

        /// <summary>
        /// The ID of the container cluster to which you want to restore data.
        /// </summary>
        [NameInMap("TargetContainerClusterId")]
        [Validation(Required=false)]
        public string TargetContainerClusterId { get; set; }

        /// <summary>
        /// This parameter is required only if the **RestoreType** parameter is set to **NAS**. This parameter specifies the time when the file system is created.
        /// </summary>
        [NameInMap("TargetCreateTime")]
        [Validation(Required=false)]
        public long? TargetCreateTime { get; set; }

        /// <summary>
        /// This parameter is required only if the **RestoreType** parameter is set to **NAS**. This parameter specifies the ID of the file system to which you want to restore data.
        /// </summary>
        [NameInMap("TargetFileSystemId")]
        [Validation(Required=false)]
        public string TargetFileSystemId { get; set; }

        /// <summary>
        /// This parameter is required only if the **RestoreType** parameter is set to **ECS_FILE**. This parameter specifies the ID of the ECS instance to which you want to restore data.
        /// </summary>
        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// The name of the Tablestore instance to which you want to restore data.
        /// </summary>
        [NameInMap("TargetInstanceName")]
        [Validation(Required=false)]
        public string TargetInstanceName { get; set; }

        /// <summary>
        /// This parameter is required only if the **RestoreType** parameter is set to **ECS_FILE**. This parameter specifies the destination file path.
        /// </summary>
        [NameInMap("TargetPath")]
        [Validation(Required=false)]
        public string TargetPath { get; set; }

        /// <summary>
        /// This parameter is required only if the **RestoreType** parameter is set to **OSS**. This parameter specifies the prefix of objects that you want to restore.
        /// </summary>
        [NameInMap("TargetPrefix")]
        [Validation(Required=false)]
        public string TargetPrefix { get; set; }

        /// <summary>
        /// The name of the table that stores the restored data.
        /// </summary>
        [NameInMap("TargetTableName")]
        [Validation(Required=false)]
        public string TargetTableName { get; set; }

        /// <summary>
        /// The time when data is restored to the Tablestore instance. The value must be a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("TargetTime")]
        [Validation(Required=false)]
        public long? TargetTime { get; set; }

        /// <summary>
        /// The details of ECS instance backup.
        /// </summary>
        [NameInMap("UdmDetail")]
        [Validation(Required=false)]
        public Dictionary<string, object> UdmDetail { get; set; }

        /// <summary>
        /// This parameter is required only if you set the **SourceType** parameter to **UDM_ECS**. This parameter specifies the region to which you want to restore data.
        /// </summary>
        [NameInMap("UdmRegionId")]
        [Validation(Required=false)]
        public string UdmRegionId { get; set; }

        /// <summary>
        /// The ID of the backup vault to which the backup snapshot belongs.
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
