// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class AsymmetricVerifyRequest : TeaModel {
        /// <summary>
        /// The signature algorithm.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// The digest that is generated for the original message by using a hash algorithm. The hash algorithm is specified by the **Algorithm** parameter.
        /// 
        /// >  The value is encoded in Base64.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// The ID of the CMK. The ID must be globally unique.
        /// 
        /// >  You can also set this parameter to an alias that is bound to the CMK. For more information, see [Overview of aliases](https://help.aliyun.com/document_detail/68522.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The version ID of the CMK. The ID must be globally unique.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

        /// <summary>
        /// The signature value to be verified.
        /// 
        /// >  The value is encoded in Base64.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
