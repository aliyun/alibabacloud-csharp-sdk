// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GenerateFileUploadURLResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GenerateFileUploadURLResponseData Data { get; set; }
        public class GenerateFileUploadURLResponseData : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=true)]
            public string Key { get; set; }
            [NameInMap("Host")]
            [Validation(Required=true)]
            public string Host { get; set; }
            [NameInMap("Policy")]
            [Validation(Required=true)]
            public string Policy { get; set; }
            [NameInMap("OssAccessKeyId")]
            [Validation(Required=true)]
            public string OssAccessKeyId { get; set; }
            [NameInMap("Signature")]
            [Validation(Required=true)]
            public string Signature { get; set; }
            [NameInMap("ObjectStorage")]
            [Validation(Required=true)]
            public string ObjectStorage { get; set; }
        };

    }

}
