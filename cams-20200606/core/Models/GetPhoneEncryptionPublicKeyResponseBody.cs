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

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPhoneEncryptionPublicKeyResponseBodyData Data { get; set; }
        public class GetPhoneEncryptionPublicKeyResponseBodyData : TeaModel {
            [NameInMap("EncryptionPublicKey")]
            [Validation(Required=false)]
            public string EncryptionPublicKey { get; set; }

            [NameInMap("EncryptionPublicKeyStatus")]
            [Validation(Required=false)]
            public string EncryptionPublicKeyStatus { get; set; }

            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
