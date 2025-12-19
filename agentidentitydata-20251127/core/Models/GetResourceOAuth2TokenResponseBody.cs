// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class GetResourceOAuth2TokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>66a1a2****0b93v3</para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://agentidentity.cn-beijing.aliyuncs.com/">https://agentidentity.cn-beijing.aliyuncs.com/</a>*****</para>
        /// </summary>
        [NameInMap("AuthorizationURL")]
        [Validation(Required=false)]
        public string AuthorizationURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>173C69C9-9C07-5B25-9477-603A33E5DA32</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>IN_PROGRESS</para>
        /// </summary>
        [NameInMap("SessionStatus")]
        [Validation(Required=false)]
        public string SessionStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>urn:ietf:params:oauth:request_uri:43b7df1a-<b><b>-</b></b>-****-709375a44d8a</para>
        /// </summary>
        [NameInMap("SessionURI")]
        [Validation(Required=false)]
        public string SessionURI { get; set; }

    }

}
