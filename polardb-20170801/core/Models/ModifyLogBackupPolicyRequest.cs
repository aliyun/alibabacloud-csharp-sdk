// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyLogBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The advanced backup policies.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is not supported for PolarDB for PostgreSQL (Oracle Compatible) or PolarDB for PostgreSQL.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>This parameter is supported only for clusters for which the BackupPolicyLevel parameter is set to Advanced.</description></item>
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
            /// <item><description><para><b>CREATE</b>: Create</para>
            /// </description></item>
            /// <item><description><para><b>UPDATE</b>: Update</para>
            /// </description></item>
            /// <item><description><para><b>DELETE</b>: Delete</para>
            /// </description></item>
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
            /// <item><description><para><b>level1</b>: level-1 backup</para>
            /// </description></item>
            /// <item><description><para><b>level2</b>: level-2 backup</para>
            /// </description></item>
            /// <item><description><para><b>level2Cross</b>: level-2 cross-region backup</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>level2</para>
            /// </summary>
            [NameInMap("DestType")]
            [Validation(Required=false)]
            public string DestType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable log backup. Set the value to 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EnableLogBackup")]
            [Validation(Required=false)]
            public int? EnableLogBackup { get; set; }

            /// <summary>
            /// <para>The retention period type for log backups. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>never</b>: The backups never expire.</para>
            /// </description></item>
            /// <item><description><para><b>delay</b>: The backups expire after a fixed number of days.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>delay</para>
            /// </summary>
            [NameInMap("LogRetentionType")]
            [Validation(Required=false)]
            public string LogRetentionType { get; set; }

            /// <summary>
            /// <para>The number of days to retain the log backups. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>3 to 7300: The retention period in days.</para>
            /// </description></item>
            /// <item><description><para>-1: long-term retention.</para>
            /// </description></item>
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
            /// <item><description><para><b>db</b>: database cluster</para>
            /// </description></item>
            /// <item><description><para><b>level1</b>: level-1 backup</para>
            /// </description></item>
            /// <item><description><para><b>level2</b>: level-2 backup</para>
            /// </description></item>
            /// <item><description><para><b>level2Cross</b>: level-2 cross-region backup</para>
            /// </description></item>
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
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to view information about all clusters in a specific region, including cluster IDs.</para>
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
        /// <para>The destination region for cross-region log backups. For information about the regions that support cross-region backup, see <a href="https://help.aliyun.com/document_detail/72672.html">Overview</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>After you enable the advanced backup feature, this parameter is no longer valid. Use the AdvancedLogPolicies parameter instead.</description></item>
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
        /// <para>The retention period of cross-region log backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Disables the cross-region log backup feature.</para>
        /// </description></item>
        /// <item><description><para><b>30 to 7300</b>: The retention period in days.</para>
        /// </description></item>
        /// <item><description><para><b>-1</b>: long-term retention.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>When you create a cluster, the default value of this parameter is <b>0</b>. This value disables the cross-region log backup feature.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>After you enable the advanced backup feature, this parameter is no longer valid. Use the AdvancedLogPolicies parameter instead.</description></item>
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
        /// <para>The retention period of log backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>3 to 7300: The retention period in days.</para>
        /// </description></item>
        /// <item><description><para>-1: long-term retention.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description>After you enable the advanced backup feature, this parameter is no longer valid. Use the AdvancedLogPolicies parameter instead.</description></item>
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
