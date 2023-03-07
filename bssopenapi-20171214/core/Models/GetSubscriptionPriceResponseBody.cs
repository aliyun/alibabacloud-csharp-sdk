// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetSubscriptionPriceResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the service price.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSubscriptionPriceResponseBodyData Data { get; set; }
        public class GetSubscriptionPriceResponseBodyData : TeaModel {
            /// <summary>
            /// The type of currency. Valid values:
            /// 
            /// *   CNY: Chinese Yuan
            /// *   USD: US dollar
            /// *   JPY: Japanese Yen
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// The discount that was applied.
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            /// <summary>
            /// The price details of the pricing module.
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
                    /// The discount price.
                    /// </summary>
                    [NameInMap("CostAfterDiscount")]
                    [Validation(Required=false)]
                    public float? CostAfterDiscount { get; set; }

                    /// <summary>
                    /// The discount that was applied.
                    /// </summary>
                    [NameInMap("InvoiceDiscount")]
                    [Validation(Required=false)]
                    public float? InvoiceDiscount { get; set; }

                    /// <summary>
                    /// The identifier of the pricing module.
                    /// </summary>
                    [NameInMap("ModuleCode")]
                    [Validation(Required=false)]
                    public string ModuleCode { get; set; }

                    /// <summary>
                    /// The original price of the service.
                    /// </summary>
                    [NameInMap("OriginalCost")]
                    [Validation(Required=false)]
                    public float? OriginalCost { get; set; }

                    /// <summary>
                    /// The unit price.
                    /// </summary>
                    [NameInMap("UnitPrice")]
                    [Validation(Required=false)]
                    public float? UnitPrice { get; set; }

                }

            }

            /// <summary>
            /// The original price of the service.
            /// </summary>
            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }

            /// <summary>
            /// The details of the discount.
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
                    /// The description of the discount.
                    /// </summary>
                    [NameInMap("PromotionDesc")]
                    [Validation(Required=false)]
                    public string PromotionDesc { get; set; }

                    /// <summary>
                    /// The ID of the discount.
                    /// </summary>
                    [NameInMap("PromotionId")]
                    [Validation(Required=false)]
                    public long? PromotionId { get; set; }

                    /// <summary>
                    /// The name of the discount.
                    /// </summary>
                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                }

            }

            /// <summary>
            /// The quantity.
            /// </summary>
            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public int? Quantity { get; set; }

            /// <summary>
            /// The discount price.
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
