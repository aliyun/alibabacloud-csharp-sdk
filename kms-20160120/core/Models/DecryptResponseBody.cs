// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DecryptResponseBody : TeaModel {
        [NameInMap("CiphertextForRecipient")]
        [Validation(Required=false)]
        public string CiphertextForRecipient { get; set; }

        /// <summary>
        /// <para>The ID of the master key that is used to decrypt the ciphertext.<br> The globally unique identifier of the master key.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>202b9877-5a25-46e3-a763-e20791b5****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The ID of the key version that is used to decrypt the ciphertext. This key version is a version of the master key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ab1a983-7072-4bbc-a582-584b5bd8****</para>
        /// </summary>
        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

        /// <summary>
        /// <para>The decrypted plaintext.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tRYXuCwgja12xxO1N/gZERDDCLw9doZEQiPDk/Bv****</para>
        /// </summary>
        [NameInMap("Plaintext")]
        [Validation(Required=false)]
        public string Plaintext { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>207596a2-36d3-4840-b1bd-f87044699bd7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
