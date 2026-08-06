// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class VerifyCatalogKmsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the KMS customer master key (CMK) to be validated. The server uses this key to perform an SSE-KMS write probe.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-1234567890abcdef</para>
        /// </summary>
        [NameInMap("kmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

    }

}
