// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class GenerateFunctionFileUploadMetaResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UploadMeta")]
        [Validation(Required=false)]
        public GenerateFunctionFileUploadMetaResponseBodyUploadMeta UploadMeta { get; set; }
        public class GenerateFunctionFileUploadMetaResponseBodyUploadMeta : TeaModel {
            [NameInMap("PostObjectPolicy")]
            [Validation(Required=false)]
            public GenerateFunctionFileUploadMetaResponseBodyUploadMetaPostObjectPolicy PostObjectPolicy { get; set; }
            public class GenerateFunctionFileUploadMetaResponseBodyUploadMetaPostObjectPolicy : TeaModel {
                [NameInMap("Signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                [NameInMap("Expire")]
                [Validation(Required=false)]
                public string Expire { get; set; }

                [NameInMap("AccessId")]
                [Validation(Required=false)]
                public string AccessId { get; set; }

            }
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }
            [NameInMap("ObjectKey")]
            [Validation(Required=false)]
            public string ObjectKey { get; set; }
        };

    }

}
