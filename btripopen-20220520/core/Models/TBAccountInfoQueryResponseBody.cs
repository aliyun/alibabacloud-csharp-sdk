// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TBAccountInfoQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
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
        /// <para>The Taobao account information query result. Returns null if the query fails.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public TBAccountInfoQueryResponseBodyModule Module { get; set; }
        public class TBAccountInfoQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The Taobao account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>下****天</para>
            /// </summary>
            [NameInMap("tb_account")]
            [Validation(Required=false)]
            public string TbAccount { get; set; }

            /// <summary>
            /// <para>Indicates whether the account is bound to Taobao.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("tb_bond")]
            [Validation(Required=false)]
            public bool? TbBond { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>456456575656757</para>
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
        /// <para>The log trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210f07f316603757445272547d959f</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
