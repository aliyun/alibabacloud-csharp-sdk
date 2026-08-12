// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class QueryModifyInstancePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The price information, including the price and discount rules.</para>
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public QueryModifyInstancePriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class QueryModifyInstancePriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ORDER.INST_HAS_UNPAID_ORDER</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The currency unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The price reduction information.</para>
            /// </summary>
            [NameInMap("DepreciateInfo")]
            [Validation(Required=false)]
            public QueryModifyInstancePriceResponseBodyPriceInfoDepreciateInfo DepreciateInfo { get; set; }
            public class QueryModifyInstancePriceResponseBodyPriceInfoDepreciateInfo : TeaModel {
                /// <summary>
                /// <para>The price reduction ratio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("CheapRate")]
                [Validation(Required=false)]
                public string CheapRate { get; set; }

                /// <summary>
                /// <para>The reduced list price total.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6000</para>
                /// </summary>
                [NameInMap("CheapStandAmount")]
                [Validation(Required=false)]
                public string CheapStandAmount { get; set; }

                /// <summary>
                /// <para>Indicates whether to display the price reduction percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsShow")]
                [Validation(Required=false)]
                public bool? IsShow { get; set; }

                /// <summary>
                /// <para>The equivalent monthly price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6</para>
                /// </summary>
                [NameInMap("MonthPrice")]
                [Validation(Required=false)]
                public string MonthPrice { get; set; }

                /// <summary>
                /// <para>The original list price total.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12000</para>
                /// </summary>
                [NameInMap("OriginalStandAmount")]
                [Validation(Required=false)]
                public string OriginalStandAmount { get; set; }

                /// <summary>
                /// <para>The price reduction start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-04T21:10:26+08:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The discount amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>655.2</para>
            /// </summary>
            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public float? DiscountAmount { get; set; }

            /// <summary>
            /// <para>Indicates whether the enterprise discount is applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Yes</para>
            /// </summary>
            [NameInMap("IsContractActivity")]
            [Validation(Required=false)]
            public bool? IsContractActivity { get; set; }

            /// <summary>
            /// <para>The Lingxiao request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>67F33190-946B-1105-B6A1-E2DF0426DD51</para>
            /// </summary>
            [NameInMap("LxRequestId")]
            [Validation(Required=false)]
            public string LxRequestId { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>An unpaid order exists. Pay for or cancel the existing order first</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The coupon group information.</para>
            /// </summary>
            [NameInMap("OptionalPromotions")]
            [Validation(Required=false)]
            public List<QueryModifyInstancePriceResponseBodyPriceInfoOptionalPromotions> OptionalPromotions { get; set; }
            public class QueryModifyInstancePriceResponseBodyPriceInfoOptionalPromotions : TeaModel {
                /// <summary>
                /// <para>The coupon description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>¥1,391.5 coupon (valid until 03/23/2022)</para>
                /// </summary>
                [NameInMap("PromotionDesc")]
                [Validation(Required=false)]
                public string PromotionDesc { get; set; }

                /// <summary>
                /// <para>The coupon name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>¥1,391.5 coupon</para>
                /// </summary>
                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                /// <summary>
                /// <para>The coupon ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500011220010099</para>
                /// </summary>
                [NameInMap("PromotionOptionNo")]
                [Validation(Required=false)]
                public string PromotionOptionNo { get; set; }

                /// <summary>
                /// <para>Indicates whether the coupon is selected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Selected.</para>
                /// </description></item>
                /// <item><description><para>false: Not selected.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Selected")]
                [Validation(Required=false)]
                public bool? Selected { get; set; }

            }

            /// <summary>
            /// <para>The original price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4368</para>
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public float? OriginalAmount { get; set; }

            /// <summary>
            /// <para>The promotion rule group.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<QueryModifyInstancePriceResponseBodyPriceInfoRules> Rules { get; set; }
            public class QueryModifyInstancePriceResponseBodyPriceInfoRules : TeaModel {
                /// <summary>
                /// <para>The promotion rule description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Purchase for 1 year or more to enjoy a 15% discount off the list price</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The promotion ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>587</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

            /// <summary>
            /// <para>The discounted price based on the official website discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1231</para>
            /// </summary>
            [NameInMap("StandDiscountPrice")]
            [Validation(Required=false)]
            public string StandDiscountPrice { get; set; }

            /// <summary>
            /// <para>The official website discount price or direct sales contract discount price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("StandPrice")]
            [Validation(Required=false)]
            public string StandPrice { get; set; }

            /// <summary>
            /// <para>The final price, which is the original price minus the discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3712.8</para>
            /// </summary>
            [NameInMap("TradeAmount")]
            [Validation(Required=false)]
            public float? TradeAmount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67F33190-946B-1105-B6A1-E2DF0426DD51</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
