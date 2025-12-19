// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateWorkloadIdentityResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D325DF9D-7CA8-5C47-BA0C-9A74873F2BE3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WorkloadIdentity")]
        [Validation(Required=false)]
        public CreateWorkloadIdentityResponseBodyWorkloadIdentity WorkloadIdentity { get; set; }
        public class CreateWorkloadIdentityResponseBodyWorkloadIdentity : TeaModel {
            [NameInMap("AllowedResourceOAuth2ReturnURLs")]
            [Validation(Required=false)]
            public List<string> AllowedResourceOAuth2ReturnURLs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-18T06:19:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

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
            /// <para>2025-12-18T06:19:17Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:agentidentity:cn-beijing:123456:workloadidentitydirectory/default/workloadidentity/agent-101</para>
            /// </summary>
            [NameInMap("WorkloadIdentityArn")]
            [Validation(Required=false)]
            public string WorkloadIdentityArn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>agent-101</para>
            /// </summary>
            [NameInMap("WorkloadIdentityName")]
            [Validation(Required=false)]
            public string WorkloadIdentityName { get; set; }

        }

    }

}
