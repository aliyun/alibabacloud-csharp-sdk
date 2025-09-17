// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class GetPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The price.</para>
        /// </summary>
        [NameInMap("price")]
        [Validation(Required=false)]
        public GetPriceResponseBodyPrice Price { get; set; }
        public class GetPriceResponseBodyPrice : TeaModel {
            /// <summary>
            /// <para>The currency type. Valid values: CNY: Chinese Yuan. USD: US dollar. JPY: Japanese Yen.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("discountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            /// <summary>
            /// <para>The order details of the pricing module.</para>
            /// </summary>
            [NameInMap("moduleDetails")]
            [Validation(Required=false)]
            public List<GetPriceResponseBodyPriceModuleDetails> ModuleDetails { get; set; }
            public class GetPriceResponseBodyPriceModuleDetails : TeaModel {
                /// <summary>
                /// <para>The discount price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.02</para>
                /// </summary>
                [NameInMap("costAfterDiscount")]
                [Validation(Required=false)]
                public float? CostAfterDiscount { get; set; }

                /// <summary>
                /// <para>The discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("invoiceDiscount")]
                [Validation(Required=false)]
                public float? InvoiceDiscount { get; set; }

                /// <summary>
                /// <para>The code of the pricing module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceRent</para>
                /// </summary>
                [NameInMap("moduleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                /// <summary>
                /// <para>The name of the pricing module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceRent</para>
                /// </summary>
                [NameInMap("moduleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                /// <summary>
                /// <para>The original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000.0</para>
                /// </summary>
                [NameInMap("originalCost")]
                [Validation(Required=false)]
                public float? OriginalCost { get; set; }

                /// <summary>
                /// <para>The price type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("priceType")]
                [Validation(Required=false)]
                public string PriceType { get; set; }

            }

            /// <summary>
            /// <para>The original price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>760.0</para>
            /// </summary>
            [NameInMap("originalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }

            /// <summary>
            /// <para>The details of the promotion.</para>
            /// </summary>
            [NameInMap("promotionDetails")]
            [Validation(Required=false)]
            public List<GetPriceResponseBodyPricePromotionDetails> PromotionDetails { get; set; }
            public class GetPriceResponseBodyPricePromotionDetails : TeaModel {
                /// <summary>
                /// <para>The description of the promotion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>37284</para>
                /// </summary>
                [NameInMap("promotionDesc")]
                [Validation(Required=false)]
                public string PromotionDesc { get; set; }

                /// <summary>
                /// <para>The ID of the promotion.</para>
                /// </summary>
                [NameInMap("promotionId")]
                [Validation(Required=false)]
                public long? PromotionId { get; set; }

                /// <summary>
                /// <para>The name of the promotion.</para>
                /// </summary>
                [NameInMap("promotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

            }

            /// <summary>
            /// <para>The discount price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("tradePrice")]
            [Validation(Required=false)]
            public float? TradePrice { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
