// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribePriceResponseBody : TeaModel {
        /// <summary>
        /// The information about the order.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyOrder Order { get; set; }
        public class DescribePriceResponseBodyOrder : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// Details about coupons.
            /// </summary>
            [NameInMap("Coupons")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyOrderCoupons Coupons { get; set; }
            public class DescribePriceResponseBodyOrderCoupons : TeaModel {
                [NameInMap("Coupon")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyOrderCouponsCoupon> Coupon { get; set; }
                public class DescribePriceResponseBodyOrderCouponsCoupon : TeaModel {
                    /// <summary>
                    /// The coupon ID.
                    /// </summary>
                    [NameInMap("CouponNo")]
                    [Validation(Required=false)]
                    public string CouponNo { get; set; }

                    /// <summary>
                    /// The description of the coupon.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// Indicates whether the coupon was selected.
                    /// </summary>
                    [NameInMap("IsSelected")]
                    [Validation(Required=false)]
                    public string IsSelected { get; set; }

                    /// <summary>
                    /// The coupon name.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// The currency used for payment. A value of CNY is used when the order was generated on the China site (aliyun.com), and a value of USD is used when the order was generated on the international site (alibabacloud.com).
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            [NameInMap("DepreciateInfo")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyOrderDepreciateInfo DepreciateInfo { get; set; }
            public class DescribePriceResponseBodyOrderDepreciateInfo : TeaModel {
                [NameInMap("CheapRate")]
                [Validation(Required=false)]
                public long? CheapRate { get; set; }

                [NameInMap("CheapStandAmount")]
                [Validation(Required=false)]
                public long? CheapStandAmount { get; set; }

                [NameInMap("Differential")]
                [Validation(Required=false)]
                public long? Differential { get; set; }

                [NameInMap("DifferentialName")]
                [Validation(Required=false)]
                public string DifferentialName { get; set; }

                [NameInMap("IsContractActivity")]
                [Validation(Required=false)]
                public bool? IsContractActivity { get; set; }

                [NameInMap("IsShow")]
                [Validation(Required=false)]
                public bool? IsShow { get; set; }

                [NameInMap("ListPrice")]
                [Validation(Required=false)]
                public long? ListPrice { get; set; }

                [NameInMap("MonthPrice")]
                [Validation(Required=false)]
                public long? MonthPrice { get; set; }

                [NameInMap("OriginalStandAmount")]
                [Validation(Required=false)]
                public long? OriginalStandAmount { get; set; }

            }

            /// <summary>
            /// The discount amount of the order.
            /// </summary>
            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public string DiscountAmount { get; set; }

            /// <summary>
            /// The service fees of the order.
            /// </summary>
            [NameInMap("HandlingFeeAmount")]
            [Validation(Required=false)]
            public string HandlingFeeAmount { get; set; }

            [NameInMap("IsContractActivity")]
            [Validation(Required=false)]
            public bool? IsContractActivity { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The original price of the order.
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public string OriginalAmount { get; set; }

            /// <summary>
            /// Details about promotion rule IDs.
            /// </summary>
            [NameInMap("RuleIds")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyOrderRuleIds RuleIds { get; set; }
            public class DescribePriceResponseBodyOrderRuleIds : TeaModel {
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public List<string> RuleId { get; set; }

            }

            /// <summary>
            /// Indicates whether the discount information is displayed.
            /// </summary>
            [NameInMap("ShowDiscountInfo")]
            [Validation(Required=false)]
            public bool? ShowDiscountInfo { get; set; }

            [NameInMap("StandDiscountPrice")]
            [Validation(Required=false)]
            public long? StandDiscountPrice { get; set; }

            [NameInMap("StandPrice")]
            [Validation(Required=false)]
            public long? StandPrice { get; set; }

            /// <summary>
            /// The transaction price of the order.
            /// </summary>
            [NameInMap("TradeAmount")]
            [Validation(Required=false)]
            public string TradeAmount { get; set; }

        }

        /// <summary>
        /// The parameters of the order. This parameter is returned when OrderParamOut is set to `true`.
        /// </summary>
        [NameInMap("OrderParams")]
        [Validation(Required=false)]
        public string OrderParams { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details about promotion rules.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyRules Rules { get; set; }
        public class DescribePriceResponseBodyRules : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodyRulesRule> Rule { get; set; }
            public class DescribePriceResponseBodyRulesRule : TeaModel {
                /// <summary>
                /// The name of the promotion rule.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the rule.
                /// </summary>
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public long? RuleDescId { get; set; }

                /// <summary>
                /// The title of the rule.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// Details about rules that match the coupon.
        /// </summary>
        [NameInMap("SubOrders")]
        [Validation(Required=false)]
        public DescribePriceResponseBodySubOrders SubOrders { get; set; }
        public class DescribePriceResponseBodySubOrders : TeaModel {
            [NameInMap("SubOrder")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodySubOrdersSubOrder> SubOrder { get; set; }
            public class DescribePriceResponseBodySubOrdersSubOrder : TeaModel {
                [NameInMap("DepreciateInfo")]
                [Validation(Required=false)]
                public DescribePriceResponseBodySubOrdersSubOrderDepreciateInfo DepreciateInfo { get; set; }
                public class DescribePriceResponseBodySubOrdersSubOrderDepreciateInfo : TeaModel {
                    [NameInMap("CheapRate")]
                    [Validation(Required=false)]
                    public long? CheapRate { get; set; }

                    [NameInMap("CheapStandAmount")]
                    [Validation(Required=false)]
                    public long? CheapStandAmount { get; set; }

                    [NameInMap("Differential")]
                    [Validation(Required=false)]
                    public long? Differential { get; set; }

                    [NameInMap("DifferentialName")]
                    [Validation(Required=false)]
                    public string DifferentialName { get; set; }

                    [NameInMap("IsContractActivity")]
                    [Validation(Required=false)]
                    public bool? IsContractActivity { get; set; }

                    [NameInMap("ListPrice")]
                    [Validation(Required=false)]
                    public long? ListPrice { get; set; }

                    [NameInMap("MonthPrice")]
                    [Validation(Required=false)]
                    public long? MonthPrice { get; set; }

                    [NameInMap("OriginalStandAmount")]
                    [Validation(Required=false)]
                    public long? OriginalStandAmount { get; set; }

                }

                /// <summary>
                /// The discount amount of the order.
                /// </summary>
                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public string DiscountAmount { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("IsContractActivity")]
                [Validation(Required=false)]
                public bool? IsContractActivity { get; set; }

                [NameInMap("ModuleInstance")]
                [Validation(Required=false)]
                public DescribePriceResponseBodySubOrdersSubOrderModuleInstance ModuleInstance { get; set; }
                public class DescribePriceResponseBodySubOrdersSubOrderModuleInstance : TeaModel {
                    [NameInMap("ModuleInstance")]
                    [Validation(Required=false)]
                    public List<DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstance> ModuleInstance { get; set; }
                    public class DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstance : TeaModel {
                        [NameInMap("DiscountFee")]
                        [Validation(Required=false)]
                        public double? DiscountFee { get; set; }

                        [NameInMap("ModuleAttrs")]
                        [Validation(Required=false)]
                        public DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstanceModuleAttrs ModuleAttrs { get; set; }
                        public class DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstanceModuleAttrs : TeaModel {
                            [NameInMap("moduleAttr")]
                            [Validation(Required=false)]
                            public List<DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstanceModuleAttrsModuleAttr> ModuleAttr { get; set; }
                            public class DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstanceModuleAttrsModuleAttr : TeaModel {
                                [NameInMap("Code")]
                                [Validation(Required=false)]
                                public string Code { get; set; }

                                [NameInMap("Name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public long? Type { get; set; }

                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        [NameInMap("ModuleCode")]
                        [Validation(Required=false)]
                        public string ModuleCode { get; set; }

                        [NameInMap("ModuleId")]
                        [Validation(Required=false)]
                        public string ModuleId { get; set; }

                        [NameInMap("ModuleName")]
                        [Validation(Required=false)]
                        public string ModuleName { get; set; }

                        [NameInMap("NeedOrderPay")]
                        [Validation(Required=false)]
                        public bool? NeedOrderPay { get; set; }

                        [NameInMap("PayFee")]
                        [Validation(Required=false)]
                        public double? PayFee { get; set; }

                        [NameInMap("PricingModule")]
                        [Validation(Required=false)]
                        public bool? PricingModule { get; set; }

                        [NameInMap("StandPrice")]
                        [Validation(Required=false)]
                        public double? StandPrice { get; set; }

                        [NameInMap("TotalProductFee")]
                        [Validation(Required=false)]
                        public double? TotalProductFee { get; set; }

                    }

                }

                [NameInMap("OptionalPromotions")]
                [Validation(Required=false)]
                public DescribePriceResponseBodySubOrdersSubOrderOptionalPromotions OptionalPromotions { get; set; }
                public class DescribePriceResponseBodySubOrdersSubOrderOptionalPromotions : TeaModel {
                    [NameInMap("OptionalPromotion")]
                    [Validation(Required=false)]
                    public List<DescribePriceResponseBodySubOrdersSubOrderOptionalPromotionsOptionalPromotion> OptionalPromotion { get; set; }
                    public class DescribePriceResponseBodySubOrdersSubOrderOptionalPromotionsOptionalPromotion : TeaModel {
                        [NameInMap("ActivityExtInfo")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> ActivityExtInfo { get; set; }

                        [NameInMap("CanPromFee")]
                        [Validation(Required=false)]
                        public string CanPromFee { get; set; }

                        [NameInMap("CouponNo")]
                        [Validation(Required=false)]
                        public string CouponNo { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("OptionCode")]
                        [Validation(Required=false)]
                        public string OptionCode { get; set; }

                        [NameInMap("PromotionName")]
                        [Validation(Required=false)]
                        public string PromotionName { get; set; }

                        [NameInMap("PromotionOptionNo")]
                        [Validation(Required=false)]
                        public string PromotionOptionNo { get; set; }

                        [NameInMap("Selected")]
                        [Validation(Required=false)]
                        public bool? Selected { get; set; }

                        [NameInMap("Show")]
                        [Validation(Required=false)]
                        public bool? Show { get; set; }

                    }

                }

                /// <summary>
                /// The original price of the order.
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public string OriginalAmount { get; set; }

                [NameInMap("PromDetailList")]
                [Validation(Required=false)]
                public DescribePriceResponseBodySubOrdersSubOrderPromDetailList PromDetailList { get; set; }
                public class DescribePriceResponseBodySubOrdersSubOrderPromDetailList : TeaModel {
                    [NameInMap("PromDetail")]
                    [Validation(Required=false)]
                    public List<DescribePriceResponseBodySubOrdersSubOrderPromDetailListPromDetail> PromDetail { get; set; }
                    public class DescribePriceResponseBodySubOrdersSubOrderPromDetailListPromDetail : TeaModel {
                        [NameInMap("FinalPromFee")]
                        [Validation(Required=false)]
                        public double? FinalPromFee { get; set; }

                        [NameInMap("OptionCode")]
                        [Validation(Required=false)]
                        public string OptionCode { get; set; }

                        [NameInMap("PromType")]
                        [Validation(Required=false)]
                        public string PromType { get; set; }

                        [NameInMap("PromotionId")]
                        [Validation(Required=false)]
                        public long? PromotionId { get; set; }

                        [NameInMap("PromotionName")]
                        [Validation(Required=false)]
                        public string PromotionName { get; set; }

                    }

                }

                /// <summary>
                /// The rule IDs.
                /// </summary>
                [NameInMap("RuleIds")]
                [Validation(Required=false)]
                public DescribePriceResponseBodySubOrdersSubOrderRuleIds RuleIds { get; set; }
                public class DescribePriceResponseBodySubOrdersSubOrderRuleIds : TeaModel {
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public List<string> RuleId { get; set; }

                }

                [NameInMap("StandDiscountPrice")]
                [Validation(Required=false)]
                public long? StandDiscountPrice { get; set; }

                [NameInMap("StandPrice")]
                [Validation(Required=false)]
                public long? StandPrice { get; set; }

                /// <summary>
                /// The final price of the order.
                /// </summary>
                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public string TradeAmount { get; set; }

            }

        }

    }

}
