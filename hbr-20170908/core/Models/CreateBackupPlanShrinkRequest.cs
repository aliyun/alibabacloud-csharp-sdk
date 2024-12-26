// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateBackupPlanShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Backup type. Value: <b>COMPLETE</b>, indicating a full backup.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETE</para>
        /// </summary>
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// <para>This parameter is required when <b>SourceType</b> is set to <b>OSS</b>. It represents the OSS bucket name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbr-backup-oss</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>Configuration for the incremental file synchronization list. (Required only for synchronization)</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dataSourceId&quot;: &quot;ds-123456789&quot;, &quot;path&quot;: &quot;/changelist&quot;}</para>
        /// </summary>
        [NameInMap("ChangeListPath")]
        [Validation(Required=false)]
        public string ChangeListPath { get; set; }

        /// <summary>
        /// <para>This parameter is required when <b>SourceType</b> is set to <b>NAS</b>. It represents the creation time of the file system, in UNIX timestamp, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1607436917</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The role name created in the RAM of the original account for cross-account backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BackupRole</para>
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// <para>Cross-account backup type. Supported values:</para>
        /// <list type="bullet">
        /// <item><description>SELF_ACCOUNT: Backup within the same account</description></item>
        /// <item><description>CROSS_ACCOUNT: Cross-account backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CROSS_ACCOUNT</para>
        /// </summary>
        [NameInMap("CrossAccountType")]
        [Validation(Required=false)]
        public string CrossAccountType { get; set; }

        /// <summary>
        /// <para>The original account ID used for cross-account backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15897534xxxx4625</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        /// <summary>
        /// <para>Destination data source details. (Required only for synchronization)</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;prefix\&quot;:\&quot;/\&quot;}</para>
        /// </summary>
        [NameInMap("DestDataSourceDetail")]
        [Validation(Required=false)]
        public string DestDataSourceDetailShrink { get; set; }

        /// <summary>
        /// <para>Destination data source ID. (Required only for synchronization)</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-*********************</para>
        /// </summary>
        [NameInMap("DestDataSourceId")]
        [Validation(Required=false)]
        public string DestDataSourceId { get; set; }

        /// <summary>
        /// <para>Destination data source type. (Required only for synchronization)</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("DestSourceType")]
        [Validation(Required=false)]
        public string DestSourceType { get; set; }

        /// <summary>
        /// <para>Details of the whole machine backup, in JSON string format.</para>
        /// <list type="bullet">
        /// <item><description>snapshotGroup: Whether to use a consistent snapshot group (only valid if all instance disks are ESSD).</description></item>
        /// <item><description>appConsistent: Whether to use application consistency (requires the use of preScriptPath and postScriptPath parameters).</description></item>
        /// <item><description>preScriptPath: Path to the freeze script.</description></item>
        /// <item><description>postScriptPath: Path to the thaw script.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;EnableFsFreeze\&quot;:true,\&quot;appConsistent\&quot;:false,\&quot;postScriptPath\&quot;:\&quot;\&quot;,\&quot;preScriptPath\&quot;:\&quot;\&quot;,\&quot;snapshotGroup\&quot;:true,\&quot;timeoutInSeconds\&quot;:60}</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string DetailShrink { get; set; }

        /// <summary>
        /// <para>Is the plan disabled by default</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>ECS_FILE</b>. It specifies the path that should not be backed up, meaning all files under this path will not be included in the backup. The maximum length is 255 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/var&quot;, &quot;/proc&quot;]</para>
        /// </summary>
        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        /// <summary>
        /// <para>This parameter is required when <b>SourceType</b> is set to <b>NAS</b>. It represents the file system ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>005494</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>This parameter is required when <b>SourceType</b> is set to <b>ECS_FILE</b>. It represents the path to be backed up, and all files under this path will be backed up. Supports up to 255 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/home/alice/<em>.pdf&quot;, &quot;/home/bob/</em>.txt&quot;]</para>
        /// </summary>
        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        /// <summary>
        /// <para>This parameter is required when <b>SourceType</b> is set to <b>ECS_FILE</b>. It represents the ECS instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-m5e*****6q</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Table store instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instancename</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Whether to enable retaining at least one backup version.</para>
        /// <list type="bullet">
        /// <item><description>0 - Do not retain</description></item>
        /// <item><description>1 - Retain</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("KeepLatestSnapshots")]
        [Validation(Required=false)]
        public long? KeepLatestSnapshots { get; set; }

        /// <summary>
        /// <para>This parameter is required when <b>SourceType</b> is set to <b>ECS_FILE</b>. It indicates whether to use the Windows system VSS to define the backup path.</para>
        /// <list type="bullet">
        /// <item><description>This feature only supports Windows type ECS instances.</description></item>
        /// <item><description>If there are data changes in the backup source and you need to ensure consistency between the backup data and the source data, you can configure it as <c>[&quot;UseVSS&quot;:true]</c>.</description></item>
        /// <item><description>After choosing to use VSS, multiple file directories cannot be backed up simultaneously.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;UseVSS&quot;:false}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>Table store instance details.</para>
        /// </summary>
        [NameInMap("OtsDetail")]
        [Validation(Required=false)]
        public string OtsDetailShrink { get; set; }

        /// <summary>
        /// <para>Backup paths.</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public List<string> Path { get; set; }

        /// <summary>
        /// <para>Name of the backup plan. 1 to 64 characters. The name must be unique for each data source type within a single backup vault.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>planname</para>
        /// </summary>
        [NameInMap("PlanName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>This parameter is required when <b>SourceType</b> is set to <b>OSS</b>. It represents the backup prefix. When specified, only objects matching the prefix are backed up.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-prefix</para>
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>Number of days to retain the backup, with a minimum value of 1, in days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public long? Retention { get; set; }

        /// <summary>
        /// <para>Backup plan rules.</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public List<CreateBackupPlanShrinkRequestRule> Rule { get; set; }
        public class CreateBackupPlanShrinkRequestRule : TeaModel {
            /// <summary>
            /// <para>Backup type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>ID of the region for offsite replication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("DestinationRegionId")]
            [Validation(Required=false)]
            public string DestinationRegionId { get; set; }

            /// <summary>
            /// <para>Number of days to retain offsite backups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("DestinationRetention")]
            [Validation(Required=false)]
            public long? DestinationRetention { get; set; }

            /// <summary>
            /// <para>Whether the rule is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// <para>Whether to enable offsite replication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DoCopy")]
            [Validation(Required=false)]
            public bool? DoCopy { get; set; }

            /// <summary>
            /// <para>Backup retention period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            /// <summary>
            /// <para>Rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule-test-name</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>Backup strategy. Optional format: I|{startTime}|{interval}. This means that a backup task is executed every {interval} starting from {startTime}. Backup tasks for past times will not be executed. If the previous backup task has not been completed, the next backup task will not be triggered. For example, I|1631685600|P1D means a backup is performed every day starting from 2021-09-15 14:00:00.</para>
            /// <list type="bullet">
            /// <item><description>startTime: The start time of the backup, in UNIX time, in seconds.</description></item>
            /// <item><description>interval: ISO8601 time interval. For example, PT1H means an interval of one hour. P1D means an interval of one day.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>I|1602673264|P1D</para>
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

        }

        /// <summary>
        /// <para>Backup policy. Optional format: <c>I|{startTime}|{interval}</c>. This indicates that a backup task will be executed every <c>{interval}</c> starting from <c>{startTime}</c>. It does not compensate for missed backup tasks due to past time. If the previous backup task has not been completed, the next backup task will not be triggered. For example, <c>I|1631685600|P1D</c> means a backup is performed every day starting from 2021-09-15 14:00:00.</para>
        /// <list type="bullet">
        /// <item><description><b>startTime</b>: Start time of the backup, in UNIX timestamp, in seconds.</description></item>
        /// <item><description><b>interval</b>: ISO8601 time interval. For example, PT1H indicates an interval of one hour, and P1D indicates an interval of one day.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>I|1602673264|P1D</para>
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public string Schedule { get; set; }

        /// <summary>
        /// <para>Data source type, with the following options:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_FILE</b>: Backs up ECS files</description></item>
        /// <item><description><b>OSS</b>: Backs up Alibaba Cloud OSS</description></item>
        /// <item><description><b>NAS</b>: Backs up Alibaba Cloud NAS</description></item>
        /// <item><description><b>OTS</b>: Backs up Alibaba Cloud OTS</description></item>
        /// <item><description><b>UDM_ECS</b>: Backs up the entire ECS instance</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_FILE</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>This parameter is required when <b>SourceType</b> is set to <b>ECS_FILE</b>. It represents the backup traffic control. Format: <c>{start}:{end}:{bandwidth}</c>. Multiple traffic control configurations are separated by |, and the configured times should not overlap.</para>
        /// <list type="bullet">
        /// <item><description><b>start</b>: Start hour.</description></item>
        /// <item><description><b>end</b>: End hour.</description></item>
        /// <item><description><b>bandwidth</b>: Limit rate, in KB/s.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0:24:5120</para>
        /// </summary>
        [NameInMap("SpeedLimit")]
        [Validation(Required=false)]
        public string SpeedLimit { get; set; }

        /// <summary>
        /// <para>Region where the whole machine backup instance is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("UdmRegionId")]
        [Validation(Required=false)]
        public string UdmRegionId { get; set; }

        /// <summary>
        /// <para>Backup vault ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-0006******q</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
