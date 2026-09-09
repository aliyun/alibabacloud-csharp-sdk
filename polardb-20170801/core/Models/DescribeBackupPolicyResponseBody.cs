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
        /// <item><description><b>enable</b>: Advanced backup is enabled.</description></item>
        /// <item><description><b>disable</b>: Advanced backup is not enabled but can be enabled.</description></item>
        /// <item><description><b>notSupport</b>: Advanced backup is not supported.<remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is not supported for PolarDB for PostgreSQL (Compatible with Oracle) or PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <item><description><b>Normal</b> (default): regular backup. A backup is performed once a day at a scheduled time.</description></item>
        /// <item><description><b>2/24H</b>: enhanced backup. A backup is performed every 2 hours.</description></item>
        /// <item><description><b>3/24H</b>: enhanced backup. A backup is performed every 3 hours.</description></item>
        /// <item><description><b>4/24H</b>: enhanced backup. A backup is performed every 4 hours.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>After enhanced backup is enabled, all backups completed within 24 hours are retained. For backups older than 24 hours, only the first backup completed after 00:00 each day is retained, and all others are deleted.</description></item>
        /// <item><description>After enhanced backup is enabled, the backup cycle parameter <b>PreferredBackupPeriod</b> is set to all days of the week by default (Monday through Sunday).</description></item>
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
        /// <para>The current backup policy level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: regular backup</description></item>
        /// <item><description><b>Advanced</b>: advanced backup<remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is not supported for PolarDB for PostgreSQL (Compatible with Oracle) or PolarDB for PostgreSQL.</description></item>
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
        /// <para>Specifies whether to retain backups when the cluster is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL</b>: All backups are retained with long-term retention (LTR).</description></item>
        /// <item><description><b>LATEST</b>: The last backup is retained with long-term retention (LTR).</description></item>
        /// <item><description><b>NONE</b> (default): No backups are retained.</description></item>
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
        /// <item><description><b>Normal</b> (default): regular backup. A backup is performed once a day at a scheduled time.</description></item>
        /// <item><description><b>2/24H</b>: high-frequency backup. A backup is performed every 2 hours.</description></item>
        /// <item><description><b>3/24H</b>: high-frequency backup. A backup is performed every 3 hours.</description></item>
        /// <item><description><b>4/24H</b>: high-frequency backup. A backup is performed every 4 hours.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported for PolarDB for PostgreSQL (Compatible with Oracle) or PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>If the region of your PolarDB for MySQL cluster does not support the cross-region backup feature, this parameter is not supported. For the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After advanced backup is enabled, use the AdvancedDataPolicies parameter instead of this parameter.</description></item>
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
        /// <para>The level-1 backup cycle. Valid values: </para>
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
        /// <item><description><list type="bullet">
        /// <item><description>At least two days must be selected. Separate multiple values with commas (,).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported for PolarDB for PostgreSQL (Compatible with Oracle) or PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>If the region of your PolarDB for MySQL cluster does not support the cross-region backup feature, this parameter is not supported. For the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After advanced backup is enabled, use the AdvancedDataPolicies parameter instead of this parameter.</description></item>
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
        /// <para>After advanced backup is enabled, use the AdvancedDataPolicies parameter instead of this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("DataLevel1BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string DataLevel1BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The time period during which automatic backups are performed. The value is in the <c>hh:mmZ-hh:mmZ</c> format (UTC). The start and end times must be on the hour and exactly 1 hour apart. Example: <c>14:00Z-15:00Z</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is not supported for PolarDB for PostgreSQL (Compatible with Oracle) or PolarDB for PostgreSQL.</description></item>
        /// <item><description>If the region of your PolarDB for MySQL cluster does not support the cross-region backup feature, this parameter is not supported. For the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
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
        /// <para>The cross-region backup region for level-2 backups. For the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</para>
        /// <remarks>
        /// <para>After advanced backup is enabled, use the AdvancedDataPolicies parameter instead of this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DataLevel2BackupAnotherRegionRegion")]
        [Validation(Required=false)]
        public string DataLevel2BackupAnotherRegionRegion { get; set; }

        /// <summary>
        /// <para>The retention epoch of cross-region backups for level-2 backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: The level-2 backup feature is shutdown.</para>
        /// </description></item>
        /// <item><description><para><b>30 to 7300</b>: The retention epoch of level-2 backups. Unit: days.</para>
        /// </description></item>
        /// <item><description><para><b>-1</b>: Level-2 backups are retained with long-term retention (LTR).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>When a cluster is created, the default value is <b>0</b>, which means the cross-region backup feature for level-2 backups is shutdown.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After advanced backup is enabled, use the AdvancedDataPolicies parameter instead of this parameter.</description></item>
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
        /// <para>The level-2 backup cycle. Valid values: </para>
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
        /// <item><description><list type="bullet">
        /// <item><description>At least two days must be selected. Separate multiple values with commas (,).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported for PolarDB for PostgreSQL (Compatible with Oracle) or PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>If the region of your PolarDB for MySQL cluster does not support the cross-region backup feature, this parameter is not supported. For the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After advanced backup is enabled, use the AdvancedDataPolicies parameter instead of this parameter.</description></item>
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
        /// <item><description>0: The level-2 backup feature is shutdown.</description></item>
        /// <item><description>30 to 7300: The retention epoch of level-2 backups. Unit: days.</description></item>
        /// <item><description>-1: Level-2 backups are retained with long-term retention (LTR).</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>When a cluster is created, the default value is <b>0</b>, which means the level-2 backup feature is shutdown.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After advanced backup is enabled, use the AdvancedDataPolicies parameter instead of this parameter.</description></item>
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
        /// <para>Indicates whether immutable cross-region backup is enabled.</para>
        /// </summary>
        [NameInMap("EnableCrossRegionImmutableBackup")]
        [Validation(Required=false)]
        public bool? EnableCrossRegionImmutableBackup { get; set; }

        /// <summary>
        /// <para>Indicates whether immutable backup is enabled.</para>
        /// </summary>
        [NameInMap("EnableImmutableBackup")]
        [Validation(Required=false)]
        public bool? EnableImmutableBackup { get; set; }

        /// <summary>
        /// <para>The data backup cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Monday</description></item>
        /// <item><description>Tuesday</description></item>
        /// <item><description>Wednesday</description></item>
        /// <item><description>Thursday</description></item>
        /// <item><description>Friday</description></item>
        /// <item><description>Saturday</description></item>
        /// <item><description>Sunday<remarks>
        /// <para>After advanced backup is enabled, use the AdvancedDataPolicies parameter instead of this parameter.</para>
        /// </remarks>
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
        /// <para>The time period during which automatic backups are performed. The value is in the <c>HH:mmZ-HH:mmZ</c> format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>07:00Z-08:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The time of the next backup. The value is in the <c>YYYY-MM-DDThh:mmZ</c> format (UTC).</para>
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
