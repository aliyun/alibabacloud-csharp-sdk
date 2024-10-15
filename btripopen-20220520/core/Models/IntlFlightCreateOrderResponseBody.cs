// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightCreateOrderResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("http_status_code")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightCreateOrderResponseBodyModule Module { get; set; }
        public class IntlFlightCreateOrderResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>deb6372db8194f1c94c23bc4fadc508d</para>
            /// </summary>
            [NameInMap("async_create_order_key")]
            [Validation(Required=false)]
            public string AsyncCreateOrderKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-08-10 17:42:32</para>
            /// </summary>
            [NameInMap("latest_pay_time")]
            [Validation(Required=false)]
            public string LatestPayTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1003038197806523003</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>F11378244642107293696</para>
            /// </summary>
            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>22300</para>
            /// </summary>
            [NameInMap("total_price")]
            [Validation(Required=false)]
            public long? TotalPrice { get; set; }

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
        /// <para>0</para>
        /// </summary>
        [NameInMap("result_code")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2103ad1116826479016562032da98c</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
