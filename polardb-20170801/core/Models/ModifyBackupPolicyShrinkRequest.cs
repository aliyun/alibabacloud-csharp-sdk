// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyBackupPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The advanced backup policies.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported for PolarDB for PostgreSQL (compatible with Oracle) and PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is supported only for clusters for which <c>BackupPolicyLevel</c> is set to <c>Advanced</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("AdvancedDataPolicies")]
        [Validation(Required=false)]
        public string AdvancedDataPoliciesShrink { get; set; }

        /// <summary>
        /// <para>The backup frequency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b> (default): standard backup. The cluster is backed up once a day.</para>
        /// </description></item>
        /// <item><description><para><b>2/24H</b>: high-frequency backup. The cluster is backed up every 2 hours.</para>
        /// </description></item>
        /// <item><description><para><b>3/24H</b>: high-frequency backup. The cluster is backed up every 3 hours.</para>
        /// </description></item>
        /// <item><description><para><b>4/24H</b>: high-frequency backup. The cluster is backed up every 4 hours.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>If you enable high-frequency backup, all backups completed within the last 24 hours are retained. For backups older than 24 hours, the system retains only the first backup completed after 00:00 each day and deletes the rest.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>If you enable high-frequency backup, the <b>PreferredBackupPeriod</b> parameter is automatically set to all days of the week (from Monday to Sunday).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported if your PolarDB for MySQL cluster is in a region that supports the cross-region backup feature. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After you enable advanced backup, this parameter is no longer effective. Use the <c>AdvancedDataPolicies</c> parameter instead.</description></item>
        /// </list>
        /// </description></item>
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
        /// <para>The level of the backup policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: standard backup</para>
        /// </description></item>
        /// <item><description><para><b>Advanced</b>: advanced backup</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported for PolarDB for PostgreSQL (compatible with Oracle) and PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>Check the <c>AdvancedPolicyOption</c> parameter in the response of the <a href="https://help.aliyun.com/document_detail/2319231.html">DescribeBackupPolicy</a> operation to determine whether the cluster supports advanced backup. If the cluster supports advanced backup, you can request this feature in <a href="~611727~~">Advanced backup settings</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After you enable advanced backup, you <b>cannot</b> switch back to standard backup.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("BackupPolicyLevel")]
        [Validation(Required=false)]
        public string BackupPolicyLevel { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain backups when you delete the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ALL</b>: Permanently retains all backups.</para>
        /// </description></item>
        /// <item><description><para><b>LATEST</b>: Permanently retains the last backup.</para>
        /// </description></item>
        /// <item><description><para><b>NONE</b>: Does not retain backup sets.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is <c>NONE</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public string BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the details of all clusters in a specified region, including the cluster IDs.</para>
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
        /// <para>The backup frequency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b> (default): standard backup. The cluster is backed up once a day.</para>
        /// </description></item>
        /// <item><description><para><b>2/24H</b>: high-frequency backup. The cluster is backed up every 2 hours.</para>
        /// </description></item>
        /// <item><description><para><b>3/24H</b>: high-frequency backup. The cluster is backed up every 3 hours.</para>
        /// </description></item>
        /// <item><description><para><b>4/24H</b>: high-frequency backup. The cluster is backed up every 4 hours.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported for PolarDB for PostgreSQL (compatible with Oracle) and PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported if your PolarDB for MySQL cluster is in a region that supports the cross-region backup feature. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After you enable advanced backup, this parameter is no longer effective. Use the <c>AdvancedDataPolicies</c> parameter instead.</description></item>
        /// </list>
        /// </description></item>
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
        /// <para>The level-1 backup cycle. Valid values:</para>
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
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>You must select at least two days. Separate multiple values with commas.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported for PolarDB for PostgreSQL (compatible with Oracle) and PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported if your PolarDB for MySQL cluster is in a region that supports the cross-region backup feature. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After you enable advanced backup, this parameter is no longer effective. Use the <c>AdvancedDataPolicies</c> parameter instead.</description></item>
        /// </list>
        /// </description></item>
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
        /// <para>The retention period for level-1 backups, in days. Valid values: 3 to 14.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>After you enable advanced backup, this parameter is no longer effective. Use the <c>AdvancedDataPolicies</c> parameter instead.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DataLevel1BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string DataLevel1BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The time window for automatic backups. Specify the time in UTC and in the <c>hh:mmZ-hh:mmZ</c> format. The time window must be a one-hour period that starts on the hour. For example, <c>14:00Z-15:00Z</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is not supported for PolarDB for PostgreSQL (compatible with Oracle) and PolarDB for PostgreSQL.</para>
        /// </description></item>
        /// <item><description><para>This parameter is not supported if your PolarDB for MySQL cluster is in a region that supports the cross-region backup feature. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</para>
        /// </description></item>
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
        /// <para>The destination region for the cross-region level-2 backup. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>After you enable advanced backup, this parameter is no longer effective. Use the <c>AdvancedDataPolicies</c> parameter instead.</description></item>
        /// </list>
        /// </remarks>
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
        /// <item><description><para><b>0</b>: Disables the cross-region level-2 backup feature.</para>
        /// </description></item>
        /// <item><description><para><b>30 to 7300</b>: The retention period of cross-region level-2 backups, in days.</para>
        /// </description></item>
        /// <item><description><para><b>-1</b>: Cross-region level-2 backups are permanently retained.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>When you create a cluster, the default value is <b>0</b>, which disables the cross-region level-2 backup feature.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After you enable advanced backup, this parameter is no longer effective. Use the <c>AdvancedDataPolicies</c> parameter instead.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("DataLevel2BackupAnotherRegionRetentionPeriod")]
        [Validation(Required=false)]
        public string DataLevel2BackupAnotherRegionRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The level-2 backup cycle. Valid values:</para>
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
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>You must select at least two days. Separate multiple values with commas.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported for PolarDB for PostgreSQL (compatible with Oracle) and PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported if your PolarDB for MySQL cluster is in a region that supports the cross-region backup feature. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After you enable advanced backup, this parameter is no longer effective. Use the <c>AdvancedDataPolicies</c> parameter instead.</description></item>
        /// </list>
        /// </description></item>
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
        /// <item><description><para><b>0</b>: Disables the level-2 backup feature.</para>
        /// </description></item>
        /// <item><description><para><b>30 to 7300</b>: The retention period of level-2 backups, in days.</para>
        /// </description></item>
        /// <item><description><para><b>-1</b>: Level-2 backups are permanently retained.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>When you create a cluster, the default value is <b>0</b>, which disables the level-2 backup feature.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After you enable advanced backup, this parameter is no longer effective. Use the <c>AdvancedDataPolicies</c> parameter instead.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
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
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>You must select at least two days. Separate multiple values with commas.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported if your PolarDB for MySQL cluster is in a region that supports the cross-region backup feature. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After you enable advanced backup, this parameter is no longer effective. Use the <c>AdvancedDataPolicies</c> parameter instead.</description></item>
        /// </list>
        /// </description></item>
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
        /// <para>The time window for automatic backups. Specify the time in UTC and in the <c>hh:mmZ-hh:mmZ</c> format. The time window must be a one-hour period that starts on the hour. For example, <c>14:00Z-15:00Z</c>.</para>
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
