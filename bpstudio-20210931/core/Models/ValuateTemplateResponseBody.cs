// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class ValuateTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The result of the inquiry.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ValuateTemplateResponseBodyData Data { get; set; }
        public class ValuateTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The result set of the inquiry.</para>
            /// </summary>
            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public List<ValuateTemplateResponseBodyDataResourceList> ResourceList { get; set; }
            public class ValuateTemplateResponseBodyDataResourceList : TeaModel {
                /// <summary>
                /// <para>The discount amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>73</para>
                /// </summary>
                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public double? DiscountAmount { get; set; }

                /// <summary>
                /// <para>The error message that is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InvalidSaleComponentFault : The request not refer to the correct order sale component.</para>
                /// </summary>
                [NameInMap("Error")]
                [Validation(Required=false)]
                public string Error { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>The original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>83.0</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public double? OriginalPrice { get; set; }

                /// <summary>
                /// <para>The information about the price.</para>
                /// </summary>
                [NameInMap("PriceList")]
                [Validation(Required=false)]
                public List<ValuateTemplateResponseBodyDataResourceListPriceList> PriceList { get; set; }
                public class ValuateTemplateResponseBodyDataResourceListPriceList : TeaModel {
                    /// <summary>
                    /// <para>The discount amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>82.99</para>
                    /// </summary>
                    [NameInMap("DiscountAmount")]
                    [Validation(Required=false)]
                    public float? DiscountAmount { get; set; }

                    /// <summary>
                    /// <para>The error message that is returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ServiceUnavailable : The request has failed due to a temporary failure of the server.\r\nRequestId : 4AA302DB-3286-5589-8637-FF6D8507B7A9.</para>
                    /// </summary>
                    [NameInMap("Error")]
                    [Validation(Required=false)]
                    public string Error { get; set; }

                    /// <summary>
                    /// <para>The resource type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eip</para>
                    /// </summary>
                    [NameInMap("NodeType")]
                    [Validation(Required=false)]
                    public string NodeType { get; set; }

                    /// <summary>
                    /// <para>The original price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>83.0</para>
                    /// </summary>
                    [NameInMap("OriginalPrice")]
                    [Validation(Required=false)]
                    public float? OriginalPrice { get; set; }

                    /// <summary>
                    /// <para>The pricing unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("PriceUnit")]
                    [Validation(Required=false)]
                    public string PriceUnit { get; set; }

                    /// <summary>
                    /// <para>The discount information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The discount information.</para>
                    /// </summary>
                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                    /// <summary>
                    /// <para>The resource ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1687225092</para>
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <para>The price at which the transaction is made.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.01</para>
                    /// </summary>
                    [NameInMap("TradePrice")]
                    [Validation(Required=false)]
                    public float? TradePrice { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the instance is newly created. Valid values:\
                    /// 1: The instance is newly created.\
                    /// 2: The instance already exists.\
                    /// 0: The price of the instance is not included.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;1&quot;</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The pricing unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>USD</para>
                /// </summary>
                [NameInMap("PriceUnit")]
                [Validation(Required=false)]
                public string PriceUnit { get; set; }

                /// <summary>
                /// <para>The discount information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The discount information.</para>
                /// </summary>
                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                /// <summary>
                /// <para>The price at which the transaction is made.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public double? TradePrice { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>847C9D0A-BABD-589C-8A9C-6464409EDED9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
