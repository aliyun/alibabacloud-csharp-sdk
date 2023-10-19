// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CssInstanceCommodity : TeaModel {
        [NameInMap("activityId")]
        [Validation(Required=false)]
        public long? ActivityId { get; set; }

        [NameInMap("aliyunProduceCode")]
        [Validation(Required=false)]
        public string AliyunProduceCode { get; set; }

        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("commodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        [NameInMap("components")]
        [Validation(Required=false)]
        public List<CssInstanceComponent> Components { get; set; }

        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("isFree")]
        [Validation(Required=false)]
        public bool? IsFree { get; set; }

        [NameInMap("isPrePayPostCharge")]
        [Validation(Required=false)]
        public bool? IsPrePayPostCharge { get; set; }

        [NameInMap("isRenewChange")]
        [Validation(Required=false)]
        public bool? IsRenewChange { get; set; }

        [NameInMap("isSyncToSubscription")]
        [Validation(Required=false)]
        public bool? IsSyncToSubscription { get; set; }

        [NameInMap("orderParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> OrderParams { get; set; }

        [NameInMap("orderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("planItemId")]
        [Validation(Required=false)]
        public long? PlanItemId { get; set; }

        [NameInMap("pricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        [NameInMap("quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        [NameInMap("redeemNoList")]
        [Validation(Required=false)]
        public List<string> RedeemNoList { get; set; }

        [NameInMap("redeemOrderType")]
        [Validation(Required=false)]
        public string RedeemOrderType { get; set; }

        [NameInMap("refundSpecCode")]
        [Validation(Required=false)]
        public string RefundSpecCode { get; set; }

        [NameInMap("specCode")]
        [Validation(Required=false)]
        public string SpecCode { get; set; }

        [NameInMap("specUpgradeOriginSpecCodes")]
        [Validation(Required=false)]
        public List<string> SpecUpgradeOriginSpecCodes { get; set; }

        [NameInMap("specifyStartDate")]
        [Validation(Required=false)]
        public long? SpecifyStartDate { get; set; }

        [NameInMap("upgradeInquireFinancialValue")]
        [Validation(Required=false)]
        public bool? UpgradeInquireFinancialValue { get; set; }

    }

}
