// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ReEncryptShrinkRequest : TeaModel {
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        [NameInMap("DestinationEncryptionContext")]
        [Validation(Required=false)]
        public string DestinationEncryptionContextShrink { get; set; }

        [NameInMap("DestinationKeyId")]
        [Validation(Required=false)]
        public string DestinationKeyId { get; set; }

        [NameInMap("SourceEncryptionAlgorithm")]
        [Validation(Required=false)]
        public string SourceEncryptionAlgorithm { get; set; }

        [NameInMap("SourceEncryptionContext")]
        [Validation(Required=false)]
        public string SourceEncryptionContextShrink { get; set; }

        [NameInMap("SourceKeyId")]
        [Validation(Required=false)]
        public string SourceKeyId { get; set; }

        [NameInMap("SourceKeyVersionId")]
        [Validation(Required=false)]
        public string SourceKeyVersionId { get; set; }

    }

}
