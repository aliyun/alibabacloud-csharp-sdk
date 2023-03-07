// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetPayAsYouGoPriceResponseBody : TeaModel {
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
        public GetPayAsYouGoPriceResponseBodyData Data { get; set; }
        public class GetPayAsYouGoPriceResponseBodyData : TeaModel {
            /// <summary>
            /// The type of the currency. Valid values:
            /// 
            /// *   CNY: Chinese Yuan
            /// *   USD: US dollar
            /// *   JPY: Japanese Yen
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// The price details of the pricing module.
            /// </summary>
            [NameInMap("ModuleDetails")]
            [Validation(Required=false)]
            public GetPayAsYouGoPriceResponseBodyDataModuleDetails ModuleDetails { get; set; }
            public class GetPayAsYouGoPriceResponseBodyDataModuleDetails : TeaModel {
                [NameInMap("ModuleDetail")]
                [Validation(Required=false)]
                public List<GetPayAsYouGoPriceResponseBodyDataModuleDetailsModuleDetail> ModuleDetail { get; set; }
                public class GetPayAsYouGoPriceResponseBodyDataModuleDetailsModuleDetail : TeaModel {
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
                    /// The code of the pricing module.
                    /// </summary>
                    [NameInMap("ModuleCode")]
                    [Validation(Required=false)]
                    public string ModuleCode { get; set; }

                    /// <summary>
                    /// The original price.
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
            /// The details of the discount.
            /// </summary>
            [NameInMap("PromotionDetails")]
            [Validation(Required=false)]
            public GetPayAsYouGoPriceResponseBodyDataPromotionDetails PromotionDetails { get; set; }
            public class GetPayAsYouGoPriceResponseBodyDataPromotionDetails : TeaModel {
                [NameInMap("PromotionDetail")]
                [Validation(Required=false)]
                public List<GetPayAsYouGoPriceResponseBodyDataPromotionDetailsPromotionDetail> PromotionDetail { get; set; }
                public class GetPayAsYouGoPriceResponseBodyDataPromotionDetailsPromotionDetail : TeaModel {
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
