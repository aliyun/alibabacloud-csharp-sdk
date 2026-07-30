// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ChannelCorpCreateResponseBody : TeaModel {
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
        /// <para>The response details.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public ChannelCorpCreateResponseBodyModule Module { get; set; }
        public class ChannelCorpCreateResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The name of the business travel enterprise administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("administrator_name")]
            [Validation(Required=false)]
            public string AdministratorName { get; set; }

            /// <summary>
            /// <para>The phone number of the business travel enterprise administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131****8888</para>
            /// </summary>
            [NameInMap("administrator_phone")]
            [Validation(Required=false)]
            public string AdministratorPhone { get; set; }

            /// <summary>
            /// <para>The business travel enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>btrip********xxe8w6</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The business travel enterprise name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里巴巴有限公司</para>
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
            /// <para>The business travel user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_1234</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
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
        /// <para>The trace ID used for global request tracking, typically for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce********056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
