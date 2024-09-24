// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateMigrateTaskRequest : TeaModel {
        /// <summary>
        /// <para>The type of the migration task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FULL</b>: The migration task migrates full backup files.</description></item>
        /// <item><description><b>UPDF</b>: The migration task migrates incremental or log backup files.</description></item>
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
        /// <para>The consistency check method for the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SyncExecuteDBCheck</b>: synchronous database check</description></item>
        /// <item><description><b>AsyncExecuteDBCheck</b>: asynchronous database check</description></item>
        /// </list>
        /// <para>Default value: <b>AsyncExecuteDBCheck</b> (compatible with SQL Server 2008 R2)</para>
        /// <remarks>
        /// <para> This parameter is valid when <b>IsOnlineDB</b> is set to <b>True</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AsyncExecuteDBCheck</para>
        /// </summary>
        [NameInMap("CheckDBMode")]
        [Validation(Required=false)]
        public string CheckDBMode { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk******</para>
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
        /// <para>Specifies whether to make the restored database data available for user access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b></description></item>
        /// <item><description><b>False</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> Set the value to <b>True</b> for instances that run SQL Server 2008 R2.</para>
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
        /// <para>The migration task ID.</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>BackupMode</b> to <b>FULL</b>, the value of this parameter is empty. The full backup mode is compatible with instance that runs SQL Server 2008 R2.</description></item>
        /// <item><description>If you set <b>BackupMode</b> to <b>UPDF</b>, the value of this parameter is the ID of the required full migration task.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set <b>IsOnlineDB</b> to <b>True</b>, the value of <b>BackupMode</b> must be <b>FULL</b>.</description></item>
        /// <item><description>If you set <b>IsOnlineDB</b> to <b>False</b>, the value of <b>BackupMode</b> must be <b>UPDF</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MigrateTaskId")]
        [Validation(Required=false)]
        public string MigrateTaskId { get; set; }

        /// <summary>
        /// <para>The shared URL of the backup file in the OSS bucket. The URL must be encoded.</para>
        /// <para>If you specify multiple URLs, separate them with vertical bars (|) and then encode them.</para>
        /// <remarks>
        /// <para> This parameter is required for instances that run SQL Server 2008 R2.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>check_cdn_oss.sh <a href="http://www.xxxxxx.mobi">www.xxxxxx.mobi</a></para>
        /// </summary>
        [NameInMap("OSSUrls")]
        [Validation(Required=false)]
        public string OSSUrls { get; set; }

        /// <summary>
        /// <para>The information about the backup file in the OSS bucket. The values consist of three parts that are separated by colons (:):</para>
        /// <list type="bullet">
        /// <item><description>OSS endpoint: oss-ap-southeast-1.aliyuncs.com.</description></item>
        /// <item><description>Name of the OSS bucket: rdsmssqlsingapore.</description></item>
        /// <item><description>Key of the backup file in the OSS bucket: autotest_2008R2_TestMigration_FULL.bak.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is optional for instances that run SQL Server 2008 R2.</description></item>
        /// <item><description>This parameter is required for instances that run a major engine version later than SQL Server 2008 R2.</description></item>
        /// </list>
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
