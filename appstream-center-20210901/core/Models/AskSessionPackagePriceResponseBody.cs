// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class AskSessionPackagePriceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<AskSessionPackagePriceResponseBodyData> Data { get; set; }
        public class AskSessionPackagePriceResponseBodyData : TeaModel {
            [NameInMap("Price")]
            [Validation(Required=false)]
            public AskSessionPackagePriceResponseBodyDataPrice Price { get; set; }
            public class AskSessionPackagePriceResponseBodyDataPrice : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("DiscountPrice")]
                [Validation(Required=false)]
                public float? DiscountPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000.0</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000.0</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2C64D9E5-DFCD-10A5-A911-xxxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
