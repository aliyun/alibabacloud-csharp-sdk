// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The request body for updating the credential.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateCredentialRequestBody Body { get; set; }
        public class UpdateCredentialRequestBody : TeaModel {
            /// <summary>
            /// <para>The new credential content, which is a JSON string. If credentialType is apiKey, this parameter can only contain the apiKey field, and the value cannot be empty. You must specify at least one of credentialMetadata and description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;apiKey&quot;:&quot;sk-example-value&quot;}</para>
            /// </summary>
            [NameInMap("credentialMetadata")]
            [Validation(Required=false)]
            public string CredentialMetadata { get; set; }

            /// <summary>
            /// <para>The new credential description, which can be up to 256 characters in length. You must specify at least one of credentialMetadata and description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>API key used to call model services in the production environment</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>If resourceScope is SPECIFIED, this parameter must be a non-empty array. Each item must include resourceType and resourceId. resourceName is optional.</para>
            /// </summary>
            [NameInMap("resourceRefs")]
            [Validation(Required=false)]
            public List<UpdateCredentialRequestBodyResourceRefs> ResourceRefs { get; set; }
            public class UpdateCredentialRequestBodyResourceRefs : TeaModel {
                /// <summary>
                /// <para>The unique identifier of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-xxxx</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource name. This parameter is empty if the resource is deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent</para>
                /// </summary>
                [NameInMap("resourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The resource type, such as agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The application scope of the credential resources. A value of ALL indicates all resources. A value of SPECIFIED indicates only the resources specified by resourceRefs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("resourceScope")]
            [Validation(Required=false)]
            public string ResourceScope { get; set; }

        }

        /// <summary>
        /// <para>Not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Not supported</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
