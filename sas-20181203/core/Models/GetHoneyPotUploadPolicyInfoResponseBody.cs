// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneyPotUploadPolicyInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHoneyPotUploadPolicyInfoResponseBodyData Data { get; set; }
        public class GetHoneyPotUploadPolicyInfoResponseBodyData : TeaModel {
            [NameInMap("Accessid")]
            [Validation(Required=false)]
            public string Accessid { get; set; }

            [NameInMap("Expire")]
            [Validation(Required=false)]
            public string Expire { get; set; }

            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
