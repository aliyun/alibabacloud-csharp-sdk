// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderChangeApplyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
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
        public HotelOrderChangeApplyResponseBodyModule Module { get; set; }
        public class HotelOrderChangeApplyResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123445443444</para>
            /// </summary>
            [NameInMap("change_order_id")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6E9ABA14-5135-58FB-9DFC-C751B5855605</para>
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
        /// <para>215045ec17018285034106091e8ba9</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
