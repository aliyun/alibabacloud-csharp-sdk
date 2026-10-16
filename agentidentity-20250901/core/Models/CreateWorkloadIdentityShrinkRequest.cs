// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateWorkloadIdentityShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The allowlist of Consent authorization callback URLs for the workload identity, which constrains the allowed redirect addresses during the offline delegation (OfflineAccess) authorization flow.</para>
        /// </summary>
        [NameInMap("AllowedConsentCallbackURLs")]
        [Validation(Required=false)]
        public string AllowedConsentCallbackURLsShrink { get; set; }

        /// <summary>
        /// <para>The list of allowed OAuth2 return URLs.</para>
        /// </summary>
        [NameInMap("AllowedResourceOAuth2ReturnURLs")]
        [Validation(Required=false)]
        public string AllowedResourceOAuth2ReturnURLsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create an associated RAM role. When set to true, the system automatically creates a RAM role with the same name as the workload identity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CreateRAMRole")]
        [Validation(Required=false)]
        public bool? CreateRAMRole { get; set; }

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
        /// <para>Specifies whether to enable session binding. When enabled, each session is bound to a specific workload identity instance.</para>
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
        /// <para>The source platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>China</para>
        /// </summary>
        [NameInMap("SourcePlatform")]
        [Validation(Required=false)]
        public string SourcePlatform { get; set; }

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
