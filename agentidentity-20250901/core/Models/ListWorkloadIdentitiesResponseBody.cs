// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListWorkloadIdentitiesResponseBody : TeaModel {
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
        /// <para>The pagination token used to retrieve the next page of results. This field is not returned if no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAcCoknY19uiBwPrAe1W7XMikkA6+rCQddIGHccphiDPypD8zCxQkHV2pg8CkZvyRKg==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173C69C9-9C07-5B25-9477-603A33E5DA32</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of workload identities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of workload identities.</para>
        /// </summary>
        [NameInMap("WorkloadIdentities")]
        [Validation(Required=false)]
        public List<ListWorkloadIdentitiesResponseBodyWorkloadIdentities> WorkloadIdentities { get; set; }
        public class ListWorkloadIdentitiesResponseBodyWorkloadIdentities : TeaModel {
            /// <summary>
            /// <para>The whitelist of consent authorization callback URLs for the workload identity. This whitelist restricts the allowed callback addresses in the offline delegation (OfflineAccess) authorization flow.</para>
            /// </summary>
            [NameInMap("AllowedConsentCallbackURLs")]
            [Validation(Required=false)]
            public List<string> AllowedConsentCallbackURLs { get; set; }

            /// <summary>
            /// <para>The list of allowed OAuth2 return URLs.</para>
            /// </summary>
            [NameInMap("AllowedResourceOAuth2ReturnURLs")]
            [Validation(Required=false)]
            public List<string> AllowedResourceOAuth2ReturnURLs { get; set; }

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
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example agent</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The configured identity provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Operations Center single sign-on</para>
            /// </summary>
            [NameInMap("IdentityProviderName")]
            [Validation(Required=false)]
            public string IdentityProviderName { get; set; }

            /// <summary>
            /// <para>The ARN of the RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1953507478506681:role/test-rrsa-cb5ca90a20f854671adbac6ed4559a654</para>
            /// </summary>
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>Specifies whether session binding is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SessionBindingEnabled")]
            [Validation(Required=false)]
            public bool? SessionBindingEnabled { get; set; }

            /// <summary>
            /// <para>The ARN of the source agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:agentidentity:cn-beijing:123456:workloadidentity/my-identity</para>
            /// </summary>
            [NameInMap("SourceAgentArn")]
            [Validation(Required=false)]
            public string SourceAgentArn { get; set; }

            /// <summary>
            /// <para>The creation source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("SourcePlatform")]
            [Validation(Required=false)]
            public string SourcePlatform { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-18T06:19:17Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The ARN of the workload identity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:agentidentity:cn-beijing:123456:workloadidentitydirectory/default/workloadidentity/agent-101</para>
            /// </summary>
            [NameInMap("WorkloadIdentityArn")]
            [Validation(Required=false)]
            public string WorkloadIdentityArn { get; set; }

            /// <summary>
            /// <para>The unique name of the workload identity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-101</para>
            /// </summary>
            [NameInMap("WorkloadIdentityName")]
            [Validation(Required=false)]
            public string WorkloadIdentityName { get; set; }

        }

    }

}
