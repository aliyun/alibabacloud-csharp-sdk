// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightReShopCreateResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
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
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightReShopCreateResponseBodyModule Module { get; set; }
        public class IntlFlightReShopCreateResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The asynchronous application key, used in the asynchronous commit pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asyncKey_2390u230slgw023</para>
            /// </summary>
            [NameInMap("async_apply_key")]
            [Validation(Required=false)]
            public string AsyncApplyKey { get; set; }

            /// <summary>
            /// <para>Indicates whether a retry is required. This parameter is used in the asynchronous commit pattern.</para>
            /// </summary>
            [NameInMap("need_retry")]
            [Validation(Required=false)]
            public bool? NeedRetry { get; set; }

            /// <summary>
            /// <para>The retry time interval, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("next_retry_interval")]
            [Validation(Required=false)]
            public long? NextRetryInterval { get; set; }

            /// <summary>
            /// <para>The external rebooking application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JPM20241024354</para>
            /// </summary>
            [NameInMap("out_re_shop_apply_id")]
            [Validation(Required=false)]
            public string OutReShopApplyId { get; set; }

            /// <summary>
            /// <para>The business travel rebooking application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1017035199374643191</para>
            /// </summary>
            [NameInMap("re_shop_apply_id")]
            [Validation(Required=false)]
            public string ReShopApplyId { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
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
        /// <para>The global trace ID of the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bc4b116835992457938931db4de</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
