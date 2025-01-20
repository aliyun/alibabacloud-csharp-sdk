// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The backup frequency. Default value: Normal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: standard backup. The system backs up data once a day.</description></item>
        /// <item><description><b>2/24H</b>: enhanced backup. The system backs up data every 2 hours.</description></item>
        /// <item><description><b>3/24H</b>: enhanced backup. The system backs up data every 3 hours.</description></item>
        /// <item><description><b>4/24H</b>: enhanced backup. The system backs up data every 4 hours.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If enhanced backup is enabled, all backups are retained for 24 hours. Backups are automatically deleted when the retention period ends. However, the system permanently retains the first backup that is created after 00:00 every day.</description></item>
        /// <item><description>If enhanced backup is enabled, <b>PreferredBackupPeriod</b> is automatically set to all days in a week (from Monday to Sunday).</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("BackupFrequency")]
        [Validation(Required=false)]
        public string BackupFrequency { get; set; }

        /// <summary>
        /// <para>Indicates whether backups are retained when you delete a cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL</b>: permanently retains all backups.</description></item>
        /// <item><description><b>LATEST</b>: permanently retains the most recent backup.</description></item>
        /// <item><description><b>NONE</b>: does not retain backups.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public string BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// <para>The backup frequency of level-1 backups. Default value: Normal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: standard backup. The system backs up data once a day.</description></item>
        /// <item><description><b>2/24H</b>: frequent backup. The system backs up data every 2 hours.</description></item>
        /// <item><description><b>3/24H</b>: frequent backup. The system backs up data every 3 hours.</description></item>
        /// <item><description><b>4/24H</b>: frequent backup. The system backs up data every 4 hours.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is not supported for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters.</description></item>
        /// <item><description>This parameter is unavailable if the region where your PolarDB for MySQL cluster is deployed does not support the cross-region backup feature. For information about regions that support the cross-region backup feature, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("DataLevel1BackupFrequency")]
        [Validation(Required=false)]
        public string DataLevel1BackupFrequency { get; set; }

        /// <summary>
        /// <para>The backup cycle of level-1 backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b></description></item>
        /// <item><description><b>Tuesday</b></description></item>
        /// <item><description><b>Wednesday</b></description></item>
        /// <item><description><b>Thursday</b></description></item>
        /// <item><description><b>Friday</b></description></item>
        /// <item><description><b>Saturday</b></description></item>
        /// <item><description><b>Sunday</b></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You need to specify at least two values. Separate multiple values with commas (,).</description></item>
        /// <item><description>This parameter is not supported for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters.</description></item>
        /// <item><description>This parameter is unavailable if the region where your PolarDB for MySQL cluster is deployed does not support the cross-region backup feature. For information about regions that support the cross-region backup feature, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Monday,Tuesday</para>
        /// </summary>
        [NameInMap("DataLevel1BackupPeriod")]
        [Validation(Required=false)]
        public string DataLevel1BackupPeriod { get; set; }

        /// <summary>
        /// <para>The retention period of level-1 backups. Valid values: 3 to 14. Unit: day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("DataLevel1BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string DataLevel1BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The period of time during which automatic backup is performed. The value must be in the <c>hh:mmZ-hh:mmZ</c> format. The time must be in UTC. The start time and the end time must be on the hour and must have an interval of 1 hour. Example: <c>14:00Z-15:00Z</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is not supported for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters.</description></item>
        /// <item><description>This parameter is unavailable if the region where your PolarDB for MySQL cluster is deployed does not support the cross-region backup feature. For information about regions that support the cross-region backup feature, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15:00Z-16:00Z</para>
        /// </summary>
        [NameInMap("DataLevel1BackupTime")]
        [Validation(Required=false)]
        public string DataLevel1BackupTime { get; set; }

        /// <summary>
        /// <para>The region where the cross-region level-2 backup is stored. For information about regions that support the cross-region backup feature, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DataLevel2BackupAnotherRegionRegion")]
        [Validation(Required=false)]
        public string DataLevel2BackupAnotherRegionRegion { get; set; }

        /// <summary>
        /// <para>The retention period of cross-region level-2 backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The cross-region level-2 backup feature is disabled.</description></item>
        /// <item><description><b>30 to 7300</b>: Cross-region level-2 backups are retained for 30 to 7,300 days.</description></item>
        /// <item><description><b>1</b>: Cross-region level-2 backups are retained for a long period of time.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The default value of the parameter is <b>0</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("DataLevel2BackupAnotherRegionRetentionPeriod")]
        [Validation(Required=false)]
        public string DataLevel2BackupAnotherRegionRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The backup cycle of level-2 backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b></description></item>
        /// <item><description><b>Tuesday</b></description></item>
        /// <item><description><b>Wednesday</b></description></item>
        /// <item><description><b>Thursday</b></description></item>
        /// <item><description><b>Friday</b></description></item>
        /// <item><description><b>Saturday</b></description></item>
        /// <item><description><b>Sunday</b></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You need to specify at least two values. Separate multiple values with commas (,).</description></item>
        /// <item><description>This parameter is not supported for PolarDB for PostgreSQL (Compatible with Oracle) clusters or PolarDB for PostgreSQL clusters.</description></item>
        /// <item><description>This parameter is unavailable if the region where your PolarDB for MySQL cluster is deployed does not support the cross-region backup feature. For information about regions that support the cross-region backup feature, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Monday,Tuesday</para>
        /// </summary>
        [NameInMap("DataLevel2BackupPeriod")]
        [Validation(Required=false)]
        public string DataLevel2BackupPeriod { get; set; }

        /// <summary>
        /// <para>The retention period of level-2 backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The level-2 backup feature is disabled.</description></item>
        /// <item><description>30 to 7300: Level-2 backups are retained for 30 to 7,300 days.</description></item>
        /// <item><description>\-1: Level-2 backups are retained for a long period of time.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The default value of this parameter is <b>0</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DataLevel2BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string DataLevel2BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The backup cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Monday</description></item>
        /// <item><description>Tuesday</description></item>
        /// <item><description>Wednesday</description></item>
        /// <item><description>Thursday</description></item>
        /// <item><description>Friday</description></item>
        /// <item><description>Saturday</description></item>
        /// <item><description>Sunday</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The time period when automatic backups are performed. The format is <c>HH:mmZ-HH:mmZ</c>. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>07:00Z-08:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The time when the next automatic backup will be performed. The format is <c>YYYY-MM-DDThh:mmZ</c>. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-16T07:30Z</para>
        /// </summary>
        [NameInMap("PreferredNextBackupTime")]
        [Validation(Required=false)]
        public string PreferredNextBackupTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EADFCE0F-9FB5-4685-B395-1440B******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
