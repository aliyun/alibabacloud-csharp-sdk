// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class ListTrademarkApplicationLogsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrademarkApplicationLogs")]
        [Validation(Required=false)]
        public ListTrademarkApplicationLogsResponseBodyTrademarkApplicationLogs TrademarkApplicationLogs { get; set; }
        public class ListTrademarkApplicationLogsResponseBodyTrademarkApplicationLogs : TeaModel {
            [NameInMap("TrademarkApplicationLog")]
            [Validation(Required=false)]
            public List<ListTrademarkApplicationLogsResponseBodyTrademarkApplicationLogsTrademarkApplicationLog> TrademarkApplicationLog { get; set; }
            public class ListTrademarkApplicationLogsResponseBodyTrademarkApplicationLogsTrademarkApplicationLog : TeaModel {
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("BizStatus")]
                [Validation(Required=false)]
                public int? BizStatus { get; set; }

                [NameInMap("Note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                [NameInMap("OperateTime")]
                [Validation(Required=false)]
                public long? OperateTime { get; set; }

                [NameInMap("OperateType")]
                [Validation(Required=false)]
                public int? OperateType { get; set; }

            }

        }

    }

}
