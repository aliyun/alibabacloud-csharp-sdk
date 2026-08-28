// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateAgentIMChannelCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. The value SUCCESS indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The summary of the updated IM channel credential.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateAgentIMChannelCredentialResponseBodyData Data { get; set; }
        public class UpdateAgentIMChannelCredentialResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of configured secret field names. Secret values are not included.</para>
            /// </summary>
            [NameInMap("configuredSecretFields")]
            [Validation(Required=false)]
            public List<string> ConfiguredSecretFields { get; set; }

            /// <summary>
            /// <para>The non-sensitive credential fields and their values.</para>
            /// </summary>
            [NameInMap("nonSecretFields")]
            [Validation(Required=false)]
            public Dictionary<string, string> NonSecretFields { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. The value 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The result message of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a2b3c4d-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
