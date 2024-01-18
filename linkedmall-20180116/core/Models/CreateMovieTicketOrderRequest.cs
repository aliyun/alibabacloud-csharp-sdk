// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class CreateMovieTicketOrderRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BizUid")]
        [Validation(Required=false)]
        public string BizUid { get; set; }

        [NameInMap("ExtJson")]
        [Validation(Required=false)]
        public string ExtJson { get; set; }

        [NameInMap("LockSeatAppKey")]
        [Validation(Required=false)]
        public string LockSeatAppKey { get; set; }

        [NameInMap("OutTradeId")]
        [Validation(Required=false)]
        public string OutTradeId { get; set; }

    }

}
