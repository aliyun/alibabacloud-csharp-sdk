// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DecryptResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the customer master key (CMK) that is used to decrypt the ciphertext.</para>
        /// <para>It is the GUID of the CMK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202b9877-5a25-46e3-a763-e20791b5****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The ID of the CMK version that is used to decrypt the ciphertext.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ab1a983-7072-4bbc-a582-584b5bd8****</para>
        /// </summary>
        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

        /// <summary>
        /// <para>The plaintext that is generated after decryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tRYXuCwgja12xxO1N/gZERDDCLw9doZEQiPDk/Bv****</para>
        /// </summary>
        [NameInMap("Plaintext")]
        [Validation(Required=false)]
        public string Plaintext { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>207596a2-36d3-4840-b1bd-f87044699bd7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
