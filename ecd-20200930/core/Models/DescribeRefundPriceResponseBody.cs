// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeRefundPriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The price details.</para>
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribeRefundPriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribeRefundPriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// <para>The unit of currency (USD).</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The amount of the refund.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3990.75</para>
            /// </summary>
            [NameInMap("RefundFee")]
            [Validation(Required=false)]
            public float? RefundFee { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
