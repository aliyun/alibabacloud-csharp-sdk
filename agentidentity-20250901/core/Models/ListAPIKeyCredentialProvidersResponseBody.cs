// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListAPIKeyCredentialProvidersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of API key credential provider summaries.</para>
        /// </summary>
        [NameInMap("APIKeyCredentialProviders")]
        [Validation(Required=false)]
        public List<ListAPIKeyCredentialProvidersResponseBodyAPIKeyCredentialProviders> APIKeyCredentialProviders { get; set; }
        public class ListAPIKeyCredentialProvidersResponseBodyAPIKeyCredentialProviders : TeaModel {
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
        /// <para>The maximum number of results to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token used to retrieve the next page of results. Leave this parameter empty for the first request. For subsequent requests, specify the NextToken value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAWbTEdBU0yvszsl8EEXALb8=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4D51596A-8A87-565B-8EDE-45141A02F11C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of credential providers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>452</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
