// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateBackupPlanShrinkRequest : TeaModel {
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
        /// <para>The details about ECS instance backup. The value is a JSON string.</para>
        /// <list type="bullet">
        /// <item><description>snapshotGroup: specifies whether to use a snapshot-consistent group. This parameter is valid only if all disks of the ECS instance are enhanced SSDs (ESSDs).</description></item>
        /// <item><description>appConsistent: specifies whether to enable application consistency. If you set this parameter to true, you must also specify the preScriptPath and postScriptPath parameters.</description></item>
        /// <item><description>preScriptPath: the path to the pre-freeze scripts.</description></item>
        /// <item><description>postScriptPath: the path to the post-thaw scripts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;EnableFsFreeze\&quot;:true,\&quot;appConsistent\&quot;:false,\&quot;postScriptPath\&quot;:\&quot;\&quot;,\&quot;preScriptPath\&quot;:\&quot;\&quot;,\&quot;snapshotGroup\&quot;:true,\&quot;timeoutInSeconds\&quot;:60}</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string DetailShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required only if the <b>SourceType</b> parameter is set to <b>ECS_FILE</b>. This parameter specifies the paths to the files that are excluded from the backup job. The value must be 1 to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/var&quot;, &quot;/proc&quot;]</para>
        /// </summary>
        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        /// <summary>
        /// <para>This parameter is required only if the <b>SourceType</b> parameter is set to <b>ECS_FILE</b>. This parameter specifies the paths to the files that you want to back up. The value must be 1 to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/home/alice/<em>.pdf&quot;, &quot;/home/bob/</em>.txt&quot;]</para>
        /// </summary>
        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the feature of keeping at least one backup version. Valid values:</para>
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
        /// <para>This parameter is required only if the <b>SourceType</b> parameter is set to <b>ECS_FILE</b>. This parameter specifies whether to use Windows Volume Shadow Copy Service (VSS) to define a source path.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is available only for Windows ECS instances.</description></item>
        /// <item><description>If data changes occur in the backup source, the source data must be the same as the data to be backed up before you can set this parameter to <c>[&quot;UseVSS&quot;:true]</c>.</description></item>
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
        /// <para>The source paths.</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public List<string> Path { get; set; }

        /// <summary>
        /// <para>The ID of the backup plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan-20211***735</para>
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The name of the backup plan.</para>
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
        /// <para>The retention period of the backup data. Minimum value: 1. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public long? Retention { get; set; }

        /// <summary>
        /// <para>The rule of the backup plan.</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public List<UpdateBackupPlanShrinkRequestRule> Rule { get; set; }
        public class UpdateBackupPlanShrinkRequestRule : TeaModel {
            /// <summary>
            /// <para>The backup type. Valid value: <b>COMPLETE</b>, which indicates full backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>The ID of the region where the remote backup vault resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("DestinationRegionId")]
            [Validation(Required=false)]
            public string DestinationRegionId { get; set; }

            /// <summary>
            /// <para>The retention period of the backup data. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("DestinationRetention")]
            [Validation(Required=false)]
            public long? DestinationRetention { get; set; }

            /// <summary>
            /// <para>Specifies whether to disable the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable remote replication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DoCopy")]
            [Validation(Required=false)]
            public bool? DoCopy { get; set; }

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
            /// <para>The name of the backup policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule-test-name</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The backup policy. Format: I|{startTime}|{interval}. The system runs the first backup job at a point in time that is specified in the {startTime} parameter and the subsequent backup jobs at an interval that is specified in the {interval} parameter. The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is completed. For example, I|1631685600|P1D specifies that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.</para>
            /// <para>startTime: the time at which the system starts to run a backup job. The time must follow the UNIX time format. Unit: seconds. interval: the interval at which the system runs a backup job. The interval must follow the ISO 8601 standard. For example, PT1H specifies an interval of one hour. P1D specifies an interval of one day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>I|1631685600|P1D</para>
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

        }

        /// <summary>
        /// <para>The backup policy. Format: <c>I|{startTime}|{interval}</c>. The system runs the first backup job at a point in time that is specified in the <c>{startTime}</c> parameter and the subsequent backup jobs at an interval that is specified in the <c>{interval}</c> parameter. The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is completed. For example, <c>I|1631685600|P1D</c> specifies that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.</para>
        /// <list type="bullet">
        /// <item><description><b>startTime</b>: the time at which the system starts to run a backup job. The time must follow the UNIX time format. Unit: seconds.</description></item>
        /// <item><description><b>interval</b>: the interval at which the system runs a backup job. The interval must follow the ISO 8601 standard. For example, PT1H specifies an interval of one hour. P1D specifies an interval of one day.</description></item>
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
        /// <item><description><b>ECS_FILE</b>: Elastic Compute Service (ECS) files</description></item>
        /// <item><description><b>OSS</b>: Object Storage Service (OSS) buckets</description></item>
        /// <item><description><b>NAS</b>: Apsara File Storage NAS file systems</description></item>
        /// <item><description><b>OTS</b>: Tablestore instances</description></item>
        /// <item><description><b>UDM_ECS</b>: ECS instances</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_FILE</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>This parameter is required only if the <b>SourceType</b> parameter is set to <b>ECS_FILE</b>. This parameter specifies the throttling rules. To ensure business continuity, you can limit the bandwidth that is used for file backup during peak hours. Format: <c>{start}|{end}|{bandwidth}</c>. Separate multiple throttling rules with vertical bars (|). A specified time range cannot overlap with another time range.</para>
        /// <list type="bullet">
        /// <item><description><b>start</b>: the start hour</description></item>
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
        /// <para>Specifies whether to update the source path if the backup source is empty. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The system replaces the original source path with the specified source path.</description></item>
        /// <item><description>false: The system does not update the original source path. The system backs up data based on the source path that you specified when you created the backup plan.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UpdatePaths")]
        [Validation(Required=false)]
        public bool? UpdatePaths { get; set; }

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
