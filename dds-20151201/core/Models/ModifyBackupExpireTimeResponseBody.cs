// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyBackupExpireTimeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-03-29T03:47:12Z</para>
        /// </summary>
        [NameInMap("BackupExpireTime")]
        [Validation(Required=false)]
        public string BackupExpireTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>260032xxxx</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A0181AC4-XXXX-XXXX-87CA-100C70B86729</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
