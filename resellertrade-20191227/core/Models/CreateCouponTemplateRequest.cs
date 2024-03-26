/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResellerTrade20191227.Models
{
    public class CreateCouponTemplateRequest : TeaModel {
        [NameInMap("ActivitySite")]
        [Validation(Required=false)]
        public int? ActivitySite { get; set; }

        [NameInMap("Bid")]
        [Validation(Required=false)]
        public long? Bid { get; set; }

        [NameInMap("CertainMoney")]
        [Validation(Required=false)]
        public double? CertainMoney { get; set; }

        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        [NameInMap("CommodityType")]
        [Validation(Required=false)]
        public string CommodityType { get; set; }

        [NameInMap("ControlType")]
        [Validation(Required=false)]
        public string ControlType { get; set; }

        [NameInMap("CouponAmount")]
        [Validation(Required=false)]
        public double? CouponAmount { get; set; }

        [NameInMap("CouponEndTime")]
        [Validation(Required=false)]
        public string CouponEndTime { get; set; }

        [NameInMap("CouponFixedType")]
        [Validation(Required=false)]
        public string CouponFixedType { get; set; }

        [NameInMap("CouponStartTime")]
        [Validation(Required=false)]
        public string CouponStartTime { get; set; }

        [NameInMap("CouponType")]
        [Validation(Required=false)]
        public string CouponType { get; set; }

        [NameInMap("Currency")]
        [Validation(Required=false)]
        public CreateCouponTemplateRequestCurrency Currency { get; set; }
        public class CreateCouponTemplateRequestCurrency : TeaModel {
            [NameInMap("CurrencyCode")]
            [Validation(Required=false)]
            public string CurrencyCode { get; set; }

            [NameInMap("DefaultFractionDigits")]
            [Validation(Required=false)]
            public int? DefaultFractionDigits { get; set; }

            [NameInMap("NumericCode")]
            [Validation(Required=false)]
            public int? NumericCode { get; set; }

        }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DiscountRate")]
        [Validation(Required=false)]
        public double? DiscountRate { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("ExtendsMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtendsMap { get; set; }

        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        [NameInMap("ItemCodeSet")]
        [Validation(Required=false)]
        public List<string> ItemCodeSet { get; set; }

        [NameInMap("Market")]
        [Validation(Required=false)]
        public string Market { get; set; }

        [NameInMap("MarketType")]
        [Validation(Required=false)]
        public long? MarketType { get; set; }

        [NameInMap("MaxRelease")]
        [Validation(Required=false)]
        public double? MaxRelease { get; set; }

        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("OrderTypeSet")]
        [Validation(Required=false)]
        public List<string> OrderTypeSet { get; set; }

        [NameInMap("PerLimitNum")]
        [Validation(Required=false)]
        public int? PerLimitNum { get; set; }

        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public long? PromotionId { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("RelativeSecond")]
        [Validation(Required=false)]
        public int? RelativeSecond { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SelectionIdSet")]
        [Validation(Required=false)]
        public List<string> SelectionIdSet { get; set; }

        [NameInMap("SellerId")]
        [Validation(Required=false)]
        public long? SellerId { get; set; }

        [NameInMap("Site")]
        [Validation(Required=false)]
        public string Site { get; set; }

        [NameInMap("SpId")]
        [Validation(Required=false)]
        public long? SpId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UniversalType")]
        [Validation(Required=false)]
        public string UniversalType { get; set; }

        [NameInMap("UpperLimit")]
        [Validation(Required=false)]
        public double? UpperLimit { get; set; }

        [NameInMap("UsageCount")]
        [Validation(Required=false)]
        public int? UsageCount { get; set; }

        [NameInMap("UseScene")]
        [Validation(Required=false)]
        public string UseScene { get; set; }

        [NameInMap("UserPkAmount")]
        [Validation(Required=false)]
        public string UserPkAmount { get; set; }

        [NameInMap("ValidityType")]
        [Validation(Required=false)]
        public string ValidityType { get; set; }

    }

}
