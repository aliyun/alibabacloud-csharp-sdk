// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListUserKeysResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListUserKeysResponseBodyResult> Result { get; set; }
        public class ListUserKeysResponseBodyResult : TeaModel {
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("expireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("fingerPrint")]
            [Validation(Required=false)]
            public string FingerPrint { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("keyScope")]
            [Validation(Required=false)]
            public string KeyScope { get; set; }

            [NameInMap("lastUsedTime")]
            [Validation(Required=false)]
            public string LastUsedTime { get; set; }

            [NameInMap("publicKey")]
            [Validation(Required=false)]
            public string PublicKey { get; set; }

            [NameInMap("tittle")]
            [Validation(Required=false)]
            public string Tittle { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
