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

            /// <summary>
            /// <para>Details about coupons.</para>
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
                    /// <para>The coupon ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>youhuiquan_promotion_option_id_for_blank</para>
                    /// </summary>
                    [NameInMap("CouponNo")]
                    [Validation(Required=false)]
                    public string CouponNo { get; set; }

                    /// <summary>
                    /// <para>The coupon description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>coupondemo</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the coupon is selected.</para>
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
                    /// <para>test</para>
                    /// </summary>
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

            /// <summary>
            /// <para>The rule IDs.</para>
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

        /// <summary>
        /// <para>Details about promotion rules.</para>
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
                /// <para>The name of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111111111</para>
                /// </summary>
                [NameInMap("RuleDescId")]
                [Validation(Required=false)]
                public long? RuleDescId { get; set; }

                /// <summary>
                /// <para>The title of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <para>The orders that match the coupons.</para>
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
                /// <para>Indicates whether eligibility for the contracted discount is met.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
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
                    /// <hr>
                    /// </summary>
                    [NameInMap("CheapRate")]
                    [Validation(Required=false)]
                    public long? CheapRate { get; set; }

                    /// <summary>
                    /// <para>The new total price displayed on the official website.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("CheapStandAmount")]
                    [Validation(Required=false)]
                    public long? CheapStandAmount { get; set; }

                    /// <summary>
                    /// <para>The contract promotion.</para>
                    /// </summary>
                    [NameInMap("ContractActivity")]
                    [Validation(Required=false)]
                    public DescribePriceResponseBodySubOrdersSubOrderDepreciateInfoContractActivity ContractActivity { get; set; }
                    public class DescribePriceResponseBodySubOrdersSubOrderDepreciateInfoContractActivity : TeaModel {
                        /// <summary>
                        /// <para>The activity ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1412025702634847</para>
                        /// </summary>
                        [NameInMap("ActivityId")]
                        [Validation(Required=false)]
                        public long? ActivityId { get; set; }

                        /// <summary>
                        /// <para>The activity name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("ActivityName")]
                        [Validation(Required=false)]
                        public string ActivityName { get; set; }

                        /// <summary>
                        /// <para>The preferential price.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("FinalFee")]
                        [Validation(Required=false)]
                        public double? FinalFee { get; set; }

                        /// <summary>
                        /// <para>The total discount amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("FinalPromFee")]
                        [Validation(Required=false)]
                        public double? FinalPromFee { get; set; }

                        /// <summary>
                        /// <para>The promotion ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
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
                    /// <hr>
                    /// </summary>
                    [NameInMap("Differential")]
                    [Validation(Required=false)]
                    public long? Differential { get; set; }

                    /// <summary>
                    /// <para>The name of the promotional offer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
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
                    /// <para>The list price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("ListPrice")]
                    [Validation(Required=false)]
                    public long? ListPrice { get; set; }

                    /// <summary>
                    /// <para>The monthly price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("MonthPrice")]
                    [Validation(Required=false)]
                    public long? MonthPrice { get; set; }

                    /// <summary>
                    /// <para>The original total price displayed on the official website.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("OriginalStandAmount")]
                    [Validation(Required=false)]
                    public long? OriginalStandAmount { get; set; }

                    /// <summary>
                    /// <para>The start time of the activity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-11-18T00:00:00Z</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

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
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp1xxxxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Indicates whether eligibility for the contracted discount is met.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("IsContractActivity")]
                [Validation(Required=false)]
                public bool? IsContractActivity { get; set; }

                /// <summary>
                /// <para>The configuration details for each instance of an order line item.</para>
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
                        /// <para>Indicates whether eligibility for the contracted discount is met.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("ContractActivity")]
                        [Validation(Required=false)]
                        public bool? ContractActivity { get; set; }

                        /// <summary>
                        /// <para>The price reduction information.</para>
                        /// </summary>
                        [NameInMap("DepreciateInfo")]
                        [Validation(Required=false)]
                        public DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstanceDepreciateInfo DepreciateInfo { get; set; }
                        public class DescribePriceResponseBodySubOrdersSubOrderModuleInstanceModuleInstanceDepreciateInfo : TeaModel {
                            /// <summary>
                            /// <para>The price reduction rate.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <hr>
                            /// </summary>
                            [NameInMap("CheapRate")]
                            [Validation(Required=false)]
                            public double? CheapRate { get; set; }

                            /// <summary>
                            /// <para>The new total price displayed on the official website.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <hr>
                            /// </summary>
                            [NameInMap("CheapStandAmount")]
                            [Validation(Required=false)]
                            public double? CheapStandAmount { get; set; }

                            /// <summary>
                            /// <para>The promotional offer (displayed in the total order amount).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <hr>
                            /// </summary>
                            [NameInMap("Differential")]
                            [Validation(Required=false)]
                            public double? Differential { get; set; }

                            /// <summary>
                            /// <para>The name of the promotional offer.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <hr>
                            /// </summary>
                            [NameInMap("DifferentialName")]
                            [Validation(Required=false)]
                            public string DifferentialName { get; set; }

                            /// <summary>
                            /// <para>Indicates whether eligibility for the contracted discount is met.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <hr>
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
                            /// <hr>
                            /// </summary>
                            [NameInMap("ListPrice")]
                            [Validation(Required=false)]
                            public double? ListPrice { get; set; }

                            /// <summary>
                            /// <para>The monthly price.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <hr>
                            /// </summary>
                            [NameInMap("MonthPrice")]
                            [Validation(Required=false)]
                            public double? MonthPrice { get; set; }

                            /// <summary>
                            /// <para>The original total price displayed on the official website.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <hr>
                            /// </summary>
                            [NameInMap("OriginalStandAmount")]
                            [Validation(Required=false)]
                            public double? OriginalStandAmount { get; set; }

                            /// <summary>
                            /// <para>The start time of the activity.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2024-09-23T14:00:01Z</para>
                            /// </summary>
                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                        }

                        /// <summary>
                        /// <para>The discount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("DiscountFee")]
                        [Validation(Required=false)]
                        public double? DiscountFee { get; set; }

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
                                /// <hr>
                                /// </summary>
                                [NameInMap("Code")]
                                [Validation(Required=false)]
                                public string Code { get; set; }

                                /// <summary>
                                /// <para>The attribute name.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <hr>
                                /// </summary>
                                [NameInMap("Name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                /// <summary>
                                /// <para>The attribute type.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <hr>
                                /// </summary>
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public long? Type { get; set; }

                                /// <summary>
                                /// <para>The attribute value.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <hr>
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
                        /// <hr>
                        /// </summary>
                        [NameInMap("ModuleCode")]
                        [Validation(Required=false)]
                        public string ModuleCode { get; set; }

                        /// <summary>
                        /// <para>The module ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("ModuleId")]
                        [Validation(Required=false)]
                        public string ModuleId { get; set; }

                        /// <summary>
                        /// <para>The module name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
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
                        /// <hr>
                        /// </summary>
                        [NameInMap("PricingModule")]
                        [Validation(Required=false)]
                        public bool? PricingModule { get; set; }

                        /// <summary>
                        /// <para>The discounted price.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("StandPrice")]
                        [Validation(Required=false)]
                        public double? StandPrice { get; set; }

                        /// <summary>
                        /// <para>The original price of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.0</para>
                        /// </summary>
                        [NameInMap("TotalProductFee")]
                        [Validation(Required=false)]
                        public double? TotalProductFee { get; set; }

                    }

                }

                /// <summary>
                /// <para>The optional promotions.</para>
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
                        /// <para>The additional activity information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("ActivityExtInfo")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> ActivityExtInfo { get; set; }

                        /// <summary>
                        /// <para>The amount that can be deducted by using the coupon.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("CanPromFee")]
                        [Validation(Required=false)]
                        public string CanPromFee { get; set; }

                        /// <summary>
                        /// <para>Indicates whether coupons are used. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>default or null (default): Coupons are used.</description></item>
                        /// <item><description>youhuiquan_promotion_option_id_for_blank: Coupons are not used.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>default</para>
                        /// </summary>
                        [NameInMap("CouponNo")]
                        [Validation(Required=false)]
                        public string CouponNo { get; set; }

                        /// <summary>
                        /// <para>The description of the coupon.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The coupon name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The promotion code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("OptionCode")]
                        [Validation(Required=false)]
                        public string OptionCode { get; set; }

                        /// <summary>
                        /// <para>The promotion name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("PromotionName")]
                        [Validation(Required=false)]
                        public string PromotionName { get; set; }

                        /// <summary>
                        /// <para>The promotion ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>youhuiquan_promotion_option_id_for_blank</para>
                        /// </summary>
                        [NameInMap("PromotionOptionNo")]
                        [Validation(Required=false)]
                        public string PromotionOptionNo { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the promotion option is selected.</para>
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
                        /// <para>False</para>
                        /// </summary>
                        [NameInMap("Show")]
                        [Validation(Required=false)]
                        public bool? Show { get; set; }

                    }

                }

                /// <summary>
                /// <para>The original price of the order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.21</para>
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public string OriginalAmount { get; set; }

                /// <summary>
                /// <para>Details about promotions.</para>
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
                        /// <hr>
                        /// </summary>
                        [NameInMap("ActivityExtInfo")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> ActivityExtInfo { get; set; }

                        /// <summary>
                        /// <para>The derived promotion type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("DerivedPromType")]
                        [Validation(Required=false)]
                        public string DerivedPromType { get; set; }

                        /// <summary>
                        /// <para>The discount amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("FinalPromFee")]
                        [Validation(Required=false)]
                        public double? FinalPromFee { get; set; }

                        /// <summary>
                        /// <para>The coupon code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("OptionCode")]
                        [Validation(Required=false)]
                        public string OptionCode { get; set; }

                        /// <summary>
                        /// <para>The promotion type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("PromType")]
                        [Validation(Required=false)]
                        public string PromType { get; set; }

                        /// <summary>
                        /// <para>The promotion code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("PromotionCode")]
                        [Validation(Required=false)]
                        public string PromotionCode { get; set; }

                        /// <summary>
                        /// <para>The promotion ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("PromotionId")]
                        [Validation(Required=false)]
                        public long? PromotionId { get; set; }

                        /// <summary>
                        /// <para>The promotion name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <hr>
                        /// </summary>
                        [NameInMap("PromotionName")]
                        [Validation(Required=false)]
                        public string PromotionName { get; set; }

                    }

                }

                /// <summary>
                /// <para>The hit rule IDs.</para>
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
                /// <para>The discounted price.</para>
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
                /// <hr>
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

        }

    }

}
