// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTradeMarkApplicationLogsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTradeMarkApplicationLogsResponseBodyData Data { get; set; }
        public class QueryTradeMarkApplicationLogsResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryTradeMarkApplicationLogsResponseBodyDataData> Data { get; set; }
            public class QueryTradeMarkApplicationLogsResponseBodyDataData : TeaModel {
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("BizStatus")]
                [Validation(Required=false)]
                public int? BizStatus { get; set; }

                [NameInMap("ExtendContent")]
                [Validation(Required=false)]
                public string ExtendContent { get; set; }

                [NameInMap("Note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                [NameInMap("OperateTime")]
                [Validation(Required=false)]
                public long? OperateTime { get; set; }

                [NameInMap("OperateType")]
                [Validation(Required=false)]
                public int? OperateType { get; set; }

                [NameInMap("ToBizStatus")]
                [Validation(Required=false)]
                public int? ToBizStatus { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
