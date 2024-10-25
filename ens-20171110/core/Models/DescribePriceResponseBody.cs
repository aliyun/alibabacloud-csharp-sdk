// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The price information.</para>
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribePriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// <para>The price.</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoPrice Price { get; set; }
            public class DescribePriceResponseBodyPriceInfoPrice : TeaModel {
                /// <summary>
                /// <para>The type of currency.</para>
                /// <list type="bullet">
                /// <item><description>USD: US dollar</description></item>
                /// <item><description>JPY: Japanese Yen</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>USD</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>The discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                /// <summary>
                /// <para>The original price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16125.00</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                /// <summary>
                /// <para>The final price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>126.75</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>694EB8FF-446C-5B1E-8146-9629E492551F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
