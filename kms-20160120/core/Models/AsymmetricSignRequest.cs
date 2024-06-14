// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class AsymmetricSignRequest : TeaModel {
        /// <summary>
        /// The version ID of the CMK. The ID must be globally unique.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// The signature algorithm.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **AsymmetricSign**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The ID of the customer master key (CMK). The ID must be globally unique.
        /// 
        /// >  You can also set this parameter to an alias that is bound to the CMK. For more information, see [Alias overview](https://help.aliyun.com/document_detail/68522.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

    }

}
