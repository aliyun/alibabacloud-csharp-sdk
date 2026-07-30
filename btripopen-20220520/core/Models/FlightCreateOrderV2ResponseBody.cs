// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightCreateOrderV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response details.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightCreateOrderV2ResponseBodyModule Module { get; set; }
        public class FlightCreateOrderV2ResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The asynchronous order creation key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>异步下单key</para>
            /// </summary>
            [NameInMap("async_create_order_key")]
            [Validation(Required=false)]
            public string AsyncCreateOrderKey { get; set; }

            /// <summary>
            /// <para>The latest payment time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-10 17:42:32</para>
            /// </summary>
            [NameInMap("latest_pay_time")]
            [Validation(Required=false)]
            public string LatestPayTime { get; set; }

            /// <summary>
            /// <para>The business travel order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1017002195798359369</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The distribution external order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234232</para>
            /// </summary>
            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            /// <summary>
            /// <para>The order status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The total order price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51000</para>
            /// </summary>
            [NameInMap("total_price")]
            [Validation(Required=false)]
            public long? TotalPrice { get; set; }

        }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bc60a16916593445203790d2a16</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2103ad0716827336456723986d4bda</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
