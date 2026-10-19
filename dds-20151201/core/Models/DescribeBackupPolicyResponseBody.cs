// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The high-frequency backup frequency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: high-frequency backup is disabled</description></item>
        /// <item><description><b>15</b>: every 15 minutes</description></item>
        /// <item><description><b>30</b>: every 30 minutes</description></item>
        /// <item><description><b>60</b>: every 1 hour</description></item>
        /// <item><description><b>120</b>: every 2 hours</description></item>
        /// <item><description><b>180</b>: every 3 hours</description></item>
        /// <item><description><b>240</b>: every 4 hours</description></item>
        /// <item><description><b>360</b>: every 6 hours</description></item>
        /// <item><description><b>480</b>: every 8 hours</description></item>
        /// <item><description><b>720</b>: every 12 hours</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public int? BackupInterval { get; set; }

        /// <summary>
        /// <para>The backup retention period in days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The backup data retention policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: All backup sets of the instance are immediately deleted when the instance is released.</description></item>
        /// <item><description>1: An automatic backup is created when the instance is released, and the backup set is retained for long-term retention (LTR).</description></item>
        /// <item><description>2: An automatic backup is created when the instance is released, and all backup sets of the cluster are retained for long-term retention (LTR).</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2779111.html">Long-term retention backup</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public int? BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// <para>The days of the week when geo-redundancy backups are performed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Monday: Monday</description></item>
        /// <item><description>Tuesday: Tuesday</description></item>
        /// <item><description>Wednesday: Wednesday</description></item>
        /// <item><description>Thursday: Thursday</description></item>
        /// <item><description>Friday: Friday</description></item>
        /// <item><description>Saturday: Saturday</description></item>
        /// <item><description>Sunday: Sunday</description></item>
        /// </list>
        /// <remarks>
        /// <para>Required for geo-redundancy backups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Monday</para>
        /// </summary>
        [NameInMap("CrossBackupPeriod")]
        [Validation(Required=false)]
        public string CrossBackupPeriod { get; set; }

        /// <summary>
        /// <para>The retention type for cross-region log backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>delay: retained for a specified period</description></item>
        /// <item><description>never: never expires</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>delay</para>
        /// </summary>
        [NameInMap("CrossLogRetentionType")]
        [Validation(Required=false)]
        public string CrossLogRetentionType { get; set; }

        /// <summary>
        /// <para>The retention period for cross-region log backups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("CrossLogRetentionValue")]
        [Validation(Required=false)]
        public int? CrossLogRetentionValue { get; set; }

        /// <summary>
        /// <para>The retention type for geo-redundancy backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>delay: retained for a specified period</para>
        /// </description></item>
        /// <item><description><para>never: never expires</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>delay</para>
        /// </summary>
        [NameInMap("CrossRetentionType")]
        [Validation(Required=false)]
        public string CrossRetentionType { get; set; }

        /// <summary>
        /// <para>The retention period for geo-redundancy backups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("CrossRetentionValue")]
        [Validation(Required=false)]
        public int? CrossRetentionValue { get; set; }

        /// <summary>
        /// <para>The region where geo-redundancy backups are stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("DestRegion")]
        [Validation(Required=false)]
        public string DestRegion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable log backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled (default)</description></item>
        /// <item><description><b>1</b>: enabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public int? EnableBackupLog { get; set; }

        /// <summary>
        /// <para>Specifies whether cross-region log backup is enabled.</para>
        /// <remarks>
        /// <para>Required for geo-redundancy backups.</para>
        /// <list type="bullet">
        /// <item><description>1: enabled (must be set to 1 for sharded cluster instances)</description></item>
        /// <item><description>0: disabled (must be set to 0 for replica set instances)</description></item>
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
        /// <para>The retention period for high-frequency backups, in days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HighFrequencyBackupRetention")]
        [Validation(Required=false)]
        public string HighFrequencyBackupRetention { get; set; }

        /// <summary>
        /// <para>The retention period for log backups, in days. Valid values: 7 to 730.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? LogBackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The backup cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b>: Monday</description></item>
        /// <item><description><b>Tuesday</b>: Tuesday</description></item>
        /// <item><description><b>Wednesday</b>: Wednesday</description></item>
        /// <item><description><b>Thursday</b>: Thursday</description></item>
        /// <item><description><b>Friday</b>: Friday</description></item>
        /// <item><description><b>Saturday</b>: Saturday</description></item>
        /// <item><description><b>Sunday</b>: Sunday</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The backup time. The format is <i>HH:mm</i>Z-<i>HH:mm</i>Z (UTC time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>09:00Z-10:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The time of the next regular backup. The format is <i>yyyy-mm-dd</i>t<i>hh:mm</i>z (UTC time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-19T19:11Z</para>
        /// </summary>
        [NameInMap("PreferredNextBackupTime")]
        [Validation(Required=false)]
        public string PreferredNextBackupTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable sparse backup within an hour. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: When the backup frequency is set to minutes, all snapshots taken within 1 hour from the current time are retained. For snapshots taken more than 1 hour but within 24 hours from the current time, only the first snapshot after the hour is retained.</para>
        /// </description></item>
        /// <item><description><para>false: Sparse backup within an hour is disabled. All snapshots within the high-frequency backup retention period are retained.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PreserveOneEachHour")]
        [Validation(Required=false)]
        public bool? PreserveOneEachHour { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A9464CA-F7DC-5434-90B1-DF7F197C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The snapshot backup type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Flash</b>: backup within seconds</description></item>
        /// <item><description><b>Standard</b>: standard backup (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("SnapshotBackupType")]
        [Validation(Required=false)]
        public string SnapshotBackupType { get; set; }

        /// <summary>
        /// <para>The region where the source instance is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SrcRegion")]
        [Validation(Required=false)]
        public string SrcRegion { get; set; }

    }

}
