// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the order.</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyOrder Order { get; set; }
        public class DescribePriceResponseBodyOrder : TeaModel {
            /// <summary>
            /// <para>The order code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Coupons")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyOrderCoupons Coupons { get; set; }
            public class DescribePriceResponseBodyOrderCoupons : TeaModel {
                [NameInMap("Coupon")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyOrderCouponsCoupon> Coupon { get; set; }
                public class DescribePriceResponseBodyOrderCouponsCoupon : TeaModel {
                    [NameInMap("CouponNo")]
                    [Validation(Required=false)]
                    public string CouponNo { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("IsSelected")]
                    [Validation(Required=false)]
                    public string IsSelected { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The currency used for payment. A value of CNY is used when the order was generated on the China site (aliyun.com), and a value of USD is used when the order was generated on the international site (alibabacloud.com).</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The activity information.</para>
            /// </summary>
            [NameInMap("DepreciateInfo")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyOrderDepreciateInfo DepreciateInfo { get; set; }
            public class DescribePriceResponseBodyOrderDepreciateInfo : TeaModel {
                /// <summary>
                /// <para>The price reduction rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30%</para>
                /// </summary>
                [NameInMap("CheapRate")]
                [Validation(Required=false)]
                public long? CheapRate { get; set; }

                /// <summary>
                /// <para>The new total price displayed on the official website.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9*</para>
                /// </summary>
                [NameInMap("CheapStandAmount")]
                [Validation(Required=false)]
                public long? CheapStandAmount { get; set; }

                /// <summary>
                /// <para>The activity information.</para>
                /// </summary>
                [NameInMap("ContractActivity")]
                [Validation(Required=false)]
                public DescribePriceResponseBodyOrderDepreciateInfoContractActivity ContractActivity { get; set; }
                public class DescribePriceResponseBodyOrderDepreciateInfoContractActivity : TeaModel {
                    /// <summary>
                    /// <para>The activity ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("ActivityId")]
                    [Validation(Required=false)]
                    public long? ActivityId { get; set; }

                    /// <summary>
                    /// <para>The activity name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>contract promotion_order_xxx discount</para>
                    /// </summary>
                    [NameInMap("ActivityName")]
                    [Validation(Required=false)]
                    public string ActivityName { get; set; }

                    /// <summary>
                    /// <para>The preferential price.</para>
                    /// </summary>
                    [NameInMap("FinalFee")]
                    [Validation(Required=false)]
                    public double? FinalFee { get; set; }

                    /// <summary>
                    /// <para>The total discount amount.</para>
                    /// </summary>
                    [NameInMap("FinalPromFee")]
                    [Validation(Required=false)]
                    public double? FinalPromFee { get; set; }

                    /// <summary>
                    /// <para>The promotion code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                    [NameInMap("OptionIds")]
                    [Validation(Required=false)]
                    public DescribePriceResponseBodyOrderDepreciateInfoContractActivityOptionIds OptionIds { get; set; }
                    public class DescribePriceResponseBodyOrderDepreciateInfoContractActivityOptionIds : TeaModel {
                        [NameInMap("OptionId")]
                        [Validation(Required=false)]
                        public List<long?> OptionId { get; set; }

                    }

                    /// <summary>
                    /// <para>The original price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("ProdFee")]
                    [Validation(Required=false)]
                    public double? ProdFee { get; set; }

                }

                /// <summary>
                /// <para>The promotional offer (displayed in the total order amount).</para>
                /// 
                /// <b>Example:</b>
                /// <para>**</para>
                /// </summary>
                [NameInMap("Differential")]
                [Validation(Required=false)]
                public long? Differential { get; set; }

                /// <summary>
                /// <para>The name of the promotional offer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXXXX</para>
                /// </summary>
                [NameInMap("DifferentialName")]
                [Validation(Required=false)]
                public string DifferentialName { get; set; }

                /// <summary>
                /// <para>Indicates whether eligibility for the contracted discount is met.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsContractActivity")]
                [Validation(Required=false)]
                public bool? IsContractActivity { get; set; }

                /// <summary>
                /// <para>Indicates whether the price reduction rate is displayed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsShow")]
                [Validation(Required=false)]
                public bool? IsShow { get; set; }

                /// <summary>
                /// <para>The list price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1*</para>
                /// </summary>
                [NameInMap("ListPrice")]
                [Validation(Required=false)]
                public long? ListPrice { get; set; }

                /// <summary>
                /// <para>The monthly price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>**</para>
                /// </summary>
                [NameInMap("MonthPrice")]
                [Validation(Required=false)]
                public long? MonthPrice { get; set; }

                /// <summary>
                /// <para>The original total price displayed on the official website.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12*</para>
                /// </summary>
                [NameInMap("OriginalStandAmount")]
                [Validation(Required=false)]
                public long? OriginalStandAmount { get; set; }

            }

            /// <summary>
            /// <para>The discount amount of the order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.21</para>
            /// </summary>
            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public string DiscountAmount { get; set; }

            /// <summary>
            /// <para>The service fees of the order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("HandlingFeeAmount")]
            [Validation(Required=false)]
            public string HandlingFeeAmount { get; set; }

            /// <summary>
            /// <para>Indicates whether eligibility for the contracted discount is met.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsContractActivity")]
            [Validation(Required=false)]
            public bool? IsContractActivity { get; set; }

            /// <summary>
            /// <para>The information about the order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The original price of the order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.21</para>
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public string OriginalAmount { get; set; }

            [NameInMap("RuleIds")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyOrderRuleIds RuleIds { get; set; }
            public class DescribePriceResponseBodyOrderRuleIds : TeaModel {
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public List<string> RuleId { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the discount information is displayed.</para>
            /// </summary>
            [NameInMap("ShowDiscountInfo")]
            [Validation(Required=false)]
            public bool? ShowDiscountInfo { get; set; }

            /// <summary>
            /// <para>The discount.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("StandDiscountPrice")]
            [Validation(Required=false)]
            public long? StandDiscountPrice { get; set; }

            /// <summary>
            /// <para>The discounted price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StandPrice")]
            [Validation(Required=false)]
            public long? StandPrice { get; set; }

            /// <summary>
            /// <para>The transaction price of the order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TradeAmount")]
            [Validation(Required=false)]
            public string TradeAmount { get; set; }

        }

        /// <summary>
        /// <para>The parameters of the order. When OrderParamOut is set to <c>true</c>, this parameter is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>String</para>
        /// </summary>
        [NameInMap("OrderParams")]
        [Validation(Required=false)]
        public string OrderParams { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3A40BE4E-1890-4972-889C-FEFA37663635</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyRules Rules { get; set; }
        public class DescribePriceResponseBodyRules : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodyRulesRule> Rule { get; set; }
            public class DescribePriceResponseBodyRulesRule : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public long? RuleDescId { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        [NameInMap("SubOrders")]
        [Validation(Required=false)]
        public DescribePriceResponseBodySubOrders SubOrders { get; set; }
        public class DescribePriceResponseBodySubOrders : TeaModel {
            [NameInMap("SubOrder")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodySubOrdersSubOrder> SubOrder { get; set; }
            public class DescribePriceResponseBodySubOrdersSubOrder : TeaModel {
                [NameInMap("ContractActivity")]
                [Validation(Required=false)]
                public bool? ContractActivity { get; set; }

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

                    [NameInMap("ContractActivity")]
                    [Validation(Required=false)]
                    public DescribePriceResponseBodySubOrdersSubOrderDepreciateInfoContractActivity ContractActivity { get; set; }
                    public class DescribePriceResponseBodySubOrdersSubOrderDepreciateInfoContractActivity : TeaModel {
                        [NameInMap("ActivityId")]
                        [Validation(Required=false)]
                        public long? ActivityId { get; set; }

                        [NameInMap("ActivityName")]
                        [Validation(Required=false)]
                        public string ActivityName { get; set; }

                        [NameInMap("FinalFee")]
                        [Validation(Required=false)]
                        public double? FinalFee { get; set; }

                        [NameInMap("FinalPromFee")]
                        [Validation(Required=false)]
                        public double? FinalPromFee { get; set; }

                        [NameInMap("OptionCode")]
                        [Validation(Required=false)]
                        public string OptionCode { get; set; }

                        [NameInMap("OptionIds")]
                        [Validation(Required=false)]
                        public DescribePriceResponseBodySubOrdersSubOrderDepreciateInfoContractActivityOptionIds OptionIds { get; set; }
                        public class DescribePriceResponseBodySubOrdersSubOrderDepreciateInfoContractActivityOptionIds : TeaModel {
                            [NameInMap("OptionId")]
                            [Validation(Required=false)]
                            public List<long?> OptionId { get; set; }

                        }

                        [NameInMap("ProdFee")]
                        [Validation(Required=false)]
                        public double? ProdFee { get; set; }

                    }

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

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public string DiscountAmount { get; set; }

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
                        [NameInMap("ContractActivity")]
                        [Validation(Required=false)]
                        public bool? ContractActivity { get; set; }

                        [NameInMap("DepreciateInfo")]
                        [Validation(Required=false)]
                        public DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstanceDepreciateInfo DepreciateInfo { get; set; }
                        public class DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstanceDepreciateInfo : TeaModel {
                            [NameInMap("CheapRate")]
                            [Validation(Required=false)]
                            public double? CheapRate { get; set; }

                            [NameInMap("CheapStandAmount")]
                            [Validation(Required=false)]
                            public double? CheapStandAmount { get; set; }

                            [NameInMap("Differential")]
                            [Validation(Required=false)]
                            public double? Differential { get; set; }

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
                            public double? ListPrice { get; set; }

                            [NameInMap("MonthPrice")]
                            [Validation(Required=false)]
                            public double? MonthPrice { get; set; }

                            [NameInMap("OriginalStandAmount")]
                            [Validation(Required=false)]
                            public double? OriginalStandAmount { get; set; }

                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                        }

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
                        [NameInMap("ActivityExtInfo")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> ActivityExtInfo { get; set; }

                        [NameInMap("DerivedPromType")]
                        [Validation(Required=false)]
                        public string DerivedPromType { get; set; }

                        [NameInMap("FinalPromFee")]
                        [Validation(Required=false)]
                        public double? FinalPromFee { get; set; }

                        [NameInMap("OptionCode")]
                        [Validation(Required=false)]
                        public string OptionCode { get; set; }

                        [NameInMap("PromType")]
                        [Validation(Required=false)]
                        public string PromType { get; set; }

                        [NameInMap("PromotionCode")]
                        [Validation(Required=false)]
                        public string PromotionCode { get; set; }

                        [NameInMap("PromotionId")]
                        [Validation(Required=false)]
                        public long? PromotionId { get; set; }

                        [NameInMap("PromotionName")]
                        [Validation(Required=false)]
                        public string PromotionName { get; set; }

                    }

                }

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

                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public string TradeAmount { get; set; }

            }

        }

    }

}
