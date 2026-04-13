// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The order information.</para>
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

            /// <summary>
            /// <para>Indicates whether the contract promotion is hit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ContractActivity")]
            [Validation(Required=false)]
            public bool? ContractActivity { get; set; }

            [NameInMap("Coupons")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyOrderCoupons Coupons { get; set; }
            public class DescribePriceResponseBodyOrderCoupons : TeaModel {
                [NameInMap("Coupon")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyOrderCouponsCoupon> Coupon { get; set; }
                public class DescribePriceResponseBodyOrderCouponsCoupon : TeaModel {
                    [NameInMap("ActivityCategory")]
                    [Validation(Required=false)]
                    public string ActivityCategory { get; set; }

                    [NameInMap("ActivityExtInfo")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ActivityExtInfo { get; set; }

                    [NameInMap("CouponNo")]
                    [Validation(Required=false)]
                    public string CouponNo { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Effective")]
                    [Validation(Required=false)]
                    public bool? Effective { get; set; }

                    [NameInMap("IsSelected")]
                    [Validation(Required=false)]
                    public string IsSelected { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                    [NameInMap("PromotionOptionCode")]
                    [Validation(Required=false)]
                    public string PromotionOptionCode { get; set; }

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
            /// <para>The currency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USD</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The price reduction information.</para>
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
                public double? CheapRate { get; set; }

                /// <summary>
                /// <para>The new total price displayed on the official website.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9*</para>
                /// </summary>
                [NameInMap("CheapStandAmount")]
                [Validation(Required=false)]
                public double? CheapStandAmount { get; set; }

                /// <summary>
                /// <para>The contract promotion.</para>
                /// </summary>
                [NameInMap("ContractActivity")]
                [Validation(Required=false)]
                public DescribePriceResponseBodyOrderDepreciateInfoContractActivity ContractActivity { get; set; }
                public class DescribePriceResponseBodyOrderDepreciateInfoContractActivity : TeaModel {
                    /// <summary>
                    /// <para>The activity ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>41120065996xxxxx</para>
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
                    /// <para>The price after the promotion.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20522.4</para>
                    /// </summary>
                    [NameInMap("FinalFee")]
                    [Validation(Required=false)]
                    public double? FinalFee { get; set; }

                    /// <summary>
                    /// <para>The total discount amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3621.6</para>
                    /// </summary>
                    [NameInMap("FinalPromFee")]
                    [Validation(Required=false)]
                    public double? FinalPromFee { get; set; }

                    /// <summary>
                    /// <para>The promotion ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>wanhua_activity</para>
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
                    /// <para>24144.0</para>
                    /// </summary>
                    [NameInMap("ProdFee")]
                    [Validation(Required=false)]
                    public double? ProdFee { get; set; }

                }

                /// <summary>
                /// <para>The price difference displayed in the total order amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>**</para>
                /// </summary>
                [NameInMap("Differential")]
                [Validation(Required=false)]
                public double? Differential { get; set; }

                /// <summary>
                /// <para>The name of the price difference.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXXXX</para>
                /// </summary>
                [NameInMap("DifferentialName")]
                [Validation(Required=false)]
                public string DifferentialName { get; set; }

                /// <summary>
                /// <para>Indicates whether the contract promotion is hit.</para>
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
                public string IsShow { get; set; }

                /// <summary>
                /// <para>The list price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1*</para>
                /// </summary>
                [NameInMap("ListPrice")]
                [Validation(Required=false)]
                public double? ListPrice { get; set; }

                /// <summary>
                /// <para>The monthly price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>**</para>
                /// </summary>
                [NameInMap("MonthPrice")]
                [Validation(Required=false)]
                public double? MonthPrice { get; set; }

                /// <summary>
                /// <para>The original total price displayed on the official website.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12*</para>
                /// </summary>
                [NameInMap("OriginalStandAmount")]
                [Validation(Required=false)]
                public double? OriginalStandAmount { get; set; }

            }

            /// <summary>
            /// <para>The discount amount of the order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>322.4</para>
            /// </summary>
            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public string DiscountAmount { get; set; }

            /// <summary>
            /// <para>Indicates whether the contract promotion is hit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsContractActivity")]
            [Validation(Required=false)]
            public bool? IsContractActivity { get; set; }

            /// <summary>
            /// <para>The order information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The promotional activity information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\”activityCategory\”:\”discount\”,\”activityExtInfo\”:{\”noUseYouhuiquan\”:\”true\”,\”activityId\”:\”191156098xxxx\”,\”activityExtraAttr\”:\”{\\\\”forbiddenCpsProfit\\\\”:\\\\”true\\\\”,\\\\”forbiddenCouponsRestricted\\\\”:\\\\”true\\\\”,\\\\”forbiddenAmbassadorProfit\\\\”:\\\\”true\\\\”}\”,\”isActivityIdFromWanHuaTong\”:\”true\”,\”isContractActivity\”:\”false\”},\”canPromFee\”:906130,\”optionCode\”:\”wanhua_activity\”,\”promotionName\”:\”FY24--MongoDB replica set - first-time purchase - \* discount for a one-year period - first-time purchase benefits\”,\”promotionOptionNo\”:\”19115609882xxxx\”,\”promotionRuleIdList\”:[2091xxxx],\”selected\”:true,\”targetArticleItemCodes\”:[]},{\”activityCategory\”:\”discount\”,\”activityExtInfo\”:{\”activityId\”:\”1018040010xxxxx\”,\”wanHuaOrderExpireSec\”:\”604800\”,\”isActivityIdFromWanHuaTong\”:\”true\”,\”isContractActivity\”:\”false\”},\”canPromFee\”:339799,\”optionCode\”:\”wanhua_activity\”,\”promotionName\”:\”FY24--MongoDB discount for a one-year period \”,\”promotionOptionNo\”:\”10180400107xxxxx\”,\”promotionRuleIdList\”:[xxxxx],\”selected\”:false,\”targetArticleItemCodes\”:[]}]”</para>
            /// </summary>
            [NameInMap("OptionalPromotions")]
            [Validation(Required=false)]
            public string OptionalPromotions { get; set; }

            /// <summary>
            /// <para>The original price of the order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>322.4</para>
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public string OriginalAmount { get; set; }

            /// <summary>
            /// <para>The promotional activity that is hit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\”finalPromFee\”:90xxx,\”optionCode\”:\”wanhua_activity\”,\”promType\”:\”discount\”,\”promotionId\”:2091xxxx,\”promotionName\”:\”\* discount is provided for new users who purchase ApsaraDB for MongoDB replica set instances for one year. A new user can purchase an ApsaraDB for MongoDB replica set instance only by using the discount.\”}]”</para>
            /// </summary>
            [NameInMap("PromDetailList")]
            [Validation(Required=false)]
            public string PromDetailList { get; set; }

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
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ShowDiscountInfo")]
            [Validation(Required=false)]
            public bool? ShowDiscountInfo { get; set; }

            /// <summary>
            /// <para>The discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StandDiscountPrice")]
            [Validation(Required=false)]
            public double? StandDiscountPrice { get; set; }

            /// <summary>
            /// <para>The discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StandPrice")]
            [Validation(Required=false)]
            public double? StandPrice { get; set; }

            [NameInMap("TotalCostAmount")]
            [Validation(Required=false)]
            public double? TotalCostAmount { get; set; }

            /// <summary>
            /// <para>The final price of the order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TradeAmount")]
            [Validation(Required=false)]
            public string TradeAmount { get; set; }

        }

        /// <summary>
        /// <para>The order parameters.</para>
        /// <remarks>
        /// <para>This parameter is returned only when the <b>OrderParamOut</b> parameter is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;autoPay\&quot;:false}&quot;</para>
        /// </summary>
        [NameInMap("OrderParams")]
        [Validation(Required=false)]
        public string OrderParams { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27227A3D-6B86-56F3-9E03-9E60F001CE12</para>
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
                    public double? CheapRate { get; set; }

                    [NameInMap("CheapStandAmount")]
                    [Validation(Required=false)]
                    public double? CheapStandAmount { get; set; }

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
                    public double? Differential { get; set; }

                    [NameInMap("DifferentialName")]
                    [Validation(Required=false)]
                    public string DifferentialName { get; set; }

                    [NameInMap("IsContractActivity")]
                    [Validation(Required=false)]
                    public bool? IsContractActivity { get; set; }

                    [NameInMap("IsShow")]
                    [Validation(Required=false)]
                    public string IsShow { get; set; }

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

                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public string DiscountAmount { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("IsContractActivity")]
                [Validation(Required=false)]
                public bool? IsContractActivity { get; set; }

                [NameInMap("IsNewOfficialActivity")]
                [Validation(Required=false)]
                public string IsNewOfficialActivity { get; set; }

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

                        [NameInMap("CycleFee")]
                        [Validation(Required=false)]
                        public string CycleFee { get; set; }

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
                            public string IsShow { get; set; }

                            [NameInMap("ListPrice")]
                            [Validation(Required=false)]
                            public double? ListPrice { get; set; }

                            [NameInMap("MonthPrice")]
                            [Validation(Required=false)]
                            public double? MonthPrice { get; set; }

                            [NameInMap("OriginalStandAmount")]
                            [Validation(Required=false)]
                            public double? OriginalStandAmount { get; set; }

                        }

                        [NameInMap("DiscountFee")]
                        [Validation(Required=false)]
                        public string DiscountFee { get; set; }

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
                                public string Type { get; set; }

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
                        public long? ModuleId { get; set; }

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

                        [NameInMap("PromDetailList")]
                        [Validation(Required=false)]
                        public DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstancePromDetailList PromDetailList { get; set; }
                        public class DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstancePromDetailList : TeaModel {
                            [NameInMap("PromDetail")]
                            [Validation(Required=false)]
                            public List<DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstancePromDetailListPromDetail> PromDetail { get; set; }
                            public class DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstancePromDetailListPromDetail : TeaModel {
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

                        [NameInMap("StandDiscountPrice")]
                        [Validation(Required=false)]
                        public double? StandDiscountPrice { get; set; }

                        [NameInMap("StandPrice")]
                        [Validation(Required=false)]
                        public double? StandPrice { get; set; }

                        [NameInMap("TotalProductFee")]
                        [Validation(Required=false)]
                        public double? TotalProductFee { get; set; }

                        [NameInMap("UnitPriceUnit4Buy")]
                        [Validation(Required=false)]
                        public string UnitPriceUnit4Buy { get; set; }

                        [NameInMap("priceType")]
                        [Validation(Required=false)]
                        public string PriceType { get; set; }

                        [NameInMap("priceUnit")]
                        [Validation(Required=false)]
                        public string PriceUnit { get; set; }

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
                        [NameInMap("ActivityCategory")]
                        [Validation(Required=false)]
                        public string ActivityCategory { get; set; }

                        [NameInMap("ActivityExtInfo")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> ActivityExtInfo { get; set; }

                        [NameInMap("CanPromFee")]
                        [Validation(Required=false)]
                        public double? CanPromFee { get; set; }

                        [NameInMap("OptionCode")]
                        [Validation(Required=false)]
                        public string OptionCode { get; set; }

                        [NameInMap("PromotionName")]
                        [Validation(Required=false)]
                        public string PromotionName { get; set; }

                        [NameInMap("PromotionOptionNo")]
                        [Validation(Required=false)]
                        public string PromotionOptionNo { get; set; }

                        [NameInMap("PromotionRuleIdList")]
                        [Validation(Required=false)]
                        public DescribePriceResponseBodySubOrdersSubOrderOptionalPromotionsOptionalPromotionPromotionRuleIdList PromotionRuleIdList { get; set; }
                        public class DescribePriceResponseBodySubOrdersSubOrderOptionalPromotionsOptionalPromotionPromotionRuleIdList : TeaModel {
                            [NameInMap("promotionRuleId")]
                            [Validation(Required=false)]
                            public List<string> PromotionRuleId { get; set; }

                        }

                        [NameInMap("Selected")]
                        [Validation(Required=false)]
                        public bool? Selected { get; set; }

                        [NameInMap("Show")]
                        [Validation(Required=false)]
                        public bool? Show { get; set; }

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
                public double? StandDiscountPrice { get; set; }

                [NameInMap("StandPrice")]
                [Validation(Required=false)]
                public double? StandPrice { get; set; }

                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public string TradeAmount { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the trace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27227A3D-6B87-56F3-9E03-9E60F001****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
