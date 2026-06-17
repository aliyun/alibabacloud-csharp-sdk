// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyLogBackupPolicyShrinkRequest : TeaModel {
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
        public string AdvancedLogPoliciesShrink { get; set; }

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
