// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GenerateFileUploadURLResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateFileUploadURLResponseBodyData Data { get; set; }
        public class GenerateFileUploadURLResponseBodyData : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }
            [NameInMap("OssAccessKeyId")]
            [Validation(Required=false)]
            public string OssAccessKeyId { get; set; }
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }
            [NameInMap("ObjectStorage")]
            [Validation(Required=false)]
            public string ObjectStorage { get; set; }
        };

    }

}
