// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CommodityValue : TeaModel {
        /// <summary>
        /// <para>Result模型。</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CommodityValueResult Result { get; set; }
        public class CommodityValueResult : TeaModel {
            /// <summary>
            /// <para>订单信息。</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public CommodityValueResultOrder Order { get; set; }
            public class CommodityValueResultOrder : TeaModel {
                /// <summary>
                /// <para>货币代码。</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>优惠后。</para>
                /// 
                /// <b>Example:</b>
                /// <para>9.99</para>
                /// </summary>
                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public string TradeAmount { get; set; }

                /// <summary>
                /// <para>抵扣金额。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.99</para>
                /// </summary>
                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public string DiscountAmount { get; set; }

                /// <summary>
                /// <para>优惠前。</para>
                /// 
                /// <b>Example:</b>
                /// <para>11.98</para>
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public string OriginalAmount { get; set; }

            }

            /// <summary>
            /// <para>询价类型，可选值：</para>
            /// <ol>
            /// <item><description>Buy：新购询价。</description></item>
            /// <item><description>ModificationBuy：变配询价。</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>Buy</para>
            /// </summary>
            [NameInMap("InquiryType")]
            [Validation(Required=false)]
            public string InquiryType { get; set; }

            /// <summary>
            /// <para>订单子项。</para>
            /// </summary>
            [NameInMap("SubOrders")]
            [Validation(Required=false)]
            public CommodityValueResultSubOrders SubOrders { get; set; }
            public class CommodityValueResultSubOrders : TeaModel {
                /// <summary>
                /// <para>订单子项。</para>
                /// </summary>
                [NameInMap("SubOrder")]
                [Validation(Required=false)]
                public List<CommodityValueResultSubOrdersSubOrder> SubOrder { get; set; }
                public class CommodityValueResultSubOrdersSubOrder : TeaModel {
                    /// <summary>
                    /// <para>模块（实例）信息。</para>
                    /// </summary>
                    [NameInMap("ModuleInstance")]
                    [Validation(Required=false)]
                    public List<CommodityValueResultSubOrdersSubOrderModuleInstance> ModuleInstance { get; set; }
                    public class CommodityValueResultSubOrdersSubOrderModuleInstance : TeaModel {
                        /// <summary>
                        /// <para>模块ID。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1234</para>
                        /// </summary>
                        [NameInMap("ModuleId")]
                        [Validation(Required=false)]
                        public long? ModuleId { get; set; }

                        /// <summary>
                        /// <para>模块名称。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Rds</para>
                        /// </summary>
                        [NameInMap("ModuleName")]
                        [Validation(Required=false)]
                        public string ModuleName { get; set; }

                        /// <summary>
                        /// <para>模块代码。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rds_dbtype</para>
                        /// </summary>
                        [NameInMap("ModuleCode")]
                        [Validation(Required=false)]
                        public string ModuleCode { get; set; }

                        /// <summary>
                        /// <para>产品原价（元）。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10.00</para>
                        /// </summary>
                        [NameInMap("TotalProductFee")]
                        [Validation(Required=false)]
                        public double? TotalProductFee { get; set; }

                        /// <summary>
                        /// <para>折扣费用（元）。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1.99</para>
                        /// </summary>
                        [NameInMap("DiscountFee")]
                        [Validation(Required=false)]
                        public double? DiscountFee { get; set; }

                        /// <summary>
                        /// <para>实付金额（元）。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8.01</para>
                        /// </summary>
                        [NameInMap("PayFee")]
                        [Validation(Required=false)]
                        public double? PayFee { get; set; }

                        /// <summary>
                        /// <para>价格单位。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>元/GB/小时</para>
                        /// </summary>
                        [NameInMap("PriceUnit")]
                        [Validation(Required=false)]
                        public string PriceUnit { get; set; }

                        /// <summary>
                        /// <para>是否计价项。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("IsPricingModule")]
                        [Validation(Required=false)]
                        public bool? IsPricingModule { get; set; }

                        /// <summary>
                        /// <para>在订单中是否需要支付。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("NeedOrderPay")]
                        [Validation(Required=false)]
                        public bool? NeedOrderPay { get; set; }

                        /// <summary>
                        /// <para>定价类型。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>hourPrice</para>
                        /// </summary>
                        [NameInMap("PriceType")]
                        [Validation(Required=false)]
                        public string PriceType { get; set; }

                        /// <summary>
                        /// <para>模块属性。</para>
                        /// </summary>
                        [NameInMap("ModuleAttrs")]
                        [Validation(Required=false)]
                        public List<CommodityValueResultSubOrdersSubOrderModuleInstanceModuleAttrs> ModuleAttrs { get; set; }
                        public class CommodityValueResultSubOrdersSubOrderModuleInstanceModuleAttrs : TeaModel {
                            /// <summary>
                            /// <para>属性类型，可选值：</para>
                            /// <ol>
                            /// <item><description>1：商品属性 </description></item>
                            /// <item><description>2：规格属性 </description></item>
                            /// <item><description>3：模块属性 </description></item>
                            /// <item><description>4：外部参数（备用）</description></item>
                            /// </ol>
                            /// 
                            /// <b>Example:</b>
                            /// <para>3</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public long? Type { get; set; }

                            /// <summary>
                            /// <para>Name</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>20GB</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>Module attr code</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>rds_storage</para>
                            /// </summary>
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public string Code { get; set; }

                            /// <summary>
                            /// <para>Value</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>20</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                            /// <summary>
                            /// <para>Unit</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>GB</para>
                            /// </summary>
                            [NameInMap("Unit")]
                            [Validation(Required=false)]
                            public string Unit { get; set; }

                        }

                    }

                }

            }

            /// <summary>
            /// <para>优惠券。</para>
            /// </summary>
            [NameInMap("Coupons")]
            [Validation(Required=false)]
            public List<CommodityValueResultCoupons> Coupons { get; set; }
            public class CommodityValueResultCoupons : TeaModel {
                /// <summary>
                /// <para>可支付金额。</para>
                /// 
                /// <b>Example:</b>
                /// <para>9.99</para>
                /// </summary>
                [NameInMap("CanPromFee")]
                [Validation(Required=false)]
                public double? CanPromFee { get; set; }

                /// <summary>
                /// <para>Coupon Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>10元优惠券（有效期至2024年9月8日）</para>
                /// </summary>
                [NameInMap("CouponDesc")]
                [Validation(Required=false)]
                public string CouponDesc { get; set; }

                /// <summary>
                /// <para>Coupon Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>10元优惠券</para>
                /// </summary>
                [NameInMap("CouponName")]
                [Validation(Required=false)]
                public string CouponName { get; set; }

                /// <summary>
                /// <para>Coupon OptionNo</para>
                /// 
                /// <b>Example:</b>
                /// <para>50008800000xxxx</para>
                /// </summary>
                [NameInMap("CouponOptionNo")]
                [Validation(Required=false)]
                public string CouponOptionNo { get; set; }

                /// <summary>
                /// <para>是否选中。</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Selected")]
                [Validation(Required=false)]
                public bool? Selected { get; set; }

            }

        }

    }

}
