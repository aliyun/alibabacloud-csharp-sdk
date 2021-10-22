// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class QueryInterconnectionCidMappingResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryInterconnectionCidMappingResponseBodyResult Result { get; set; }
        public class QueryInterconnectionCidMappingResponseBodyResult : TeaModel {
            [NameInMap("DstCid")]
            [Validation(Required=false)]
            public string DstCid { get; set; }
        };

    }

}
