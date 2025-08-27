// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightReShopApplyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightReShopApplyResponseBodyModule Module { get; set; }
        public class IntlFlightReShopApplyResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>asyncKey_2390u230slgw023</para>
            /// </summary>
            [NameInMap("async_apply_key")]
            [Validation(Required=false)]
            public string AsyncApplyKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>JPM20241024354</para>
            /// </summary>
            [NameInMap("out_re_shop_apply_id")]
            [Validation(Required=false)]
            public string OutReShopApplyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1009035199432</para>
            /// </summary>
            [NameInMap("re_shop_apply_id")]
            [Validation(Required=false)]
            public string ReShopApplyId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>88BA5020-561C-51F5-8E73-6659729913F0</para>
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
        /// <para>210bc4b116835992457938931db4de</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
