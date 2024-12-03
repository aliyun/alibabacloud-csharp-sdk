// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetPayAsYouGoPriceResponseBody : TeaModel {
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
        public GetPayAsYouGoPriceResponseBodyData Data { get; set; }
        public class GetPayAsYouGoPriceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The type of the currency. Valid values:</para>
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
            /// <para>The price details of the pricing module.</para>
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
                    /// <para>The discount price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CostAfterDiscount")]
                    [Validation(Required=false)]
                    public float? CostAfterDiscount { get; set; }

                    /// <summary>
                    /// <para>The discount that was applied.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("InvoiceDiscount")]
                    [Validation(Required=false)]
                    public float? InvoiceDiscount { get; set; }

                    /// <summary>
                    /// <para>The code of the pricing module.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>InstanceType</para>
                    /// </summary>
                    [NameInMap("ModuleCode")]
                    [Validation(Required=false)]
                    public string ModuleCode { get; set; }

                    /// <summary>
                    /// <para>The original price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.77</para>
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
            /// <para>The details of the discount.</para>
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
                    /// <para>The description of the discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This discount allows you to use a service at the minimum price and is provided for testing purposes only.</para>
                    /// </summary>
                    [NameInMap("PromotionDesc")]
                    [Validation(Required=false)]
                    public string PromotionDesc { get; set; }

                    /// <summary>
                    /// <para>The ID of the discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10200210</para>
                    /// </summary>
                    [NameInMap("PromotionId")]
                    [Validation(Required=false)]
                    public long? PromotionId { get; set; }

                    /// <summary>
                    /// <para>The name of the discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This discount allows you to use a service at the minimum price and is provided for testing purposes only.</para>
                    /// </summary>
                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                }

            }

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
        /// <para>1537A007-72D7-4165-8A26-8694A38E219A</para>
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
