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
        /// <item><description><b>FULL</b>: performs a restore operation by using a full backup file. This value is applicable to first-time migrations or full data recovery scenarios.</description></item>
        /// <item><description><b>UPDF</b>: restores incremental data by using an incremental backup file or log file. This value is applicable to incremental synchronization scenarios where a full backup already exists.</description></item>
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
        /// <para>The consistency check method after the database is brought online. This parameter takes effect only when IsOnlineDB is set to True. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SyncExecuteDBCheck</b>: performs a synchronous database check. This value is applicable to scenarios that require high data consistency.</description></item>
        /// <item><description><b>AsyncExecuteDBCheck</b>: performs an asynchronous database check. This value provides higher performance but may delay the detection of potential issues.</description></item>
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
        /// <para>Specifies whether to bring the restored database online so that users can access it. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: Brings the database online.</description></item>
        /// <item><description><b>False</b>: Does not bring the database online.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For SQL Server 2008 R2, this value is always True.</description></item>
        /// <item><description>When <b>IsOnlineDB</b> is set to <b>True</b>, <b>BackupMode</b> must be set to <b>FULL</b>.</description></item>
        /// <item><description>When <b>IsOnlineDB</b> is set to <b>False</b>, <b>BackupMode</b> must be set to <b>UPDF</b>.</description></item>
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
        /// <para>The migration task ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When <b>BackupMode</b> is set to <b>FULL</b>, leave this parameter empty (compatible with SQL Server 2008 R2).</description></item>
        /// <item><description>When <b>BackupMode</b> is set to <b>UPDF</b>, set this parameter to the ID of the corresponding FULL task. You can call DescribeMigrateTasks to query the task ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MigrateTaskId")]
        [Validation(Required=false)]
        public string MigrateTaskId { get; set; }

        /// <summary>
        /// <para>The shared URL of the backup file on OSS (URL-encoded). If multiple URLs exist, separate them with vertical bars (|) before encoding, and then pass the encoded value.</para>
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
        /// <para>The OSS file information, which consists of the following three parts separated by colons (:):</para>
        /// <list type="bullet">
        /// <item><description><b>OSS endpoint</b>: oss-ap-southeast-1.aliyuncs.com.</description></item>
        /// <item><description><b>OSS bucket name</b>: rdsmssqlsingapore.</description></item>
        /// <item><description><b>Backup file name on OSS</b>: autotest_2008R2_TestMigration_FULL.bak.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required for SQL Server versions later than SQL Server 2008 R2.</para>
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
