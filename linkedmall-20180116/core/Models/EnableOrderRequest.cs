// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class EnableOrderRequest : TeaModel {
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BizUid")]
        [Validation(Required=false)]
        public string BizUid { get; set; }

        [NameInMap("ExtJson")]
        [Validation(Required=false)]
        public string ExtJson { get; set; }

        [NameInMap("LmOrderId")]
        [Validation(Required=false)]
        public string LmOrderId { get; set; }

        [NameInMap("OutTradeId")]
        [Validation(Required=false)]
        public string OutTradeId { get; set; }

        [NameInMap("ThirdPartyUserId")]
        [Validation(Required=false)]
        public string ThirdPartyUserId { get; set; }

        [NameInMap("UseAnonymousTbAccount")]
        [Validation(Required=false)]
        public bool? UseAnonymousTbAccount { get; set; }

    }

}
