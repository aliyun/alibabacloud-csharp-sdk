// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class UpgradeDBInstanceKernelVersionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The storage type of the ApsaraDB RDS for PostgreSQL instance must be <b>cloud disk</b>. You can call the <a href="https://help.aliyun.com/document_detail/26230.html">restart the instance</a> operation to restart an instance with Premium Local SSDs to automatically upgrade the instance to the latest minor engine version.</description></item>
        /// <item><description>Only ApsaraDB RDS for SQL Server 2019 instances support minor engine version upgrades.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp****</para>
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
        /// <para>The specified time when the upgrade is performed. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>UpgradeTime</b> is set to <b>SpecifyTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-01-15T00:00:00Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The target minor database version. Format:</para>
        /// <list type="bullet">
        /// <item><description><b>PostgreSQL</b>: <c>rds_postgres_&lt;Major version number&gt;00_&lt;Minor version number&gt;</c>. Example: <c>rds_postgres_1200_20200830</c> for PostgreSQL 12 version 20200830.</description></item>
        /// <item><description><b>MySQL</b>: <c>&lt;Instance edition&gt;_&lt;Minor version number&gt;</c>. Examples: <c>rds_20200229</c>, <c>xcluster_20200229</c>, and <c>xcluster80_20200229</c>. The instance editions are as follows:<list type="bullet">
        /// <item><description><b>rds</b>: high availability series or Basic Edition.</description></item>
        /// <item><description><b>xcluster</b>: MySQL 5.7 RDS Enterprise Edition.</description></item>
        /// <item><description><b>xcluster80</b>: MySQL 8.0 RDS Enterprise Edition.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>SQL Server</b>: <c>&lt;Minor version number&gt;</c>. Example: <c>15.0.4073.23</c>.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the instance is upgraded to the latest minor database version by default.</para>
        /// <remarks>
        /// <para>For more information about minor database versions, see <a href="https://help.aliyun.com/document_detail/126002.html">Release notes for minor engine versions of ApsaraDB RDS for PostgreSQL</a>, <a href="https://help.aliyun.com/document_detail/96060.html">Release notes for minor engine versions of ApsaraDB RDS for MySQL</a>, and <a href="https://help.aliyun.com/document_detail/213577.html">Release notes for minor engine versions of ApsaraDB RDS for SQL Server</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xcluster80_20210305</para>
        /// </summary>
        [NameInMap("TargetMinorVersion")]
        [Validation(Required=false)]
        public string TargetMinorVersion { get; set; }

        /// <summary>
        /// <para>The time when the upgrade is performed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: The upgrade is immediately performed. This is the default value.</description></item>
        /// <item><description><b>MaintainTime</b>: The upgrade is performed within the specified maintenance window. For more information about how to modify the maintenance window, see ModifyDBInstanceMaintainTime.</description></item>
        /// <item><description><b>SpecifyTime</b>: The upgrade is performed at the specified time.</description></item>
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
