// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateEngineNamespaceResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateEngineNamespaceResponseBodyData Data { get; set; }
        public class CreateEngineNamespaceResponseBodyData : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }
            [NameInMap("NamespaceShowName")]
            [Validation(Required=false)]
            public string NamespaceShowName { get; set; }
            [NameInMap("Quota")]
            [Validation(Required=false)]
            public int? Quota { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("NamespaceDesc")]
            [Validation(Required=false)]
            public string NamespaceDesc { get; set; }
            [NameInMap("ConfigCount")]
            [Validation(Required=false)]
            public int? ConfigCount { get; set; }
            [NameInMap("ServiceCount")]
            [Validation(Required=false)]
            public int? ServiceCount { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
