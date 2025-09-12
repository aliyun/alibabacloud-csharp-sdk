// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20220913.Models
{
    public class EncryptInvokeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public EncryptInvokeResponseBodyData Data { get; set; }
        public class EncryptInvokeResponseBodyData : TeaModel {
            [NameInMap("encryptData")]
            [Validation(Required=false)]
            public string EncryptData { get; set; }

            [NameInMap("encryptKey")]
            [Validation(Required=false)]
            public string EncryptKey { get; set; }

            [NameInMap("sign")]
            [Validation(Required=false)]
            public string Sign { get; set; }

        }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
