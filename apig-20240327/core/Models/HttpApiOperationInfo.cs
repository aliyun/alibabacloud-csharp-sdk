// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiOperationInfo : TeaModel {
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        [NameInMap("mock")]
        [Validation(Required=false)]
        public HttpApiMockContract Mock { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("operationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("request")]
        [Validation(Required=false)]
        public HttpApiRequestContract Request { get; set; }

        [NameInMap("response")]
        [Validation(Required=false)]
        public HttpApiResponseContract Response { get; set; }

    }

}
