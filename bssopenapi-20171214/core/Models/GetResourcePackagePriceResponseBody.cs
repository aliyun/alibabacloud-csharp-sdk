// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetResourcePackagePriceResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetResourcePackagePriceResponseBodyData Data { get; set; }
        public class GetResourcePackagePriceResponseBodyData : TeaModel {
            /// <summary>
            /// The type of the currency.
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// The discounted amount. Unit: CNY.
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            /// <summary>
            /// The original price. Unit: CNY.
            /// </summary>
            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }

            /// <summary>
            /// The details of the discount.
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
                    /// The ID of the promotion.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// The description of the discount.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// The price at which the transaction is made. Unit: CNY.
            /// </summary>
            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public float? TradePrice { get; set; }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
