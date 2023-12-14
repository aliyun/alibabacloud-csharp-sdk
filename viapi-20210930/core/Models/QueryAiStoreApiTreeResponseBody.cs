// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi20210930.Models
{
    public class QueryAiStoreApiTreeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<AiStoreApiNode> Data { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
