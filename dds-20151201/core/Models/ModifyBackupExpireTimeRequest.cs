// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyBackupExpireTimeRequest : TeaModel {
        /// <summary>
        /// <para>The time-to-live (TTL) of the backup. The time must be in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format and in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para><em>9999-01-01</em>T<em>00:00:00</em>&#x5A;<em>&#x20;indicates that the backup is retained permanently.</em></para>
        /// <para><em>- You can only extend the retention period. You cannot shorten it.- If you do not set the time to <em>9999-01-01</em>T</em>00:00:00<em>Z, the new expiration time must be within 730 days after the end time of the backup set.</em></para>
        /// </description></item>
        /// </list>
        /// <para>**</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-29T03:47:12Z</para>
        /// </summary>
        [NameInMap("BackupExpireTime")]
        [Validation(Required=false)]
        public string BackupExpireTime { get; set; }

        /// <summary>
        /// <para>The backup ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>260032xxxx</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp16cb162771****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

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
