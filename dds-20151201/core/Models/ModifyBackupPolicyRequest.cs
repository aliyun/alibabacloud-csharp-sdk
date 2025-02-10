// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The frequency at which high-frequency backups are generated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: High-frequency backup is disabled.</description></item>
        /// <item><description><b>30</b>: High-frequency backups are generated every 30 minutes.</description></item>
        /// <item><description><b>60</b>: High-frequency backups are generated every 1 hour.</description></item>
        /// <item><description><b>120</b>: High-frequency backups are generated every 2 hours.</description></item>
        /// <item><description><b>180</b>: High-frequency backups are generated every 3 hours.</description></item>
        /// <item><description><b>240</b>: High-frequency backups are generated every 4 hours.</description></item>
        /// <item><description><b>360</b>: High-frequency backups are generated every 6 hours.</description></item>
        /// <item><description><b>480</b>: High-frequency backups are generated every 8 hours.</description></item>
        /// <item><description><b>720</b>: High-frequency backups are generated every 12 hours.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you set the <b>SnapshotBackupType</b> parameter to <b>Standard</b>, you must fix the value of this parameter to -1.</para>
        /// </description></item>
        /// <item><description><para>High-frequency backup takes effect only when you set the <b>SnapshotBackupType</b> parameter to <b>Flash</b> and this parameter to a value greater than 0.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public string BackupInterval { get; set; }

        /// <summary>
        /// <para>The retention period of full backups.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If your instance is created before September 10, 2021, backups are retained for seven days by default.</para>
        /// </description></item>
        /// <item><description><para>If your instance is created after September 10, 2021, backups are retained for 30 days by default.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public long? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The backup retention policy configured for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: All backup sets are immediately deleted when the instance is released.</description></item>
        /// <item><description>1: Automatic backup is performed when the instance is released and the backup set is retained for a long period of time.</description></item>
        /// <item><description>2: Automatic backup is performed when the instance is released and all backup sets are retained for a long period of time.</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2779111.html">Retain the backup files of an ApsaraDB for MongoDB instance for a long period of time</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public int? BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// <para>The day of the week on which the cross-region backup files are retained. Valid values:</para>
        /// <ol>
        /// <item><description>Monday</description></item>
        /// <item><description>Tuesday</description></item>
        /// <item><description>Wednesday</description></item>
        /// <item><description>Thursday</description></item>
        /// <item><description>Friday</description></item>
        /// <item><description>Saturday</description></item>
        /// <item><description>Sunday</description></item>
        /// </ol>
        /// <remarks>
        /// <para> This parameter is required for a cross-region backup operation.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Separate multiple values with commas (,).</para>
        /// </description></item>
        /// <item><description><para>If you set the SnapshotBackupType parameter to Standard, the parameter value must fall within the value of the PreferredBackupPeriod parameter that specifies the standard backup period.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday</para>
        /// </summary>
        [NameInMap("CrossBackupPeriod")]
        [Validation(Required=false)]
        public string CrossBackupPeriod { get; set; }

        /// <summary>
        /// <para>The action performed for the cross-region backup policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>update: modifies the cross-region backup policy.</description></item>
        /// <item><description>delete: deletes the cross-region backup policy.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required for a cross-region backup operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>update</para>
        /// </summary>
        [NameInMap("CrossBackupType")]
        [Validation(Required=false)]
        public string CrossBackupType { get; set; }

        /// <summary>
        /// <para>The retention type of the cross-region log backup files. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>delay: retains the cross-region backup files for a period of time.</description></item>
        /// <item><description>never: permanently retains the cross-region backup files.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required for a cross-region backup operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>delay</para>
        /// </summary>
        [NameInMap("CrossLogRetentionType")]
        [Validation(Required=false)]
        public string CrossLogRetentionType { get; set; }

        /// <summary>
        /// <para>The retention period of the cross-region log backup files. Valid values: 3 to 1825. Unit: day. The parameter value must be less than or equal to the value of the CrossRetentionValue parameter.</para>
        /// <remarks>
        /// <para> This parameter is required for a cross-region backup operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CrossLogRetentionValue")]
        [Validation(Required=false)]
        public int? CrossLogRetentionValue { get; set; }

        /// <summary>
        /// <para>The retention type of the cross-region backup files. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>delay: retains the cross-region backup files for a period of time.</description></item>
        /// <item><description>never: permanently retains the cross-region backup files.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required for a cross-region backup operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>delay</para>
        /// </summary>
        [NameInMap("CrossRetentionType")]
        [Validation(Required=false)]
        public string CrossRetentionType { get; set; }

        /// <summary>
        /// <para>The retention period of the cross-region backup files. Valid values: 3 to 1825. Unit: day.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required for a cross-region backup operation.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required when you set the CrossRetentionType parameter to delay.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The region in which the backup files are retained.</para>
        /// <remarks>
        /// <para> This parameter is required for a cross-region backup operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DestRegion")]
        [Validation(Required=false)]
        public string DestRegion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the log backup feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): The log backup feature is disabled.</description></item>
        /// <item><description><b>1</b>: The log backup feature is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public long? EnableBackupLog { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the cross-region log backup feature.</para>
        /// <remarks>
        /// <para> This parameter is required for a cross-region backup operation.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Valid values:1: enables the feature. The parameter value must be 1 for sharded cluster instances.</para>
        /// </description></item>
        /// <item><description><para>0: disables the feature. The parameter value must be 0 for replica set instances.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableCrossLogBackup")]
        [Validation(Required=false)]
        public int? EnableCrossLogBackup { get; set; }

        /// <summary>
        /// <para>The number of days for which high-frequency backup files are retained. Before you use this parameter, make sure that you specify the BackupInterval parameter. By default, high-frequency backup files are retained for one day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HighFrequencyBackupRetention")]
        [Validation(Required=false)]
        public long? HighFrequencyBackupRetention { get; set; }

        /// <summary>
        /// <para>The instance architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>replicate</description></item>
        /// <item><description>sharding</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required when you set the RestoreType parameter to 2.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required when you set the RestoreType parameter to 3.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The day of a week when the system regularly backs up data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b></description></item>
        /// <item><description><b>Tuesday</b></description></item>
        /// <item><description><b>Wednesday</b></description></item>
        /// <item><description><b>Thursday</b></description></item>
        /// <item><description><b>Friday</b></description></item>
        /// <item><description><b>Saturday</b></description></item>
        /// <item><description><b>Sunday</b></description></item>
        /// </list>
        /// <para>**</para>
        /// <para><b>Notice</b>: To ensure data security, make sure that the system backs up data at least twice a week.</para>
        /// <remarks>
        /// <para> Separate multiple values with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Monday,Wednesday,Friday,Sunday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The start time of the backup. Specify the time in the ISO 8601 standard in the <em>HH:mm</em>Z-<em>HH:mm</em>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> The time range is 1 hour.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>03:00Z-04:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The snapshot backup type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Flash</b>: single-digit second backup</description></item>
        /// <item><description><b>Standard</b> (default): standard backup</description></item>
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
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required for the data restoration of a deleted instance.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required for a cross-region backup operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("SrcRegion")]
        [Validation(Required=false)]
        public string SrcRegion { get; set; }

    }

}
