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
        /// <para>The information about the service price.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSubscriptionPriceResponseBodyData Data { get; set; }
        public class GetSubscriptionPriceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The type of currency. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CNY: Chinese Yuan</description></item>
            /// <item><description>USD: US dollar</description></item>
            /// <item><description>JPY: Japanese Yen</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The discount that was applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            /// <summary>
            /// <para>The price details of the pricing module.</para>
            /// </summary>
            [NameInMap("ModuleDetails")]
            [Validation(Required=false)]
            public GetSubscriptionPriceResponseBodyDataModuleDetails ModuleDetails { get; set; }
            public class GetSubscriptionPriceResponseBodyDataModuleDetails : TeaModel {
                [NameInMap("ModuleDetail")]
                [Validation(Required=false)]
                public List<GetSubscriptionPriceResponseBodyDataModuleDetailsModuleDetail> ModuleDetail { get; set; }
                public class GetSubscriptionPriceResponseBodyDataModuleDetailsModuleDetail : TeaModel {
                    /// <summary>
                    /// <para>The discount price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CostAfterDiscount")]
                    [Validation(Required=false)]
                    public float? CostAfterDiscount { get; set; }

                    /// <summary>
                    /// <para>The discount that was applied.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("InvoiceDiscount")]
                    [Validation(Required=false)]
                    public float? InvoiceDiscount { get; set; }

                    /// <summary>
                    /// <para>The identifier of the pricing module.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PackageCode</para>
                    /// </summary>
                    [NameInMap("ModuleCode")]
                    [Validation(Required=false)]
                    public string ModuleCode { get; set; }

                    /// <summary>
                    /// <para>The original price of the service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("OriginalCost")]
                    [Validation(Required=false)]
                    public float? OriginalCost { get; set; }

                    /// <summary>
                    /// <para>The unit price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("UnitPrice")]
                    [Validation(Required=false)]
                    public float? UnitPrice { get; set; }

                }

            }

            /// <summary>
            /// <para>The original price of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }

            /// <summary>
            /// <para>The details of the discount.</para>
            /// </summary>
            [NameInMap("PromotionDetails")]
            [Validation(Required=false)]
            public GetSubscriptionPriceResponseBodyDataPromotionDetails PromotionDetails { get; set; }
            public class GetSubscriptionPriceResponseBodyDataPromotionDetails : TeaModel {
                [NameInMap("PromotionDetail")]
                [Validation(Required=false)]
                public List<GetSubscriptionPriceResponseBodyDataPromotionDetailsPromotionDetail> PromotionDetail { get; set; }
                public class GetSubscriptionPriceResponseBodyDataPromotionDetailsPromotionDetail : TeaModel {
                    /// <summary>
                    /// <para>The description of the discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("PromotionDesc")]
                    [Validation(Required=false)]
                    public string PromotionDesc { get; set; }

                    /// <summary>
                    /// <para>The ID of the discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1021199213</para>
                    /// </summary>
                    [NameInMap("PromotionId")]
                    [Validation(Required=false)]
                    public long? PromotionId { get; set; }

                    /// <summary>
                    /// <para>The name of the discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
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
            /// <para>The discount price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public float? TradePrice { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
