// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class VerifyCatalogKmsResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("hint")]
        [Validation(Required=false)]
        public string Hint { get; set; }

        [NameInMap("kmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        [NameInMap("serverSideEncryption")]
        [Validation(Required=false)]
        public string ServerSideEncryption { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
