// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribePriceResponseBody : TeaModel {
        /// <summary>
        /// The order information.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyOrder Order { get; set; }
        public class DescribePriceResponseBodyOrder : TeaModel {
            /// <summary>
            /// The order code.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// Indicates whether the contract promotion is hit.
            /// </summary>
            [NameInMap("ContractActivity")]
            [Validation(Required=false)]
            public bool? ContractActivity { get; set; }

            /// <summary>
            /// The information of coupons.
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
                    /// The activity type of the coupon. Valid values:
                    /// 
                    /// *   **payondemand**: subscription
                    /// *   **payasyougo**: pay-as-you-go
                    /// </summary>
                    [NameInMap("ActivityCategory")]
                    [Validation(Required=false)]
                    public string ActivityCategory { get; set; }

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
                    /// Indicates whether the coupon was selected. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
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

                    /// <summary>
                    /// The code of the coupon.
                    /// </summary>
                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                    /// <summary>
                    /// The promotional option code.
                    /// </summary>
                    [NameInMap("PromotionOptionCode")]
                    [Validation(Required=false)]
                    public string PromotionOptionCode { get; set; }

                    /// <summary>
                    /// The IDs of the rules that correspond to the coupon.
                    /// </summary>
                    [NameInMap("PromotionRuleIdList")]
                    [Validation(Required=false)]
                    public DescribePriceResponseBodyOrderCouponsCouponPromotionRuleIdList PromotionRuleIdList { get; set; }
                    public class DescribePriceResponseBodyOrderCouponsCouponPromotionRuleIdList : TeaModel {
                        [NameInMap("PromotionRuleId")]
                        [Validation(Required=false)]
                        public List<long?> PromotionRuleId { get; set; }

                    }

                }

            }

            /// <summary>
            /// The currency.
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// The price reduction information.
            /// </summary>
            [NameInMap("DepreciateInfo")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyOrderDepreciateInfo DepreciateInfo { get; set; }
            public class DescribePriceResponseBodyOrderDepreciateInfo : TeaModel {
                /// <summary>
                /// The price reduction rate.
                /// </summary>
                [NameInMap("CheapRate")]
                [Validation(Required=false)]
                public double? CheapRate { get; set; }

                /// <summary>
                /// The new total price displayed on the official website.
                /// </summary>
                [NameInMap("CheapStandAmount")]
                [Validation(Required=false)]
                public double? CheapStandAmount { get; set; }

                /// <summary>
                /// The contract promotion.
                /// </summary>
                [NameInMap("ContractActivity")]
                [Validation(Required=false)]
                public DescribePriceResponseBodyOrderDepreciateInfoContractActivity ContractActivity { get; set; }
                public class DescribePriceResponseBodyOrderDepreciateInfoContractActivity : TeaModel {
                    /// <summary>
                    /// The activity ID.
                    /// </summary>
                    [NameInMap("ActivityId")]
                    [Validation(Required=false)]
                    public long? ActivityId { get; set; }

                    /// <summary>
                    /// The activity name.
                    /// </summary>
                    [NameInMap("ActivityName")]
                    [Validation(Required=false)]
                    public string ActivityName { get; set; }

                    /// <summary>
                    /// The price after the promotion.
                    /// </summary>
                    [NameInMap("FinalFee")]
                    [Validation(Required=false)]
                    public double? FinalFee { get; set; }

                    /// <summary>
                    /// The total discount amount.
                    /// </summary>
                    [NameInMap("FinalPromFee")]
                    [Validation(Required=false)]
                    public double? FinalPromFee { get; set; }

                    /// <summary>
                    /// The promotion ID.
                    /// </summary>
                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                    /// <summary>
                    /// The promotion IDs.
                    /// </summary>
                    [NameInMap("OptionIds")]
                    [Validation(Required=false)]
                    public DescribePriceResponseBodyOrderDepreciateInfoContractActivityOptionIds OptionIds { get; set; }
                    public class DescribePriceResponseBodyOrderDepreciateInfoContractActivityOptionIds : TeaModel {
                        [NameInMap("OptionId")]
                        [Validation(Required=false)]
                        public List<long?> OptionId { get; set; }

                    }

                    /// <summary>
                    /// The original price.
                    /// </summary>
                    [NameInMap("ProdFee")]
                    [Validation(Required=false)]
                    public double? ProdFee { get; set; }

                }

                /// <summary>
                /// The price difference displayed in the total order amount.
                /// </summary>
                [NameInMap("Differential")]
                [Validation(Required=false)]
                public double? Differential { get; set; }

                /// <summary>
                /// The name of the price difference.
                /// </summary>
                [NameInMap("DifferentialName")]
                [Validation(Required=false)]
                public string DifferentialName { get; set; }

                /// <summary>
                /// Indicates whether the contract promotion is hit.
                /// </summary>
                [NameInMap("IsContractActivity")]
                [Validation(Required=false)]
                public bool? IsContractActivity { get; set; }

                /// <summary>
                /// Indicates whether the price reduction rate is displayed.
                /// </summary>
                [NameInMap("IsShow")]
                [Validation(Required=false)]
                public string IsShow { get; set; }

                /// <summary>
                /// The list price.
                /// </summary>
                [NameInMap("ListPrice")]
                [Validation(Required=false)]
                public double? ListPrice { get; set; }

                /// <summary>
                /// The monthly price.
                /// </summary>
                [NameInMap("MonthPrice")]
                [Validation(Required=false)]
                public double? MonthPrice { get; set; }

                /// <summary>
                /// The original total price displayed on the official website.
                /// </summary>
                [NameInMap("OriginalStandAmount")]
                [Validation(Required=false)]
                public double? OriginalStandAmount { get; set; }

            }

            /// <summary>
            /// The discount amount of the order.
            /// </summary>
            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public string DiscountAmount { get; set; }

            /// <summary>
            /// Indicates whether the contract promotion is hit.
            /// </summary>
            [NameInMap("IsContractActivity")]
            [Validation(Required=false)]
            public bool? IsContractActivity { get; set; }

            /// <summary>
            /// The order information.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The promotional activity information.
            /// </summary>
            [NameInMap("OptionalPromotions")]
            [Validation(Required=false)]
            public string OptionalPromotions { get; set; }

            /// <summary>
            /// The original price of the order.
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public string OriginalAmount { get; set; }

            /// <summary>
            /// The promotional activity that is hit.
            /// </summary>
            [NameInMap("PromDetailList")]
            [Validation(Required=false)]
            public string PromDetailList { get; set; }

            /// <summary>
            /// The rules of the order.
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

            /// <summary>
            /// The discount.
            /// </summary>
            [NameInMap("StandDiscountPrice")]
            [Validation(Required=false)]
            public double? StandDiscountPrice { get; set; }

            /// <summary>
            /// The discount.
            /// </summary>
            [NameInMap("StandPrice")]
            [Validation(Required=false)]
            public double? StandPrice { get; set; }

            /// <summary>
            /// The final price of the order.
            /// </summary>
            [NameInMap("TradeAmount")]
            [Validation(Required=false)]
            public string TradeAmount { get; set; }

        }

        /// <summary>
        /// The order parameters.
        /// 
        /// > This parameter is returned only when the **OrderParamOut** parameter is set to **true**.
        /// </summary>
        [NameInMap("OrderParams")]
        [Validation(Required=false)]
        public string OrderParams { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The promotion rules.
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
                /// The rule name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The rule ID.
                /// </summary>
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public long? RuleDescId { get; set; }

                /// <summary>
                /// The rule title.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// The coupon rules.
        /// </summary>
        [NameInMap("SubOrders")]
        [Validation(Required=false)]
        public DescribePriceResponseBodySubOrders SubOrders { get; set; }
        public class DescribePriceResponseBodySubOrders : TeaModel {
            [NameInMap("SubOrder")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodySubOrdersSubOrder> SubOrder { get; set; }
            public class DescribePriceResponseBodySubOrdersSubOrder : TeaModel {
                /// <summary>
                /// Indicates whether the contract promotion is hit.
                /// </summary>
                [NameInMap("ContractActivity")]
                [Validation(Required=false)]
                public bool? ContractActivity { get; set; }

                /// <summary>
                /// The price reduction information.
                /// </summary>
                [NameInMap("DepreciateInfo")]
                [Validation(Required=false)]
                public DescribePriceResponseBodySubOrdersSubOrderDepreciateInfo DepreciateInfo { get; set; }
                public class DescribePriceResponseBodySubOrdersSubOrderDepreciateInfo : TeaModel {
                    /// <summary>
                    /// The price reduction rate.
                    /// </summary>
                    [NameInMap("CheapRate")]
                    [Validation(Required=false)]
                    public double? CheapRate { get; set; }

                    /// <summary>
                    /// The new total price displayed on the official website.
                    /// </summary>
                    [NameInMap("CheapStandAmount")]
                    [Validation(Required=false)]
                    public double? CheapStandAmount { get; set; }

                    /// <summary>
                    /// The activity information.
                    /// </summary>
                    [NameInMap("ContractActivity")]
                    [Validation(Required=false)]
                    public DescribePriceResponseBodySubOrdersSubOrderDepreciateInfoContractActivity ContractActivity { get; set; }
                    public class DescribePriceResponseBodySubOrdersSubOrderDepreciateInfoContractActivity : TeaModel {
                        /// <summary>
                        /// The activity ID.
                        /// </summary>
                        [NameInMap("ActivityId")]
                        [Validation(Required=false)]
                        public long? ActivityId { get; set; }

                        /// <summary>
                        /// The activity name.
                        /// </summary>
                        [NameInMap("ActivityName")]
                        [Validation(Required=false)]
                        public string ActivityName { get; set; }

                        /// <summary>
                        /// The price after the promotion.
                        /// </summary>
                        [NameInMap("FinalFee")]
                        [Validation(Required=false)]
                        public double? FinalFee { get; set; }

                        /// <summary>
                        /// The total discount amount.
                        /// </summary>
                        [NameInMap("FinalPromFee")]
                        [Validation(Required=false)]
                        public double? FinalPromFee { get; set; }

                        /// <summary>
                        /// The promotion ID.
                        /// </summary>
                        [NameInMap("OptionCode")]
                        [Validation(Required=false)]
                        public string OptionCode { get; set; }

                        /// <summary>
                        /// The promotion IDs.
                        /// </summary>
                        [NameInMap("OptionIds")]
                        [Validation(Required=false)]
                        public DescribePriceResponseBodySubOrdersSubOrderDepreciateInfoContractActivityOptionIds OptionIds { get; set; }
                        public class DescribePriceResponseBodySubOrdersSubOrderDepreciateInfoContractActivityOptionIds : TeaModel {
                            [NameInMap("OptionId")]
                            [Validation(Required=false)]
                            public List<long?> OptionId { get; set; }

                        }

                        /// <summary>
                        /// The original price.
                        /// </summary>
                        [NameInMap("ProdFee")]
                        [Validation(Required=false)]
                        public double? ProdFee { get; set; }

                    }

                    /// <summary>
                    /// The price difference displayed in the total order amount.
                    /// </summary>
                    [NameInMap("Differential")]
                    [Validation(Required=false)]
                    public double? Differential { get; set; }

                    /// <summary>
                    /// The name of the price difference.
                    /// </summary>
                    [NameInMap("DifferentialName")]
                    [Validation(Required=false)]
                    public string DifferentialName { get; set; }

                    /// <summary>
                    /// Indicates whether the contract promotion is hit.
                    /// </summary>
                    [NameInMap("IsContractActivity")]
                    [Validation(Required=false)]
                    public bool? IsContractActivity { get; set; }

                    /// <summary>
                    /// Indicates whether the price reduction rate is displayed.
                    /// </summary>
                    [NameInMap("IsShow")]
                    [Validation(Required=false)]
                    public string IsShow { get; set; }

                    /// <summary>
                    /// The list price.
                    /// </summary>
                    [NameInMap("ListPrice")]
                    [Validation(Required=false)]
                    public double? ListPrice { get; set; }

                    /// <summary>
                    /// The monthly price.
                    /// </summary>
                    [NameInMap("MonthPrice")]
                    [Validation(Required=false)]
                    public double? MonthPrice { get; set; }

                    /// <summary>
                    /// The original total price displayed on the official website.
                    /// </summary>
                    [NameInMap("OriginalStandAmount")]
                    [Validation(Required=false)]
                    public double? OriginalStandAmount { get; set; }

                    /// <summary>
                    /// The start time of the activity.
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

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

                /// <summary>
                /// Indicates whether the contract promotion is hit.
                /// </summary>
                [NameInMap("IsContractActivity")]
                [Validation(Required=false)]
                public bool? IsContractActivity { get; set; }

                /// <summary>
                /// Indicates whether the discount is hit.
                /// </summary>
                [NameInMap("IsNewOfficialActivity")]
                [Validation(Required=false)]
                public string IsNewOfficialActivity { get; set; }

                /// <summary>
                /// The configuration item of the instance in the order.
                /// </summary>
                [NameInMap("ModuleInstance")]
                [Validation(Required=false)]
                public DescribePriceResponseBodySubOrdersSubOrderModuleInstance ModuleInstance { get; set; }
                public class DescribePriceResponseBodySubOrdersSubOrderModuleInstance : TeaModel {
                    [NameInMap("ModuleInstance")]
                    [Validation(Required=false)]
                    public List<DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstance> ModuleInstance { get; set; }
                    public class DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstance : TeaModel {
                        /// <summary>
                        /// Indicates whether the contract promotion is hit.
                        /// </summary>
                        [NameInMap("ContractActivity")]
                        [Validation(Required=false)]
                        public bool? ContractActivity { get; set; }

                        /// <summary>
                        /// The cycle fee of the module.
                        /// </summary>
                        [NameInMap("CycleFee")]
                        [Validation(Required=false)]
                        public string CycleFee { get; set; }

                        /// <summary>
                        /// The activity information.
                        /// </summary>
                        [NameInMap("DepreciateInfo")]
                        [Validation(Required=false)]
                        public DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstanceDepreciateInfo DepreciateInfo { get; set; }
                        public class DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstanceDepreciateInfo : TeaModel {
                            /// <summary>
                            /// The price reduction rate.
                            /// </summary>
                            [NameInMap("CheapRate")]
                            [Validation(Required=false)]
                            public double? CheapRate { get; set; }

                            /// <summary>
                            /// The new total price displayed on the official website.
                            /// </summary>
                            [NameInMap("CheapStandAmount")]
                            [Validation(Required=false)]
                            public double? CheapStandAmount { get; set; }

                            /// <summary>
                            /// The price difference displayed in the total order amount.
                            /// </summary>
                            [NameInMap("Differential")]
                            [Validation(Required=false)]
                            public double? Differential { get; set; }

                            /// <summary>
                            /// The name of the price difference.
                            /// </summary>
                            [NameInMap("DifferentialName")]
                            [Validation(Required=false)]
                            public string DifferentialName { get; set; }

                            /// <summary>
                            /// Indicates whether the contract promotion is hit.
                            /// </summary>
                            [NameInMap("IsContractActivity")]
                            [Validation(Required=false)]
                            public bool? IsContractActivity { get; set; }

                            /// <summary>
                            /// Indicates whether the price reduction rate is displayed.
                            /// </summary>
                            [NameInMap("IsShow")]
                            [Validation(Required=false)]
                            public string IsShow { get; set; }

                            /// <summary>
                            /// The list price.
                            /// </summary>
                            [NameInMap("ListPrice")]
                            [Validation(Required=false)]
                            public double? ListPrice { get; set; }

                            /// <summary>
                            /// The monthly price.
                            /// </summary>
                            [NameInMap("MonthPrice")]
                            [Validation(Required=false)]
                            public double? MonthPrice { get; set; }

                            /// <summary>
                            /// The original total price displayed on the official website.
                            /// </summary>
                            [NameInMap("OriginalStandAmount")]
                            [Validation(Required=false)]
                            public double? OriginalStandAmount { get; set; }

                        }

                        /// <summary>
                        /// The discount.
                        /// </summary>
                        [NameInMap("DiscountFee")]
                        [Validation(Required=false)]
                        public string DiscountFee { get; set; }

                        /// <summary>
                        /// The module attributes.
                        /// </summary>
                        [NameInMap("ModuleAttrs")]
                        [Validation(Required=false)]
                        public DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstanceModuleAttrs ModuleAttrs { get; set; }
                        public class DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstanceModuleAttrs : TeaModel {
                            [NameInMap("moduleAttr")]
                            [Validation(Required=false)]
                            public List<DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstanceModuleAttrsModuleAttr> ModuleAttr { get; set; }
                            public class DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstanceModuleAttrsModuleAttr : TeaModel {
                                /// <summary>
                                /// The attribute code.
                                /// </summary>
                                [NameInMap("Code")]
                                [Validation(Required=false)]
                                public string Code { get; set; }

                                /// <summary>
                                /// The attribute name.
                                /// </summary>
                                [NameInMap("Name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                /// <summary>
                                /// The attribute type.
                                /// </summary>
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                                /// <summary>
                                /// The attribute value.
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        /// <summary>
                        /// The module code.
                        /// </summary>
                        [NameInMap("ModuleCode")]
                        [Validation(Required=false)]
                        public string ModuleCode { get; set; }

                        /// <summary>
                        /// The module ID
                        /// </summary>
                        [NameInMap("ModuleId")]
                        [Validation(Required=false)]
                        public long? ModuleId { get; set; }

                        /// <summary>
                        /// The module name.
                        /// </summary>
                        [NameInMap("ModuleName")]
                        [Validation(Required=false)]
                        public string ModuleName { get; set; }

                        /// <summary>
                        /// Indicates whether the order is paid.
                        /// </summary>
                        [NameInMap("NeedOrderPay")]
                        [Validation(Required=false)]
                        public bool? NeedOrderPay { get; set; }

                        /// <summary>
                        /// The actual amount paid.
                        /// </summary>
                        [NameInMap("PayFee")]
                        [Validation(Required=false)]
                        public double? PayFee { get; set; }

                        /// <summary>
                        /// Indicates whether the item is billed.
                        /// </summary>
                        [NameInMap("PricingModule")]
                        [Validation(Required=false)]
                        public bool? PricingModule { get; set; }

                        /// <summary>
                        /// The promotion details.
                        /// </summary>
                        [NameInMap("PromDetailList")]
                        [Validation(Required=false)]
                        public DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstancePromDetailList PromDetailList { get; set; }
                        public class DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstancePromDetailList : TeaModel {
                            [NameInMap("PromDetail")]
                            [Validation(Required=false)]
                            public List<DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstancePromDetailListPromDetail> PromDetail { get; set; }
                            public class DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstancePromDetailListPromDetail : TeaModel {
                                /// <summary>
                                /// The additional promotion information.
                                /// </summary>
                                [NameInMap("ActivityExtInfo")]
                                [Validation(Required=false)]
                                public Dictionary<string, object> ActivityExtInfo { get; set; }

                                /// <summary>
                                /// The sub-type of the promotion.
                                /// </summary>
                                [NameInMap("DerivedPromType")]
                                [Validation(Required=false)]
                                public string DerivedPromType { get; set; }

                                /// <summary>
                                /// The discount amount.
                                /// </summary>
                                [NameInMap("FinalPromFee")]
                                [Validation(Required=false)]
                                public double? FinalPromFee { get; set; }

                                /// <summary>
                                /// The code of the commodity to which the coupon can be applied.
                                /// </summary>
                                [NameInMap("OptionCode")]
                                [Validation(Required=false)]
                                public string OptionCode { get; set; }

                                /// <summary>
                                /// The sub-type of the promotion.
                                /// </summary>
                                [NameInMap("PromType")]
                                [Validation(Required=false)]
                                public string PromType { get; set; }

                                /// <summary>
                                /// The coupon code.
                                /// </summary>
                                [NameInMap("PromotionCode")]
                                [Validation(Required=false)]
                                public string PromotionCode { get; set; }

                                /// <summary>
                                /// The ID of the promotional activity.
                                /// </summary>
                                [NameInMap("PromotionId")]
                                [Validation(Required=false)]
                                public long? PromotionId { get; set; }

                                /// <summary>
                                /// The promotional activity name.
                                /// </summary>
                                [NameInMap("PromotionName")]
                                [Validation(Required=false)]
                                public string PromotionName { get; set; }

                            }

                        }

                        /// <summary>
                        /// The discount.
                        /// </summary>
                        [NameInMap("StandDiscountPrice")]
                        [Validation(Required=false)]
                        public double? StandDiscountPrice { get; set; }

                        /// <summary>
                        /// The discount.
                        /// </summary>
                        [NameInMap("StandPrice")]
                        [Validation(Required=false)]
                        public double? StandPrice { get; set; }

                        /// <summary>
                        /// The original price of the product.
                        /// </summary>
                        [NameInMap("TotalProductFee")]
                        [Validation(Required=false)]
                        public double? TotalProductFee { get; set; }

                    }

                }

                /// <summary>
                /// The promotional options that can be configured.
                /// </summary>
                [NameInMap("OptionalPromotions")]
                [Validation(Required=false)]
                public DescribePriceResponseBodySubOrdersSubOrderOptionalPromotions OptionalPromotions { get; set; }
                public class DescribePriceResponseBodySubOrdersSubOrderOptionalPromotions : TeaModel {
                    [NameInMap("OptionalPromotion")]
                    [Validation(Required=false)]
                    public List<DescribePriceResponseBodySubOrdersSubOrderOptionalPromotionsOptionalPromotion> OptionalPromotion { get; set; }
                    public class DescribePriceResponseBodySubOrdersSubOrderOptionalPromotionsOptionalPromotion : TeaModel {
                        /// <summary>
                        /// The activity type.
                        /// </summary>
                        [NameInMap("ActivityCategory")]
                        [Validation(Required=false)]
                        public string ActivityCategory { get; set; }

                        /// <summary>
                        /// The additional activity information.
                        /// </summary>
                        [NameInMap("ActivityExtInfo")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> ActivityExtInfo { get; set; }

                        /// <summary>
                        /// The amount that can be deducted by using the coupon.
                        /// </summary>
                        [NameInMap("CanPromFee")]
                        [Validation(Required=false)]
                        public double? CanPromFee { get; set; }

                        /// <summary>
                        /// The promotion type.
                        /// </summary>
                        [NameInMap("OptionCode")]
                        [Validation(Required=false)]
                        public string OptionCode { get; set; }

                        /// <summary>
                        /// The promotion name.
                        /// </summary>
                        [NameInMap("PromotionName")]
                        [Validation(Required=false)]
                        public string PromotionName { get; set; }

                        /// <summary>
                        /// The promotion ID.
                        /// </summary>
                        [NameInMap("PromotionOptionNo")]
                        [Validation(Required=false)]
                        public string PromotionOptionNo { get; set; }

                        /// <summary>
                        /// The IDs of the rules that correspond to the coupon.
                        /// </summary>
                        [NameInMap("PromotionRuleIdList")]
                        [Validation(Required=false)]
                        public DescribePriceResponseBodySubOrdersSubOrderOptionalPromotionsOptionalPromotionPromotionRuleIdList PromotionRuleIdList { get; set; }
                        public class DescribePriceResponseBodySubOrdersSubOrderOptionalPromotionsOptionalPromotionPromotionRuleIdList : TeaModel {
                            [NameInMap("promotionRuleId")]
                            [Validation(Required=false)]
                            public List<string> PromotionRuleId { get; set; }

                        }

                        /// <summary>
                        /// Indicates whether
                        /// </summary>
                        [NameInMap("Selected")]
                        [Validation(Required=false)]
                        public bool? Selected { get; set; }

                        /// <summary>
                        /// Indicates whether the discount is displayed.
                        /// </summary>
                        [NameInMap("Show")]
                        [Validation(Required=false)]
                        public bool? Show { get; set; }

                        /// <summary>
                        /// The specification codes of the product.
                        /// </summary>
                        [NameInMap("TargetArticleItemCodes")]
                        [Validation(Required=false)]
                        public DescribePriceResponseBodySubOrdersSubOrderOptionalPromotionsOptionalPromotionTargetArticleItemCodes TargetArticleItemCodes { get; set; }
                        public class DescribePriceResponseBodySubOrdersSubOrderOptionalPromotionsOptionalPromotionTargetArticleItemCodes : TeaModel {
                            [NameInMap("targetArticleItemCode")]
                            [Validation(Required=false)]
                            public List<string> TargetArticleItemCode { get; set; }

                        }

                    }

                }

                /// <summary>
                /// The original price of the order.
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public string OriginalAmount { get; set; }

                /// <summary>
                /// The promotion details.
                /// </summary>
                [NameInMap("PromDetailList")]
                [Validation(Required=false)]
                public DescribePriceResponseBodySubOrdersSubOrderPromDetailList PromDetailList { get; set; }
                public class DescribePriceResponseBodySubOrdersSubOrderPromDetailList : TeaModel {
                    [NameInMap("PromDetail")]
                    [Validation(Required=false)]
                    public List<DescribePriceResponseBodySubOrdersSubOrderPromDetailListPromDetail> PromDetail { get; set; }
                    public class DescribePriceResponseBodySubOrdersSubOrderPromDetailListPromDetail : TeaModel {
                        /// <summary>
                        /// The additional activity information.
                        /// </summary>
                        [NameInMap("ActivityExtInfo")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> ActivityExtInfo { get; set; }

                        /// <summary>
                        /// The sub-type of the promotion.
                        /// </summary>
                        [NameInMap("DerivedPromType")]
                        [Validation(Required=false)]
                        public string DerivedPromType { get; set; }

                        /// <summary>
                        /// The discount amount.
                        /// </summary>
                        [NameInMap("FinalPromFee")]
                        [Validation(Required=false)]
                        public double? FinalPromFee { get; set; }

                        /// <summary>
                        /// The code of the coupon.
                        /// </summary>
                        [NameInMap("OptionCode")]
                        [Validation(Required=false)]
                        public string OptionCode { get; set; }

                        /// <summary>
                        /// The sub-type of the promotion.
                        /// </summary>
                        [NameInMap("PromType")]
                        [Validation(Required=false)]
                        public string PromType { get; set; }

                        /// <summary>
                        /// The coupon code.
                        /// </summary>
                        [NameInMap("PromotionCode")]
                        [Validation(Required=false)]
                        public string PromotionCode { get; set; }

                        /// <summary>
                        /// The promotion ID.
                        /// </summary>
                        [NameInMap("PromotionId")]
                        [Validation(Required=false)]
                        public long? PromotionId { get; set; }

                        /// <summary>
                        /// The name of the promotional activity.
                        /// </summary>
                        [NameInMap("PromotionName")]
                        [Validation(Required=false)]
                        public string PromotionName { get; set; }

                    }

                }

                /// <summary>
                /// The activity rules.
                /// </summary>
                [NameInMap("RuleIds")]
                [Validation(Required=false)]
                public DescribePriceResponseBodySubOrdersSubOrderRuleIds RuleIds { get; set; }
                public class DescribePriceResponseBodySubOrdersSubOrderRuleIds : TeaModel {
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public List<string> RuleId { get; set; }

                }

                /// <summary>
                /// The discount.
                /// </summary>
                [NameInMap("StandDiscountPrice")]
                [Validation(Required=false)]
                public double? StandDiscountPrice { get; set; }

                /// <summary>
                /// The discount.
                /// </summary>
                [NameInMap("StandPrice")]
                [Validation(Required=false)]
                public double? StandPrice { get; set; }

                /// <summary>
                /// The actual price of the order.
                /// </summary>
                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public string TradeAmount { get; set; }

            }

        }

        /// <summary>
        /// The ID of the trace.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
