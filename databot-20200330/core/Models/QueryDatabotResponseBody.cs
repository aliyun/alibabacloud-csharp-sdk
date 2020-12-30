// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Databot20200330.Models
{
    public class QueryDatabotResponseBody : TeaModel {
        [NameInMap("CostTime")]
        [Validation(Required=false)]
        public long? CostTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

    }

}
