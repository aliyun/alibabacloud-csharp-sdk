// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class GetAgentInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAgentInfoResponseBodyData Data { get; set; }
        public class GetAgentInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4e7400028e6f4a7393ed3acf6a7b8927_p_beebot_public</para>
            /// </summary>
            [NameInMap("AgentKey")]
            [Validation(Required=false)]
            public string AgentKey { get; set; }

            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Parameter.Invalid</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC384CE1-8D42-1900-84E1-F33F990F2B5E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
