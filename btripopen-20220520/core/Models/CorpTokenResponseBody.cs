// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CorpTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CorpTokenResponseBodyData Data { get; set; }
        public class CorpTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>70000</para>
            /// </summary>
            [NameInMap("expire")]
            [Validation(Required=false)]
            public long? Expire { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>37j76df</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public CorpTokenResponseBodyModule Module { get; set; }
        public class CorpTokenResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>70000</para>
            /// </summary>
            [NameInMap("expire")]
            [Validation(Required=false)]
            public long? Expire { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1635744378301</para>
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public long? Start { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>37j76df</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>是否成功</para>
        /// 
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
