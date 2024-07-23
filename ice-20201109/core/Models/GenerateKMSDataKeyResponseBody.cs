// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GenerateKMSDataKeyResponseBody : TeaModel {
        [NameInMap("DataKey")]
        [Validation(Required=false)]
        public GenerateKMSDataKeyResponseBodyDataKey DataKey { get; set; }
        public class GenerateKMSDataKeyResponseBodyDataKey : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ODZhOWVmZDktM2QxNi00ODk0LWJkNGYtMWZjNDNmM2YyYWJmS7FmDBBQ0BkKsQrtRnidtPwirmDcS0ZuJCU41xxAAWk4Z8qsADfbV0b+i6kQmlvj79dJdGOvtX69Uycs901qOjop4bTS****</para>
            /// </summary>
            [NameInMap("CiphertextBlob")]
            [Validation(Required=false)]
            public string CiphertextBlob { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7906979c-8e06-46a2-be2d-68e3ccbc****</para>
            /// </summary>
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>QmFzZTY0IGVuY29kZWQgcGxhaW50****</para>
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
