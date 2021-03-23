// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class GetOssUploadMetaResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OssUploadMeta")]
        [Validation(Required=false)]
        public GetOssUploadMetaResponseBodyOssUploadMeta OssUploadMeta { get; set; }
        public class GetOssUploadMetaResponseBodyOssUploadMeta : TeaModel {
            [NameInMap("ObjectKey")]
            [Validation(Required=false)]
            public string ObjectKey { get; set; }
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }
        };

    }

}
