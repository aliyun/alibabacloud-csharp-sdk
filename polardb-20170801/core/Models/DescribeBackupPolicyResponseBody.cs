// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        [NameInMap("AdvancedDataPolicies")]
        [Validation(Required=false)]
        public DescribeBackupPolicyResponseBodyAdvancedDataPolicies AdvancedDataPolicies { get; set; }
        public class DescribeBackupPolicyResponseBodyAdvancedDataPolicies : TeaModel {
            [NameInMap("AdvancedDataPolicy")]
            [Validation(Required=false)]
            public List<DescribeBackupPolicyResponseBodyAdvancedDataPoliciesAdvancedDataPolicy> AdvancedDataPolicy { get; set; }
            public class DescribeBackupPolicyResponseBodyAdvancedDataPoliciesAdvancedDataPolicy : TeaModel {
                [NameInMap("AutoCreated")]
                [Validation(Required=false)]
                public bool? AutoCreated { get; set; }

                [NameInMap("BakType")]
                [Validation(Required=false)]
                public string BakType { get; set; }

                [NameInMap("DestRegion")]
                [Validation(Required=false)]
                public string DestRegion { get; set; }

                [NameInMap("DestType")]
                [Validation(Required=false)]
                public string DestType { get; set; }

                [NameInMap("DumpAction")]
                [Validation(Required=false)]
                public string DumpAction { get; set; }

                [NameInMap("FilterKey")]
                [Validation(Required=false)]
                public string FilterKey { get; set; }

                [NameInMap("FilterType")]
                [Validation(Required=false)]
                public string FilterType { get; set; }

                [NameInMap("FilterValue")]
                [Validation(Required=false)]
                public string FilterValue { get; set; }

                [NameInMap("OnlyPreserveOneEachDay")]
                [Validation(Required=false)]
                public bool? OnlyPreserveOneEachDay { get; set; }

                [NameInMap("OnlyPreserveOneEachHour")]
                [Validation(Required=false)]
                public bool? OnlyPreserveOneEachHour { get; set; }

                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                [NameInMap("RetentionType")]
                [Validation(Required=false)]
                public string RetentionType { get; set; }

                [NameInMap("RetentionValue")]
                [Validation(Required=false)]
                public string RetentionValue { get; set; }

                [NameInMap("SrcRegion")]
                [Validation(Required=false)]
                public string SrcRegion { get; set; }

                [NameInMap("SrcType")]
                [Validation(Required=false)]
                public string SrcType { get; set; }

                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

            }

        }

        /// <summary>
        /// <para>The advanced backup policy option. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>enable</b>: Advanced backup is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>disable</b>: Advanced backup is disabled. You can enable it.</para>
        /// </description></item>
        /// <item><description><para><b>notSupport</b>: Advanced backup is not supported.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is not supported by PolarDB for PostgreSQL (compatible with Oracle) and PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>disable</para>
        /// </summary>
        [NameInMap("AdvancedPolicyOption")]
        [Validation(Required=false)]
        public string AdvancedPolicyOption { get; set; }

        /// <summary>
        /// <para>The backup frequency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b> (Default): Standard backup. A backup is performed once a day.</para>
        /// </description></item>
        /// <item><description><para><b>2/24H</b>: Enhanced backup. A backup is performed every 2 hours.</para>
        /// </description></item>
        /// <item><description><para><b>3/24H</b>: Enhanced backup. A backup is performed every 3 hours.</para>
        /// </description></item>
        /// <item><description><para><b>4/24H</b>: Enhanced backup. A backup is performed every 4 hours.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you enable enhanced backup, all backups that are completed within 24 hours are retained. For backups that are completed more than 24 hours ago, the system retains only the first backup that is completed after 00:00 every day. Other backups are deleted.</para>
        /// </description></item>
        /// <item><description><para>If you enable enhanced backup, the <b>PreferredBackupPeriod</b> parameter is automatically set to all days of the week (Monday to Sunday).</para>
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
        /// <item><description>This parameter is not supported by PolarDB for PostgreSQL (compatible with Oracle) and PolarDB for PostgreSQL.</description></item>
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
        /// <para>The policy to retain backups when you delete a cluster:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ALL</b>: Retains all backups permanently.</para>
        /// </description></item>
        /// <item><description><para><b>LATEST</b>: Retains the last backup permanently.</para>
        /// </description></item>
        /// <item><description><para><b>NONE</b> (Default): Does not retain backup sets.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public string BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// <para>The backup frequency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b> (Default): Standard backup. A backup is performed once a day.</para>
        /// </description></item>
        /// <item><description><para><b>2/24H</b>: High-frequency backup. A backup is performed every 2 hours.</para>
        /// </description></item>
        /// <item><description><para><b>3/24H</b>: High-frequency backup. A backup is performed every 3 hours.</para>
        /// </description></item>
        /// <item><description><para><b>4/24H</b>: High-frequency backup. A backup is performed every 4 hours.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported by PolarDB for PostgreSQL (compatible with Oracle) and PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported if the cross-region backup feature is unavailable in the region where your PolarDB for MySQL cluster resides. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not recommended if the advanced backup feature is enabled. Use the AdvancedDataPolicies parameter instead.</description></item>
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
        /// <para>The cycle of a level-1 backup. Valid values:</para>
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
        /// <item><description>Select at least two days. Separate multiple values with commas (,).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported by PolarDB for PostgreSQL (compatible with Oracle) and PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported if the cross-region backup feature is unavailable in the region where your PolarDB for MySQL cluster resides. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not recommended if the advanced backup feature is enabled. Use the AdvancedDataPolicies parameter instead.</description></item>
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
        /// <para>This parameter is not recommended if the advanced backup feature is enabled. Use the AdvancedDataPolicies parameter instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("DataLevel1BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string DataLevel1BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The time range when an automatic backup is performed. The time is in the <c>hh:mmZ-hh:mmZ</c> format and is displayed in UTC. The specified time range must be a 1-hour interval on the hour, such as <c>14:00Z-15:00Z</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is not supported by PolarDB for PostgreSQL (compatible with Oracle) and PolarDB for PostgreSQL.</para>
        /// </description></item>
        /// <item><description><para>This parameter is not supported if the cross-region backup feature is unavailable in the region where your PolarDB for MySQL cluster resides. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</para>
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
        /// <para>The destination region of the cross-region level-2 backup. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</para>
        /// <remarks>
        /// <para>This parameter is not recommended if the advanced backup feature is enabled. Use the AdvancedDataPolicies parameter instead.</para>
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
        /// <item><description><para><b>0</b>: The level-2 backup feature is disabled.</para>
        /// </description></item>
        /// <item><description><para><b>30 to 7300</b>: The retention period of level-2 backups in days.</para>
        /// </description></item>
        /// <item><description><para><b>-1</b>: The level-2 backups are permanently retained.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>When you create a cluster, the default value is <b>0</b>. This means the cross-region backup feature for level-2 backups is disabled.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not recommended if the advanced backup feature is enabled. Use the AdvancedDataPolicies parameter instead.</description></item>
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
        /// <para>The cycle of a level-2 backup. Valid values:</para>
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
        /// <item><description>Select at least two days. Separate multiple values with commas (,).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported by PolarDB for PostgreSQL (compatible with Oracle) and PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported if the cross-region backup feature is unavailable in the region where your PolarDB for MySQL cluster resides. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not recommended if the advanced backup feature is enabled. Use the AdvancedDataPolicies parameter instead.</description></item>
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
        /// <item><description><para>0: The level-2 backup feature is disabled.</para>
        /// </description></item>
        /// <item><description><para>30 to 7300: The retention period of level-2 backups in days.</para>
        /// </description></item>
        /// <item><description><para>-1: The level-2 backups are permanently retained.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>When you create a cluster, the default value is <b>0</b>. This means the level-2 backup feature is disabled.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not recommended if the advanced backup feature is enabled. Use the AdvancedDataPolicies parameter instead.</description></item>
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

        /// <summary>
        /// <para>The backup cycle. Valid values:</para>
        /// <list type="bullet">
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
        /// </list>
        /// <remarks>
        /// <para>This parameter is not recommended if the advanced backup feature is enabled. Use the AdvancedDataPolicies parameter instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The time range when an automatic backup is performed. The time is in the <c>HH:mmZ-HH:mmZ</c> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>07:00Z-08:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The time of the next backup. The time is in the <c>YYYY-MM-DDThh:mmZ</c> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-16T07:30Z</para>
        /// </summary>
        [NameInMap("PreferredNextBackupTime")]
        [Validation(Required=false)]
        public string PreferredNextBackupTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EADFCE0F-9FB5-4685-B395-1440B******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
