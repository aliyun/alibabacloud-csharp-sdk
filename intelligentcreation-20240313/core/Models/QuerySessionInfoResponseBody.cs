// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class QuerySessionInfoResponseBody : TeaModel {
        [NameInMap("queryResourceInfoList")]
        [Validation(Required=false)]
        public List<QuerySessionInfoResponseBodyQueryResourceInfoList> QueryResourceInfoList { get; set; }
        public class QuerySessionInfoResponseBodyQueryResourceInfoList : TeaModel {
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
