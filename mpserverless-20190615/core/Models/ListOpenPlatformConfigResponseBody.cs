// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class ListOpenPlatformConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecretList")]
        [Validation(Required=false)]
        public List<ListOpenPlatformConfigResponseBodySecretList> SecretList { get; set; }
        public class ListOpenPlatformConfigResponseBodySecretList : TeaModel {
            [NameInMap("SpaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public string AppSecret { get; set; }

            [NameInMap("PublicCert")]
            [Validation(Required=false)]
            public string PublicCert { get; set; }

            [NameInMap("AppCert")]
            [Validation(Required=false)]
            public string AppCert { get; set; }

            [NameInMap("PrivateKey")]
            [Validation(Required=false)]
            public string PrivateKey { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("RootCert")]
            [Validation(Required=false)]
            public string RootCert { get; set; }

            [NameInMap("PublicKey")]
            [Validation(Required=false)]
            public string PublicKey { get; set; }

            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("SignMode")]
            [Validation(Required=false)]
            public string SignMode { get; set; }

        }

    }

}
