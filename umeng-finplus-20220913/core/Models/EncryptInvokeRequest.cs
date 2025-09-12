// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20220913.Models
{
    public class EncryptInvokeRequest : TeaModel {
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public long? ClientId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("encryptKey")]
        [Validation(Required=false)]
        public string EncryptKey { get; set; }

        [NameInMap("methodName")]
        [Validation(Required=false)]
        public string MethodName { get; set; }

        [NameInMap("sign")]
        [Validation(Required=false)]
        public string Sign { get; set; }

    }

}
