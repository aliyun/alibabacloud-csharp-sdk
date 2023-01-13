// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GenerateOTAUploadURLResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GenerateOTAUploadURLResponseData Data { get; set; }
        public class GenerateOTAUploadURLResponseData : TeaModel {
            [NameInMap("FirmwareUrl")]
            [Validation(Required=true)]
            public string FirmwareUrl { get; set; }

            [NameInMap("Host")]
            [Validation(Required=true)]
            public string Host { get; set; }

            [NameInMap("Key")]
            [Validation(Required=true)]
            public string Key { get; set; }

            [NameInMap("OSSAccessKeyId")]
            [Validation(Required=true)]
            public string OSSAccessKeyId { get; set; }

            [NameInMap("ObjectStorage")]
            [Validation(Required=true)]
            public string ObjectStorage { get; set; }

            [NameInMap("Policy")]
            [Validation(Required=true)]
            public string Policy { get; set; }

            [NameInMap("Signature")]
            [Validation(Required=true)]
            public string Signature { get; set; }

            [NameInMap("UtcCreate")]
            [Validation(Required=true)]
            public string UtcCreate { get; set; }

        }

    }

}
