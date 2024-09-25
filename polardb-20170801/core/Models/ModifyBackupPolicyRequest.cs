// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
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
        /// <item><description>If you enable enhanced backup, all backups are retained for 24 hours. For backup files that are created earlier than the previous 24 hours, the system permanently retains only the first backup that is created after 00:00 every day and deletes the rest.</description></item>
        /// <item><description>If you enable enhanced backup, <b>PreferredBackupPeriod</b> is automatically set to all days in a week (from Monday to Sunday).</description></item>
        /// <item><description>This parameter is invalid if the region where your PolarDB for MySQL cluster is deployed supports the cross-region backup feature. For information about the regions that support the cross-region backup feature, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
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
        /// <para>Specifies whether to retain backups when you delete a cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL</b>: permanently retains all backups.</description></item>
        /// <item><description><b>LATEST</b>: permanently retains only the last backup.</description></item>
        /// <item><description><b>NONE</b>: does not retain backups.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is NONE.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public string BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query information about all clusters that are deployed in a specified region, such as the cluster ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp13wz9586voc****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The frequency of level-1 backups. Default value: Normal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: standard backup. The system backs up data once a day.</description></item>
        /// <item><description><b>2/24H</b>: enhanced backup. The system backs up data every 2 hours.</description></item>
        /// <item><description><b>3/24H</b>: enhanced backup. The system backs up data every 3 hours.</description></item>
        /// <item><description><b>4/24H</b>: enhanced backup. The system backs up data every 4 hours.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is invalid for PolarDB for Oracle clusters or PolarDB for PostgreSQL clusters.</description></item>
        /// <item><description>This parameter is invalid if the region where your PolarDB for MySQL cluster is deployed does not support the cross-region backup feature. For information about the regions that support the cross-region backup feature, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
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
        /// <item><description>This parameter is invalid for PolarDB for Oracle clusters or PolarDB for PostgreSQL clusters.</description></item>
        /// <item><description>This parameter is invalid if the region where your PolarDB for MySQL cluster is deployed does not support the cross-region backup feature. For information about the regions that support the cross-region backup feature, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
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
        /// <para>The retention period of level-1 backups. Valid values: 3 to 14. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DataLevel1BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string DataLevel1BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The time period during which automatic backup for level-1 backup is performed. The time period is in the <c>hh:mmZ-hh:mmZ</c> format and is displayed in UTC. The start time and end time are on the hour and have an interval of 1 hour. Example: <c>14:00Z-15:00Z</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is invalid for PolarDB for Oracle clusters or PolarDB for PostgreSQL clusters.</description></item>
        /// <item><description>This parameter is invalid if the region where your PolarDB for MySQL cluster is deployed does not support the cross-region backup feature. For information about the regions that support the cross-region backup feature, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
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
        /// <item><description><b>1</b>: Cross-region level-2 backups are permanently retained.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is <b>0</b>. By default, the cross-region level-2 backup feature is disabled when you create a cluster.</para>
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
        /// <item><description>This parameter is invalid for PolarDB for Oracle clusters or PolarDB for PostgreSQL clusters.</description></item>
        /// <item><description>This parameter is invalid if the region where your PolarDB for MySQL cluster is deployed does not support the cross-region backup feature. For information about the regions that support the cross-region backup feature, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
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
        /// <item><description><b>0</b>: The level-2 backup feature is disabled.</description></item>
        /// <item><description><b>30 to 7300</b>: Cross-region level-2 backups are retained for 30 to 7,300 days.</description></item>
        /// <item><description><b>1</b>: Cross-region level-2 backups are permanently retained.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is <b>0</b>. By default, the level-2 backup feature is disabled when you create a cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DataLevel2BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string DataLevel2BackupRetentionPeriod { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The backup cycle. Valid values:</para>
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
        /// <item><description>This parameter is invalid if the region where your PolarDB for MySQL cluster is deployed supports the cross-region backup feature. For information about the regions that support the cross-region backup feature, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Monday,Tuesday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The time period during which automatic backup for level-1 backup is performed. The format is <c>hh:mmZ-hh:mmZ</c> format. The time is displayed in UTC. The start time and end time are on the hour and with an interval of one hour. Example: <c>14:00Z-15:00Z</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15:00Z-16:00Z</para>
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

    }

}
