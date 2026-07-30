// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CorpTokenResponseBody : TeaModel {
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
        /// <para>The response data. <b>Deprecated</b>. Use the <c>module</c> field instead.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CorpTokenResponseBodyData Data { get; set; }
        public class CorpTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <para><b>Deprecated</b>. Use the <c>expire</c> field in the <c>module</c> object instead.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("expire")]
            [Validation(Required=false)]
            public long? Expire { get; set; }

            /// <summary>
            /// <para><b>Deprecated</b>. Use the <c>token</c> field in the <c>module</c> object instead.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

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
        public CorpTokenResponseBodyModule Module { get; set; }
        public class CorpTokenResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The token validity period. The default value is 2 hours (7200000 ms). To prevent token expiration, set the refresh interval to: <b>5 minutes ≤ interval ≤ 2 hours</b>. If you refresh within this interval, the token obtained from the previous request remains valid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7200000</para>
            /// </summary>
            [NameInMap("expire")]
            [Validation(Required=false)]
            public long? Expire { get; set; }

            /// <summary>
            /// <para>The time when the token takes effect. This field value does not change if you send repeated requests within a short period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1635744378301</para>
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public long? Start { get; set; }

            /// <summary>
            /// <para>The enterprise access credential (CorpToken). This field does not change if you send repeated requests within a short period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>37***df</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61ECFF6-<b><b>-</b></b>-****-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Use this field to determine whether the call succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The global trace identifier of the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041********3edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
