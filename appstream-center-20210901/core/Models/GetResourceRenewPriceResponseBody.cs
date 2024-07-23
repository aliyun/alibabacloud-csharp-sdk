// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetResourceRenewPriceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetResourceRenewPriceResponseBodyData Data { get; set; }
        public class GetResourceRenewPriceResponseBodyData : TeaModel {
            [NameInMap("Price")]
            [Validation(Required=false)]
            public GetResourceRenewPriceResponseBodyDataPrice Price { get; set; }
            public class GetResourceRenewPriceResponseBodyDataPrice : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public string DiscountPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public string OriginalPrice { get; set; }

                [NameInMap("Promotions")]
                [Validation(Required=false)]
                public List<GetResourceRenewPriceResponseBodyDataPricePromotions> Promotions { get; set; }
                public class GetResourceRenewPriceResponseBodyDataPricePromotions : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>coupon****</para>
                    /// </summary>
                    [NameInMap("OptionCode")]
                    [Validation(Required=false)]
                    public string OptionCode { get; set; }

                    [NameInMap("PromotionDesc")]
                    [Validation(Required=false)]
                    public string PromotionDesc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>139965*****</para>
                    /// </summary>
                    [NameInMap("PromotionId")]
                    [Validation(Required=false)]
                    public string PromotionId { get; set; }

                    [NameInMap("PromotionName")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

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
                /// <para>10</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public string TradePrice { get; set; }

            }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<GetResourceRenewPriceResponseBodyDataRules> Rules { get; set; }
            public class GetResourceRenewPriceResponseBodyDataRules : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20002****</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
