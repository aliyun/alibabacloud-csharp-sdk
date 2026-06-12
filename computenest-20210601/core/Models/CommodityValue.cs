// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CommodityValue : TeaModel {
        /// <summary>
        /// <para>The Result model.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CommodityValueResult Result { get; set; }
        public class CommodityValueResult : TeaModel {
            /// <summary>
            /// <para>The order information.</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public CommodityValueResultOrder Order { get; set; }
            public class CommodityValueResultOrder : TeaModel {
                /// <summary>
                /// <para>The currency code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>The amount after the discount is applied.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9.99</para>
                /// </summary>
                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public string TradeAmount { get; set; }

                /// <summary>
                /// <para>The discount amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.99</para>
                /// </summary>
                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public string DiscountAmount { get; set; }

                /// <summary>
                /// <para>The original amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11.98</para>
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public string OriginalAmount { get; set; }

            }

            /// <summary>
            /// <para>The inquiry type. Valid values:</para>
            /// <ol>
            /// <item><description><para>Buy: an inquiry for a new purchase.</para>
            /// </description></item>
            /// <item><description><para>ModificationBuy: an inquiry for an upgrade or downgrade.</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>Buy</para>
            /// </summary>
            [NameInMap("InquiryType")]
            [Validation(Required=false)]
            public string InquiryType { get; set; }

            /// <summary>
            /// <para>The sub-orders.</para>
            /// </summary>
            [NameInMap("SubOrders")]
            [Validation(Required=false)]
            public CommodityValueResultSubOrders SubOrders { get; set; }
            public class CommodityValueResultSubOrders : TeaModel {
                /// <summary>
                /// <para>The sub-orders.</para>
                /// </summary>
                [NameInMap("SubOrder")]
                [Validation(Required=false)]
                public List<CommodityValueResultSubOrdersSubOrder> SubOrder { get; set; }
                public class CommodityValueResultSubOrdersSubOrder : TeaModel {
                    /// <summary>
                    /// <para>The module or instance information.</para>
                    /// </summary>
                    [NameInMap("ModuleInstance")]
                    [Validation(Required=false)]
                    public List<CommodityValueResultSubOrdersSubOrderModuleInstance> ModuleInstance { get; set; }
                    public class CommodityValueResultSubOrdersSubOrderModuleInstance : TeaModel {
                        /// <summary>
                        /// <para>The module ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1234</para>
                        /// </summary>
                        [NameInMap("ModuleId")]
                        [Validation(Required=false)]
                        public long? ModuleId { get; set; }

                        /// <summary>
                        /// <para>The module name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>数据库类型</para>
                        /// </summary>
                        [NameInMap("ModuleName")]
                        [Validation(Required=false)]
                        public string ModuleName { get; set; }

                        /// <summary>
                        /// <para>The module code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rds_dbtype</para>
                        /// </summary>
                        [NameInMap("ModuleCode")]
                        [Validation(Required=false)]
                        public string ModuleCode { get; set; }

                        /// <summary>
                        /// <para>The original price of the product, in CNY.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10.00</para>
                        /// </summary>
                        [NameInMap("TotalProductFee")]
                        [Validation(Required=false)]
                        public double? TotalProductFee { get; set; }

                        /// <summary>
                        /// <para>The discount, in CNY.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1.99</para>
                        /// </summary>
                        [NameInMap("DiscountFee")]
                        [Validation(Required=false)]
                        public double? DiscountFee { get; set; }

                        /// <summary>
                        /// <para>The amount payable, in CNY.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8.01</para>
                        /// </summary>
                        [NameInMap("PayFee")]
                        [Validation(Required=false)]
                        public double? PayFee { get; set; }

                        /// <summary>
                        /// <para>The unit of the price.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>元/GB/小时</para>
                        /// </summary>
                        [NameInMap("PriceUnit")]
                        [Validation(Required=false)]
                        public string PriceUnit { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the module is a billing item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("IsPricingModule")]
                        [Validation(Required=false)]
                        public bool? IsPricingModule { get; set; }

                        /// <summary>
                        /// <para>Indicates whether payment is required for the module in the order.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("NeedOrderPay")]
                        [Validation(Required=false)]
                        public bool? NeedOrderPay { get; set; }

                        /// <summary>
                        /// <para>The pricing type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>hourPrice</para>
                        /// </summary>
                        [NameInMap("PriceType")]
                        [Validation(Required=false)]
                        public string PriceType { get; set; }

                        /// <summary>
                        /// <para>The module attributes.</para>
                        /// </summary>
                        [NameInMap("ModuleAttrs")]
                        [Validation(Required=false)]
                        public List<CommodityValueResultSubOrdersSubOrderModuleInstanceModuleAttrs> ModuleAttrs { get; set; }
                        public class CommodityValueResultSubOrdersSubOrderModuleInstanceModuleAttrs : TeaModel {
                            /// <summary>
                            /// <para>The attribute type. Valid values:</para>
                            /// <ol>
                            /// <item><description><para>1: product attribute</para>
                            /// </description></item>
                            /// <item><description><para>2: specification attribute</para>
                            /// </description></item>
                            /// <item><description><para>3: module attribute</para>
                            /// </description></item>
                            /// <item><description><para>4: external parameter (reserved)</para>
                            /// </description></item>
                            /// </ol>
                            /// 
                            /// <b>Example:</b>
                            /// <para>3</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public long? Type { get; set; }

                            /// <summary>
                            /// <para>The attribute name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>20GB</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The attribute code.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>rds_storage</para>
                            /// </summary>
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public string Code { get; set; }

                            /// <summary>
                            /// <para>The attribute value.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>20</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                            /// <summary>
                            /// <para>The unit of the value.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>GB</para>
                            /// </summary>
                            [NameInMap("Unit")]
                            [Validation(Required=false)]
                            public string Unit { get; set; }

                        }

                        /// <summary>
                        /// <para>The English name of the module.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>数据单元</para>
                        /// </summary>
                        [NameInMap("ModuleNameEn")]
                        [Validation(Required=false)]
                        public string ModuleNameEn { get; set; }

                        /// <summary>
                        /// <para>The English name of the price unit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>元/月</para>
                        /// </summary>
                        [NameInMap("PriceUnitEn")]
                        [Validation(Required=false)]
                        public string PriceUnitEn { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The coupons.</para>
            /// </summary>
            [NameInMap("Coupons")]
            [Validation(Required=false)]
            public List<CommodityValueResultCoupons> Coupons { get; set; }
            public class CommodityValueResultCoupons : TeaModel {
                /// <summary>
                /// <para>The payable amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9.99</para>
                /// </summary>
                [NameInMap("CanPromFee")]
                [Validation(Required=false)]
                public double? CanPromFee { get; set; }

                /// <summary>
                /// <para>The description of the coupon.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10元优惠券（有效期至2024年9月8日）</para>
                /// </summary>
                [NameInMap("CouponDesc")]
                [Validation(Required=false)]
                public string CouponDesc { get; set; }

                /// <summary>
                /// <para>The name of the coupon.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10元优惠券</para>
                /// </summary>
                [NameInMap("CouponName")]
                [Validation(Required=false)]
                public string CouponName { get; set; }

                /// <summary>
                /// <para>The coupon number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50008800000xxxx</para>
                /// </summary>
                [NameInMap("CouponOptionNo")]
                [Validation(Required=false)]
                public string CouponOptionNo { get; set; }

                /// <summary>
                /// <para>Indicates whether the coupon is selected.</para>
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
