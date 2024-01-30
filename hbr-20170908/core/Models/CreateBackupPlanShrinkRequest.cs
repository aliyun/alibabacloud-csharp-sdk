// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateBackupPlanShrinkRequest : TeaModel {
        /// <summary>
        /// The backup type. Valid value: **COMPLETE**, which indicates full backup.
        /// </summary>
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// This parameter is required only if the **SourceType** parameter is set to **OSS**. This parameter specifies the name of the OSS bucket.
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// The configurations of the incremental file synchronization. This parameter is required for data synchronization only.
        /// </summary>
        [NameInMap("ChangeListPath")]
        [Validation(Required=false)]
        public string ChangeListPath { get; set; }

        /// <summary>
        /// This parameter is required only if the **SourceType** parameter is set to **NAS**. This parameter specifies the time to create the file system. The value must be a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// The name of the RAM role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up and restore data across Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// Specifies whether data is backed up and restored within the same Alibaba Cloud account or across Alibaba Cloud accounts. Valid values:
        /// 
        /// *   SELF_ACCOUNT: Data is backed up and restored within the same Alibaba Cloud account.
        /// *   CROSS_ACCOUNT: Data is backed up and restored across Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("CrossAccountType")]
        [Validation(Required=false)]
        public string CrossAccountType { get; set; }

        /// <summary>
        /// The ID of the source Alibaba Cloud account that authorizes the current Alibaba Cloud account to back up and restore data across Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        [NameInMap("DestDataSourceDetail")]
        [Validation(Required=false)]
        public string DestDataSourceDetailShrink { get; set; }

        [NameInMap("DestDataSourceId")]
        [Validation(Required=false)]
        public string DestDataSourceId { get; set; }

        [NameInMap("DestSourceType")]
        [Validation(Required=false)]
        public string DestSourceType { get; set; }

        /// <summary>
        /// The details about ECS instance backup. The value is a JSON string.
        /// 
        /// *   snapshotGroup: specifies whether to use a snapshot-consistent group. This parameter is valid only if all disks of the ECS instance are enhanced SSDs (ESSDs).
        /// *   appConsistent: specifies whether to enable application consistency. If you set this parameter to true, you must also specify the preScriptPath and postScriptPath parameters.
        /// *   preScriptPath: the path to the prescript file.
        /// *   postScriptPath: the path to the postscript file.
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string DetailShrink { get; set; }

        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// This parameter is required only if the **SourceType** parameter is set to **ECS_FILE**. This parameter specifies the paths to the files that are excluded from the backup job. The value can be up to 255 characters in length.
        /// </summary>
        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        /// <summary>
        /// This parameter is required only if the **SourceType** parameter is set to **NAS**. This parameter specifies the ID of the NAS file system.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// This parameter is required only if the **SourceType** parameter is set to **ECS_FILE**. This parameter specifies the paths to the files that you want to back up. The value can be up to 255 characters in length.
        /// </summary>
        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        /// <summary>
        /// This parameter is required only if the **SourceType** parameter is set to **ECS_FILE**. This parameter specifies the ID of the ECS instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the Tablestore instance.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Specifies whether to enable the "Keep at least one backup version" feature. Valid values:
        /// 
        /// *   0: The feature is disabled.
        /// *   1: The feature is enabled.
        /// </summary>
        [NameInMap("KeepLatestSnapshots")]
        [Validation(Required=false)]
        public long? KeepLatestSnapshots { get; set; }

        /// <summary>
        /// This parameter is required only if the **SourceType** parameter is set to **ECS_FILE**. This parameter specifies whether to use Windows Volume Shadow Copy Service (VSS) to define a backup path.
        /// 
        /// *   This parameter is available only for Windows ECS instances.
        /// *   If data changes occur in the backup source, the source data must be the same as the data to be backed up before the system sets this parameter to `["UseVSS":true]`.
        /// *   If you use VSS, you cannot back up data from multiple directories.
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// The details about the Tablestore instance.
        /// </summary>
        [NameInMap("OtsDetail")]
        [Validation(Required=false)]
        public string OtsDetailShrink { get; set; }

        /// <summary>
        /// The backup paths.
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public List<string> Path { get; set; }

        /// <summary>
        /// The name of the backup schedule. The name must be 1 to 64 characters in length. The name of a backup schedule for each type of data source must be unique within a backup vault.
        /// </summary>
        [NameInMap("PlanName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// This parameter is required only if the **SourceType** parameter is set to **OSS**. This parameter specifies the prefix of objects that you want to back up. After a prefix is specified, only objects whose names start with the prefix are backed up.
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// The retention period of backup data. Minimum value: 1. Unit: days.
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public long? Retention { get; set; }

        /// <summary>
        /// The rules of the backup schedule.
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public List<CreateBackupPlanShrinkRequestRule> Rule { get; set; }
        public class CreateBackupPlanShrinkRequestRule : TeaModel {
            /// <summary>
            /// The backup type.
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// The ID of the region to which data is replicated.
            /// </summary>
            [NameInMap("DestinationRegionId")]
            [Validation(Required=false)]
            public string DestinationRegionId { get; set; }

            /// <summary>
            /// The retention period of the backup data in geo-redundancy mode. Unit: days.
            /// </summary>
            [NameInMap("DestinationRetention")]
            [Validation(Required=false)]
            public long? DestinationRetention { get; set; }

            /// <summary>
            /// Specifies whether to enable the rule.
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// Specifies whether to enable cross-region replication.
            /// </summary>
            [NameInMap("DoCopy")]
            [Validation(Required=false)]
            public bool? DoCopy { get; set; }

            /// <summary>
            /// The retention period of the backup data. Unit: days.
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The backup policy. Format: I|{startTime}|{interval}. The system runs the first backup job at a point in time that is specified in the {startTime} parameter and the subsequent backup jobs at an interval that is specified in the {interval} parameter. The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is complete. For example, I|1631685600|P1D specifies that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.
            /// 
            /// startTime: the time at which the system starts to run a backup job. The time must follow the UNIX time format. Unit: seconds. interval: the interval at which the system runs a backup job. The interval must follow the ISO 8601 standard. For example, PT1H specifies an interval of one hour. P1D specifies an interval of one day.
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

        }

        /// <summary>
        /// The backup policy. Format: `I|{startTime}|{interval}`. The system runs the first backup job at a point in time that is specified in the `{startTime}` parameter and the subsequent backup jobs at an interval that is specified in the `{interval}` parameter. The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is complete. For example, `I|1631685600|P1D` specifies that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.
        /// 
        /// *   **startTime**: the time at which the system starts to run a backup job. The time must follow the UNIX time format. Unit: seconds.
        /// *   **interval**: the interval at which the system runs a backup job. The interval must follow the ISO 8601 standard. For example, PT1H specifies an interval of one hour. P1D specifies an interval of one day.
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public string Schedule { get; set; }

        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   **ECS_FILE**: backs up Elastic Compute Service (ECS) files.
        /// *   **OSS**: backs up Object Storage Service (OSS) buckets.
        /// *   **NAS**: backs up Apsara File Storage NAS file systems.
        /// *   **OTS**: backs up Tablestore instances.
        /// *   **UDM_ECS**: backs up ECS instances.
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// This parameter is required only if the **SourceType** parameter is set to **ECS_FILE**. This parameter specifies the throttling rules. Format: `{start}|{end}|{bandwidth}`. Separate multiple throttling rules with vertical bars (|). A specified time range cannot overlap with another time range.
        /// 
        /// *   **start**: the start hour.
        /// *   **end**: the end hour.
        /// *   **bandwidth**: the bandwidth. Unit: KB/s.
        /// </summary>
        [NameInMap("SpeedLimit")]
        [Validation(Required=false)]
        public string SpeedLimit { get; set; }

        /// <summary>
        /// The region in which the ECS instance that you want to back up resides.
        /// </summary>
        [NameInMap("UdmRegionId")]
        [Validation(Required=false)]
        public string UdmRegionId { get; set; }

        /// <summary>
        /// The ID of the backup vault.
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
