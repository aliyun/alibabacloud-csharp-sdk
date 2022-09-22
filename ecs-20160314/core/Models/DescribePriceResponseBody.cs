// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribePriceResponseBody : TeaModel {
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribePriceResponseBodyPriceInfo : TeaModel {
            [NameInMap("Order")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoOrder Order { get; set; }
            public class DescribePriceResponseBodyPriceInfoOrder : TeaModel {
                [NameInMap("Coupons")]
                [Validation(Required=false)]
                public DescribePriceResponseBodyPriceInfoOrderCoupons Coupons { get; set; }
                public class DescribePriceResponseBodyPriceInfoOrderCoupons : TeaModel {
                    [NameInMap("Coupon")]
                    [Validation(Required=false)]
                    public List<DescribePriceResponseBodyPriceInfoOrderCouponsCoupon> Coupon { get; set; }
                    public class DescribePriceResponseBodyPriceInfoOrderCouponsCoupon : TeaModel {
                        [NameInMap("CouponNo")]
                        [Validation(Required=false)]
                        public string CouponNo { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("DiscountOff")]
                        [Validation(Required=false)]
                        public float? DiscountOff { get; set; }

                        [NameInMap("IsSelected")]
                        [Validation(Required=false)]
                        public bool? IsSelected { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("DetailInfos")]
                [Validation(Required=false)]
                public DescribePriceResponseBodyPriceInfoOrderDetailInfos DetailInfos { get; set; }
                public class DescribePriceResponseBodyPriceInfoOrderDetailInfos : TeaModel {
                    [NameInMap("ResourcePriceModel")]
                    [Validation(Required=false)]
                    public List<DescribePriceResponseBodyPriceInfoOrderDetailInfosResourcePriceModel> ResourcePriceModel { get; set; }
                    public class DescribePriceResponseBodyPriceInfoOrderDetailInfosResourcePriceModel : TeaModel {
                        [NameInMap("DiscountPrice")]
                        [Validation(Required=false)]
                        public float? DiscountPrice { get; set; }

                        [NameInMap("OriginalPrice")]
                        [Validation(Required=false)]
                        public float? OriginalPrice { get; set; }

                        [NameInMap("Resource")]
                        [Validation(Required=false)]
                        public string Resource { get; set; }

                        [NameInMap("SubRules")]
                        [Validation(Required=false)]
                        public DescribePriceResponseBodyPriceInfoOrderDetailInfosResourcePriceModelSubRules SubRules { get; set; }
                        public class DescribePriceResponseBodyPriceInfoOrderDetailInfosResourcePriceModelSubRules : TeaModel {
                            [NameInMap("Rule")]
                            [Validation(Required=false)]
                            public List<DescribePriceResponseBodyPriceInfoOrderDetailInfosResourcePriceModelSubRulesRule> Rule { get; set; }
                            public class DescribePriceResponseBodyPriceInfoOrderDetailInfosResourcePriceModelSubRulesRule : TeaModel {
                                [NameInMap("Name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                [NameInMap("RuleId")]
                                [Validation(Required=false)]
                                public long? RuleId { get; set; }

                                [NameInMap("Title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                        }

                        [NameInMap("TradePrice")]
                        [Validation(Required=false)]
                        public float? TradePrice { get; set; }

                    }

                }

                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                [NameInMap("RuleIdSet")]
                [Validation(Required=false)]
                public DescribePriceResponseBodyPriceInfoOrderRuleIdSet RuleIdSet { get; set; }
                public class DescribePriceResponseBodyPriceInfoOrderRuleIdSet : TeaModel {
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public List<string> RuleId { get; set; }

                }

                [NameInMap("SpotInstanceTypeOriginalPrice")]
                [Validation(Required=false)]
                public float? SpotInstanceTypeOriginalPrice { get; set; }

                [NameInMap("SpotInstanceTypePrice")]
                [Validation(Required=false)]
                public float? SpotInstanceTypePrice { get; set; }

                [NameInMap("SubOrders")]
                [Validation(Required=false)]
                public DescribePriceResponseBodyPriceInfoOrderSubOrders SubOrders { get; set; }
                public class DescribePriceResponseBodyPriceInfoOrderSubOrders : TeaModel {
                    [NameInMap("SubOrder")]
                    [Validation(Required=false)]
                    public List<DescribePriceResponseBodyPriceInfoOrderSubOrdersSubOrder> SubOrder { get; set; }
                    public class DescribePriceResponseBodyPriceInfoOrderSubOrdersSubOrder : TeaModel {
                        [NameInMap("DiscountPrice")]
                        [Validation(Required=false)]
                        public float? DiscountPrice { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("OriginalPrice")]
                        [Validation(Required=false)]
                        public float? OriginalPrice { get; set; }

                        [NameInMap("RuleIdSet")]
                        [Validation(Required=false)]
                        public DescribePriceResponseBodyPriceInfoOrderSubOrdersSubOrderRuleIdSet RuleIdSet { get; set; }
                        public class DescribePriceResponseBodyPriceInfoOrderSubOrdersSubOrderRuleIdSet : TeaModel {
                            [NameInMap("RuleId")]
                            [Validation(Required=false)]
                            public List<string> RuleId { get; set; }

                        }

                        [NameInMap("TradePrice")]
                        [Validation(Required=false)]
                        public float? TradePrice { get; set; }

                    }

                }

                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

            [NameInMap("OrderParams")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoOrderParams OrderParams { get; set; }
            public class DescribePriceResponseBodyPriceInfoOrderParams : TeaModel {
                [NameInMap("OrderParam")]
                [Validation(Required=false)]
                public List<string> OrderParam { get; set; }

            }

            [NameInMap("PriceWarning")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoPriceWarning PriceWarning { get; set; }
            public class DescribePriceResponseBodyPriceInfoPriceWarning : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

            }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoRules Rules { get; set; }
            public class DescribePriceResponseBodyPriceInfoRules : TeaModel {
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyPriceInfoRulesRule> Rule { get; set; }
                public class DescribePriceResponseBodyPriceInfoRulesRule : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
