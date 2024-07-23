// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class AskSessionPackageRenewPriceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<AskSessionPackageRenewPriceResponseBodyData> Data { get; set; }
        public class AskSessionPackageRenewPriceResponseBodyData : TeaModel {
            [NameInMap("Price")]
            [Validation(Required=false)]
            public AskSessionPackageRenewPriceResponseBodyDataPrice Price { get; set; }
            public class AskSessionPackageRenewPriceResponseBodyDataPrice : TeaModel {
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
        /// <para>50158E8B-992E-1286-B174-**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
