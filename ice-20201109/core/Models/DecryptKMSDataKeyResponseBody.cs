// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DecryptKMSDataKeyResponseBody : TeaModel {
        [NameInMap("DataKey")]
        [Validation(Required=false)]
        public DecryptKMSDataKeyResponseBodyDataKey DataKey { get; set; }
        public class DecryptKMSDataKeyResponseBodyDataKey : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>202b9877-5a25-46e3-a763-e20791b5****</para>
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tRYXuCwgja12xxO1N/gZERDDCLw9doZEQiPDk/Bv****</para>
            /// </summary>
            [NameInMap("Plaintext")]
            [Validation(Required=false)]
            public string Plaintext { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
