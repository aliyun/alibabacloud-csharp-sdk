// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class UpdateWorkloadIdentityRequest : TeaModel {
        /// <summary>
        /// <para>The whitelist of consent authorization callback URLs for the workload identity, which restricts the allowed callback URLs in the offline access delegation authorization flow.</para>
        /// </summary>
        [NameInMap("AllowedConsentCallbackURLs")]
        [Validation(Required=false)]
        public List<string> AllowedConsentCallbackURLs { get; set; }

        /// <summary>
        /// <para>The list of allowed OAuth2 return URLs.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("AllowedResourceOAuth2ReturnURLs")]
        [Validation(Required=false)]
        public List<string> AllowedResourceOAuth2ReturnURLs { get; set; }

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
        /// <para>Specifies whether session binding is enabled. If enabled, each session is bound to a specific workload identity instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SessionBindingEnabled")]
        [Validation(Required=false)]
        public string SessionBindingEnabled { get; set; }

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
