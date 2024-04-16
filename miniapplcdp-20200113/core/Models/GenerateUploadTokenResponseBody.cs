// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class GenerateUploadTokenResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateUploadTokenResponseBodyData Data { get; set; }
        public class GenerateUploadTokenResponseBodyData : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("OssAccessKeyId")]
            [Validation(Required=false)]
            public string OssAccessKeyId { get; set; }

            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            [NameInMap("ServerURL")]
            [Validation(Required=false)]
            public string ServerURL { get; set; }

            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            [NameInMap("X-Amz-Algorithm")]
            [Validation(Required=false)]
            public string XAmzAlgorithm { get; set; }

            [NameInMap("X-Amz-Credential")]
            [Validation(Required=false)]
            public string XAmzCredential { get; set; }

            [NameInMap("X-Amz-Date")]
            [Validation(Required=false)]
            public string XAmzDate { get; set; }

            [NameInMap("X-Amz-Signature")]
            [Validation(Required=false)]
            public string XAmzSignature { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
