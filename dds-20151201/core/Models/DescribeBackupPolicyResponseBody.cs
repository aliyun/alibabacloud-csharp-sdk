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
        /// <item><description><para><b>-1</b>: high-frequency backup is disabled.</para>
        /// </description></item>
        /// <item><description><para><b>15</b>: every 15 minutes.</para>
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
        /// <para>The backup retention policy.</para>
        /// <ol>
        /// <item><description><para>0: All backup sets of the instance are immediately deleted when the instance is released</para>
        /// </description></item>
        /// <item><description><para>1: The instance is automatically backed up when it is released, and the backup set is retained for a long time</para>
        /// </description></item>
        /// <item><description><para>2: The instance is automatically backed up when it is released, and all backup sets of the cluster are retained for a long time</para>
        /// </description></item>
        /// </ol>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2779111.html">Long-term backup retention</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public int? BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// <para>The geo-redundancy backup retention time.</para>
        /// <ol>
        /// <item><description><para>Monday: Monday.</para>
        /// </description></item>
        /// <item><description><para>Tuesday: Tuesday.</para>
        /// </description></item>
        /// <item><description><para>Wednesday: Wednesday.</para>
        /// </description></item>
        /// <item><description><para>Thursday: Thursday.</para>
        /// </description></item>
        /// <item><description><para>Friday: Friday.</para>
        /// </description></item>
        /// <item><description><para>Saturday: Saturday.</para>
        /// </description></item>
        /// <item><description><para>Sunday: Sunday.</para>
        /// </description></item>
        /// </ol>
        /// <remarks>
        /// <para>Required for geo-redundancy backup</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Monday</para>
        /// </summary>
        [NameInMap("CrossBackupPeriod")]
        [Validation(Required=false)]
        public string CrossBackupPeriod { get; set; }

        /// <summary>
        /// <para>The geo-redundancy log backup retention type.</para>
        /// <list type="bullet">
        /// <item><description><para>delay: retained for a period of time</para>
        /// </description></item>
        /// <item><description><para>never: never expires</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>delay</para>
        /// </summary>
        [NameInMap("CrossLogRetentionType")]
        [Validation(Required=false)]
        public string CrossLogRetentionType { get; set; }

        /// <summary>
        /// <para>The geo-redundancy log backup retention period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("CrossLogRetentionValue")]
        [Validation(Required=false)]
        public int? CrossLogRetentionValue { get; set; }

        /// <summary>
        /// <para>The geo-redundancy backup retention type.</para>
        /// <list type="bullet">
        /// <item><description><para>delay: retained for a period of time</para>
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
        /// <para>The geo-redundancy backup retention period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("CrossRetentionValue")]
        [Validation(Required=false)]
        public int? CrossRetentionValue { get; set; }

        /// <summary>
        /// <para>The region where the geo-redundancy backup is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("DestRegion")]
        [Validation(Required=false)]
        public string DestRegion { get; set; }

        /// <summary>
        /// <para>Indicates whether log backup is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: disabled (default).</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public int? EnableBackupLog { get; set; }

        /// <summary>
        /// <para>Indicates whether cross-region log backup is enabled.</para>
        /// <remarks>
        /// <para>Required for geo-redundancy backup</para>
        /// <list type="bullet">
        /// <item><description><para>1: enabled (must be 1 for sharded cluster instances)</para>
        /// </description></item>
        /// <item><description><para>0: disabled (must be 0 for replica set instances)</para>
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
        /// <para>The high-frequency backup retention period in days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HighFrequencyBackupRetention")]
        [Validation(Required=false)]
        public string HighFrequencyBackupRetention { get; set; }

        /// <summary>
        /// <para>The log backup retention period in days. Valid values: 7 to 730.</para>
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
        /// <item><description><para><b>Monday</b>: Monday.</para>
        /// </description></item>
        /// <item><description><para><b>Tuesday</b>: Tuesday.</para>
        /// </description></item>
        /// <item><description><para><b>Wednesday</b>: Wednesday.</para>
        /// </description></item>
        /// <item><description><para><b>Thursday</b>: Thursday.</para>
        /// </description></item>
        /// <item><description><para><b>Friday</b>: Friday.</para>
        /// </description></item>
        /// <item><description><para><b>Saturday</b>: Saturday.</para>
        /// </description></item>
        /// <item><description><para><b>Sunday</b>: Sunday.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The backup time in the format of <em>HH:mm</em>Z-<em>HH:mm</em>Z (UTC time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>09:00Z-10:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The next regular backup time in the format of <em>yyyy-mm-dd</em>t<em>hh:mm</em>z (UTC time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-19T19:11Z</para>
        /// </summary>
        [NameInMap("PreferredNextBackupTime")]
        [Validation(Required=false)]
        public string PreferredNextBackupTime { get; set; }

        /// <summary>
        /// <para>Indicates whether sparse backup within an hour is enabled.</para>
        /// <list type="bullet">
        /// <item><description><para>true: When the backup frequency is at the minute level, all snapshots within 1 hour from the current time are retained. For snapshots that are more than 1 hour but within 24 hours from the current time, only the first snapshot after each hour is retained.</para>
        /// </description></item>
        /// <item><description><para>false: Sparse backup within an hour is disabled: all snapshots within the high-frequency backup retention period are retained.</para>
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
        /// <para>The request ID.</para>
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
        /// <item><description><para><b>Flash</b>: second-level backup.</para>
        /// </description></item>
        /// <item><description><para><b>Standard</b>: regular backup (default).</para>
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
        /// <para>The region where the source instance is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SrcRegion")]
        [Validation(Required=false)]
        public string SrcRegion { get; set; }

    }

}
