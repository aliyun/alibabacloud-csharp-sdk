// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateMigrateTaskRequest : TeaModel {
        /// <summary>
        /// <para>The type of the cloud migration task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FULL</b>: restores data by using a full backup file. This value is applicable to the first migration or full data recovery scenarios.</description></item>
        /// <item><description><b>UPDF</b>: restores incremental data by using an incremental backup file or log file. This value is applicable to incremental synchronization scenarios based on an existing full backup.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FULL</para>
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// <para>The consistency check method used after the database is opened. This parameter takes effect only when IsOnlineDB is set to True. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SyncExecuteDBCheck</b>: synchronously executes the database check. This value is applicable to scenarios that require high data consistency.</description></item>
        /// <item><description><b>AsyncExecuteDBCheck</b>: asynchronously executes the database check. This value provides higher performance but may delay the discovery of potential issues.</description></item>
        /// </list>
        /// <para>Default value: <b>AsyncExecuteDBCheck</b> (compatible with SQL Server 2008 R2).</para>
        /// 
        /// <b>Example:</b>
        /// <para>AsyncExecuteDBCheck</para>
        /// </summary>
        [NameInMap("CheckDBMode")]
        [Validation(Required=false)]
        public string CheckDBMode { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the destination database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDB</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>Specifies whether to bring the restored database online for user access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: brings the database online.</description></item>
        /// <item><description><b>False</b>: does not bring the database online.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For SQL Server 2008 R2, this value is always True.</description></item>
        /// <item><description>If <b>IsOnlineDB</b> is set to <b>True</b>, <b>BackupMode</b> must be set to <b>FULL</b>.</description></item>
        /// <item><description>If <b>IsOnlineDB</b> is set to <b>False</b>, <b>BackupMode</b> must be set to <b>UPDF</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("IsOnlineDB")]
        [Validation(Required=false)]
        public string IsOnlineDB { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain the database- and table-level Change Data Capture (CDC) switches and change table data. This parameter takes effect only when IsOnlineDB is set to True. Regardless of the value of this parameter, CDC jobs are not rebuilt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("KeepCDC")]
        [Validation(Required=false)]
        public bool? KeepCDC { get; set; }

        /// <summary>
        /// <para>The ID of the migration task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>BackupMode</b> is set to <b>FULL</b>, leave this parameter empty. This ensures compatibility with SQL Server 2008 R2.</description></item>
        /// <item><description>If <b>BackupMode</b> is set to <b>UPDF</b>, set this parameter to the ID of the corresponding FULL task. You can call the DescribeMigrateTasks operation to query the ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MigrateTaskId")]
        [Validation(Required=false)]
        public string MigrateTaskId { get; set; }

        /// <summary>
        /// <para>The shared URL of the backup file in OSS. The URL must be encoded. If multiple URLs exist, separate them with vertical bars (|) and then encode the string before passing it as the parameter value.</para>
        /// <remarks>
        /// <para>This parameter is required for SQL Server 2008 R2.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>check_cdn_oss.sh www.******.mobi</para>
        /// </summary>
        [NameInMap("OSSUrls")]
        [Validation(Required=false)]
        public string OSSUrls { get; set; }

        /// <summary>
        /// <para>The components of the OSS file. The value consists of the following three parts separated by colons (:):</para>
        /// <list type="bullet">
        /// <item><description><b>OSS endpoint</b>: oss-ap-southeast-1.aliyuncs.com.</description></item>
        /// <item><description><b>OSS bucket name</b>: rdsmssqlsingapore.</description></item>
        /// <item><description><b>Backup file name in OSS</b>: autotest_2008R2_TestMigration_FULL.bak.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required for SQL Server versions later than 2008 R2.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss-ap-southeast-1.aliyuncs.com:rdsmssqlsingapore:autotest_2008R2_TestMigration_FULL.bak</para>
        /// </summary>
        [NameInMap("OssObjectPositions")]
        [Validation(Required=false)]
        public string OssObjectPositions { get; set; }

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
