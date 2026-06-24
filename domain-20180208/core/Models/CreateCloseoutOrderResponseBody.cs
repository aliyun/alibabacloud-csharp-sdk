// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class CreateCloseoutOrderResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public CreateCloseoutOrderResponseBodyModule Module { get; set; }
        public class CreateCloseoutOrderResponseBodyModule : TeaModel {
            [NameInMap("BizIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> BizIds { get; set; }

            [NameInMap("BuyerBlockTrade")]
            [Validation(Required=false)]
            public List<string> BuyerBlockTrade { get; set; }

            [NameInMap("DomainBlockTrade")]
            [Validation(Required=false)]
            public List<string> DomainBlockTrade { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("DomainTradeRiskWarn")]
            [Validation(Required=false)]
            public List<string> DomainTradeRiskWarn { get; set; }

            [NameInMap("Extend")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extend { get; set; }

            [NameInMap("IgnoredDomains")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> IgnoredDomains { get; set; }

            [NameInMap("NeedPay")]
            [Validation(Required=false)]
            public bool? NeedPay { get; set; }

            [NameInMap("OrderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }

            [NameInMap("OrderSumMoney")]
            [Validation(Required=false)]
            public double? OrderSumMoney { get; set; }

            [NameInMap("OutOrderNo")]
            [Validation(Required=false)]
            public string OutOrderNo { get; set; }

            [NameInMap("PayMoney")]
            [Validation(Required=false)]
            public double? PayMoney { get; set; }

            [NameInMap("PayUrl")]
            [Validation(Required=false)]
            public string PayUrl { get; set; }

            [NameInMap("RealNameTemplate")]
            [Validation(Required=false)]
            public List<long?> RealNameTemplate { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
