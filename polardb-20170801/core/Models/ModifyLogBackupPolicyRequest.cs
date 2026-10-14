// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyLogBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The advanced backup policy.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported by PolarDB for PostgreSQL (Compatible with Oracle) or PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is supported only by clusters whose BackupPolicyLevel is set to Advanced.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("AdvancedLogPolicies")]
        [Validation(Required=false)]
        public List<ModifyLogBackupPolicyRequestAdvancedLogPolicies> AdvancedLogPolicies { get; set; }
        public class ModifyLogBackupPolicyRequestAdvancedLogPolicies : TeaModel {
            /// <summary>
            /// <para>The operation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CREATE</b>: creates a policy.</description></item>
            /// <item><description><b>UPDATE</b>: updates a policy.</description></item>
            /// <item><description><b>DELETE</b>: deletes a policy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE</para>
            /// </summary>
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// <para>The destination region of the log backup policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("DestRegion")]
            [Validation(Required=false)]
            public string DestRegion { get; set; }

            /// <summary>
            /// <para>The destination type of the backup policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>level1</b>: level-1 backup</description></item>
            /// <item><description><b>level2</b>: level-2 backup</description></item>
            /// <item><description><b>level2Cross</b>: level-2 cross-region backup</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>level2</para>
            /// </summary>
            [NameInMap("DestType")]
            [Validation(Required=false)]
            public string DestType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable log backup. The value is fixed to 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EnableLogBackup")]
            [Validation(Required=false)]
            public int? EnableLogBackup { get; set; }

            /// <summary>
            /// <para>The log backup retention period type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>never</b>: never expires</description></item>
            /// <item><description><b>delay</b>: expires after a fixed number of days</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>delay</para>
            /// </summary>
            [NameInMap("LogRetentionType")]
            [Validation(Required=false)]
            public string LogRetentionType { get; set; }

            /// <summary>
            /// <para>The log backup retention period in days. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>3 to 7300: the log retention period, in days.</description></item>
            /// <item><description>-1: long-term retention (LTR).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LogRetentionValue")]
            [Validation(Required=false)]
            public string LogRetentionValue { get; set; }

            /// <summary>
            /// <para>The ID of the log backup policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>71930ac2e9f15e41615e10627c******</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The source region of the log backup policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("SrcRegion")]
            [Validation(Required=false)]
            public string SrcRegion { get; set; }

            /// <summary>
            /// <para>The source type of the log backup policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>db</b>: database cluster</description></item>
            /// <item><description><b>level1</b>: level-1 backup</description></item>
            /// <item><description><b>level2</b>: level-2 backup</description></item>
            /// <item><description><b>level2Cross</b>: level-2 cross-region backup</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>level1</para>
            /// </summary>
            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public string SrcType { get; set; }

        }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query all clusters in a specific region, including their cluster IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The region for cross-region log backup. For more information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>After advanced backup is enabled, this parameter no longer takes effect. Use the AdvancedLogPolicies parameter instead.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("LogBackupAnotherRegionRegion")]
        [Validation(Required=false)]
        public string LogBackupAnotherRegionRegion { get; set; }

        /// <summary>
        /// <para>The retention period for cross-region backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disables the cross-region backup feature.</description></item>
        /// <item><description><b>30 to 7300</b>: the retention period for cross-region backups, in days.</description></item>
        /// <item><description><b>-1</b>: long-term retention (LTR).</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>When a cluster is created, the default value is <b>0</b>, which indicates that the cross-region backup feature is disabled.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After advanced backup is enabled, this parameter no longer takes effect. Use the AdvancedLogPolicies parameter instead.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("LogBackupAnotherRegionRetentionPeriod")]
        [Validation(Required=false)]
        public string LogBackupAnotherRegionRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The log retention period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>3 to 7300: the log retention period, in days.</description></item>
        /// <item><description>-1: long-term retention (LTR).</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>After advanced backup is enabled, this parameter no longer takes effect. Use the AdvancedLogPolicies parameter instead.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string LogBackupRetentionPeriod { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
