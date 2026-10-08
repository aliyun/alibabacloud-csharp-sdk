// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateBackupRequest : TeaModel {
        /// <summary>
        /// <para>The backup type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Logical</b>: logical backup. Only MySQL instances with local disks support this type.</description></item>
        /// <item><description><b>Physical</b>: physical backup. MySQL instances with local disks, SQL Server instances, and PostgreSQL instances support this type.</description></item>
        /// <item><description><b>Snapshot</b>: snapshot backup. MySQL instances with cloud disks, SQL Server instances, PostgreSQL instances, and MariaDB instances support this type.</description></item>
        /// </list>
        /// <para>Default value: <b>Physical</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When you use logical backup, the database must contain data (the data cannot be empty).</description></item>
        /// <item><description>MariaDB instances support only snapshot backup. However, set this parameter to <b>Physical</b>.</description></item>
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
        /// <list type="bullet">
        /// <item><description><b>SQL Server</b>: When the BackupStrategy parameter is set to db, the BackupMethod parameter is set to Physical, and the BackupType parameter is set to FullBackup, you can specify the retention period of the backup set. Valid values: 7 to 730 days, or -1 (long-term retention (LTR)).</description></item>
        /// <item><description><b>MySQL</b>: You can specify the retention period of the backup set. Valid values: 7 to 730 days, or -1 (long-term retention (LTR)).</description></item>
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
        /// <item><description><b>db</b>: single-database backup</description></item>
        /// <item><description><b>instance</b>: instance backup</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when the following conditions are met:</para>
        /// <list type="bullet">
        /// <item><description>MySQL: The <b>BackupMethod</b> parameter is set to <b>Logical</b>.</description></item>
        /// <item><description>SQL Server: The <b>BackupType</b> parameter is set to <b>FullBackup</b>.</description></item>
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
        /// <para>The backup method for SQL Server instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Auto</b> (default): automatically selects full backup or incremental backup.</description></item>
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
        /// <para>The instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The list of databases. Separate multiple databases with commas (,).</para>
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
