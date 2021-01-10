// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryBatchRegistAnonymousTbAccountResultResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("FailIds")]
        [Validation(Required=false)]
        public QueryBatchRegistAnonymousTbAccountResultResponseBodyFailIds FailIds { get; set; }
        public class QueryBatchRegistAnonymousTbAccountResultResponseBodyFailIds : TeaModel {
            [NameInMap("FailId")]
            [Validation(Required=false)]
            public List<string> FailId { get; set; }
        };

    }

}
