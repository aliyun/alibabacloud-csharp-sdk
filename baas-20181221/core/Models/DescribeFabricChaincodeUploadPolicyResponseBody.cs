// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeFabricChaincodeUploadPolicyResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeFabricChaincodeUploadPolicyResponseBodyResult Result { get; set; }
        public class DescribeFabricChaincodeUploadPolicyResponseBodyResult : TeaModel {
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }
            [NameInMap("Dir")]
            [Validation(Required=false)]
            public string Dir { get; set; }
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }
            [NameInMap("Expire")]
            [Validation(Required=false)]
            public int? Expire { get; set; }
        };

    }

}
