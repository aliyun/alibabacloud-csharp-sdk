// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class QueryConvertPrepayInstancePriceResponseBody : TeaModel {
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public QueryConvertPrepayInstancePriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class QueryConvertPrepayInstancePriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ORDER.INST_HAS_UNPAID_ORDER</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            [NameInMap("DepreciateInfo")]
            [Validation(Required=false)]
            public QueryConvertPrepayInstancePriceResponseBodyPriceInfoDepreciateInfo DepreciateInfo { get; set; }
            public class QueryConvertPrepayInstancePriceResponseBodyPriceInfoDepreciateInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20%</para>
                /// </summary>
                [NameInMap("CheapRate")]
                [Validation(Required=false)]
                public string CheapRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8000</para>
                /// </summary>
                [NameInMap("CheapStandAmount")]
                [Validation(Required=false)]
                public string CheapStandAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsShow")]
                [Validation(Required=false)]
                public bool? IsShow { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4000</para>
                /// </summary>
                [NameInMap("MonthPrice")]
                [Validation(Required=false)]
                public string MonthPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("OriginalStandAmount")]
                [Validation(Required=false)]
                public string OriginalStandAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-03-31T16:00:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>655.2</para>
            /// </summary>
            [NameInMap("DiscountAmount")]
            [Validation(Required=false)]
            public float? DiscountAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsContractActivity")]
            [Validation(Required=false)]
            public bool? IsContractActivity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>存在未支付订单，请先支付或取消原有订单</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("OptionalPromotions")]
            [Validation(Required=false)]
            public List<QueryConvertPrepayInstancePriceResponseBodyPriceInfoOptionalPromotions> OptionalPromotions { get; set; }
            public class QueryConvertPrepayInstancePriceResponseBodyPriceInfoOptionalPromotions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>￥1,391.5 优惠券 (有效期至 03/23/2022)</para>
                /// </summary>
                [NameInMap("PromotionDesc")]
                [Validation(Required=false)]
                public string PromotionDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>￥1,391.5 优惠券</para>
                /// </summary>
                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>500011220010099</para>
                /// </summary>
                [NameInMap("PromotionOptionNo")]
                [Validation(Required=false)]
                public string PromotionOptionNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Selected")]
                [Validation(Required=false)]
                public bool? Selected { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4368</para>
            /// </summary>
            [NameInMap("OriginalAmount")]
            [Validation(Required=false)]
            public float? OriginalAmount { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<QueryConvertPrepayInstancePriceResponseBodyPriceInfoRules> Rules { get; set; }
            public class QueryConvertPrepayInstancePriceResponseBodyPriceInfoRules : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>买满1年，立享官网价格8.5折优惠。</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>587</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21321</para>
            /// </summary>
            [NameInMap("StandDiscountPrice")]
            [Validation(Required=false)]
            public string StandDiscountPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32432</para>
            /// </summary>
            [NameInMap("StandPrice")]
            [Validation(Required=false)]
            public string StandPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3712.8</para>
            /// </summary>
            [NameInMap("TradeAmount")]
            [Validation(Required=false)]
            public float? TradeAmount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>67F33190-946B-1105-B6A1-E2DF0426DD51</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
