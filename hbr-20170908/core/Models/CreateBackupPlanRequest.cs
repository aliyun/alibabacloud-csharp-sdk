// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateBackupPlanRequest : TeaModel {
        /// <summary>
        /// <para>The backup type. Set the value to <b>COMPLETE</b>, which indicates full backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETE</para>
        /// </summary>
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>OSS</b>. The name of the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbr-backup-oss</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>The configuration of the incremental file synchronization list. This parameter is required only for data synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dataSourceId&quot;: &quot;ds-123456789&quot;, &quot;path&quot;: &quot;/changelist&quot;}</para>
        /// </summary>
        [NameInMap("ChangeListPath")]
        [Validation(Required=false)]
        public string ChangeListPath { get; set; }

        /// <summary>
        /// <para>The ID of the client group that executes the data synchronization plan. This parameter is required only for data synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cl-***************</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>NAS</b>. The time when the file system was created. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1607436917</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The name of the RAM role created in the source account for cross-account backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BackupRole</para>
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// <para>The cross-account backup type. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>SELF_ACCOUNT: backup within the same account.</description></item>
        /// <item><description>CROSS_ACCOUNT: cross-account backup.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CROSS_ACCOUNT</para>
        /// </summary>
        [NameInMap("CrossAccountType")]
        [Validation(Required=false)]
        public string CrossAccountType { get; set; }

        /// <summary>
        /// <para>The ID of the source account for cross-account backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15897534xxxx4625</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        /// <summary>
        /// <para>The ID of the source data source. This parameter is required only for data synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-****************</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>The details of the destination data source. This parameter is required only for data synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;prefix\&quot;:\&quot;/\&quot;}</para>
        /// </summary>
        [NameInMap("DestDataSourceDetail")]
        [Validation(Required=false)]
        public Dictionary<string, object> DestDataSourceDetail { get; set; }

        /// <summary>
        /// <para>The ID of the destination data source. This parameter is required only for data synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-*********************</para>
        /// </summary>
        [NameInMap("DestDataSourceId")]
        [Validation(Required=false)]
        public string DestDataSourceId { get; set; }

        /// <summary>
        /// <para>The type of the destination data source. This parameter is required only for data synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("DestSourceType")]
        [Validation(Required=false)]
        public string DestSourceType { get; set; }

        /// <summary>
        /// <para>The details of the full-copy backup. The value is a JSON string.</para>
        /// <list type="bullet">
        /// <item><description>snapshotGroup: specifies whether to use a consistent snapshot group. This parameter is valid only when all cloud disks of the instance are ESSDs.</description></item>
        /// <item><description>appConsistent: specifies whether to use application consistency. This parameter must be used together with the preScriptPath and postScriptPath parameters.</description></item>
        /// <item><description>preScriptPath: the path of the pre-freeze script.</description></item>
        /// <item><description>postScriptPath: the path of the post-thaw script.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;EnableFsFreeze\&quot;:true,\&quot;appConsistent\&quot;:false,\&quot;postScriptPath\&quot;:\&quot;\&quot;,\&quot;preScriptPath\&quot;:\&quot;\&quot;,\&quot;snapshotGroup\&quot;:true,\&quot;timeoutInSeconds\&quot;:60}</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public Dictionary<string, object> Detail { get; set; }

        /// <summary>
        /// <para>Specifies whether the plan is disabled by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// <para>The edition type. Valid values: BASIC and STANDARD. Default value: STANDARD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>ECS_FILE</b>. The path to exclude from the backup. All files in this path are not backed up. The value can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/var&quot;, &quot;/proc&quot;]</para>
        /// </summary>
        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        /// <summary>
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>NAS</b>. The file system ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>005494</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>ECS_FILE</b>. The path to include in the backup. All files in this path are backed up. The value can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/home/alice/<em>.pdf&quot;, &quot;/home/bob/</em>.txt&quot;]</para>
        /// </summary>
        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        /// <summary>
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>ECS_FILE</b>. The ECS instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-m5e*****6q</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the Tablestore instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instancename</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain at least one backup version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: does not retain.</description></item>
        /// <item><description>1: retains.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("KeepLatestSnapshots")]
        [Validation(Required=false)]
        public long? KeepLatestSnapshots { get; set; }

        /// <summary>
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>ECS_FILE</b>. Specifies whether to use Windows Volume Shadow Copy Service (VSS) to define the source path.</para>
        /// <list type="bullet">
        /// <item><description>This feature is supported only for Windows ECS instances.</description></item>
        /// <item><description>If the backup source contains data changes and you need to ensure consistency between the backup data and the source data, set this parameter to <c>[&quot;UseVSS&quot;:true]</c>.</description></item>
        /// <item><description>After VSS is enabled, multiple file folders cannot be backed up simultaneously.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;UseVSS&quot;:false}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The details of the Tablestore instance.</para>
        /// </summary>
        [NameInMap("OtsDetail")]
        [Validation(Required=false)]
        public OtsDetail OtsDetail { get; set; }

        /// <summary>
        /// <para>The source paths.</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public List<string> Path { get; set; }

        /// <summary>
        /// <para>The name of the backup plan. The name must be 1 to 64 characters in length. The backup plan name must be unique for each data source type within a single vault.</para>
        /// 
        /// <b>Example:</b>
        /// <para>planname</para>
        /// </summary>
        [NameInMap("PlanName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>OSS</b>. The backup prefix. If specified, only objects that match the prefix are backed up.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-prefix</para>
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The retention period of the backup data. Minimum value: 1. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public long? Retention { get; set; }

        /// <summary>
        /// <para>The backup plan rules.</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public List<CreateBackupPlanRequestRule> Rule { get; set; }
        public class CreateBackupPlanRequestRule : TeaModel {
            /// <summary>
            /// <para>The backup type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>The ID of the destination region for cross-region replication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("DestinationRegionId")]
            [Validation(Required=false)]
            public string DestinationRegionId { get; set; }

            /// <summary>
            /// <para>The retention period of the geo-redundancy backup. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("DestinationRetention")]
            [Validation(Required=false)]
            public long? DestinationRetention { get; set; }

            /// <summary>
            /// <para>Specifies whether the rule is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable cross-region replication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DoCopy")]
            [Validation(Required=false)]
            public bool? DoCopy { get; set; }

            /// <summary>
            /// <para>The retention period of the backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule-test-name</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The backup policy. Format: I|{startTime}|{interval}. This indicates that a backup job is executed at every {interval} starting from {startTime}. Backup jobs for past time periods are not executed. If the previous backup job is not completed, the next backup job is not triggered. Example: I|1631685600|P1D indicates that a backup is performed once a day starting from 2021-09-15 14:00:00.</para>
            /// <para>startTime: the start time of the backup. The value is a UNIX timestamp. Unit: seconds.
            /// interval: the ISO 8601 time interval. Example: PT1H indicates an interval of one hour. P1D indicates an interval of one day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>I|1602673264|P1D</para>
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

        }

        /// <summary>
        /// <para>The backup policy. Format: <c>I|{startTime}|{interval}</c>. This indicates that a backup job is executed at every <c>{interval}</c> starting from <c>{startTime}</c>. Backup jobs for past time periods are not compensated. If the previous backup job is not completed, the next backup job is not triggered. Example: <c>I|1631685600|P1D</c> indicates that a backup is performed once a day starting from 2021-09-15 14:00:00.</para>
        /// <list type="bullet">
        /// <item><description><b>startTime</b>: the start time of the backup. The value is a UNIX timestamp. Unit: seconds.</description></item>
        /// <item><description><b>interval</b>: the ISO 8601 time interval. Example: PT1H indicates an interval of one hour. P1D indicates an interval of one day.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>I|1602673264|P1D</para>
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public string Schedule { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_FILE</b>: backs up ECS files.</description></item>
        /// <item><description><b>OSS</b>: backs up Alibaba Cloud OSS.</description></item>
        /// <item><description><b>NAS</b>: backs up Alibaba Cloud NAS.</description></item>
        /// <item><description><b>OTS</b>: backs up Alibaba Cloud OTS.</description></item>
        /// <item><description><b>UDM_ECS</b>: backs up an entire ECS instance.</description></item>
        /// <item><description><b>SYNC</b>: data synchronization.</description></item>
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
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>ECS_FILE</b>. The backup traffic control. Format: <c>{start}:{end}:{bandwidth}</c>. Separate multiple traffic control configurations with vertical bars (|). The time ranges of the configurations cannot overlap.</para>
        /// <list type="bullet">
        /// <item><description><b>start</b>: the start hour.</description></item>
        /// <item><description><b>end</b>: the end hour.</description></item>
        /// <item><description><b>bandwidth</b>: the rate limit. Unit: KB/s.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0:24:5120</para>
        /// </summary>
        [NameInMap("SpeedLimit")]
        [Validation(Required=false)]
        public string SpeedLimit { get; set; }

        /// <summary>
        /// <para>The region where the ECS instance for full-copy backup resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("UdmRegionId")]
        [Validation(Required=false)]
        public string UdmRegionId { get; set; }

        /// <summary>
        /// <para>The vault ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-0006******q</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
