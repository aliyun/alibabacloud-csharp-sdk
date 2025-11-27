// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyBackupSetExpireTimeRequest : TeaModel {
        /// <summary>
        /// <para>The backup set ID. You can call the DescribeBackups operation to query the backup set ID. The backup set must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The Engine parameter is SQLServer</description></item>
        /// <item><description>The BackupMode parameter is set to Manual.</description></item>
        /// <item><description>The BackupMethod parameter is set to Physical.</description></item>
        /// <item><description>The BackupType parameter is set to FullBackup.</description></item>
        /// <item><description>The BackupStatus parameter is set to Success.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b-n8tpg24c6i0v****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public long? BackupId { get; set; }

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
        /// <para>The point in time to which you want to extend the expiration time of the backup set. Specify the time in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.</para>
        /// <para>The time cannot be earlier than the current expiration time. You can call the DescribeBackups operation to view the current expiration time of the backup set.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-17T12:10:23Z</para>
        /// </summary>
        [NameInMap("ExpectExpireTime")]
        [Validation(Required=false)]
        public string ExpectExpireTime { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
