// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetSubscriptionPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidConfigCod</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The product price information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSubscriptionPriceResponseBodyData Data { get; set; }
        public class GetSubscriptionPriceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The currency. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CNY: Chinese yuan.</description></item>
            /// <item><description>USD: US dollar.</description></item>
            /// <item><description>JPY: Japanese yen.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The discount amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            [NameInMap("ModuleDetails")]
            [Validation(Required=false)]
            public GetSubscriptionPriceResponseBodyDataModuleDetails ModuleDetails { get; set; }
            public class GetSubscriptionPriceResponseBodyDataModuleDetails : TeaModel {
                [NameInMap("ModuleDetail")]
                [Validation(Required=false)]
                public List<GetSubscriptionPriceResponseBodyDataModuleDetailsModuleDetail> ModuleDetail { get; set; }
                public class GetSubscriptionPriceResponseBodyDataModuleDetailsModuleDetail : TeaModel {
                    [NameInMap("CostAfterDiscount")]
                    [Validation(Required=false)]
                    public float? CostAfterDiscount { get; set; }

                    [NameInMap("InvoiceDiscount")]
                    [Validation(Required=false)]
                    public float? InvoiceDiscount { get; set; }

                    [NameInMap("ModuleCode")]
                    [Validation(Required=false)]
                    public string ModuleCode { get; set; }

                    [NameInMap("OriginalCost")]
                    [Validation(Required=false)]
                    public float? OriginalCost { get; set; }

                    [NameInMap("UnitPrice")]
                    [Validation(Required=false)]
                    public float? UnitPrice { get; set; }

                }

            }

            /// <summary>
            /// <para>The original price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }

            /// <summary>
            /// <para>The parameters for fixed-fee installments.</para>
            /// </summary>
            [NameInMap("PaymentScheme")]
            [Validation(Required=false)]
            public GetSubscriptionPriceResponseBodyDataPaymentScheme PaymentScheme { get; set; }
            public class GetSubscriptionPriceResponseBodyDataPaymentScheme : TeaModel {
                /// <summary>
                /// <para>The payable amount for the order, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>35092</para>
                /// </summary>
                [NameInMap("OrderDownPaymentFee")]
                [Validation(Required=false)]
                public string OrderDownPaymentFee { get; set; }

                /// <summary>
                /// <para>The payable amount in the settlement currency for the order, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>35092</para>
                /// </summary>
                [NameInMap("OrderDownPaymentSettleFee")]
                [Validation(Required=false)]
                public string OrderDownPaymentSettleFee { get; set; }

                /// <summary>
                /// <para>The total payable amount for the order, including the prepayment and installment parts, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70184</para>
                /// </summary>
                [NameInMap("OrderTotalFee")]
                [Validation(Required=false)]
                public string OrderTotalFee { get; set; }

                /// <summary>
                /// <para>The total payable amount in the settlement currency for the order, including the prepayment and installment parts, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70184</para>
                /// </summary>
                [NameInMap("OrderTotalSettleFee")]
                [Validation(Required=false)]
                public string OrderTotalSettleFee { get; set; }

                /// <summary>
                /// <para>The fixed-fee installment type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PAYMENT_NORMAL: non-fixed-fee installment products.</description></item>
                /// <item><description>PAYMENT_PHASED: fixed-fee installment products.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PAYMENT_NORMAL</para>
                /// </summary>
                [NameInMap("PaymentType")]
                [Validation(Required=false)]
                public string PaymentType { get; set; }

            }

            [NameInMap("PromotionDetails")]
            [Validation(Required=false)]
            public GetSubscriptionPriceResponseBodyDataPromotionDetails PromotionDetails { get; set; }
            public class GetSubscriptionPriceResponseBodyDataPromotionDetails : TeaModel {
                [NameInMap("PromotionDetail")]
                [Validation(Required=false)]
                public List<GetSubscriptionPriceResponseBodyDataPromotionDetailsPromotionDetail> PromotionDetail { get; set; }
                public class GetSubscriptionPriceResponseBodyDataPromotionDetailsPromotionDetail : TeaModel {
                    [NameInMap("PromotionDesc")]
                    [Validation(Required=false)]
                    public string PromotionDesc { get; set; }

                    [NameInMap("PromotionId")]
                    [Validation(Required=false)]
                    public long? PromotionId { get; set; }

                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                }

            }

            /// <summary>
            /// <para>The quantity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public int? Quantity { get; set; }

            /// <summary>
            /// <para>The discounted price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public float? TradePrice { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30E7066E-AE6F-4E59-AFE6-11386CE3AFA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
