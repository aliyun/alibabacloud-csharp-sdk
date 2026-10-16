// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetAPIKeyCredentialProviderResponseBody : TeaModel {
        /// <summary>
        /// <para>The API key credential provider.</para>
        /// </summary>
        [NameInMap("APIKeyCredentialProvider")]
        [Validation(Required=false)]
        public GetAPIKeyCredentialProviderResponseBodyAPIKeyCredentialProvider APIKeyCredentialProvider { get; set; }
        public class GetAPIKeyCredentialProviderResponseBodyAPIKeyCredentialProvider : TeaModel {
            /// <summary>
            /// <para>The name of the credential provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-key-dash-scope</para>
            /// </summary>
            [NameInMap("APIKeyCredentialProviderName")]
            [Validation(Required=false)]
            public string APIKeyCredentialProviderName { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-18T06:19:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ARN of the credential provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:agentidentity:cn-beijing:123456:tokenvault/default/apikeycredentialprovider/api-key-dash-scope</para>
            /// </summary>
            [NameInMap("CredentialProviderArn")]
            [Validation(Required=false)]
            public string CredentialProviderArn { get; set; }

            /// <summary>
            /// <para>The description of the credential provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example provider</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("SourcePlatform")]
            [Validation(Required=false)]
            public string SourcePlatform { get; set; }

            /// <summary>
            /// <para>The name of the TokenVault.</para>
            /// </summary>
            [NameInMap("TokenVaultName")]
            [Validation(Required=false)]
            public string TokenVaultName { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-18T06:19:17Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76BF2570-76F5-5093-87CE-0918DD85752C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
