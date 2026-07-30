// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class QueryCorpDetailInfoResponseBody : TeaModel {
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
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The details of the response. Fields with null values are not returned.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public QueryCorpDetailInfoResponseBodyModule Module { get; set; }
        public class QueryCorpDetailInfoResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The business travel enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>btrip5txxxxxxx</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The business travel enterprise name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里巴巴</para>
            /// </summary>
            [NameInMap("corp_name")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// <para>The business travel enterprise agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>open12********012jq</para>
            /// </summary>
            [NameInMap("open_agent_id")]
            [Validation(Required=false)]
            public string OpenAgentId { get; set; }

            /// <summary>
            /// <para>The name of the business travel enterprise super administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("super_admin_name")]
            [Validation(Required=false)]
            public string SuperAdminName { get; set; }

            /// <summary>
            /// <para>The phone number of the business travel enterprise super administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>138xxxx0001</para>
            /// </summary>
            [NameInMap("super_admin_phone")]
            [Validation(Required=false)]
            public string SuperAdminPhone { get; set; }

            /// <summary>
            /// <para>The user ID of the business travel super administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1234</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61ECFF6-<b><b>-</b></b>-****-D77369043A5F</para>
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
        /// <para>The global trace identifier for the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce********056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
