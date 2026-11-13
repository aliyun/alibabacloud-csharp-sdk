// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateBackupRequest : TeaModel {
        /// <summary>
        /// <para>The backup method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Logical</b>: logical backup. This value is supported only for ApsaraDB RDS for MySQL instances with local SSDs.</description></item>
        /// <item><description><b>Physical</b>: physical backup. This value is supported for ApsaraDB RDS for MySQL instances with local SSDs, ApsaraDB RDS for SQL Server instances, and ApsaraDB RDS for PostgreSQL instances.</description></item>
        /// <item><description><b>Snapshot</b>: snapshot backup. This value is supported for ApsaraDB RDS for MySQL instances with cloud disks, ApsaraDB RDS for SQL Server instances, ApsaraDB RDS for PostgreSQL instances, and ApsaraDB RDS for MariaDB instances.</description></item>
        /// </list>
        /// <para>Default value: <b>Physical</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When you use logical backup, the databases must contain data.</description></item>
        /// <item><description>ApsaraDB RDS for MariaDB instances support only snapshot backup. However, you must set this parameter to <b>Physical</b> for these instances.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Physical</para>
        /// </summary>
        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        /// <summary>
        /// <para>The retention period of the backup set.</para>
        /// <list type="bullet">
        /// <item><description><b>ApsaraDB RDS for SQL Server</b>: When the BackupStrategy parameter is set to db, the BackupMethod parameter is set to Physical, and the BackupType parameter is set to FullBackup, you can specify the retention period of the backup set. Valid values: 7 to 730 days, and -1 (long-term retention (LTR)).</description></item>
        /// <item><description><b>ApsaraDB RDS for MySQL</b>: You can specify the retention period of the backup set. Valid values: 7 to 730 days, and -1 (long-term retention (LTR)).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public long? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The backup strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>db</b>: database-level backup.</description></item>
        /// <item><description><b>instance</b>: instance-level backup.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when the following conditions are met:</para>
        /// <list type="bullet">
        /// <item><description>For ApsaraDB RDS for MySQL: The <b>BackupMethod</b> parameter is set to <b>Logical</b>.</description></item>
        /// <item><description>For ApsaraDB RDS for SQL Server: The <b>BackupType</b> parameter is set to <b>FullBackup</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>db</para>
        /// </summary>
        [NameInMap("BackupStrategy")]
        [Validation(Required=false)]
        public string BackupStrategy { get; set; }

        /// <summary>
        /// <para>The backup type for ApsaraDB RDS for SQL Server instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Auto</b>: The system automatically selects full backup or incremental backup. This is the default value.</description></item>
        /// <item><description><b>FullBackup</b>: full backup.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when the <b>BackupMethod</b> parameter is set to <b>Physical</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// <para>Instance ID of the instance. You can call the DescribeDBInstances operation to query instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The names of the databases. Separate multiple database names with commas (,).</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the <b>BackupStrategy</b> parameter is set to <b>db</b>.</para>
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
