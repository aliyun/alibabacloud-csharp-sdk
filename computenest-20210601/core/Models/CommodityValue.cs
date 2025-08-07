// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CommodityValue : TeaModel {
        /// <summary>
        /// <para>The result model.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CommodityValueResult Result { get; set; }
        public class CommodityValueResult : TeaModel {
            /// <summary>
            /// <para>The information about the order.</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public CommodityValueResultOrder Order { get; set; }
            public class CommodityValueResultOrder : TeaModel {
                /// <summary>
                /// <para>The code of the native currency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>Amount after the discount.</para>
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
                /// <para>Amount before the discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11.98</para>
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public string OriginalAmount { get; set; }

            }

            /// <summary>
            /// <para>The RFQ type. Valid values:</para>
            /// <ol>
            /// <item><description>Buy: price inquiry for new resources.</description></item>
            /// <item><description>ModificationBuy: price inquiry for resource configuration changes.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>Buy</para>
            /// </summary>
            [NameInMap("InquiryType")]
            [Validation(Required=false)]
            public string InquiryType { get; set; }

            /// <summary>
            /// <para>The order sub-items.</para>
            /// </summary>
            [NameInMap("SubOrders")]
            [Validation(Required=false)]
            public CommodityValueResultSubOrders SubOrders { get; set; }
            public class CommodityValueResultSubOrders : TeaModel {
                /// <summary>
                /// <para>The order sub-item.</para>
                /// </summary>
                [NameInMap("SubOrder")]
                [Validation(Required=false)]
                public List<CommodityValueResultSubOrdersSubOrder> SubOrder { get; set; }
                public class CommodityValueResultSubOrdersSubOrder : TeaModel {
                    /// <summary>
                    /// <para>The information about the module (instance).</para>
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
                        /// <para>Rds</para>
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
                        /// <para>The original price (RMB).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10.00</para>
                        /// </summary>
                        [NameInMap("TotalProductFee")]
                        [Validation(Required=false)]
                        public double? TotalProductFee { get; set; }

                        /// <summary>
                        /// <para>The discount amount (RMB).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1.99</para>
                        /// </summary>
                        [NameInMap("DiscountFee")]
                        [Validation(Required=false)]
                        public double? DiscountFee { get; set; }

                        /// <summary>
                        /// <para>The amount actually paid (RMB).</para>
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
                        /// <para>Yuan/GB/hour</para>
                        /// </summary>
                        [NameInMap("PriceUnit")]
                        [Validation(Required=false)]
                        public string PriceUnit { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the item is billed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("IsPricingModule")]
                        [Validation(Required=false)]
                        public bool? IsPricingModule { get; set; }

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
                            /// <para>The type of the attribute. Valid values:</para>
                            /// <ol>
                            /// <item><description>1: product</description></item>
                            /// <item><description>2\. specifications</description></item>
                            /// <item><description>3: module</description></item>
                            /// <item><description>4: external parameters (backup)</description></item>
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

                        [NameInMap("ModuleNameEn")]
                        [Validation(Required=false)]
                        public string ModuleNameEn { get; set; }

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
                /// <para>CNY 10 coupon (valid until September 8, 2024)</para>
                /// </summary>
                [NameInMap("CouponDesc")]
                [Validation(Required=false)]
                public string CouponDesc { get; set; }

                /// <summary>
                /// <para>The name of the coupon.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY 10 coupon</para>
                /// </summary>
                [NameInMap("CouponName")]
                [Validation(Required=false)]
                public string CouponName { get; set; }

                /// <summary>
                /// <para>The coupon ID.</para>
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
