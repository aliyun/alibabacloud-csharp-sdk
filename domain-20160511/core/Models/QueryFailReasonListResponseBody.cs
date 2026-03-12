// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20160511.Models
{
    public class QueryFailReasonListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFailReasonListResponseBodyData Data { get; set; }
        public class QueryFailReasonListResponseBodyData : TeaModel {
            [NameInMap("FailRecord")]
            [Validation(Required=false)]
            public List<QueryFailReasonListResponseBodyDataFailRecord> FailRecord { get; set; }
            public class QueryFailReasonListResponseBodyDataFailRecord : TeaModel {
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("FailReason")]
                [Validation(Required=false)]
                public string FailReason { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
