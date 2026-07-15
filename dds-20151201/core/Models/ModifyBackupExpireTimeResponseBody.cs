// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyBackupExpireTimeResponseBody : TeaModel {
        /// <summary>
        /// <para>The time-to-live (TTL) of the backup. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format and is in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para><em>9999-01-01</em>T<em>00:00:00</em>&#x5A;<em>&#x20;indicates that the backup is retained permanently.</em></para>
        /// <para>**</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>260032xxxx</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A0181AC4-XXXX-XXXX-87CA-100C70B86729</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
