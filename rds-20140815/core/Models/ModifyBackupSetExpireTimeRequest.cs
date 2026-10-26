// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyBackupSetExpireTimeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup set. You can call the DescribeBackups operation to query the ID. The supported backup set must meet the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>Engine (database type): SQLServer</description></item>
        /// <item><description>BackupMode (backup mode): Manual (manual backup)</description></item>
        /// <item><description>BackupMethod (backup method): Physical (physical backup)</description></item>
        /// <item><description>BackupType (backup type): FullBackup (full backup)</description></item>
        /// <item><description>BackupStatus (backup set status): Success (backup completed)</description></item>
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
        /// <para>Instance ID of the instance. You can call the DescribeDBInstances operation to query instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-7xv8f2zcia0e4****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The new expiration time of the backup set. Specify the time in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.</para>
        /// <para>The specified time cannot be earlier than the current expiration time. You can call the DescribeBackups operation to query the current expiration time (ExpectExpireTime).</para>
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
