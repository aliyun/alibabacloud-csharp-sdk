// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DecryptKMSDataKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the decryption result.</para>
        /// </summary>
        [NameInMap("DataKey")]
        [Validation(Required=false)]
        public DecryptKMSDataKeyResponseBodyDataKey DataKey { get; set; }
        public class DecryptKMSDataKeyResponseBodyDataKey : TeaModel {
            /// <summary>
            /// <para>The ID of the customer master key (CMK) that was used to decrypt the ciphertext.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202b9877-5a25-46e3-a763-e20791b5****</para>
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            /// <summary>
            /// <para>The plaintext that is generated after decryption.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tRYXuCwgja12xxO1N/gZERDDCLw9doZEQiPDk/Bv****</para>
            /// </summary>
            [NameInMap("Plaintext")]
            [Validation(Required=false)]
            public string Plaintext { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
