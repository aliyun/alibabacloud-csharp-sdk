// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetPhoneEncryptionPublicKeyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPhoneEncryptionPublicKeyResponseBodyData Data { get; set; }
        public class GetPhoneEncryptionPublicKeyResponseBodyData : TeaModel {
            /// <summary>
            /// The public key.
            /// </summary>
            [NameInMap("EncryptionPublicKey")]
            [Validation(Required=false)]
            public string EncryptionPublicKey { get; set; }

            /// <summary>
            /// The validity state of the public key. Valid values:
            /// 
            /// *   MISMATCH: The public key is invalid.
            /// *   VALID: The public key is valid.
            /// </summary>
            [NameInMap("EncryptionPublicKeyStatus")]
            [Validation(Required=false)]
            public string EncryptionPublicKeyStatus { get; set; }

            /// <summary>
            /// The phone number.
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
