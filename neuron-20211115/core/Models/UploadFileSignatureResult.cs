// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class UploadFileSignatureResult : TeaModel {
        [NameInMap("expiredTime")]
        [Validation(Required=false)]
        public long? ExpiredTime { get; set; }

        [NameInMap("fileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        [NameInMap("host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("keyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        [NameInMap("thumbUrl")]
        [Validation(Required=false)]
        public string ThumbUrl { get; set; }

    }

}
