// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetBatchMediaProducingJobRequest : TeaModel {
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        [NameInMap("SignatureMehtod")]
        [Validation(Required=false)]
        public string SignatureMehtod { get; set; }

        [NameInMap("SignatureNonce")]
        [Validation(Required=false)]
        public string SignatureNonce { get; set; }

        [NameInMap("SignatureType")]
        [Validation(Required=false)]
        public string SignatureType { get; set; }

        [NameInMap("SignatureVersion")]
        [Validation(Required=false)]
        public string SignatureVersion { get; set; }

    }

}
