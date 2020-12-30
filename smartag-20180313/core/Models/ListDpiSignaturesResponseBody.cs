// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListDpiSignaturesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DpiSignature")]
        [Validation(Required=false)]
        public List<ListDpiSignaturesResponseBodyDpiSignature> DpiSignature { get; set; }
        public class ListDpiSignaturesResponseBodyDpiSignature : TeaModel {
            [NameInMap("DpiSignatureId")]
            [Validation(Required=false)]
            public string DpiSignatureId { get; set; }

            [NameInMap("MinSignatureDbVersion")]
            [Validation(Required=false)]
            public string MinSignatureDbVersion { get; set; }

            [NameInMap("DpiGroupId")]
            [Validation(Required=false)]
            public string DpiGroupId { get; set; }

            [NameInMap("MinEngineVersion")]
            [Validation(Required=false)]
            public string MinEngineVersion { get; set; }

            [NameInMap("DpiSignatureName")]
            [Validation(Required=false)]
            public string DpiSignatureName { get; set; }

        }

    }

}
