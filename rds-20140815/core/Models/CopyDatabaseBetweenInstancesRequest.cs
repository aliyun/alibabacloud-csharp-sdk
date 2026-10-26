// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CopyDatabaseBetweenInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup set of the source instance. When you copy a database based on a backup set, you can call the DescribeBackups operation to query the backup set ID.</para>
        /// <remarks>
        /// <para>When you call this operation, you must specify either <b>BackupId</b> or <b>RestoreTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>259321****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The ID of the source instance. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp172446ys9cf****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The names of the databases to be copied. Specify the names in the following format: <c>{&quot;Source database name&quot;:&quot;Target database name&quot;}</c>. Separate multiple databases with commas (,). Examples:</para>
        /// <list type="bullet">
        /// <item><description>Copy a single database: <c>{&quot;zhttest&quot;:&quot;zhttest&quot;}</c></description></item>
        /// <item><description>Copy multiple databases: <c>{&quot;zhttest01&quot;:&quot;zhttest01&quot;,&quot;zhttest02&quot;:&quot;zhttest02&quot;}</c></description></item>
        /// </list>
        /// <remarks>
        /// <para>The name of the database in the target instance can be different from that in the source instance. However, before copying, make sure that the target instance does not contain a database with the same name.</para>
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
        /// <para>The point in time to which you want to restore the database. You can select any point in time within the backup retention period. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>When you call this operation, you must specify either <b>BackupId</b> or <b>RestoreTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-08T17:41:14Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the replication of users and permissions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>YES</b>: Enables the replication of users and permissions. If the target instance contains a user with the same name as a user in the source instance, the permissions of the source user are added to the target user.</description></item>
        /// <item><description><b>NO</b>: Disables the replication of users and permissions. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NO</para>
        /// </summary>
        [NameInMap("SyncUserPrivilege")]
        [Validation(Required=false)]
        public string SyncUserPrivilege { get; set; }

        /// <summary>
        /// <para>The ID of the target instance. You can call the DescribeDBInstances operation to query the instance ID.</para>
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
