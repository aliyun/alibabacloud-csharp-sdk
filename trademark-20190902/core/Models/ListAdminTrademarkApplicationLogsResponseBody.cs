// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class ListAdminTrademarkApplicationLogsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrademarkApplicationLogs")]
        [Validation(Required=false)]
        public List<ListAdminTrademarkApplicationLogsResponseBodyTrademarkApplicationLogs> TrademarkApplicationLogs { get; set; }
        public class ListAdminTrademarkApplicationLogsResponseBodyTrademarkApplicationLogs : TeaModel {
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
