// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderCancelResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>module</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public TrainOrderCancelResponseBodyModule Module { get; set; }
        public class TrainOrderCancelResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>11127278782</para>
            /// </summary>
            [NameInMap("change_order_id")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>116019444</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>43534345</para>
            /// </summary>
            [NameInMap("out_change_order_id")]
            [Validation(Required=false)]
            public string OutChangeOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3702553342926024704</para>
            /// </summary>
            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B72B39C8-32DE-558D-AD1C-D53F11F6ADFE</para>
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
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
