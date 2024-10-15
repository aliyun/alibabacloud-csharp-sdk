// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ChannelCorpCreateResponseBody : TeaModel {
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
        public ChannelCorpCreateResponseBodyModule Module { get; set; }
        public class ChannelCorpCreateResponseBodyModule : TeaModel {
            [NameInMap("administrator_name")]
            [Validation(Required=false)]
            public string AdministratorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>18378889782</para>
            /// </summary>
            [NameInMap("administrator_phone")]
            [Validation(Required=false)]
            public string AdministratorPhone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingaa15ca45cba9ee744a5</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("corp_name")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>open12mplkebufu8701012jq</para>
            /// </summary>
            [NameInMap("open_agent_id")]
            [Validation(Required=false)]
            public string OpenAgentId { get; set; }

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
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
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
