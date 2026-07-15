// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The frequency of high-frequency backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>-1</b>: High-frequency backup is disabled.</para>
        /// </description></item>
        /// <item><description><para><b>30</b>: every 30 minutes.</para>
        /// </description></item>
        /// <item><description><para><b>60</b>: every 1 hour.</para>
        /// </description></item>
        /// <item><description><para><b>120</b>: every 2 hours.</para>
        /// </description></item>
        /// <item><description><para><b>180</b>: every 3 hours.</para>
        /// </description></item>
        /// <item><description><para><b>240</b>: every 4 hours.</para>
        /// </description></item>
        /// <item><description><para><b>360</b>: every 6 hours.</para>
        /// </description></item>
        /// <item><description><para><b>480</b>: every 8 hours.</para>
        /// </description></item>
        /// <item><description><para><b>720</b>: every 12 hours.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you set <b>SnapshotBackupType</b> to <b>Standard</b>, the value of this parameter is -1.</para>
        /// </description></item>
        /// <item><description><para>High-frequency backup takes effect only if you set <b>SnapshotBackupType</b> to <b>Flash</b> and set this parameter to a value greater than 0.</para>
        /// </description></item>
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
        /// <para>The number of days to retain full backups.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>For instances that were created before September 10, 2021, the default retention period is 7 days.</para>
        /// </description></item>
        /// <item><description><para>For instances that are created after September 10, 2021, the default retention period is 30 days.</para>
        /// </description></item>
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
        /// <para>The policy to retain backups when you release the instance.</para>
        /// <list type="bullet">
        /// <item><description><para>0: All backup sets of the instance are deleted when the instance is released.</para>
        /// </description></item>
        /// <item><description><para>1: An automatic backup is performed when the instance is released, and this backup is retained for a long time.</para>
        /// </description></item>
        /// <item><description><para>2: An automatic backup is performed when the instance is released, and all backup sets of the instance are retained for a long time.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2779111.html">Long-term backup retention</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public int? BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// <para>The days of the week to perform geo-redundant backups. Valid values:</para>
        /// <ol>
        /// <item><description><para>Monday</para>
        /// </description></item>
        /// <item><description><para>Tuesday</para>
        /// </description></item>
        /// <item><description><para>Wednesday</para>
        /// </description></item>
        /// <item><description><para>Thursday</para>
        /// </description></item>
        /// <item><description><para>Friday</para>
        /// </description></item>
        /// <item><description><para>Saturday</para>
        /// </description></item>
        /// <item><description><para>Sunday</para>
        /// </description></item>
        /// </ol>
        /// <remarks>
        /// <para>This parameter is required if you enable geo-redundancy.</para>
        /// <list type="bullet">
        /// <item><description><para>To specify multiple days, separate them with commas (,).</para>
        /// </description></item>
        /// <item><description><para>If you set the backup method to conventional backup, the days of the week specified by this parameter must be a subset of the days of the week specified by PreferredBackupPeriod.</para>
        /// </description></item>
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
        /// <para>The policy for geo-redundant backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>update: Modify the geo-redundancy policy.</para>
        /// </description></item>
        /// <item><description><para>delete: Delete the geo-redundancy policy.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if you enable geo-redundancy.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>update</para>
        /// </summary>
        [NameInMap("CrossBackupType")]
        [Validation(Required=false)]
        public string CrossBackupType { get; set; }

        /// <summary>
        /// <para>The retention policy for cross-region log backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>delay: Retain the backup for a specified period.</para>
        /// </description></item>
        /// <item><description><para>never: Retain the backup permanently.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if you enable geo-redundancy.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>delay</para>
        /// </summary>
        [NameInMap("CrossLogRetentionType")]
        [Validation(Required=false)]
        public string CrossLogRetentionType { get; set; }

        /// <summary>
        /// <para>The number of days to retain cross-region log backups. Valid values: 3 to 1825. The value must be less than or equal to the value of CrossRetentionValue.</para>
        /// <remarks>
        /// <para>This parameter is required if you enable geo-redundancy.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CrossLogRetentionValue")]
        [Validation(Required=false)]
        public int? CrossLogRetentionValue { get; set; }

        /// <summary>
        /// <para>The retention policy for geo-redundant backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>delay: Retain the backup for a specified period.</para>
        /// </description></item>
        /// <item><description><para>never: Retain the backup permanently.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if you enable geo-redundancy.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>delay</para>
        /// </summary>
        [NameInMap("CrossRetentionType")]
        [Validation(Required=false)]
        public string CrossRetentionType { get; set; }

        /// <summary>
        /// <para>The number of days to retain geo-redundant backups. Valid values: 3 to 1825.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required if you enable geo-redundancy.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required if you set CrossRetentionType to delay.</para>
        /// </description></item>
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
        /// <para>The region ID of the geo-redundant backup.</para>
        /// <remarks>
        /// <para>This parameter is required if you enable geo-redundancy.</para>
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
        /// <item><description><para><b>0</b>: Disable log backup. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Enable log backup.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>You cannot disable log backup for sharded cluster instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public long? EnableBackupLog { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable cross-region log backup. Valid values:</para>
        /// <remarks>
        /// <para>This parameter is required if you enable geo-redundancy.</para>
        /// <list type="bullet">
        /// <item><description><para>1: Enable cross-region log backup. This value is required for sharded cluster instances. This value is also required for replica set instances if you want to enable geo-redundant point-in-time recovery.</para>
        /// </description></item>
        /// <item><description><para>0: Disable cross-region log backup.</para>
        /// </description></item>
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
        /// <para>The number of days to retain high-frequency backups. Before you specify this parameter, you must set the BackupInterval parameter. The default retention period is 1 day.</para>
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
        /// <item><description><para>replicate</para>
        /// </description></item>
        /// <item><description><para>sharding</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required when you restore a deleted instance.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required when you clone an instance from a geo-redundant backup.</para>
        /// </description></item>
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
        /// <para>The number of days to retain log backups. Default value: 7.</para>
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
        /// <item><description><para><b>Monday</b></para>
        /// </description></item>
        /// <item><description><para><b>Tuesday</b></para>
        /// </description></item>
        /// <item><description><para><b>Wednesday</b></para>
        /// </description></item>
        /// <item><description><para><b>Thursday</b></para>
        /// </description></item>
        /// <item><description><para><b>Friday</b></para>
        /// </description></item>
        /// <item><description><para><b>Saturday</b></para>
        /// </description></item>
        /// <item><description><para><b>Sunday</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>To ensure data security, back up the MongoDB instance at least twice a week.</para>
        /// <remarks>
        /// <para>To specify multiple backup cycles, separate them with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Monday,Wednesday,Friday,Sunday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The time range to perform a backup. Specify the time in the <em>HH:mm</em>Z-<em>HH:mm</em>Z format. The time is displayed in Coordinated Universal Time (UTC).</para>
        /// <remarks>
        /// <para>The time range must be 1 hour.</para>
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
        /// <item><description><para>true: If the backup frequency is in minutes, all snapshots that are generated within the last hour are retained. For snapshots that were generated more than 1 hour ago but less than 24 hours ago, only the first snapshot that is generated after each full hour is retained.</para>
        /// </description></item>
        /// <item><description><para>false: All snapshots are retained within the high-frequency backup retention period.</para>
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
        /// <item><description><para><b>Flash</b>: second-level backup.</para>
        /// </description></item>
        /// <item><description><para><b>Standard</b>: conventional backup. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("SnapshotBackupType")]
        [Validation(Required=false)]
        public string SnapshotBackupType { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required if you restore a deleted instance.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required if you enable geo-redundancy.</para>
        /// </description></item>
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
