// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class UpgradeDBInstanceKernelVersionRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can invoke DescribeDBInstances to query the instance ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The storage type of the ApsaraDB RDS for PostgreSQL instance must be <b>cloud disks</b>. For an instance with Premium Local SSDs, you can invoke the <a href="https://help.aliyun.com/document_detail/26230.html">RestartDBInstance</a> operation to restart the instance, which automatically upgrades the instance to the latest minor engine version.</description></item>
        /// <item><description>Only the 2019 version of ApsaraDB RDS for SQL Server supports minor engine version upgrades.</description></item>
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
        /// <para>The specified time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
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
        /// <para>The minor database engine version to which you want to upgrade. Format:</para>
        /// <list type="bullet">
        /// <item><description><b>PostgreSQL</b>: <c>rds_postgres_&lt;Major version number&gt;00_&lt;Minor version number&gt;</c>. Example for version 12 with minor version 20200830: <c>rds_postgres_1200_20200830</c>.</description></item>
        /// <item><description><b>MySQL</b>: <c>&lt;Instance version&gt;_&lt;Minor version number&gt;</c>. Examples: <c>rds_20200229</c>, <c>xcluster_20200229</c>, or <c>xcluster80_20200229</c>. The instance version can be one of the following:<list type="bullet">
        /// <item><description><b>rds</b>: high-availability series or Basic Edition.</description></item>
        /// <item><description><b>xcluster</b>: MySQL 5.7 RDS Enterprise Edition.</description></item>
        /// <item><description><b>xcluster80</b>: MySQL 8.0 RDS Enterprise Edition.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>SQLServer</b>: <c>&lt;Minor version number&gt;</c>. Example: <c>15.0.4073.23</c>.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the instance is upgraded to the latest minor engine version by default.</para>
        /// <remarks>
        /// <para>For minor engine version numbers, see <a href="https://help.aliyun.com/document_detail/126002.html">Release notes of ApsaraDB RDS for PostgreSQL minor engine versions</a>, <a href="https://help.aliyun.com/document_detail/96060.html">Release notes of ApsaraDB RDS for MySQL minor engine versions</a>, and <a href="https://help.aliyun.com/document_detail/213577.html">Release notes of ApsaraDB RDS for SQL Server minor engine versions</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xcluster80_20210305</para>
        /// </summary>
        [NameInMap("TargetMinorVersion")]
        [Validation(Required=false)]
        public string TargetMinorVersion { get; set; }

        /// <summary>
        /// <para>The upgrade time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b> (default): The upgrade takes effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The upgrade takes effect during the maintenance window. To modify the maintenance window, call ModifyDBInstanceMaintainTime.</description></item>
        /// <item><description><b>SpecifyTime</b>: The upgrade takes effect at a specified time.</description></item>
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
