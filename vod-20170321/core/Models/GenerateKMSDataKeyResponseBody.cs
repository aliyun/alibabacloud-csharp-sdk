// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GenerateKMSDataKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ciphertext of the encrypted data key. This is used as CipherText when you create a transcoding job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ODZhOWVmZDktM2QxNi00ODk0LWJkNGYtMWZjNDNmM2YyYWJmS7FmDBBQ0BkKsQrtRnidtPwirmDcS0ZuJCU41xxAAWk4Z8qsADfbV0b+i6kQmlvj79dJdGOvtX69Uycs901qOjop4bTS****</para>
        /// </summary>
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        /// <summary>
        /// <para>The ID of the customer master key (CMK). The ID must be globally unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7906979c-8e06-46a2-be2d-68e3ccbc****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The Base64-encoded plaintext of the data key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QmFzZTY0IGVuY29kZWQgcGxhaW50****</para>
        /// </summary>
        [NameInMap("Plaintext")]
        [Validation(Required=false)]
        public string Plaintext { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A*****F6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
