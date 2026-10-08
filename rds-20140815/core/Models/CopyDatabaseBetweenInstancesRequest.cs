// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CopyDatabaseBetweenInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The backup set ID of the source instance. To copy a database from a backup set, call DescribeBackups to query the backup set ID.</para>
        /// <remarks>
        /// <para>You must specify either <b>BackupId</b> or <b>RestoreTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>259321****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The source instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp172446ys9cf****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The list of database names to be copied. Format: <c>{&quot;Source database name&quot;:&quot;Destination database name&quot;}</c>. Separate multiple databases with commas (,). Examples:</para>
        /// <list type="bullet">
        /// <item><description>Copy a single database: <c>{&quot;zhttest&quot;:&quot;zhttest&quot;}</c></description></item>
        /// <item><description>Copy multiple databases: <c>{&quot;zhttest01&quot;:&quot;zhttest01&quot;,&quot;zhttest02&quot;:&quot;zhttest02&quot;}</c></description></item>
        /// </list>
        /// <remarks>
        /// <para>The database name on the target instance can be different from that on the source instance. However, make sure that the target instance does not contain a database with the same name before copying.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;zhttest&quot;:&quot;zhttest&quot;}</para>
        /// </summary>
        [NameInMap("DbNames")]
        [Validation(Required=false)]
        public string DbNames { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The point in time to which you want to copy the database. You can specify any point in time within the backup retention period. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// <remarks>
        /// <para>You must specify either <b>BackupId</b> or <b>RestoreTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-08T17:41:14Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to copy users and permissions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>YES</b>: Users and permissions are copied. If the target instance contains a user with the same name, the permissions of the user on the source instance are merged with those of the user on the target instance.</description></item>
        /// <item><description><b>NO</b> (default): Users and permissions are not copied.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NO</para>
        /// </summary>
        [NameInMap("SyncUserPrivilege")]
        [Validation(Required=false)]
        public string SyncUserPrivilege { get; set; }

        /// <summary>
        /// <para>The target instance ID. You can invoke DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1m71wvzfiq7****</para>
        /// </summary>
        [NameInMap("TargetDBInstanceId")]
        [Validation(Required=false)]
        public string TargetDBInstanceId { get; set; }

    }

}
