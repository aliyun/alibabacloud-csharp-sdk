// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateBackupRequest : TeaModel {
        /// <summary>
        /// <para>The backup type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Logical</b>: logical backup</description></item>
        /// <item><description><b>Physical</b>: physical backup</description></item>
        /// <item><description><b>Snapshot</b>: snapshot backup</description></item>
        /// </list>
        /// <para>Default value: <b>Physical</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can perform a logical backup only when databases are created on the instance.</description></item>
        /// <item><description>When you perform a snapshot backup on an ApsaraDB RDS for MariaDB instance, you must set this parameter to <b>Physical</b>.</description></item>
        /// <item><description>For more information about the supported backup types, see <a href="https://help.aliyun.com/document_detail/98818.html">Use the data backup feature</a>.</description></item>
        /// <item><description>When you perform a snapshot backup on an ApsaraDB RDS for SQL Server instance that uses cloud disks, you must set this parameter to <b>Snapshot</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Physical</para>
        /// </summary>
        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public long? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The backup policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>db</b>: a database-level backup.</description></item>
        /// <item><description><b>instance</b>: an instance-level backup.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can specify this parameter when you perform a logical backup on an ApsaraDB RDS for MySQL instance. You can also specify this parameter when you perform a full physical backup on an ApsaraDB RDS for SQL Server instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>db</para>
        /// </summary>
        [NameInMap("BackupStrategy")]
        [Validation(Required=false)]
        public string BackupStrategy { get; set; }

        /// <summary>
        /// <para>The backup method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Auto</b>: full or incremental backup that is automatically selected</description></item>
        /// <item><description><b>FullBackup</b>: full backup</description></item>
        /// </list>
        /// <para>Default value: <b>Auto</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must set this parameter only when the instance runs SQL Server.</description></item>
        /// <item><description>This parameter is valid only when you set the <b>BackupMethod</b> parameter to <b>Physical</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The names of the databases whose data you want to back up. Separate the names of the databases with commas (,).</para>
        /// <remarks>
        /// <para>You can specify this parameter when you perform a logical backup on individual databases of an ApsaraDB RDS for MySQL instance. You can also specify this parameter when you perform a full physical backup on individual databases of an ApsaraDB RDS for SQL Server instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rds_mysql</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
