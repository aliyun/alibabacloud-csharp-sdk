// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetResourcePackagePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetResourcePackagePriceResponseBodyData Data { get; set; }
        public class GetResourcePackagePriceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The type of the currency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The discounted amount. Unit: CNY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>215040</para>
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            /// <summary>
            /// <para>The original price. Unit: CNY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1290240</para>
            /// </summary>
            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }

            /// <summary>
            /// <para>The details of the discount.</para>
            /// </summary>
            [NameInMap("Promotions")]
            [Validation(Required=false)]
            public GetResourcePackagePriceResponseBodyDataPromotions Promotions { get; set; }
            public class GetResourcePackagePriceResponseBodyDataPromotions : TeaModel {
                [NameInMap("Promotion")]
                [Validation(Required=false)]
                public List<GetResourcePackagePriceResponseBodyDataPromotionsPromotion> Promotion { get; set; }
                public class GetResourcePackagePriceResponseBodyDataPromotionsPromotion : TeaModel {
                    /// <summary>
                    /// <para>The ID of the promotion.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000680914</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The description of the discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A discount of 17% is offered if you purchase a resource plan for six months.</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The price at which the transaction is made. Unit: CNY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1075200</para>
            /// </summary>
            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public float? TradePrice { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBEF51A3-E933-4F40-A534-C673CBDB9C80</para>
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
