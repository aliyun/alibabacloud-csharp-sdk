// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateWorkloadIdentityResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D325DF9D-7CA8-5C47-BA0C-9A74873F2BE3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The workload identity.</para>
        /// </summary>
        [NameInMap("WorkloadIdentity")]
        [Validation(Required=false)]
        public CreateWorkloadIdentityResponseBodyWorkloadIdentity WorkloadIdentity { get; set; }
        public class CreateWorkloadIdentityResponseBodyWorkloadIdentity : TeaModel {
            /// <summary>
            /// <para>The allowlist of Consent authorization callback URLs for the workload identity, which constrains the allowed redirect addresses during the offline delegation (OfflineAccess) authorization flow.</para>
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
            /// <para>identity-provider-okta</para>
            /// </summary>
            [NameInMap("IdentityProviderName")]
            [Validation(Required=false)]
            public string IdentityProviderName { get; set; }

            /// <summary>
            /// <para>The ARN of the RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::123456:role/agent-101-role</para>
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
