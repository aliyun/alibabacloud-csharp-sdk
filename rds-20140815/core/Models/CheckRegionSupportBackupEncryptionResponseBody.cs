// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CheckRegionSupportBackupEncryptionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>081FAAD5-9E56-5BE7-A495-*******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportBackupEncryption")]
        [Validation(Required=false)]
        public bool? SupportBackupEncryption { get; set; }

    }

}
