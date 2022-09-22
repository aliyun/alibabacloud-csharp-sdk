// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class CreateUploadPolicyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateUploadPolicyResponseBodyData Data { get; set; }
        public class CreateUploadPolicyResponseBodyData : TeaModel {
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            [NameInMap("Callback")]
            [Validation(Required=false)]
            public string Callback { get; set; }

            [NameInMap("Dir")]
            [Validation(Required=false)]
            public string Dir { get; set; }

            [NameInMap("Expire")]
            [Validation(Required=false)]
            public string Expire { get; set; }

            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
