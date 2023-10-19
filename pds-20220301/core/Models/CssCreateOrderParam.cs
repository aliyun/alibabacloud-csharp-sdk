// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CssCreateOrderParam : TeaModel {
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        [NameInMap("autoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("autoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        [NameInMap("bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        [NameInMap("buyerId")]
        [Validation(Required=false)]
        public long? BuyerId { get; set; }

        [NameInMap("certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        [NameInMap("childId")]
        [Validation(Required=false)]
        public long? ChildId { get; set; }

        [NameInMap("cilentIp")]
        [Validation(Required=false)]
        public string CilentIp { get; set; }

        [NameInMap("commodities")]
        [Validation(Required=false)]
        public List<CssInstanceCommodity> Commodities { get; set; }

        [NameInMap("createrNick")]
        [Validation(Required=false)]
        public string CreaterNick { get; set; }

        [NameInMap("cssAuthRequestParam")]
        [Validation(Required=false)]
        public object CssAuthRequestParam { get; set; }

        [NameInMap("fromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("marketType")]
        [Validation(Required=false)]
        public long? MarketType { get; set; }

        [NameInMap("memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        [NameInMap("orderOrigin")]
        [Validation(Required=false)]
        public string OrderOrigin { get; set; }

        [NameInMap("orderParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> OrderParams { get; set; }

        [NameInMap("payerId")]
        [Validation(Required=false)]
        public long? PayerId { get; set; }

        [NameInMap("planGroupId")]
        [Validation(Required=false)]
        public long? PlanGroupId { get; set; }

        [NameInMap("planId")]
        [Validation(Required=false)]
        public long? PlanId { get; set; }

        [NameInMap("planInstanceId")]
        [Validation(Required=false)]
        public string PlanInstanceId { get; set; }

        [NameInMap("promotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        [NameInMap("promotionInputParam")]
        [Validation(Required=false)]
        public object PromotionInputParam { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("skipChannel")]
        [Validation(Required=false)]
        public bool? SkipChannel { get; set; }

        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("transientAccess")]
        [Validation(Required=false)]
        public object TransientAccess { get; set; }

        [NameInMap("umidToken")]
        [Validation(Required=false)]
        public string UmidToken { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
