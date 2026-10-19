// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The high-frequency backup frequency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: Disables high-frequency backups.</description></item>
        /// <item><description><b>30</b>: Every 30 minutes.</description></item>
        /// <item><description><b>60</b>: Every 1 hour.</description></item>
        /// <item><description><b>120</b>: Every 2 hours.</description></item>
        /// <item><description><b>180</b>: Every 3 hours.</description></item>
        /// <item><description><b>240</b>: Every 4 hours.</description></item>
        /// <item><description><b>360</b>: Every 6 hours.</description></item>
        /// <item><description><b>480</b>: Every 8 hours.</description></item>
        /// <item><description><b>720</b>: Every 12 hours.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If <b>SnapshotBackupType</b> is set to <b>Standard</b>, this parameter must be set to <b>-1</b>.</description></item>
        /// <item><description>If <b>SnapshotBackupType</b> is set to <b>Flash</b> and this parameter is set to a value greater than 0, high-frequency backups take effect.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public string BackupInterval { get; set; }

        /// <summary>
        /// <para>The number of days for which full backups are retained.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For users who created instances before September 10, 2021, the default retention period is 7 days.</description></item>
        /// <item><description>For new users who created instances on or after September 10, 2021, the default retention period is 30 days.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public long? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The backup data retention policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Deletes all backup sets of the instance immediately when the instance is released.</para>
        /// </description></item>
        /// <item><description><para>1: An automatic backup is performed when the instance is released, and the backup set is retained for long-term retention (LTR).</para>
        /// </description></item>
        /// <item><description><para>2: An automatic backup is performed when the instance is released, and all backup sets of the cluster are retained for long-term retention (LTR).</para>
        /// </description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2779111.html">Long-term retention backups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public int? BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// <para>The days of the week when cross-region backup is performed. Valid values:</para>
        /// <ol>
        /// <item><description>Monday: Monday.</description></item>
        /// <item><description>Tuesday: Tuesday.</description></item>
        /// <item><description>Wednesday: Wednesday.</description></item>
        /// <item><description>Thursday: Thursday.</description></item>
        /// <item><description>Friday: Friday.</description></item>
        /// <item><description>Saturday: Saturday.</description></item>
        /// <item><description>Sunday: Sunday.</description></item>
        /// </ol>
        /// <remarks>
        /// <para>This parameter is required for cross-region backup.</para>
        /// <list type="bullet">
        /// <item><description>If you specify multiple values, separate them with commas (,).</description></item>
        /// <item><description>When the backup settings are set to standard backup, the value must be a subset of the PreferredBackupPeriod backup epoch.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday</para>
        /// </summary>
        [NameInMap("CrossBackupPeriod")]
        [Validation(Required=false)]
        public string CrossBackupPeriod { get; set; }

        /// <summary>
        /// <para>The operation policy for cross-region backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>update: Modifies the cross-region backup policy.</description></item>
        /// <item><description>delete: Deletes the cross-region backup policy.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required for cross-region backup.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>update</para>
        /// </summary>
        [NameInMap("CrossBackupType")]
        [Validation(Required=false)]
        public string CrossBackupType { get; set; }

        /// <summary>
        /// <para>The retention type for cross-region log backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>delay: Retains backups for a specified period.</description></item>
        /// <item><description>never: Never expires.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required for cross-region backup.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>delay</para>
        /// </summary>
        [NameInMap("CrossLogRetentionType")]
        [Validation(Required=false)]
        public string CrossLogRetentionType { get; set; }

        /// <summary>
        /// <para>The retention period for cross-region log backup. Valid values: 3 to 1825 days. The value must be less than or equal to the value of CrossRetentionValue.</para>
        /// <remarks>
        /// <para>This parameter is required for cross-region backup.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CrossLogRetentionValue")]
        [Validation(Required=false)]
        public int? CrossLogRetentionValue { get; set; }

        /// <summary>
        /// <para>The retention type for cross-region backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>delay: Retains backups for a specified period.</para>
        /// </description></item>
        /// <item><description><para>never: Never expires.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required for cross-region backup.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>delay</para>
        /// </summary>
        [NameInMap("CrossRetentionType")]
        [Validation(Required=false)]
        public string CrossRetentionType { get; set; }

        /// <summary>
        /// <para>The retention period for cross-region backup. Valid values: 3 to 1825 days.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required for cross-region backup.</description></item>
        /// <item><description>This parameter is required and must be specified when CrossRetentionType is set to delay.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("CrossRetentionValue")]
        [Validation(Required=false)]
        public int? CrossRetentionValue { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp16cb162771****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The region where backups are stored.</para>
        /// <remarks>
        /// <para>This parameter is required for cross-region backup.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DestRegion")]
        [Validation(Required=false)]
        public string DestRegion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable log backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Disables log backup. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Enables log backup.</para>
        /// <remarks>
        /// <para>Notice: Sharded cluster instances do not support disabling log backup.</notice></para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public long? EnableBackupLog { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable cross-region log backup.</para>
        /// <remarks>
        /// <para>This parameter is required for cross-region backup.</para>
        /// <list type="bullet">
        /// <item><description>1: Enables cross-region log backup. This value is required for sharded cluster instances. For replica set instances, this value is required if you want to support cross-region point-in-time recovery.</description></item>
        /// <item><description>0: Disables cross-region log backup.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableCrossLogBackup")]
        [Validation(Required=false)]
        public int? EnableCrossLogBackup { get; set; }

        /// <summary>
        /// <para>The number of days for which high-frequency backups are retained. Before you use this parameter, make sure that the BackupInterval parameter is specified. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HighFrequencyBackupRetention")]
        [Validation(Required=false)]
        public long? HighFrequencyBackupRetention { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>replicate </description></item>
        /// <item><description>sharding</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when the backup recovery type is set to rebuilding a deleted instance.</description></item>
        /// <item><description>This parameter is required when the backup recovery type is set to cloning an instance from cross-region backup.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>replicate</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The number of days for which log backups are retained. Default value: 7.</para>
        /// <para>Valid values: 7 to 730.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public long? LogBackupRetentionPeriod { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The backup cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b>: Monday.</description></item>
        /// <item><description><b>Tuesday</b>: Tuesday.</description></item>
        /// <item><description><b>Wednesday</b>: Wednesday.</description></item>
        /// <item><description><b>Thursday</b>: Thursday.</description></item>
        /// <item><description><b>Friday</b>: Friday.</description></item>
        /// <item><description><b>Saturday</b>: Saturday.</description></item>
        /// <item><description><b>Sunday</b>: Sunday.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: To ensure data security, back up your MongoDB data at least twice a week.</notice></para>
        /// </remarks>
        /// <remarks>
        /// <para>If you specify multiple values, separate them with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Monday,Wednesday,Friday,Sunday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The time period during which backups are performed. The format is <i>HH:mm</i>Z-<i>HH:mm</i>Z (UTC).</para>
        /// <remarks>
        /// <para>The time period is limited to 1 hour.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>03:00Z-04:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable hourly sparse backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: If the backup frequency is set to minutes, all snapshots taken within 1 hour from the current time are retained. For snapshots taken more than 1 hour but within 24 hours from the current time, only the first snapshot taken after the hour is retained.</para>
        /// </description></item>
        /// <item><description><para>false: All snapshots taken within the high-frequency backup retention period are retained.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PreserveOneEachHour")]
        [Validation(Required=false)]
        public bool? PreserveOneEachHour { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The snapshot backup type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Flash</b>: Backup within seconds.</description></item>
        /// <item><description><b>Standard</b>: Standard backup. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("SnapshotBackupType")]
        [Validation(Required=false)]
        public string SnapshotBackupType { get; set; }

        /// <summary>
        /// <para>The region where the instance is deployed.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required to recover deleted instances.</description></item>
        /// <item><description>This parameter is required for cross-region backup.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("SrcRegion")]
        [Validation(Required=false)]
        public string SrcRegion { get; set; }

    }

}
