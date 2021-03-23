// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class GenerateOssPostPolicyResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OssPostPolicy")]
        [Validation(Required=false)]
        public GenerateOssPostPolicyResponseBodyOssPostPolicy OssPostPolicy { get; set; }
        public class GenerateOssPostPolicyResponseBodyOssPostPolicy : TeaModel {
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }
            [NameInMap("Expire")]
            [Validation(Required=false)]
            public string Expire { get; set; }
        };

    }

}
