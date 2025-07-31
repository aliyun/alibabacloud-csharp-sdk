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

            /// <summary>
            /// <para>The information of coupons.</para>
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
                    /// <para>The activity type of the coupon. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>payondemand</b>: subscription</description></item>
                    /// <item><description><b>payasyougo</b>: pay-as-you-go</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>payondemand</para>
                    /// </summary>
                    [NameInMap("ActivityCategory")]
                    [Validation(Required=false)]
                    public string ActivityCategory { get; set; }

                    /// <summary>
                    /// <para>The coupon ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>youhuiquan_promotion_option_id_for_blank</para>
                    /// </summary>
                    [NameInMap("CouponNo")]
                    [Validation(Required=false)]
                    public string CouponNo { get; set; }

                    /// <summary>
                    /// <para>The description of the coupon.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ceshi</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the coupon was selected. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsSelected")]
                    [Validation(Required=false)]
                    public string IsSelected { get; set; }

                    /// <summary>
                    /// <para>The coupon name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>youhuiquan111</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The code of the coupon.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>youhui_quan</para>
                    /// </summary>
                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                    /// <summary>
                    /// <para>The promotional option code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>youhui_quan</para>
                    /// </summary>
                    [NameInMap("PromotionOptionCode")]
                    [Validation(Required=false)]
                    public string PromotionOptionCode { get; set; }

                    /// <summary>
                    /// <para>The IDs of the rules that correspond to the coupon.</para>
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

                    /// <summary>
                    /// <para>The promotion IDs.</para>
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

            /// <summary>
            /// <para>The rules of the order.</para>
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

        /// <summary>
        /// <para>The promotion rules.</para>
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
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demoname</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2075****</para>
                /// </summary>
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public long? RuleDescId { get; set; }

                /// <summary>
                /// <para>The rule title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <para>The coupon rules.</para>
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
                /// <para>Indicates whether the contract promotion is hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ContractActivity")]
                [Validation(Required=false)]
                public bool? ContractActivity { get; set; }

                /// <summary>
                /// <para>The price reduction information.</para>
                /// </summary>
                [NameInMap("DepreciateInfo")]
                [Validation(Required=false)]
                public DescribePriceResponseBodySubOrdersSubOrderDepreciateInfo DepreciateInfo { get; set; }
                public class DescribePriceResponseBodySubOrdersSubOrderDepreciateInfo : TeaModel {
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
                    /// <para>The activity information.</para>
                    /// </summary>
                    [NameInMap("ContractActivity")]
                    [Validation(Required=false)]
                    public DescribePriceResponseBodySubOrdersSubOrderDepreciateInfoContractActivity ContractActivity { get; set; }
                    public class DescribePriceResponseBodySubOrdersSubOrderDepreciateInfoContractActivity : TeaModel {
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

                        /// <summary>
                        /// <para>The promotion IDs.</para>
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

                    /// <summary>
                    /// <para>The start time of the activity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-02-29 10:30:00</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

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
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dds-bp1b6e54e7cc****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

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
                /// <para>Indicates whether the discount is hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsNewOfficialActivity")]
                [Validation(Required=false)]
                public string IsNewOfficialActivity { get; set; }

                /// <summary>
                /// <para>The configuration item of the instance in the order.</para>
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
                        /// <para>Indicates whether the contract promotion is hit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("ContractActivity")]
                        [Validation(Required=false)]
                        public bool? ContractActivity { get; set; }

                        /// <summary>
                        /// <para>The cycle fee of the module.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.0</para>
                        /// </summary>
                        [NameInMap("CycleFee")]
                        [Validation(Required=false)]
                        public string CycleFee { get; set; }

                        /// <summary>
                        /// <para>The activity information.</para>
                        /// </summary>
                        [NameInMap("DepreciateInfo")]
                        [Validation(Required=false)]
                        public DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstanceDepreciateInfo DepreciateInfo { get; set; }
                        public class DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstanceDepreciateInfo : TeaModel {
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
                        /// <para>The discount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.0</para>
                        /// </summary>
                        [NameInMap("DiscountFee")]
                        [Validation(Required=false)]
                        public string DiscountFee { get; set; }

                        /// <summary>
                        /// <para>The module attributes.</para>
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
                                /// <para>The attribute code.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>dds_dbtype</para>
                                /// </summary>
                                [NameInMap("Code")]
                                [Validation(Required=false)]
                                public string Code { get; set; }

                                /// <summary>
                                /// <para>The attribute name.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>MongoDB</para>
                                /// </summary>
                                [NameInMap("Name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                /// <summary>
                                /// <para>The attribute type.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>3</para>
                                /// </summary>
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                                /// <summary>
                                /// <para>The attribute value.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>MongoDB</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The module code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dds_dbtype</para>
                        /// </summary>
                        [NameInMap("ModuleCode")]
                        [Validation(Required=false)]
                        public string ModuleCode { get; set; }

                        /// <summary>
                        /// <para>The module ID</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1017110000415xxx</para>
                        /// </summary>
                        [NameInMap("ModuleId")]
                        [Validation(Required=false)]
                        public long? ModuleId { get; set; }

                        /// <summary>
                        /// <para>The module name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>database type</para>
                        /// </summary>
                        [NameInMap("ModuleName")]
                        [Validation(Required=false)]
                        public string ModuleName { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the order is paid.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("NeedOrderPay")]
                        [Validation(Required=false)]
                        public bool? NeedOrderPay { get; set; }

                        /// <summary>
                        /// <para>The actual amount paid.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.0</para>
                        /// </summary>
                        [NameInMap("PayFee")]
                        [Validation(Required=false)]
                        public double? PayFee { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the item is billed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("PricingModule")]
                        [Validation(Required=false)]
                        public bool? PricingModule { get; set; }

                        /// <summary>
                        /// <para>The promotion details.</para>
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
                                /// <para>The additional promotion information.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>{
                                ///     &quot;activityId&quot;: &quot;1512010241743170&quot;
                                /// }</para>
                                /// </summary>
                                [NameInMap("ActivityExtInfo")]
                                [Validation(Required=false)]
                                public Dictionary<string, object> ActivityExtInfo { get; set; }

                                /// <summary>
                                /// <para>The sub-type of the promotion.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>subPrice</para>
                                /// </summary>
                                [NameInMap("DerivedPromType")]
                                [Validation(Required=false)]
                                public string DerivedPromType { get; set; }

                                /// <summary>
                                /// <para>The discount amount.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>0.0</para>
                                /// </summary>
                                [NameInMap("FinalPromFee")]
                                [Validation(Required=false)]
                                public double? FinalPromFee { get; set; }

                                /// <summary>
                                /// <para>The code of the commodity to which the coupon can be applied.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>wanhua_activity</para>
                                /// </summary>
                                [NameInMap("OptionCode")]
                                [Validation(Required=false)]
                                public string OptionCode { get; set; }

                                /// <summary>
                                /// <para>The sub-type of the promotion.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>discount</para>
                                /// </summary>
                                [NameInMap("PromType")]
                                [Validation(Required=false)]
                                public string PromType { get; set; }

                                /// <summary>
                                /// <para>The coupon code.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>aliwood-xxx</para>
                                /// </summary>
                                [NameInMap("PromotionCode")]
                                [Validation(Required=false)]
                                public string PromotionCode { get; set; }

                                /// <summary>
                                /// <para>The ID of the promotional activity.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>8105187xxxx</para>
                                /// </summary>
                                [NameInMap("PromotionId")]
                                [Validation(Required=false)]
                                public long? PromotionId { get; set; }

                                /// <summary>
                                /// <para>The promotional activity name.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>[Item with price reduction in x xxxx] ApsaraDB for MongoDB instances of a full range of specifications - xxxxx</para>
                                /// </summary>
                                [NameInMap("PromotionName")]
                                [Validation(Required=false)]
                                public string PromotionName { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The discounted price.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>451.00</para>
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

                        /// <summary>
                        /// <para>The original price of the product.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.0</para>
                        /// </summary>
                        [NameInMap("TotalProductFee")]
                        [Validation(Required=false)]
                        public double? TotalProductFee { get; set; }

                        /// <summary>
                        /// <para>The price type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>monthPrice</para>
                        /// </summary>
                        [NameInMap("priceType")]
                        [Validation(Required=false)]
                        public string PriceType { get; set; }

                        /// <summary>
                        /// <para>The unit of the price.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xxxx</para>
                        /// </summary>
                        [NameInMap("priceUnit")]
                        [Validation(Required=false)]
                        public string PriceUnit { get; set; }

                    }

                }

                /// <summary>
                /// <para>The promotional options that can be configured.</para>
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
                        /// <para>The activity type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>discount</para>
                        /// </summary>
                        [NameInMap("ActivityCategory")]
                        [Validation(Required=false)]
                        public string ActivityCategory { get; set; }

                        /// <summary>
                        /// <para>The additional activity information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///     &quot;activityId&quot;: &quot;1512010241743170&quot;
                        /// }</para>
                        /// </summary>
                        [NameInMap("ActivityExtInfo")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> ActivityExtInfo { get; set; }

                        /// <summary>
                        /// <para>The amount that can be deducted by using the coupon.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4560789</para>
                        /// </summary>
                        [NameInMap("CanPromFee")]
                        [Validation(Required=false)]
                        public double? CanPromFee { get; set; }

                        /// <summary>
                        /// <para>The promotion type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>wanhua_activity</para>
                        /// </summary>
                        [NameInMap("OptionCode")]
                        [Validation(Required=false)]
                        public string OptionCode { get; set; }

                        /// <summary>
                        /// <para>The promotion name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[Item with price reduction in xxx] ApsaraDB for MongoDB instances of a full range of specifications - xxx</para>
                        /// </summary>
                        [NameInMap("PromotionName")]
                        [Validation(Required=false)]
                        public string PromotionName { get; set; }

                        /// <summary>
                        /// <para>The promotion ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1512010241xxxxx</para>
                        /// </summary>
                        [NameInMap("PromotionOptionNo")]
                        [Validation(Required=false)]
                        public string PromotionOptionNo { get; set; }

                        /// <summary>
                        /// <para>The promotion IDs.</para>
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
                        /// <para>Indicates whether</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Selected")]
                        [Validation(Required=false)]
                        public bool? Selected { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the discount is displayed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Show")]
                        [Validation(Required=false)]
                        public bool? Show { get; set; }

                        /// <summary>
                        /// <para>The specification codes of the product.</para>
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
                /// <para>The original price of the order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>322.4</para>
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public string OriginalAmount { get; set; }

                /// <summary>
                /// <para>The promotion details.</para>
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
                        /// <para>The additional activity information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{
                        ///     &quot;activityId&quot;: &quot;1512010241743170&quot;
                        /// }</para>
                        /// </summary>
                        [NameInMap("ActivityExtInfo")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> ActivityExtInfo { get; set; }

                        /// <summary>
                        /// <para>The sub-type of the promotion.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>subPrice</para>
                        /// </summary>
                        [NameInMap("DerivedPromType")]
                        [Validation(Required=false)]
                        public string DerivedPromType { get; set; }

                        /// <summary>
                        /// <para>The discount amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.0</para>
                        /// </summary>
                        [NameInMap("FinalPromFee")]
                        [Validation(Required=false)]
                        public double? FinalPromFee { get; set; }

                        /// <summary>
                        /// <para>The code of the coupon.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>youhui_quan</para>
                        /// </summary>
                        [NameInMap("OptionCode")]
                        [Validation(Required=false)]
                        public string OptionCode { get; set; }

                        /// <summary>
                        /// <para>The sub-type of the promotion.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>discount</para>
                        /// </summary>
                        [NameInMap("PromType")]
                        [Validation(Required=false)]
                        public string PromType { get; set; }

                        /// <summary>
                        /// <para>The coupon code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ali-wood</para>
                        /// </summary>
                        [NameInMap("PromotionCode")]
                        [Validation(Required=false)]
                        public string PromotionCode { get; set; }

                        /// <summary>
                        /// <para>The promotion ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>233xxxxx</para>
                        /// </summary>
                        [NameInMap("PromotionId")]
                        [Validation(Required=false)]
                        public long? PromotionId { get; set; }

                        /// <summary>
                        /// <para>The name of the promotional activity.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[Item with price reduction in x xxxx] ApsaraDB for MongoDB instances of a full range of specifications - xxxxx</para>
                        /// </summary>
                        [NameInMap("PromotionName")]
                        [Validation(Required=false)]
                        public string PromotionName { get; set; }

                    }

                }

                /// <summary>
                /// <para>The activity rules.</para>
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
                /// <para>The discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8687</para>
                /// </summary>
                [NameInMap("StandDiscountPrice")]
                [Validation(Required=false)]
                public double? StandDiscountPrice { get; set; }

                /// <summary>
                /// <para>The discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>62982</para>
                /// </summary>
                [NameInMap("StandPrice")]
                [Validation(Required=false)]
                public double? StandPrice { get; set; }

                /// <summary>
                /// <para>The actual price of the order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
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
