// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyBackupPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The advanced backup policy.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported by PolarDB for PostgreSQL (Compatible with Oracle) and PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is supported only by clusters whose BackupPolicyLevel is set to Advanced.</description></item>
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
        /// <item><description><b>Normal</b> (default): standard backup, performed once a day at a scheduled time.</description></item>
        /// <item><description><b>2/24H</b>: high-frequency backup, performed once every 2 hours.</description></item>
        /// <item><description><b>3/24H</b>: high-frequency backup, performed once every 3 hours.</description></item>
        /// <item><description><b>4/24H</b>: high-frequency backup, performed once every 4 hours.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>After high-frequency backup is enabled, all backups completed within 24 hours are retained. For backups that exceed 24 hours, the system retains only the first backup completed after 00:00 each day and deletes the rest.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After high-frequency backup is enabled, all days of the week (Monday to Sunday) are selected by default for the backup epoch <b>PreferredBackupPeriod</b> parameter.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported if the region where your PolarDB for MySQL cluster resides supports the cross-region backup feature. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After advanced backup is enabled, this parameter no longer takes effect. Use the AdvancedDataPolicies parameter instead.</description></item>
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
        /// <item><description><b>Normal</b>: standard backup</description></item>
        /// <item><description><b>Advanced</b>: advanced backup<remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported by PolarDB for PostgreSQL (Compatible with Oracle) and PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>You can check the AdvancedPolicyOption parameter in the response of the <a href="https://help.aliyun.com/document_detail/2319231.html">DescribeBackupPolicy</a> operation to determine whether the cluster supports advanced backup. If the cluster supports advanced backup, you can apply for this feature in <a href="~611727~~">Advanced backup settings</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After advanced backup is enabled, you <b>cannot</b> roll back to standard backup.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("BackupPolicyLevel")]
        [Validation(Required=false)]
        public string BackupPolicyLevel { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain backups when a cluster is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ALL</b>: long-term retention (LTR) of all backups.</para>
        /// </description></item>
        /// <item><description><para><b>LATEST</b>: long-term retention (LTR) of the last backup.</para>
        /// </description></item>
        /// <item><description><para><b>NONE</b>: does not retain backup sets.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: NONE.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query all clusters in a specific region, including their cluster IDs.</para>
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
        /// <item><description><b>Normal</b> (default): standard backup, performed once a day at a scheduled time</description></item>
        /// <item><description><b>2/24H</b>: high-frequency backup, performed once every 2 hours</description></item>
        /// <item><description><b>3/24H</b>: high-frequency backup, performed once every 3 hours</description></item>
        /// <item><description><b>4/24H</b>: high-frequency backup, performed once every 4 hours</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported by PolarDB for PostgreSQL (Compatible with Oracle) and PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported if the region where your PolarDB for MySQL cluster resides does not support cross-region backup. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After advanced backup is enabled, this parameter no longer takes effect. Use the AdvancedDataPolicies parameter instead.</description></item>
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
        /// <para>The backup cycle for level-1 backups. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b>: Monday</description></item>
        /// <item><description><b>Tuesday</b>: Tuesday</description></item>
        /// <item><description><b>Wednesday</b>: Wednesday</description></item>
        /// <item><description><b>Thursday</b>: Thursday</description></item>
        /// <item><description><b>Friday</b>: Friday</description></item>
        /// <item><description><b>Saturday</b>: Saturday</description></item>
        /// <item><description><b>Sunday</b>: Sunday</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>You must select at least two days. Separate multiple values with commas (,).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported by PolarDB for PostgreSQL (Compatible with Oracle) and PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported if the region where your PolarDB for MySQL cluster resides does not support cross-region backup. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After advanced backup is enabled, this parameter no longer takes effect. Use the AdvancedDataPolicies parameter instead.</description></item>
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
        /// <para>The retention period of level-1 backups. Valid values: 3 to 14. Unit: days.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>After advanced backup is enabled, this parameter no longer takes effect. Use the AdvancedDataPolicies parameter instead.</description></item>
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
        /// <para>The time period during which automatic backups are performed. The time must be in the <c>hh:mmZ-hh:mmZ</c> format (UTC time) and must be on the hour with a 1-hour interval, such as <c>14:00Z-15:00Z</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is not supported by PolarDB for PostgreSQL (Compatible with Oracle) and PolarDB for PostgreSQL.</description></item>
        /// <item><description>This parameter is not supported if the region where your PolarDB for MySQL cluster resides does not support cross-region backup. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
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
        /// <para>The destination region for cross-region backup of level-2 backups. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>After advanced backup is enabled, this parameter no longer takes effect. Use the AdvancedDataPolicies parameter instead.</description></item>
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
        /// <para>The retention epoch for cross-region backup of level-2 backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: shutdown of the level-2 backup feature.</para>
        /// </description></item>
        /// <item><description><para><b>30 to 7300</b>: the retention epoch of level-2 backups, in days.</para>
        /// </description></item>
        /// <item><description><para><b>-1</b>: long-term retention (LTR) of level-2 backups.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>When a cluster is created, the default value is <b>0</b>, which indicates the shutdown of the cross-region backup feature for level-2 backups.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After advanced backup is enabled, this parameter no longer takes effect. Use the AdvancedDataPolicies parameter instead.</description></item>
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
        /// <para>The backup cycle for level-2 backups. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b>: Monday</description></item>
        /// <item><description><b>Tuesday</b>: Tuesday</description></item>
        /// <item><description><b>Wednesday</b>: Wednesday</description></item>
        /// <item><description><b>Thursday</b>: Thursday</description></item>
        /// <item><description><b>Friday</b>: Friday</description></item>
        /// <item><description><b>Saturday</b>: Saturday</description></item>
        /// <item><description><b>Sunday</b>: Sunday</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>You must select at least two days. Separate multiple values with commas (,).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported by PolarDB for PostgreSQL (Compatible with Oracle) and PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported if the region where your PolarDB for MySQL cluster resides does not support cross-region backup. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After advanced backup is enabled, this parameter no longer takes effect. Use the AdvancedDataPolicies parameter instead.</description></item>
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
        /// <para>The retention epoch of level-2 backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: shutdown of the level-2 backup feature.</para>
        /// </description></item>
        /// <item><description><para><b>30 to 7300</b>: the retention epoch of level-2 backups, in days.</para>
        /// </description></item>
        /// <item><description><para><b>-1</b>: long-term retention (LTR) of level-2 backups.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>When a cluster is created, the default value is <b>0</b>, which indicates the shutdown of the level-2 backup feature.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After advanced backup is enabled, this parameter no longer takes effect. Use the AdvancedDataPolicies parameter instead.</description></item>
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
        /// <para>The backup cycle. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b>: Monday</description></item>
        /// <item><description><b>Tuesday</b>: Tuesday</description></item>
        /// <item><description><b>Wednesday</b>: Wednesday</description></item>
        /// <item><description><b>Thursday</b>: Thursday</description></item>
        /// <item><description><b>Friday</b>: Friday</description></item>
        /// <item><description><b>Saturday</b>: Saturday</description></item>
        /// <item><description><b>Sunday</b>: Sunday</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>You must select at least two days. Separate multiple values with commas (,).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported if the region where your PolarDB for MySQL cluster resides supports cross-region backup. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After advanced backup is enabled, this parameter no longer takes effect. Use the AdvancedDataPolicies parameter instead.</description></item>
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
        /// <para>The time period during which automatic backups are performed. The time must be in the <c>hh:mmZ-hh:mmZ</c> format (UTC time) and must be on the hour with a 1-hour interval, such as <c>14:00Z-15:00Z</c>.</para>
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
