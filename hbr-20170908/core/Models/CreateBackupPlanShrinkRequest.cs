// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateBackupPlanShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The backup type. Valid value: <b>COMPLETE</b>, which indicates full backup.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETE</para>
        /// </summary>
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// <para>This parameter is required only if the <b>SourceType</b> parameter is set to <b>OSS</b>. This parameter specifies the name of the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbr-backup-oss</para>
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// <para>The configurations of the incremental file synchronization. This parameter is required for data synchronization only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dataSourceId&quot;: &quot;ds-123456789&quot;, &quot;path&quot;: &quot;/changelist&quot;}</para>
        /// </summary>
        [NameInMap("ChangeListPath")]
        [Validation(Required=false)]
        public string ChangeListPath { get; set; }

        /// <summary>
        /// <para>This parameter is required only if the <b>SourceType</b> parameter is set to <b>NAS</b>. This parameter specifies the time to create the file system. The value must be a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1607436917</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The name of the RAM role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up and restore data across Alibaba Cloud accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BackupRole</para>
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// <para>Specifies whether data is backed up and restored within the same Alibaba Cloud account or across Alibaba Cloud accounts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SELF_ACCOUNT: Data is backed up and restored within the same Alibaba Cloud account.</description></item>
        /// <item><description>CROSS_ACCOUNT: Data is backed up and restored across Alibaba Cloud accounts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CROSS_ACCOUNT</para>
        /// </summary>
        [NameInMap("CrossAccountType")]
        [Validation(Required=false)]
        public string CrossAccountType { get; set; }

        /// <summary>
        /// <para>The ID of the source Alibaba Cloud account that authorizes the current Alibaba Cloud account to back up and restore data across Alibaba Cloud accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15897534xxxx4625</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;prefix\&quot;:\&quot;/\&quot;}</para>
        /// </summary>
        [NameInMap("DestDataSourceDetail")]
        [Validation(Required=false)]
        public string DestDataSourceDetailShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ds-*********************</para>
        /// </summary>
        [NameInMap("DestDataSourceId")]
        [Validation(Required=false)]
        public string DestDataSourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("DestSourceType")]
        [Validation(Required=false)]
        public string DestSourceType { get; set; }

        /// <summary>
        /// <para>The details about ECS instance backup. The value is a JSON string.</para>
        /// <list type="bullet">
        /// <item><description>snapshotGroup: specifies whether to use a snapshot-consistent group. This parameter is valid only if all disks of the ECS instance are enhanced SSDs (ESSDs).</description></item>
        /// <item><description>appConsistent: specifies whether to enable application consistency. If you set this parameter to true, you must also specify the preScriptPath and postScriptPath parameters.</description></item>
        /// <item><description>preScriptPath: the path to the prescript file.</description></item>
        /// <item><description>postScriptPath: the path to the postscript file.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;EnableFsFreeze\&quot;:true,\&quot;appConsistent\&quot;:false,\&quot;postScriptPath\&quot;:\&quot;\&quot;,\&quot;preScriptPath\&quot;:\&quot;\&quot;,\&quot;snapshotGroup\&quot;:true,\&quot;timeoutInSeconds\&quot;:60}</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string DetailShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// <para>This parameter is required only if the <b>SourceType</b> parameter is set to <b>ECS_FILE</b>. This parameter specifies the paths to the files that are excluded from the backup job. The value can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/var&quot;, &quot;/proc&quot;]</para>
        /// </summary>
        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        /// <summary>
        /// <para>This parameter is required only if the <b>SourceType</b> parameter is set to <b>NAS</b>. This parameter specifies the ID of the NAS file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>005494</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>This parameter is required only if the <b>SourceType</b> parameter is set to <b>ECS_FILE</b>. This parameter specifies the paths to the files that you want to back up. The value can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/home/alice/<em>.pdf&quot;, &quot;/home/bob/</em>.txt&quot;]</para>
        /// </summary>
        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        /// <summary>
        /// <para>This parameter is required only if the <b>SourceType</b> parameter is set to <b>ECS_FILE</b>. This parameter specifies the ID of the ECS instance.</para>
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
        /// <para>Specifies whether to enable the &quot;Keep at least one backup version&quot; feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The feature is disabled.</description></item>
        /// <item><description>1: The feature is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("KeepLatestSnapshots")]
        [Validation(Required=false)]
        public long? KeepLatestSnapshots { get; set; }

        /// <summary>
        /// <para>This parameter is required only if the <b>SourceType</b> parameter is set to <b>ECS_FILE</b>. This parameter specifies whether to use Windows Volume Shadow Copy Service (VSS) to define a backup path.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is available only for Windows ECS instances.</description></item>
        /// <item><description>If data changes occur in the backup source, the source data must be the same as the data to be backed up before the system sets this parameter to <c>[&quot;UseVSS&quot;:true]</c>.</description></item>
        /// <item><description>If you use VSS, you cannot back up data from multiple directories.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;UseVSS&quot;:false}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The details about the Tablestore instance.</para>
        /// </summary>
        [NameInMap("OtsDetail")]
        [Validation(Required=false)]
        public string OtsDetailShrink { get; set; }

        /// <summary>
        /// <para>The backup paths.</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public List<string> Path { get; set; }

        /// <summary>
        /// <para>The name of the backup schedule. The name must be 1 to 64 characters in length. The name of a backup schedule for each type of data source must be unique within a backup vault.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>planname</para>
        /// </summary>
        [NameInMap("PlanName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>This parameter is required only if the <b>SourceType</b> parameter is set to <b>OSS</b>. This parameter specifies the prefix of objects that you want to back up. After a prefix is specified, only objects whose names start with the prefix are backed up.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-prefix</para>
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The retention period of backup data. Minimum value: 1. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public long? Retention { get; set; }

        /// <summary>
        /// <para>The rules of the backup schedule.</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public List<CreateBackupPlanShrinkRequestRule> Rule { get; set; }
        public class CreateBackupPlanShrinkRequestRule : TeaModel {
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
            /// <para>The ID of the region to which data is replicated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("DestinationRegionId")]
            [Validation(Required=false)]
            public string DestinationRegionId { get; set; }

            /// <summary>
            /// <para>The retention period of the backup data in geo-redundancy mode. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("DestinationRetention")]
            [Validation(Required=false)]
            public long? DestinationRetention { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the rule.</para>
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
            /// <para>The retention period of the backup data. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule-test-name</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The backup policy. Format: I|{startTime}|{interval}. The system runs the first backup job at a point in time that is specified in the {startTime} parameter and the subsequent backup jobs at an interval that is specified in the {interval} parameter. The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is complete. For example, I|1631685600|P1D specifies that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.</para>
            /// <para>startTime: the time at which the system starts to run a backup job. The time must follow the UNIX time format. Unit: seconds. interval: the interval at which the system runs a backup job. The interval must follow the ISO 8601 standard. For example, PT1H specifies an interval of one hour. P1D specifies an interval of one day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>I|1602673264|P1D</para>
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

        }

        /// <summary>
        /// <para>The backup policy. Format: <c>I|{startTime}|{interval}</c>. The system runs the first backup job at a point in time that is specified in the <c>{startTime}</c> parameter and the subsequent backup jobs at an interval that is specified in the <c>{interval}</c> parameter. The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is complete. For example, <c>I|1631685600|P1D</c> specifies that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.</para>
        /// <list type="bullet">
        /// <item><description><b>startTime</b>: the time at which the system starts to run a backup job. The time must follow the UNIX time format. Unit: seconds.</description></item>
        /// <item><description><b>interval</b>: the interval at which the system runs a backup job. The interval must follow the ISO 8601 standard. For example, PT1H specifies an interval of one hour. P1D specifies an interval of one day.</description></item>
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
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_FILE</b>: backs up Elastic Compute Service (ECS) files.</description></item>
        /// <item><description><b>OSS</b>: backs up Object Storage Service (OSS) buckets.</description></item>
        /// <item><description><b>NAS</b>: backs up Apsara File Storage NAS file systems.</description></item>
        /// <item><description><b>OTS</b>: backs up Tablestore instances.</description></item>
        /// <item><description><b>UDM_ECS</b>: backs up ECS instances.</description></item>
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
        /// <para>This parameter is required only if the <b>SourceType</b> parameter is set to <b>ECS_FILE</b>. This parameter specifies the throttling rules. Format: <c>{start}|{end}|{bandwidth}</c>. Separate multiple throttling rules with vertical bars (|). A specified time range cannot overlap with another time range.</para>
        /// <list type="bullet">
        /// <item><description><b>start</b>: the start hour.</description></item>
        /// <item><description><b>end</b>: the end hour.</description></item>
        /// <item><description><b>bandwidth</b>: the bandwidth. Unit: KB/s.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0:24:5120</para>
        /// </summary>
        [NameInMap("SpeedLimit")]
        [Validation(Required=false)]
        public string SpeedLimit { get; set; }

        /// <summary>
        /// <para>The region in which the ECS instance that you want to back up resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("UdmRegionId")]
        [Validation(Required=false)]
        public string UdmRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-0006******q</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
