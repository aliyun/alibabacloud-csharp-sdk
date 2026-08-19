// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateBackupPlanShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The configuration for the incremental file synchronization list. (This parameter is required only for file synchronization.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dataSourceId&quot;: &quot;ds-123456789&quot;, &quot;path&quot;: &quot;/changelist&quot;}</para>
        /// </summary>
        [NameInMap("ChangeListPath")]
        [Validation(Required=false)]
        public string ChangeListPath { get; set; }

        /// <summary>
        /// <para>The details of the ECS instance backup. This is a JSON string.</para>
        /// <list type="bullet">
        /// <item><description><para>snapshotGroup: Specifies whether to use a snapshot-consistent group. This feature is available only when all disks of the instance are Enhanced Solid-State Drives (ESSDs).</para>
        /// </description></item>
        /// <item><description><para>appConsistent: Specifies whether to enable application consistency. You must also configure the preScriptPath and postScriptPath parameters.</para>
        /// </description></item>
        /// <item><description><para>preScriptPath: The path to the pre-freeze script.</para>
        /// </description></item>
        /// <item><description><para>postScriptPath: The path to the post-thaw script.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;EnableFsFreeze\&quot;:true,\&quot;appConsistent\&quot;:false,\&quot;postScriptPath\&quot;:\&quot;\&quot;,\&quot;preScriptPath\&quot;:\&quot;\&quot;,\&quot;snapshotGroup\&quot;:true,\&quot;timeoutInSeconds\&quot;:60}</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string DetailShrink { get; set; }

        /// <summary>
        /// <para>The edition. Valid values are BASIC and STANDARD. The default value is STANDARD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>ECS_FILE</b>. This parameter specifies the paths to the files to exclude from the backup. All files in the specified paths are not backed up. The value can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/var&quot;, &quot;/proc&quot;]</para>
        /// </summary>
        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        /// <summary>
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>ECS_FILE</b>. This parameter specifies the paths to the files to back up. All files in the specified paths are backed up. The value can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/home/alice/<em>.pdf&quot;, &quot;/home/bob/</em>.txt&quot;]</para>
        /// </summary>
        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        /// <summary>
        /// <para>Specifies whether to permanently retain the latest backup version.</para>
        /// <list type="bullet">
        /// <item><description><para>0: No</para>
        /// </description></item>
        /// <item><description><para>1: Yes</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("KeepLatestSnapshots")]
        [Validation(Required=false)]
        public long? KeepLatestSnapshots { get; set; }

        /// <summary>
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>ECS_FILE</b>. This parameter specifies whether to use Volume Shadow Copy Service (VSS) to define the backup path.</para>
        /// <list type="bullet">
        /// <item><description><para>This feature is available only for Windows ECS instances.</para>
        /// </description></item>
        /// <item><description><para>If data changes occur in the backup source, set this parameter to <c>[&quot;UseVSS&quot;:true]</c> to ensure data consistency.</para>
        /// </description></item>
        /// <item><description><para>If you enable VSS, you cannot back up multiple file directories at the same time.</para>
        /// </description></item>
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
        public string OtsDetailShrink { get; set; }

        /// <summary>
        /// <para>The backup paths.</para>
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
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>OSS</b>. This parameter specifies the prefix of objects to back up. After you specify a prefix, only objects that match the prefix are backed up.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-prefix</para>
        /// </summary>
        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The number of days to retain backups. The minimum value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public long? Retention { get; set; }

        /// <summary>
        /// <para>The rules of the backup plan.</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public List<UpdateBackupPlanShrinkRequestRule> Rule { get; set; }
        public class UpdateBackupPlanShrinkRequestRule : TeaModel {
            /// <summary>
            /// <para>The backup type. Set the value to <b>COMPLETE</b>. This indicates a full backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>The ID of the destination region for the geo-redundant backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("DestinationRegionId")]
            [Validation(Required=false)]
            public string DestinationRegionId { get; set; }

            /// <summary>
            /// <para>The number of days to retain the geo-redundant backup.</para>
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
            /// <para>Specifies whether to enable geo-redundant replication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DoCopy")]
            [Validation(Required=false)]
            public bool? DoCopy { get; set; }

            /// <summary>
            /// <para>The number of days to retain backups. The minimum value is 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            /// <summary>
            /// <para>The name of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule-test-name</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The backup policy. Use the I|{startTime}|{interval} format. This specifies that a backup job runs at a recurring interval. The {startTime} is when the backup starts. The {interval} is the time between jobs. HBR does not run overdue backup jobs. If the previous backup job is not finished, the next one does not start. For example, I|1631685600|P1D means the backup runs once a day, starting at 14:00:00 on September 15, 2021.</para>
            /// <para>startTime: The start time of the backup. This is a UNIX timestamp in seconds. interval: The time interval. Use the ISO 8601 standard. For example, PT1H specifies an interval of one hour. P1D specifies an interval of one day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>I|1631685600|P1D</para>
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

        }

        /// <summary>
        /// <para>The backup policy. Use the <c>I|{startTime}|{interval}</c> format. This specifies that a backup job runs at a recurring interval. The <c>{startTime}</c> is when the backup starts. The <c>{interval}</c> is the time between jobs. HBR does not run overdue backup jobs. If the previous backup job is not finished, the next one does not start. For example, <c>I|1631685600|P1D</c> means the backup runs once a day, starting at 14:00:00 on September 15, 2021.</para>
        /// <list type="bullet">
        /// <item><description><para><b>startTime</b>: The start time of the backup. This is a UNIX timestamp in seconds.</para>
        /// </description></item>
        /// <item><description><para><b>interval</b>: The time interval. Use the ISO 8601 standard. For example, PT1H specifies an interval of one hour. P1D specifies an interval of one day.</para>
        /// </description></item>
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
        /// <item><description><para><b>ECS_FILE</b>: Backs up ECS files.</para>
        /// </description></item>
        /// <item><description><para><b>OSS</b>: Backs up Alibaba Cloud OSS.</para>
        /// </description></item>
        /// <item><description><para><b>NAS</b>: Backs up Alibaba Cloud NAS.</para>
        /// </description></item>
        /// <item><description><para><b>OTS</b>: Backs up Alibaba Cloud Tablestore.</para>
        /// </description></item>
        /// <item><description><para><b>UDM_ECS</b>: Backs up an entire ECS instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_FILE</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>This parameter is required only when <b>SourceType</b> is set to <b>ECS_FILE</b>. This parameter specifies traffic shaping for backups. Traffic shaping helps you control backup traffic during peak business hours to avoid affecting your services. The format is <c>{start}|{end}|{bandwidth}</c>. You can specify multiple traffic shaping rules. Separate them with vertical bars (|). The time ranges of the rules cannot overlap.</para>
        /// <list type="bullet">
        /// <item><description><para><b>start</b>: The start hour.</para>
        /// </description></item>
        /// <item><description><para><b>end</b>: The end hour.</para>
        /// </description></item>
        /// <item><description><para><b>bandwidth</b>: The maximum speed. Unit: KB/s.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0:24:5120</para>
        /// </summary>
        [NameInMap("SpeedLimit")]
        [Validation(Required=false)]
        public string SpeedLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to update the backup paths if the Path parameter is empty.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Updates the backup paths based on the paths specified in this call.</para>
        /// </description></item>
        /// <item><description><para>false: Does not update the backup paths. The backup paths that were configured when the backup plan was created are used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UpdatePaths")]
        [Validation(Required=false)]
        public bool? UpdatePaths { get; set; }

        /// <summary>
        /// <para>The ID of the backup repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-0006******q</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
