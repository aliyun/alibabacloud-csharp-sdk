// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyBackupSetExpireTimeRequest : TeaModel {
        /// <summary>
        /// <para>The backup set ID. You can invoke DescribeBackups to query the backup set ID. The backup set must meet the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>Engine (database type): SQLServer</description></item>
        /// <item><description>BackupMode (backup pattern): Manual (manual backup)</description></item>
        /// <item><description>BackupMethod: Physical (physical backup)</description></item>
        /// <item><description>BackupType: FullBackup (full backup)</description></item>
        /// <item><description>BackupStatus: Success (backup completed)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>262186****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public long? BackupId { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-7xv8f2zcia0e4****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The time to which you want to extend the expiration time of the backup set. Specify the time in the yyyy-MM-ddTHH:mmZ format (UTC).</para>
        /// <para>The specified time cannot be earlier than the current expiration time. You can call DescribeBackups to query the current expiration time (ExpectExpireTime).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-07-15T12:10:23Z</para>
        /// </summary>
        [NameInMap("ExpectExpireTime")]
        [Validation(Required=false)]
        public string ExpectExpireTime { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
