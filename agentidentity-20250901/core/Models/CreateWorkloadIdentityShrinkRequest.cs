// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateWorkloadIdentityShrinkRequest : TeaModel {
        [NameInMap("AllowedResourceOAuth2ReturnURLs")]
        [Validation(Required=false)]
        public string AllowedResourceOAuth2ReturnURLsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example agent</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>identity-provider-okta</para>
        /// </summary>
        [NameInMap("IdentityProviderName")]
        [Validation(Required=false)]
        public string IdentityProviderName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::123456:role/agent-101-role</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>agent-101</para>
        /// </summary>
        [NameInMap("WorkloadIdentityName")]
        [Validation(Required=false)]
        public string WorkloadIdentityName { get; set; }

    }

}
