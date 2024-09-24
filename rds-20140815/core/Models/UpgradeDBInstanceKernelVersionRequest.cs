// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class UpgradeDBInstanceKernelVersionRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If your instance runs PostgreSQL, you must make sure that the instance uses <b>cloud disks</b>. If the instance uses local disks, you must call the <a href="https://help.aliyun.com/document_detail/26230.html">RestartDBInstance</a> operation to restart the instance. The system automatically updates the minor engine version of the instance to the latest version during the restart.</description></item>
        /// <item><description>If your instance runs SQL Server, you must make sure that the instance runs SQL Server 2019.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bpxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The update time. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when you set <b>UpgradeTime</b> to <b>SpecifyTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-01-15T00:00:00Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The minor engine version to which you want to update. Format:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PostgreSQL</b>: <c>rds_postgres_&lt;Major engine version&gt;00_&lt;Minor engine version&gt;</c>. Example: <c>rds_postgres_1200_20200830</c>.</para>
        /// </description></item>
        /// <item><description><para><b>MySQL</b>: <c>&lt;RDS edition and MySQL version&gt;_&lt;Minor engine version&gt;</c>. Examples: <c>rds_20200229</c>, <c>xcluster_20200229</c>, and <c>xcluster80_20200229</c>. The following RDS editions and MySQL versions are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>rds</b>: RDS Basic Edition or RDS High-availability Edition</description></item>
        /// <item><description><b>xcluster</b>: MySQL 5.7 on RDS Enterprise Edition</description></item>
        /// <item><description><b>xcluster80</b>: MySQL 8.0 on RDS Enterprise Edition</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>SQLServer</b>: <c>&lt;Minor engine version&gt;</c>. Example: <c>15.0.4073.23</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the instance is updated to the latest minor engine version.</para>
        /// <remarks>
        /// <para> For more information about minor engine versions, see <a href="https://help.aliyun.com/document_detail/126002.html">Release notes of AliPG</a>, <a href="https://help.aliyun.com/document_detail/96060.html">Release notes of AliSQL</a>, and <a href="https://help.aliyun.com/document_detail/213577.html">Release notes of minor engine versions of ApsaraDB RDS for SQL Server</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xcluster80_20210305</para>
        /// </summary>
        [NameInMap("TargetMinorVersion")]
        [Validation(Required=false)]
        public string TargetMinorVersion { get; set; }

        /// <summary>
        /// <para>The time when the update takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b> (default): The update takes effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The update takes effect during the maintenance window that you specify. For more information about how to change the maintenance window, see ModifyDBInstanceMaintainTime.</description></item>
        /// <item><description><b>SpecifyTime</b>: The update takes effect at the point in time you specify.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("UpgradeTime")]
        [Validation(Required=false)]
        public string UpgradeTime { get; set; }

    }

}
