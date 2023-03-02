// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Moguan_sdk20210415.Models
{
    public class RegisterDeviceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RegisterDeviceResponseBodyData Data { get; set; }
        public class RegisterDeviceResponseBodyData : TeaModel {
            [NameInMap("License")]
            [Validation(Required=false)]
            public string License { get; set; }

            [NameInMap("PublicKey")]
            [Validation(Required=false)]
            public string PublicKey { get; set; }

            [NameInMap("Rid")]
            [Validation(Required=false)]
            public string Rid { get; set; }

            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
