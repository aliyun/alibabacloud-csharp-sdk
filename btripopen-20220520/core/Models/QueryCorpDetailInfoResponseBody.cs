// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class QueryCorpDetailInfoResponseBody : TeaModel {
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
        public QueryCorpDetailInfoResponseBodyModule Module { get; set; }
        public class QueryCorpDetailInfoResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>btrip5txxxxxxx</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("corp_name")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>open12********012jq</para>
            /// </summary>
            [NameInMap("open_agent_id")]
            [Validation(Required=false)]
            public string OpenAgentId { get; set; }

            [NameInMap("super_admin_name")]
            [Validation(Required=false)]
            public string SuperAdminName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>138xxxx0001</para>
            /// </summary>
            [NameInMap("super_admin_phone")]
            [Validation(Required=false)]
            public string SuperAdminPhone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user1234</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C61ECFF6-<b><b>-</b></b>-****-D77369043A5F</para>
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
        /// <para>21041ce********056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
