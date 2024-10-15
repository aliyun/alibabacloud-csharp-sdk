// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightPayOrderResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightPayOrderResponseBodyModule Module { get; set; }
        public class FlightPayOrderResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("actual_pay_price")]
            [Validation(Required=false)]
            public long? ActualPayPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12989127316726531726</para>
            /// </summary>
            [NameInMap("alipay_trade_no")]
            [Validation(Required=false)]
            public string AlipayTradeNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0000-00-00 00:00:00</para>
            /// </summary>
            [NameInMap("last_pay_time")]
            [Validation(Required=false)]
            public string LastPayTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>210e842b16611337974412836dae27</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
