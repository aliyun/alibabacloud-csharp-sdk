// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class ValuateTemplateResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The result of the inquiry.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ValuateTemplateResponseBodyData Data { get; set; }
        public class ValuateTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// The result set of the inquiry.
            /// </summary>
            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public List<ValuateTemplateResponseBodyDataResourceList> ResourceList { get; set; }
            public class ValuateTemplateResponseBodyDataResourceList : TeaModel {
                /// <summary>
                /// The discount amount.
                /// </summary>
                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public double? DiscountAmount { get; set; }

                /// <summary>
                /// The error message that is returned.
                /// </summary>
                [NameInMap("Error")]
                [Validation(Required=false)]
                public string Error { get; set; }

                /// <summary>
                /// The resource type.
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// The original price.
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public double? OriginalPrice { get; set; }

                /// <summary>
                /// The information about the price.
                /// </summary>
                [NameInMap("PriceList")]
                [Validation(Required=false)]
                public List<ValuateTemplateResponseBodyDataResourceListPriceList> PriceList { get; set; }
                public class ValuateTemplateResponseBodyDataResourceListPriceList : TeaModel {
                    /// <summary>
                    /// The discount amount.
                    /// </summary>
                    [NameInMap("DiscountAmount")]
                    [Validation(Required=false)]
                    public float? DiscountAmount { get; set; }

                    /// <summary>
                    /// The error message that is returned.
                    /// </summary>
                    [NameInMap("Error")]
                    [Validation(Required=false)]
                    public string Error { get; set; }

                    /// <summary>
                    /// The resource type.
                    /// </summary>
                    [NameInMap("NodeType")]
                    [Validation(Required=false)]
                    public string NodeType { get; set; }

                    /// <summary>
                    /// The original price.
                    /// </summary>
                    [NameInMap("OriginalPrice")]
                    [Validation(Required=false)]
                    public float? OriginalPrice { get; set; }

                    /// <summary>
                    /// The pricing unit.
                    /// </summary>
                    [NameInMap("PriceUnit")]
                    [Validation(Required=false)]
                    public string PriceUnit { get; set; }

                    /// <summary>
                    /// The discount information.
                    /// </summary>
                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                    /// <summary>
                    /// The resource ID.
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// The price at which the transaction is made.
                    /// </summary>
                    [NameInMap("TradePrice")]
                    [Validation(Required=false)]
                    public float? TradePrice { get; set; }

                    /// <summary>
                    /// Indicates whether the instance is newly created. Valid values:\
                    /// 1: The instance is newly created.\
                    /// 2: The instance already exists.\
                    /// 0: The price of the instance is not included.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The pricing unit.
                /// </summary>
                [NameInMap("PriceUnit")]
                [Validation(Required=false)]
                public string PriceUnit { get; set; }

                /// <summary>
                /// The discount information.
                /// </summary>
                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                /// <summary>
                /// The price at which the transaction is made.
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public double? TradePrice { get; set; }

            }

        }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
